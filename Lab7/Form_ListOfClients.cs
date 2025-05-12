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
using Microsoft.VisualBasic;


namespace Lab7
{
    public partial class Form_ListOfClients : Form
    {
        public Form_ListOfClients()
        {
            InitializeComponent();
        }
        private string selectedClientId = null;
        private string searchFilter = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedClientId = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            }
        }

        private void Form_ListOfClients_Load(object sender, EventArgs e)
        {
            LoadClients(); // Завантажуємо клієнтів
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Підписка на подію зміни тексту в полі пошуку
            searchTextBox.TextChanged += searchTextBox_TextChanged;

        }
        private void LoadClients()
        {
            dataGridView1.DataSource = GetClients(searchFilter);  // GetClients() - ваш метод для отримання клієнтів
        }
        private DataTable GetClients(string filter)
        {
            DataTable dt = new DataTable();

            try
            {
                var config = Form1.GetDbConfig();

                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Додаємо умову WHERE для фільтрації за ім'ям, телефоном або email
                    string query = "SELECT ClientID AS [ID], ClientFullName AS [ПІБ], ClientPhone AS [Телефон], ClientEmail AS [Email] FROM dbo.Client WHERE " +
                                   "(ClientFullName LIKE @filter OR ClientPhone LIKE @filter OR ClientEmail LIKE @filter)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Передаємо фільтр для пошуку
                        cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження клієнтів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }


        private void CloseFormButton_ListOfClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2.form2Instance.Show();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            // Просте вікно вводу нових даних клієнта
            string fullName = Microsoft.VisualBasic.Interaction.InputBox("Введіть ПІБ клієнта:", "Новий клієнт");
            string phone = Microsoft.VisualBasic.Interaction.InputBox("Введіть телефон клієнта:", "Новий клієнт");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Введіть email клієнта:", "Новий клієнт");

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Всі поля обов'язкові для заповнення!");
                return;
            }

            try
            {
                // Підключення до БД
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO dbo.Client (ClientID, ClientFullName, ClientPhone, ClientEmail) VALUES (@ClientID, @FullName, @Phone, @Email)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", Guid.NewGuid().ToString());
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", email);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Клієнт успішно доданий!");
                LoadClients(); // Оновлюємо таблицю після додавання
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні клієнта: {ex.Message}");
            }

        }
       

        private void EditClientButton_Click(object sender, EventArgs e)
        {
            // Перевірка, чи обрано клієнта для редагування
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть клієнта для редагування.");
                return;
            }

            // Отримуємо поточні дані клієнта для редагування
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string fullName = selectedRow.Cells["ПІБ"].Value.ToString();
            string phone = selectedRow.Cells["Телефон"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();

            // Відкриваємо вікно для редагування
            string newFullName = Microsoft.VisualBasic.Interaction.InputBox("Відредагуйте ПІБ клієнта:", "Редагувати клієнта", fullName);
            string newPhone = Microsoft.VisualBasic.Interaction.InputBox("Відредагуйте телефон клієнта:", "Редагувати клієнта", phone);
            string newEmail = Microsoft.VisualBasic.Interaction.InputBox("Відредагуйте email клієнта:", "Редагувати клієнта", email);

            // Перевірка, чи не порожні нові значення
            if (string.IsNullOrWhiteSpace(newFullName) || string.IsNullOrWhiteSpace(newPhone) || string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Всі поля обов'язкові для заповнення!");
                return;
            }

            try
            {
                // Підключення до БД
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Запит на оновлення даних клієнта
                    string query = "UPDATE dbo.Client SET ClientFullName = @FullName, ClientPhone = @Phone, ClientEmail = @Email WHERE ClientID = @ClientID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", selectedClientId);
                        command.Parameters.AddWithValue("@FullName", newFullName);
                        command.Parameters.AddWithValue("@Phone", newPhone);
                        command.Parameters.AddWithValue("@Email", newEmail);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Дані клієнта успішно оновлено!");
                LoadClients(); // Оновлюємо таблицю після редагування
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при редагуванні клієнта: {ex.Message}");
            }
        }
        // Обробник події для пошуку
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchFilter = searchTextBox.Text;  // Оновлюємо фільтр на основі тексту пошуку
            LoadClients();  // Оновлюємо дані в таблиці
        }
        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            if (selectedClientId == null)
            {
                MessageBox.Show("Оберіть клієнта для видалення.");
                return;
            }

            var confirm = MessageBox.Show("Ви впевнені, що хочете видалити цього клієнта?", "Підтвердження", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var config = Form1.GetDbConfig();
                    string connectionString = $"Server={config.Server};Database={config.Database};Integrated Security=True;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Client WHERE ClientID = @ClientID";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ClientID", selectedClientId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Клієнта видалено.");
                    LoadClients(); // оновлюємо таблицю
                    selectedClientId = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            searchFilter = searchTextBox.Text;  // Оновлюємо фільтр на основі тексту пошуку
            LoadClients();  // Оновлюємо дані в таблиці
        }
    }
   
}
