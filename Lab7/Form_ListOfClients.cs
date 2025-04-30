using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form_ListOfClients : Form
    {
        public Form_ListOfClients()
        {
            InitializeComponent();
        }

        private void Form_ListOfClients_Load(object sender, EventArgs e)
        {
            // Логіка для завантаження даних про клієнтів (наприклад, з бази даних чи списку)
            LoadClients();
        }
        private void LoadClients()
        {
            // Це місце для коду, який завантажує список клієнтів у DataGridView
            // Наприклад, якщо ми використовуємо список або базу даних, треба показати їх у DataGridView.
            dataGridView1.DataSource = GetClients();  // GetClients() - ваш метод для отримання клієнтів
        }
        private List<Client> GetClients()
        {
            // Можна замінити на метод, що отримує клієнтів з бази даних
            List<Client> clients = new List<Client>
            {
                new Client { Id = 1, FullName = "Іван Іванов", Email = "ivan@domain.com", Phone = "+380671234567" },
                new Client { Id = 2, FullName = "Марія Петрова", Email = "maria@domain.com", Phone = "+380681234567" }
            };
            return clients;
        }
        private void CloseFormButton_ListOfClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2.form2Instance.Show();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            // Логіка для додавання нового клієнта
            // Тут можна відкрити нову форму або модальне вікно для введення клієнта.
           
        }
       

        private void EditClientButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {

        }
    }
    // Клас для клієнта (приклад)
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
