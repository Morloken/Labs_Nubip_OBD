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
            //прибрати кнопку розкриття вікна на весь екран
            this.MaximizeBox = false;
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
            //NameTextBox
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

        private void LoginButton_Click(object sender, EventArgs e)
        {

            // Створюємо екземпляр Form2
            Form2 form2 = new Form2();

            // Відкриваємо Form2
            Form2.form2Instance.Show();

            // Приховуємо Form1, щоб вона залишалася в пам'яті
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
