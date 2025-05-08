using Newtonsoft.Json;
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

namespace DbConfigGenerator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class DbConfig
        {
            public string Server { get; set; }
            public string Database { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Збираємо дані
            DbConfig config = new DbConfig
            {
                Server = serverTextBox.Text.Trim(),
                Database = databaseTextBox.Text.Trim()
            };

            // Перевіряємо чи користувач ввів шлях до папки bin\Debug
            string targetFolder = pathTextBox.Text.Trim();

            if (!Directory.Exists(targetFolder))
            {
                MessageBox.Show("Вказана папка не існує. Перевірте шлях!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Формуємо JSON
                string json = JsonConvert.SerializeObject(config, Formatting.Indented);

                // Повний шлях до файлу в цільовій папці
                string targetPath = Path.Combine(targetFolder, "dbconfig.json");

                // Записуємо файл
                File.WriteAllText(targetPath, json);

                MessageBox.Show($"Файл успішно збережено у папку:\n{targetFolder}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка при збереженні файлу:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            // Відкрити діалог вибору папки
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pathTextBox.Text = dialog.SelectedPath;
                }
            }
        }
    }
}
