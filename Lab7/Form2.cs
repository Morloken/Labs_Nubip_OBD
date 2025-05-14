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
    public partial class Form2 : Form
    {
        public static Form2 form2Instance;
        // Створюємо новий екземпляр Form_ListOfAvailableServices
        Form_ListOfAvailableServices formListOfAvailableServices = new Form_ListOfAvailableServices();
        // Створюємо новий екземпляр Form_EditService
        Form_EditService formEditService = new Form_EditService();

        // Створюємо новий екземпляр Form_ListOfClients
        Form_ListOfClients formListOfClients = new Form_ListOfClients();
        // Створюємо новий екземпляр Form_ListOfOrders
        Form_ListOfOrders formListOfOrders = new Form_ListOfOrders();
        // Створюємо новий екземпляр Form_ListOfFinancialReports
        Form_ListOfFinancialReports formListOfFinancialReports = new Form_ListOfFinancialReports();
        // Створюємо новий екземпляр Form_OrderHistorycs
        Form_OrderHistorycs formOrderHistorycs = new Form_OrderHistorycs();
        // Створюємо новий екземпляр Reports
        Reports reports = new Reports();

        public Form2()
        {
            InitializeComponent();
            form2Instance = this;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            
            // Використовуємо збережений екземпляр Form1, щоб повернутися до нього
            Form1.form1Instance.Show();

            // Приховуємо поточну форму (Form2)
            this.Hide();
        }

        private void списокДоступнихПослугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Приховуємо поточну форму (Form2)
            this.Hide();

            // Відкриваємо нову форму (Form_ListOfAvailableServices)
            formListOfAvailableServices.Show();
        }

        private void редагуванняПослугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Створення нового екземпляра форми редагування послуг
            //Form_EditServices formEditServices = new Form_EditServices();
            formEditService.Show();

            // Приховуємо поточну форму (Form2)
            this.Hide();
        }

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void списокКлієнтівToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Приховуємо поточну форму (Form2)
            this.Hide();

            // Відкриваємо нову форму (Form_ListOfClients)
           
            formListOfClients.Show();
        }

        private void списокЗамовленьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Приховуємо поточну форму (Form2)
            this.Hide();

            // Відкриваємо нову форму (Form_ListOfOrders)
            formListOfOrders.Show();
        }

        private void списокФінансовихЗвітівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Приховуємо поточну форму (Form2)
            this.Hide();
            // Відкриваємо нову форму (Form_ListOfFinancialReports)
           
            formListOfFinancialReports.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void історіяЗамовленьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Приховуємо поточну форму (Form2)
            this.Hide();
            // Відкриваємо нову форму (Form_ListOfOrders)
            formOrderHistorycs.Show();


        }

        private void фінансиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void формуванняЗвітівToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Приховуємо поточну форму (Form2)
            this.Hide();
           
            reports.Show();
        }
    }
}
