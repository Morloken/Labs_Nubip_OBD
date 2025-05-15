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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;



namespace Lab7
{
    public partial class Reports: Form
    {
        public Reports()
        {
        
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//close button
        {
        

           
            // Приховуємо поточну форму (Form2)
            this.Hide();
            // Показуємо форму Form1
            Form2.form2Instance.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

            
        }

        private void btnAllReports_Click(object sender, EventArgs e)
        {
            LoadReport("GetAllFinanceReports");
        }

        private void btnDateRange_Click(object sender, EventArgs e)
        {
            SqlParameter[] parameters = new SqlParameter[]
   {
        new SqlParameter("@StartDate", dateTimePicker1.Value.Date),
        new SqlParameter("@EndDate", dateTimePicker2.Value.Date)
   };
            LoadReport("GetFinanceReportByDateRange", parameters);
        }

        private void btnByEmployee_Click(object sender, EventArgs e)
        {
            LoadReport("GetFinanceByEmployee");
        }

        private void btnByClient_Click(object sender, EventArgs e)
        {
            LoadReport("GetFinanceByClient");
        }

        private void LoadReport(string procedureName, SqlParameter[] parameters = null)
        {
            var config = Form1.GetDbConfig();
            string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(procedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

               
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Немає даних для експорту!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Звіт";
                //Назва файлу

                string fileName = $"Report_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);


                // Додаємо заголовки
                for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                // Додаємо рядки
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка експорту: " + ex.Message);
            }
        }
    }


}
