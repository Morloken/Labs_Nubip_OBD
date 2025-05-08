using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Lab7
{
    public partial class Form1 : Form
    {
        public static Form1 form1Instance;
        public Form1()
        {
            InitializeComponent();
            SetPlaceholder();
            form1Instance = this;
            this.MaximizeBox = false;
        }

        public class DbConfig
        {
            public string Server { get; set; }
            public string Database { get; set; }
        }

        // Метод для отримання Server і Database з файлу JSON
        public static DbConfig GetDbConfig()
        {
            string json = File.ReadAllText("dbconfig.json");
            DbConfig config = Newtonsoft.Json.JsonConvert.DeserializeObject<DbConfig>(json);
            return config;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetPlaceholder()
        {
            NameTextBox.ForeColor = Color.Gray;
            NameTextBox.Text = "Введіть ім'я...";

            NameTextBox.Enter += (s, e) =>
            {
                if (NameTextBox.Text == "Введіть ім'я...")
                {
                    NameTextBox.Text = "";
                    NameTextBox.ForeColor = Color.Black;
                }
            };

            NameTextBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                {
                    NameTextBox.Text = "Введіть ім'я...";
                    NameTextBox.ForeColor = Color.Gray;
                }
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Метод для авторизації через SQL логін
        public static bool AuthenticateUser(string login, string password)
        {
            try
            {
                // Отримуємо Server і Database з JSON
                DbConfig config = GetDbConfig();

                // Формуємо рядок підключення з введеним логіном і паролем користувача
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={login};Password={password};";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Якщо відкрив — авторизація успішна
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка підключення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = NameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            bool isAuthenticated = AuthenticateUser(login, password);

            if (isAuthenticated)
            {
                MessageBox.Show($"Вітаю, {login}! Ви успішно підключені до бази.");

                // Відкриваємо Form2
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
