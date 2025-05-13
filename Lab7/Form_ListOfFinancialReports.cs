using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form_ListOfFinancialReports : Form
    {
        private bool isEditing = false;
        private string currentFinanceId = null;

        public Form_ListOfFinancialReports()
        {
            InitializeComponent();
        }
        private void CloseButton_ListOfFinancialReports_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2.form2Instance.Show();
        }

        private void LoadFinancialReports()
        {
            try
            {
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GetFinancialReports", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні фінансових звітів: {ex.Message}");
            }
        }

        private void AddReportButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(orderIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(clientIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(serviceIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(orderDetailIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(employeeIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(financeAmountTextBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            var config = Form1.GetDbConfig();
            string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("AddFinancialReport", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@OrderID", orderIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@ClientID", clientIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@ServiceID", serviceIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@OrderDetailID", orderDetailIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@FinanceTransactionDate", financeTransactionDatePicker.Value);
                    cmd.Parameters.AddWithValue("@FinanceTransactionType", financeTransactionTypeTextBox.Text);
                    cmd.Parameters.AddWithValue("@FinanceAmount", decimal.Parse(financeAmountTextBox.Text));
                    cmd.Parameters.AddWithValue("@FinanceDescription", financeDescriptionTextBox.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Фінансовий звіт додано.");
                LoadFinancialReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні звіту: {ex.Message}");
            }
        }

        private void EditReportButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Зберігаємо зміни
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("UpdateFinancialReport", connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FinanceID", currentFinanceId);
                        cmd.Parameters.AddWithValue("@OrderID", orderIDTextBox.Text);
                        cmd.Parameters.AddWithValue("@ClientID", clientIDTextBox.Text);
                        cmd.Parameters.AddWithValue("@ServiceID", serviceIDTextBox.Text);
                        cmd.Parameters.AddWithValue("@OrderDetailID", orderDetailIDTextBox.Text);
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeIDTextBox.Text);
                        cmd.Parameters.AddWithValue("@FinanceTransactionDate", financeTransactionDatePicker.Value);
                        cmd.Parameters.AddWithValue("@FinanceTransactionType", financeTransactionTypeTextBox.Text);
                        cmd.Parameters.AddWithValue("@FinanceAmount", decimal.Parse(financeAmountTextBox.Text));
                        cmd.Parameters.AddWithValue("@FinanceDescription", financeDescriptionTextBox.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Фінансовий звіт оновлено.");
                    LoadFinancialReports();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при редагуванні звіту: {ex.Message}");
                }

                isEditing = false;
                EditReportButton.Text = "Редагувати";
                currentFinanceId = null;
                orderIDTextBox.Clear();
                clientIDTextBox.Clear();
                serviceIDTextBox.Clear();
                orderDetailIDTextBox.Clear();
                employeeIDTextBox.Clear();
                financeTransactionTypeTextBox.Clear();
                financeAmountTextBox.Clear();
                financeDescriptionTextBox.Clear();
                financeTransactionDatePicker.Value = DateTime.Now;


            }
            else
            {
                // Переводимо в режим редагування
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Виберіть фінансовий звіт для редагування.");
                    return;
                }

                var row = dataGridView1.SelectedRows[0];
                currentFinanceId = row.Cells["FinanceID"].Value.ToString();
                orderIDTextBox.Text = row.Cells["OrderID"].Value.ToString();
                clientIDTextBox.Text = row.Cells["ClientID"].Value.ToString();
                serviceIDTextBox.Text = row.Cells["ServiceID"].Value.ToString();
                orderDetailIDTextBox.Text = row.Cells["OrderDetailID"].Value.ToString();
                employeeIDTextBox.Text = row.Cells["EmployeeID"].Value.ToString();
                financeTransactionDatePicker.Value = (DateTime)row.Cells["FinanceTransactionDate"].Value;
                financeTransactionTypeTextBox.Text = row.Cells["FinanceTransactionType"].Value.ToString();
                financeAmountTextBox.Text = row.Cells["FinanceAmount"].Value.ToString();
                financeDescriptionTextBox.Text = row.Cells["FinanceDescription"].Value.ToString();

                isEditing = true;
                EditReportButton.Text = "Зберегти зміни";
            }
            
        }

        private void DeleteReportButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть фінансовий звіт для видалення.");
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            string financeId = row.Cells["FinanceID"].Value.ToString();

            var config = Form1.GetDbConfig();
            string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";
            if (MessageBox.Show("Ви впевнені, що хочете видалити цей фінансовий звіт?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DeleteFinancialReport", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FinanceID", financeId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Фінансовий звіт видалено.");
                LoadFinancialReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при видаленні звіту: {ex.Message}");
            }
        }
        private void Form_ListOfFinancialReports_Load_1(object sender, EventArgs e)
        {
            LoadFinancialReports();
            //Зміна назв стовпців
            dataGridView1.Columns[0].HeaderText = "Ідентифікатор фінансового звіту";
            dataGridView1.Columns[1].HeaderText = "Ідентифікатор замовлення";
            dataGridView1.Columns[2].HeaderText = "Ідентифікатор клієнта";
            dataGridView1.Columns[3].HeaderText = "Ідентифікатор послуги";
            dataGridView1.Columns[4].HeaderText = "Ідентифікатор деталей замовлення";
            dataGridView1.Columns[5].HeaderText = "Ідентифікатор працівника";
            dataGridView1.Columns[6].HeaderText = "Дата транзакції";
            dataGridView1.Columns[7].HeaderText = "Тип транзакції";
            dataGridView1.Columns[8].HeaderText = "Сума транзакції";
            dataGridView1.Columns[9].HeaderText = "Опис транзакції";
           
            

        }

        //label1 click
        private void label1_Click(object sender, EventArgs e)
        {
            // Do nothing
        }
        private void label6_Click(object sender, EventArgs e)
        {
            // Do nothing
        }
    }
}
