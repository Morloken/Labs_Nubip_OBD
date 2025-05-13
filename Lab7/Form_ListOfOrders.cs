
using Lab7;
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
using static Lab7.Form_ListOfOrders;

namespace Lab7
{
    public partial class Form_ListOfOrders : Form
    {
        private string editingOrderId = null;
        private bool isEditing = false;
        private string searchFilter = "";

        public Form_ListOfOrders()
        {
            InitializeComponent();
            LoadOrders();
            //заміна заголовків стовпців
            dataGridView1.Columns[0].HeaderText = "Ідентифікатор замовлення";
            dataGridView1.Columns[1].HeaderText = "Ідентифікатор клієнта";
            dataGridView1.Columns[2].HeaderText = "ПІБ клієнта";
            dataGridView1.Columns[3].HeaderText = "Ідентифікатор послуги";
            dataGridView1.Columns[4].HeaderText = "Назва послуги";
            dataGridView1.Columns[5].HeaderText = "Ідентифікатор працівника";
            dataGridView1.Columns[6].HeaderText = "ПІБ працівника";
            dataGridView1.Columns[7].HeaderText = "Дата замовлення";
            dataGridView1.Columns[8].HeaderText = "Статус замовлення";
        }
        private void CloseButton_ListOfOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2.form2Instance.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        // Завантаження клієнтів та працівників у комбобокси
        private void LoadClientsAndEmployees()
        {
            try
            {
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Завантаження клієнтів
                    using (SqlCommand cmd = new SqlCommand("SELECT ClientID, ClientFullName FROM Client", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        comboBoxClients.Items.Clear();
                        while (reader.Read())
                        {
                            comboBoxClients.Items.Add(new ComboBoxItem
                            {
                                Text = reader["ClientFullName"].ToString(),
                                Value = reader["ClientID"].ToString()
                            });
                        }
                        reader.Close(); // Закриваємо reader після завершення роботи
                    }

                    // Завантаження працівників (відокремлено від клієнтів)
                    using (SqlCommand cmd = new SqlCommand("SELECT EmployeeID, EmployeeFullName FROM Employee", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        comboBoxEmployees.Items.Clear();
                        while (reader.Read())
                        {
                            comboBoxEmployees.Items.Add(new ComboBoxItem
                            {
                                Text = reader["EmployeeFullName"].ToString(),
                                Value = reader["EmployeeID"].ToString()
                            });
                        }
                        reader.Close(); // Закриваємо reader після завершення роботи
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_ListOfOrders_Load(object sender, EventArgs e)
        {
            LoadClientsAndEmployees(); // Спочатку завантажуємо клієнтів та працівників
            LoadOrders();
            LoadServices(); // Завантажуємо послуги
            searchTextBox.TextChanged += searchTextBox_TextChanged;

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchFilter = searchTextBox.Text; // Оновлюємо текст пошуку
            LoadOrders(searchFilter); // Перезавантажуємо замовлення з фільтром
        }

        private void LoadOrders(string filter = "")
        {
            try
            {
                dataGridView1.DataSource = GetOrders(filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження замовлень: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private DataTable GetOrders(string filter)
        {
            DataTable dt = new DataTable();

            try
            {
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Змінено запит для фільтрації за кількома полями
                    string query = @"SELECT o.OrderID, 
                                           o.ClientID,
                                           c.ClientFullName,  
                                           o.ServiceID,
                                           s.ServiceName,    
                                           o.EmployeeID,
                                           e.EmployeeFullName, 
                                           o.OrderDate, 
                                           o.OrderStatus
                                    FROM OrderTable o
                                    INNER JOIN Client c ON o.ClientID = c.ClientID
                                    INNER JOIN ServiceTable s ON o.ServiceID = s.ServiceID
                                    INNER JOIN Employee e ON o.EmployeeID = e.EmployeeID
                                    WHERE c.ClientFullName LIKE @filter 
                                       OR e.EmployeeFullName LIKE @filter
                                       OR s.ServiceName LIKE @filter
                                       OR o.OrderStatus LIKE @filter";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження замовлень: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            // Перевірка на наявність вибору
            if (comboBoxClients.SelectedItem == null || comboBoxEmployees.SelectedItem == null || comboBoxServices.SelectedItem == null || string.IsNullOrWhiteSpace(txtOrderStatus.Text))
            {
                MessageBox.Show("Виберіть клієнта, працівника, сервіс і введіть статус замовлення.");
                return;
            }

            // Отримуємо значення
            string clientId = ((ComboBoxItem)comboBoxClients.SelectedItem).Value;
            string employeeId = ((ComboBoxItem)comboBoxEmployees.SelectedItem).Value;
            string orderStatus = txtOrderStatus.Text;

            // Викликаємо метод для додавання замовлення
            AddOrder(clientId, employeeId, orderStatus);
        }

       
        private void AddOrder(string clientId, string employeeId, string orderStatus)
        {
        try
        {
        var config = Form1.GetDbConfig();
        string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

        // Генеруємо ідентифікатори
        string orderId = Guid.NewGuid().ToString();          // для OrderTable
        string orderDetailId = Guid.NewGuid().ToString();    // для OrderDetails

        if (comboBoxServices.SelectedItem == null)
        {
            MessageBox.Show("Виберіть сервіс для замовлення.");
            return;
        }

        string serviceId = ((Service)comboBoxServices.SelectedItem).ServiceID;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Додаємо основне замовлення
            using (SqlCommand command = new SqlCommand("dbo.AddNewOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@OrderID", orderId);
                command.Parameters.AddWithValue("@ClientID", clientId);
                command.Parameters.AddWithValue("@ServiceID", serviceId);
                command.Parameters.AddWithValue("@EmployeeID", employeeId);
                command.Parameters.AddWithValue("@OrderStatus", orderStatus);
                command.Parameters.AddWithValue("@OrderDate", DateTime.Now.Date);

                command.ExecuteNonQuery();
            }

// Додаємо деталі замовлення
using (SqlCommand cmd = new SqlCommand("dbo.AddOrderDetails", connection))
{
                      

                       
                        cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.AddWithValue("@OrderDetailID", orderDetailId);
    cmd.Parameters.AddWithValue("@ServiceID", serviceId);
    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                        decimal fakeTotalPrice = 11; 
                        cmd.Parameters.AddWithValue("@OrderDetailTotalPrice", fakeTotalPrice); 
    cmd.ExecuteNonQuery();
}
        }

        MessageBox.Show("Замовлення успішно додано!");
LoadOrders(); // Оновлюємо список замовлень після додавання
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Помилка при додаванні замовлення: {ex.Message}");
    }
}




        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Виберіть замовлення для редагування.");
                    return;
                }

                // Отримуємо вибраний рядок
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Зберігаємо ID редагованого замовлення
                editingOrderId = selectedRow.Cells["OrderID"].Value.ToString();

                // Завантажуємо дані у поля
                string clientId = selectedRow.Cells["ClientID"].Value.ToString();
                string employeeId = selectedRow.Cells["EmployeeID"].Value.ToString();
                string serviceId = selectedRow.Cells["ServiceID"].Value.ToString();
                string orderStatus = selectedRow.Cells["OrderStatus"].Value.ToString();

                // Встановлюємо вибрані значення у ComboBox-и
                comboBoxClients.SelectedItem = comboBoxClients.Items.Cast<ComboBoxItem>().FirstOrDefault(i => i.Value == clientId);
                comboBoxEmployees.SelectedItem = comboBoxEmployees.Items.Cast<ComboBoxItem>().FirstOrDefault(i => i.Value == employeeId);
                comboBoxServices.SelectedItem = comboBoxServices.Items.Cast<Service>().FirstOrDefault(i => i.ServiceID == serviceId);

                txtOrderStatus.Text = orderStatus;

                // Міняємо стан форми
                AddOrderButton.Visible = false;
                DeleteOrderButton.Visible = false;
                searchTextBox.Visible = false;
                CloseButton_ListOfOrders.Visible = false;
                EditOrderButton.Text = "Закінчити редагування";
                isEditing = true;
            }
            else
            {
                // Зберігаємо оновлення
                if (comboBoxClients.SelectedItem == null || comboBoxEmployees.SelectedItem == null || comboBoxServices.SelectedItem == null || string.IsNullOrWhiteSpace(txtOrderStatus.Text))
                {
                    MessageBox.Show("Виберіть клієнта, працівника, сервіс і введіть статус замовлення.");
                    return;
                }

                string newClientId = ((ComboBoxItem)comboBoxClients.SelectedItem).Value;
                string newEmployeeId = ((ComboBoxItem)comboBoxEmployees.SelectedItem).Value;
                string newServiceId = ((Service)comboBoxServices.SelectedItem).ServiceID;
                string newOrderStatus = txtOrderStatus.Text;

                SaveEditedOrder(editingOrderId, newClientId, newEmployeeId, newServiceId, newOrderStatus);

                // Скидаємо стан
                AddOrderButton.Visible = true;
                DeleteOrderButton.Visible = true;
                searchTextBox.Visible = true;
                CloseButton_ListOfOrders.Visible = true;
                EditOrderButton.Text = "Редагувати замовлення";
                isEditing = false;
                editingOrderId = null;

                // Очищаємо поля
                comboBoxClients.SelectedIndex = -1;
                comboBoxEmployees.SelectedIndex = -1;
                comboBoxServices.SelectedIndex = -1;
                txtOrderStatus.Clear();
            }
        }
        
        private void SaveEditedOrder(string orderId, string clientId, string employeeId, string serviceId, string newOrderStatus)
        {
            try
            {
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Спочатку отримаємо старий статус
                    string oldStatus = "";
                    using (SqlCommand getStatusCmd = new SqlCommand("SELECT OrderStatus FROM OrderTable WHERE OrderID = @OrderID", connection))
                    {
                        getStatusCmd.Parameters.AddWithValue("@OrderID", orderId);
                        object result = getStatusCmd.ExecuteScalar();
                        if (result != null)
                            oldStatus = result.ToString();
                    }

                    // Оновлюємо решту полів (існуюча процедура)
                    using (SqlCommand command = new SqlCommand("dbo.UpdateOrder", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@OrderID", orderId);
                        command.Parameters.AddWithValue("@ClientID", clientId);
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);
                        command.Parameters.AddWithValue("@ServiceID", serviceId);
                        command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                        command.Parameters.AddWithValue("@OrderStatus", newOrderStatus);

                        command.ExecuteNonQuery();
                    }

                    // Якщо статус змінився, викликаємо логування
                    if (oldStatus != newOrderStatus)
                    {
                        using (SqlCommand logCommand = new SqlCommand("dbo.UpdateOrderStatusWithLog", connection))
                        {
                            logCommand.CommandType = CommandType.StoredProcedure;
                            logCommand.Parameters.AddWithValue("@OrderID", orderId);
                            logCommand.Parameters.AddWithValue("@NewStatus", newOrderStatus);
                            logCommand.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Дані замовлення оновлено!");
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при редагуванні замовлення: {ex.Message}");
            }
        }


        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть замовлення для видалення.");
                return;
            }

            string orderId = dataGridView1.SelectedRows[0].Cells["OrderID"].Value.ToString();

            var confirmResult = MessageBox.Show("Ви впевнені, що хочете видалити це замовлення?", "Підтвердження", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteOrder(orderId);
            }
        }

        private void DeleteOrder(string orderId)
        {
            try
            {
                var config = Form1.GetDbConfig();
                string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DeleteOrderByID", connection)) // Викликаємо твою процедуру
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@OrderID", orderId);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Замовлення успішно видалено.");
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при видаленні замовлення: {ex.Message}");
            }
        }

        // Клас для елементів ComboBox
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() => Text;
        }
        private void LoadServices()
        {
            var config = Form1.GetDbConfig();
            string connectionString = $"Server={config.Server};Database={config.Database};User Id={Form1.CurrentLogin};Password={Form1.CurrentPassword};";
            string query = "SELECT ServiceID, ServiceName FROM dbo.ServiceTable";

            List<Service> services = new List<Service>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    services.Add(new Service
                    {
                        ServiceID = reader["ServiceID"].ToString(),
                        ServiceName = reader["ServiceName"].ToString()
                    });
                }
                reader.Close();
            }

            comboBoxServices.DataSource = services;
            comboBoxServices.DisplayMember = "ServiceName";
            comboBoxServices.ValueMember = "ServiceID";
        }
        public class Service
        {
            public string ServiceID { get; set; }
            public string ServiceName { get; set; }

            public override string ToString()
            {
                return ServiceName; // Так буде відображатися в ComboBox
            }
        }
    }
}
