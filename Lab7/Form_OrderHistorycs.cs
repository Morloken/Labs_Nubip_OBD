using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form_OrderHistorycs: Form
    {
        public Form_OrderHistorycs()
        {
            InitializeComponent();

            
        }


        private void Form_OrderHistorycs_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
            LoadOrderStatusLogs();
            //зміна заголовків стовпців
            dataGridView1.Columns[0].HeaderText = "Ідентифікатор логу";
            dataGridView1.Columns[1].HeaderText = "Ідентифікатор замовлення";
            dataGridView1.Columns[2].HeaderText = "Старий статус";
            dataGridView1.Columns[3].HeaderText = "Новий статус";
            dataGridView1.Columns[4].HeaderText = "Дата зміни статусу";

            dataGridView2.Columns[0].HeaderText = "Ідентифікатор деталей замовлення";
            dataGridView2.Columns[1].HeaderText = "Ідентифікатор послуги";
            dataGridView2.Columns[2].HeaderText = "Ідентифікатор працівника";
            dataGridView2.Columns[3].HeaderText = "Спільна ціна";

        }
        private void LoadOrderDetails()
        {
            var config = Form1.GetDbConfig();
            string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM OrderDetails"; // Виводимо всі поля

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView2.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні деталей замовлень: " + ex.Message);
                }
            }
        }
        private void LoadOrderStatusLogs()
        {
            try
            {
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Запит для отримання даних з таблиці OrderStatusLog
                    string query = "SELECT LogID, OrderID, OldStatus, NewStatus, ChangedAt FROM OrderStatusLog ORDER BY ChangedAt DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Прив'язуємо дані до DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні логів: {ex.Message}");
            }
        }
        private void CloseButton_OrderHistorycs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2.form2Instance.Show();
        }
    }
}
