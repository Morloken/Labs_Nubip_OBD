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
    public partial class Form_ListOfFinancialReports : Form
    {
        public Form_ListOfFinancialReports()
        {
            InitializeComponent();
        }
        private void Form_ListOfFinancialReports_Load(object sender, EventArgs e)
        {
            // Логіка для завантаження фінансових звітів (наприклад, з бази даних чи списку)
            LoadFinancialReports();
        }
        private void LoadFinancialReports()
        {
            // Це місце для коду, який завантажує список фінансових звітів у DataGridView
            // Наприклад, якщо ми використовуємо список або базу даних, треба показати їх у DataGridView.
            dataGridView1.DataSource = GetFinancialReports(); 
        }
        private List<FinancialReport> GetFinancialReports()
        {
            // Можна замінити на метод, що отримує фінансові звіти з бази даних
            List<FinancialReport> reports = new List<FinancialReport>
            {
                new FinancialReport { Id = 1, ReportName = "Звіт за січень", TotalIncome = 10000, TotalExpenses = 5000 },
                new FinancialReport { Id = 2, ReportName = "Звіт за лютий", TotalIncome = 15000, TotalExpenses = 7000 }
            };
            return reports;
        }
        


        private void CloseButton_ListOfFinancialReports_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2.form2Instance.Show();
        }

        private void Form_ListOfFinancialReports_Load_1(object sender, EventArgs e)
        {

        }

        private void AddReportButton_Click(object sender, EventArgs e)
        {

        }

        private void EditReportButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteReportButton_Click(object sender, EventArgs e)
        {

        }
    }
    public class FinancialReport
    {
        public int Id { get; set; }
        public string ReportName { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
    }
}
