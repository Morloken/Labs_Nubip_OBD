using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab7
{
    public partial class Form_ListOfAvailableServices : Form
    {

        public Form_ListOfAvailableServices()
        {
            InitializeComponent();
            
        }
        private bool isEditing = false;
        private string currentServiceId = null;


        private void Form_ListOfAvailableServices_Load(object sender, EventArgs e)
        {
            
            LoadServices();

            // Українські назви стовпців
            dataGridView1.Columns[0].HeaderText = "ID послуги";
            dataGridView1.Columns[1].HeaderText = "Назва";
            dataGridView1.Columns[2].HeaderText = "Опис";
            dataGridView1.Columns[3].HeaderText = "Ціна";
            dataGridView1.Columns[4].HeaderText = "Тривалість (хв)";
        }

        private void LoadServices()
        {
            try
            {
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ServiceTable";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні послуг: {ex.Message}");
            }
        }



        private void CloseFormButton_ListOfAvailableServices_Click(object sender, EventArgs e)
        {
            // Приховуємо поточну форму (Form_ListOfAvailableServices)
            this.Hide();

            // Дозволяємо використання попередньої форми (Form2)
            Form2.form2Instance.Show();
        }

        private void setServiceButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Виберіть послугу для редагування.");
                    return;
                }

                // Збереження ID та заповнення полів
                currentServiceId = dataGridView1.SelectedRows[0].Cells["ServiceID"].Value.ToString();
                var row = dataGridView1.SelectedRows[0];
                serviceNameTextBox.Text = row.Cells["ServiceName"].Value.ToString();
                serviceDescriptionTextBox.Text = row.Cells["ServiceDescription"].Value.ToString();
                servicePriceTextBox.Text = row.Cells["ServicePrice"].Value.ToString();
                serviceDurationNumericUpDown.Value = Convert.ToDecimal(row.Cells["ServiceDuration"].Value);

                // Вмикаємо режим редагування
                isEditing = true;
                editServiceButton.Text = "Закінчити редагування";

                // Ховаємо всі кнопки окрім "Редагувати"
                addServiceButton.Visible = false;
                deleteServiceButton.Visible = false;
                CloseFormButton_ListOfAvailableServices.Visible = false;
                dataGridView1.Enabled = false; // заблокуємо вибір нових рядків

                return;
            }
            else
            {
                // Закінчення редагування — збереження
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE ServiceTable SET ServiceName = @Name, ServiceDescription = @Description, ServicePrice = @Price, ServiceDuration = @Duration WHERE ServiceID = @ServiceID";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ServiceID", currentServiceId);
                            cmd.Parameters.AddWithValue("@Name", serviceNameTextBox.Text);
                            cmd.Parameters.AddWithValue("@Description", serviceDescriptionTextBox.Text);
                            cmd.Parameters.AddWithValue("@Price", decimal.Parse(servicePriceTextBox.Text));
                            cmd.Parameters.AddWithValue("@Duration", (int)serviceDurationNumericUpDown.Value);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Послугу оновлено.");
                    LoadServices();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при редагуванні послуги: {ex.Message}");
                }

                // Вихід з режиму редагування
                isEditing = false;
                currentServiceId = null;
                editServiceButton.Text = "Редагувати";

                addServiceButton.Visible = true;
                deleteServiceButton.Visible = true;
                CloseFormButton_ListOfAvailableServices.Visible = true;
                dataGridView1.Enabled = true;
            }
        }


        private void addServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";
                if (string.IsNullOrWhiteSpace(serviceNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(serviceDescriptionTextBox.Text) ||
                string.IsNullOrWhiteSpace(servicePriceTextBox.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO ServiceTable (ServiceID, ServiceName, ServiceDescription, ServicePrice, ServiceDuration) " +
                                   "VALUES (NEWID(), @Name, @Description, @Price, @Duration)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", serviceNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Description", serviceDescriptionTextBox.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(servicePriceTextBox.Text));
                        cmd.Parameters.AddWithValue("@Duration", (int)serviceDurationNumericUpDown.Value);


                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Послугу додано!");
                LoadServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні послуги: {ex.Message}");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                serviceNameTextBox.Text = row.Cells["ServiceName"].Value.ToString();
                serviceDescriptionTextBox.Text = row.Cells["ServiceDescription"].Value.ToString();
                servicePriceTextBox.Text = row.Cells["ServicePrice"].Value.ToString();
                serviceDurationNumericUpDown.Value = Convert.ToDecimal(row.Cells["ServiceDuration"].Value);
            }
        }


        private void deleteServiceButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть послугу для видалення.");
                return;
            }

            string serviceId = dataGridView1.SelectedRows[0].Cells["ServiceID"].Value.ToString();

            var config = Form1.GetDbConfig();
            string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM ServiceTable WHERE ServiceID = @ServiceID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Послугу видалено.");
                LoadServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при видаленні послуги: {ex.Message}");
            }
        }
    }
}
