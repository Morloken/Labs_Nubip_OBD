namespace Lab7
{
    partial class Form_ListOfFinancialReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton_ListOfFinancialReports = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteReportButton = new System.Windows.Forms.Button();
            this.EditReportButton = new System.Windows.Forms.Button();
            this.AddReportButton = new System.Windows.Forms.Button();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDetailIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serviceIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.financeAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.financeTransactionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.financeTransactionTypeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.financeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton_ListOfFinancialReports
            // 
            this.CloseButton_ListOfFinancialReports.Location = new System.Drawing.Point(928, 16);
            this.CloseButton_ListOfFinancialReports.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton_ListOfFinancialReports.Name = "CloseButton_ListOfFinancialReports";
            this.CloseButton_ListOfFinancialReports.Size = new System.Drawing.Size(108, 28);
            this.CloseButton_ListOfFinancialReports.TabIndex = 0;
            this.CloseButton_ListOfFinancialReports.Text = "Повернутися";
            this.CloseButton_ListOfFinancialReports.UseVisualStyleBackColor = true;
            this.CloseButton_ListOfFinancialReports.Click += new System.EventHandler(this.CloseButton_ListOfFinancialReports_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 343);
            this.dataGridView1.TabIndex = 1;
            // 
            // DeleteReportButton
            // 
            this.DeleteReportButton.Location = new System.Drawing.Point(876, 442);
            this.DeleteReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteReportButton.Name = "DeleteReportButton";
            this.DeleteReportButton.Size = new System.Drawing.Size(160, 28);
            this.DeleteReportButton.TabIndex = 4;
            this.DeleteReportButton.Text = "Видалити звіт";
            this.DeleteReportButton.UseVisualStyleBackColor = true;
            this.DeleteReportButton.Click += new System.EventHandler(this.DeleteReportButton_Click);
            // 
            // EditReportButton
            // 
            this.EditReportButton.Location = new System.Drawing.Point(373, 442);
            this.EditReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditReportButton.Name = "EditReportButton";
            this.EditReportButton.Size = new System.Drawing.Size(160, 28);
            this.EditReportButton.TabIndex = 3;
            this.EditReportButton.Text = "Редагувати звіт";
            this.EditReportButton.UseVisualStyleBackColor = true;
            this.EditReportButton.Click += new System.EventHandler(this.EditReportButton_Click);
            // 
            // AddReportButton
            // 
            this.AddReportButton.Location = new System.Drawing.Point(708, 442);
            this.AddReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddReportButton.Name = "AddReportButton";
            this.AddReportButton.Size = new System.Drawing.Size(160, 28);
            this.AddReportButton.TabIndex = 2;
            this.AddReportButton.Text = "Додати звіт";
            this.AddReportButton.UseVisualStyleBackColor = true;
            this.AddReportButton.Click += new System.EventHandler(this.AddReportButton_Click);
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(44, 31);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(296, 22);
            this.orderIDTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ідентифікатор замовлення";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ідентифікатор клієнта";
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.Location = new System.Drawing.Point(44, 91);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(296, 22);
            this.clientIDTextBox.TabIndex = 5;
            // 
            // orderDetailIDTextBox
            // 
            this.orderDetailIDTextBox.Location = new System.Drawing.Point(44, 204);
            this.orderDetailIDTextBox.Name = "orderDetailIDTextBox";
            this.orderDetailIDTextBox.Size = new System.Drawing.Size(296, 22);
            this.orderDetailIDTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ідентифікатор послуги/Сервісу";
            // 
            // serviceIDTextBox
            // 
            this.serviceIDTextBox.Location = new System.Drawing.Point(44, 144);
            this.serviceIDTextBox.Name = "serviceIDTextBox";
            this.serviceIDTextBox.Size = new System.Drawing.Size(296, 22);
            this.serviceIDTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ідентифікатор деталей замовлення";
            // 
            // financeAmountTextBox
            // 
            this.financeAmountTextBox.Location = new System.Drawing.Point(44, 315);
            this.financeAmountTextBox.Name = "financeAmountTextBox";
            this.financeAmountTextBox.Size = new System.Drawing.Size(296, 22);
            this.financeAmountTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ідентифікатор працівника";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Location = new System.Drawing.Point(44, 259);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(296, 22);
            this.employeeIDTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Грошова сумарна вартість";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // financeTransactionDatePicker
            // 
            this.financeTransactionDatePicker.Location = new System.Drawing.Point(44, 368);
            this.financeTransactionDatePicker.Name = "financeTransactionDatePicker";
            this.financeTransactionDatePicker.Size = new System.Drawing.Size(296, 22);
            this.financeTransactionDatePicker.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата фінансової транзакції";
            // 
            // financeTransactionTypeTextBox
            // 
            this.financeTransactionTypeTextBox.Location = new System.Drawing.Point(44, 422);
            this.financeTransactionTypeTextBox.Name = "financeTransactionTypeTextBox";
            this.financeTransactionTypeTextBox.Size = new System.Drawing.Size(296, 22);
            this.financeTransactionTypeTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Тип фінансової транзакції";
            // 
            // financeDescriptionTextBox
            // 
            this.financeDescriptionTextBox.Location = new System.Drawing.Point(44, 467);
            this.financeDescriptionTextBox.Multiline = true;
            this.financeDescriptionTextBox.Name = "financeDescriptionTextBox";
            this.financeDescriptionTextBox.Size = new System.Drawing.Size(296, 22);
            this.financeDescriptionTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Опис транзакції";
            // 
            // Form_ListOfFinancialReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 554);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.financeDescriptionTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.financeTransactionTypeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.financeTransactionDatePicker);
            this.Controls.Add(this.financeAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderDetailIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serviceIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(this.DeleteReportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditReportButton);
            this.Controls.Add(this.AddReportButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseButton_ListOfFinancialReports);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ListOfFinancialReports";
            this.Text = "Список фінансових звітів";
            this.Load += new System.EventHandler(this.Form_ListOfFinancialReports_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton_ListOfFinancialReports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteReportButton;
        private System.Windows.Forms.Button EditReportButton;
        private System.Windows.Forms.Button AddReportButton;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox orderDetailIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serviceIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox financeAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker financeTransactionDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox financeTransactionTypeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox financeDescriptionTextBox;
        private System.Windows.Forms.Label label9;
    }
}