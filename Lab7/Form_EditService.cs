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
    // Клас для послуги (приклад)
    
    public partial class Form_EditService : Form
    {
        public Form_EditService()
        {
            InitializeComponent();
        }

        private void Form_EditService_Load(object sender, EventArgs e)
        {
            // Логіка для завантаження даних про послуги (наприклад, з бази даних чи списку)
            LoadServices();
        }
        private void LoadServices()
        {
            // Це місце для коду, який завантажує список послуг у DataGridView
            // Наприклад, якщо ми використовуємо список або базу даних, треба показати їх у DataGridView.
            dataGridView1.DataSource = GetServices();  // GetServices() - ваш метод для отримання послуг
        }
        private List<Service> GetServices()
        {
            // Можна замінити на метод, що отримує послуги з бази даних
            List<Service> services = new List<Service>
            {
                new Service { Id = 1, Name = "Ремонт ПК", Price = 100 },
                new Service { Id = 2, Name = "Налаштування мережі", Price = 150 }
            };
            return services;
        }

        // Додавання нової послуги
        private void AddServiceButton_Click(object sender, EventArgs e)
        {
           
        }

       

        // Редагування обраної послуги
        private void EditServiceButton_Click(object sender, EventArgs e)
        {
           
        }

        

        // Видалення обраної послуги
        private void DeleteServiceButton_Click(object sender, EventArgs e)
        {
           
        }

        private void DeleteService(int serviceId)
        {
         
        }

        private void AddServiceButton_Click_1(object sender, EventArgs e)
        {

        }

        private void CloseFormButton_EditService_Click(object sender, EventArgs e)
        {
            // Приховуємо поточну форму (Form_EditService)
            this.Hide();

            // Дозволяємо використання попередньої форми (Form2)
            Form2.form2Instance.Show();
        }
    }
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
