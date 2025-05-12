namespace Lab7
{
    partial class Form_ListOfAvailableServices
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
            this.CloseFormButton_ListOfAvailableServices = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editServiceButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.deleteServiceButton = new System.Windows.Forms.Button();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.servicePriceTextBox = new System.Windows.Forms.TextBox();
            this.serviceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serviceDurationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDurationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseFormButton_ListOfAvailableServices
            // 
            this.CloseFormButton_ListOfAvailableServices.Location = new System.Drawing.Point(947, 1);
            this.CloseFormButton_ListOfAvailableServices.Margin = new System.Windows.Forms.Padding(4);
            this.CloseFormButton_ListOfAvailableServices.Name = "CloseFormButton_ListOfAvailableServices";
            this.CloseFormButton_ListOfAvailableServices.Size = new System.Drawing.Size(119, 28);
            this.CloseFormButton_ListOfAvailableServices.TabIndex = 0;
            this.CloseFormButton_ListOfAvailableServices.Text = "Повернутися";
            this.CloseFormButton_ListOfAvailableServices.UseVisualStyleBackColor = true;
            this.CloseFormButton_ListOfAvailableServices.Click += new System.EventHandler(this.CloseFormButton_ListOfAvailableServices_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(585, 530);
            this.dataGridView1.TabIndex = 1;
            // 
            // editServiceButton
            // 
            this.editServiceButton.Location = new System.Drawing.Point(3, 3);
            this.editServiceButton.Name = "editServiceButton";
            this.editServiceButton.Size = new System.Drawing.Size(213, 23);
            this.editServiceButton.TabIndex = 2;
            this.editServiceButton.Text = "Редагувати послугу";
            this.editServiceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editServiceButton.UseVisualStyleBackColor = true;
            this.editServiceButton.Click += new System.EventHandler(this.setServiceButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.editServiceButton);
            this.flowLayoutPanel1.Controls.Add(this.addServiceButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteServiceButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(643, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 103);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(3, 32);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(213, 23);
            this.addServiceButton.TabIndex = 3;
            this.addServiceButton.Text = "Додати послугу";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // deleteServiceButton
            // 
            this.deleteServiceButton.Location = new System.Drawing.Point(3, 61);
            this.deleteServiceButton.Name = "deleteServiceButton";
            this.deleteServiceButton.Size = new System.Drawing.Size(213, 23);
            this.deleteServiceButton.TabIndex = 4;
            this.deleteServiceButton.Text = "Видалити послугу";
            this.deleteServiceButton.UseVisualStyleBackColor = true;
            this.deleteServiceButton.Click += new System.EventHandler(this.deleteServiceButton_Click);
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.Location = new System.Drawing.Point(643, 176);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(218, 22);
            this.serviceNameTextBox.TabIndex = 5;
            // 
            // servicePriceTextBox
            // 
            this.servicePriceTextBox.Location = new System.Drawing.Point(646, 251);
            this.servicePriceTextBox.Name = "servicePriceTextBox";
            this.servicePriceTextBox.Size = new System.Drawing.Size(213, 22);
            this.servicePriceTextBox.TabIndex = 6;
            // 
            // serviceDescriptionTextBox
            // 
            this.serviceDescriptionTextBox.Location = new System.Drawing.Point(646, 417);
            this.serviceDescriptionTextBox.Name = "serviceDescriptionTextBox";
            this.serviceDescriptionTextBox.Size = new System.Drawing.Size(213, 22);
            this.serviceDescriptionTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Назва послуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ціна послуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тривалість послуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Опис послуги";
            // 
            // serviceDurationNumericUpDown
            // 
            this.serviceDurationNumericUpDown.Location = new System.Drawing.Point(646, 347);
            this.serviceDurationNumericUpDown.Name = "serviceDurationNumericUpDown";
            this.serviceDurationNumericUpDown.Size = new System.Drawing.Size(213, 22);
            this.serviceDurationNumericUpDown.TabIndex = 13;
            // 
            // Form_ListOfAvailableServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.serviceDurationNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serviceDescriptionTextBox);
            this.Controls.Add(this.servicePriceTextBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseFormButton_ListOfAvailableServices);
            this.Controls.Add(this.serviceNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ListOfAvailableServices";
            this.Text = "Список доступних послуг";
            this.Load += new System.EventHandler(this.Form_ListOfAvailableServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceDurationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton_ListOfAvailableServices;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editServiceButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button deleteServiceButton;
        private System.Windows.Forms.TextBox serviceNameTextBox;
        private System.Windows.Forms.TextBox servicePriceTextBox;
        private System.Windows.Forms.TextBox serviceDescriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown serviceDurationNumericUpDown;
    }
}