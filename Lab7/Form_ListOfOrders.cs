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
    public partial class Form_ListOfOrders : Form
    {
        public Form_ListOfOrders()
        {
            InitializeComponent();
        }
        
        private void LoadOrders()
        {
            // Це місце для коду, який завантажує список замовлень у DataGridView
            // Наприклад, якщо ми використовуємо список або базу даних, треба показати їх у DataGridView.
            dataGridView1.DataSource = GetOrders();  // GetOrders() - ваш метод для отримання замовлень
        }
        private List<Order> GetOrders()
        {
            // Можна замінити на метод, що отримує замовлення з бази даних
            List<Order> orders = new List<Order>
            {
                new Order { Id = 1, ClientName = "Іван Іванов", ServiceName = "Ремонт ПК", Date = DateTime.Now, Status = "Виконано" },
                new Order { Id = 2, ClientName = "Марія Петрова", ServiceName = "Налаштування мережі", Date = DateTime.Now.AddDays(-1), Status = "В очікуванні" }
            };
            return orders;
        }

        private void CloseButton_ListOfOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2.form2Instance.Show();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void EditOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void Form_ListOfOrders_Load(object sender, EventArgs e)
        {
            // Логіка для завантаження даних про замовлення (наприклад, з бази даних чи списку)
            LoadOrders();
        }
    }
    // Клас для замовлення (приклад)
    public class Order
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ServiceName { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
