using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab7
{
    public partial class Form_ListOfAvailableServices : Form
    {

        public Form_ListOfAvailableServices()
        {
            InitializeComponent();

        }

        private void Form_ListOfAvailableServices_Load(object sender, EventArgs e)
        {
            LoadServices();
        }




        private void CloseFormButton_ListOfAvailableServices_Click(object sender, EventArgs e)
        {
            // Приховуємо поточну форму (Form_ListOfAvailableServices)
            this.Hide();

            // Дозволяємо використання попередньої форми (Form2)
            Form2.form2Instance.Show();
        }

        private void setServiceButton_Click(object sender, EventArgs e)
        {

        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
         
        }
        private void LoadServices()
        {
          
        }

        private void deleteServiceButton_Click(object sender, EventArgs e)
        {

        }
    }
}
