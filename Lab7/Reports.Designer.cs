namespace Lab7
{
    partial class Reports
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
            this.closeButtonReports = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnAllReports = new System.Windows.Forms.Button();
            this.btnDateRange = new System.Windows.Forms.Button();
            this.btnByEmployee = new System.Windows.Forms.Button();
            this.btnByClient = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButtonReports
            // 
            this.closeButtonReports.Location = new System.Drawing.Point(887, 12);
            this.closeButtonReports.Name = "closeButtonReports";
            this.closeButtonReports.Size = new System.Drawing.Size(121, 23);
            this.closeButtonReports.TabIndex = 0;
            this.closeButtonReports.Text = "Повернутися";
            this.closeButtonReports.UseVisualStyleBackColor = true;
            this.closeButtonReports.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Початкова дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кінцева дата";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(648, 146);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // btnAllReports
            // 
            this.btnAllReports.Location = new System.Drawing.Point(648, 198);
            this.btnAllReports.Name = "btnAllReports";
            this.btnAllReports.Size = new System.Drawing.Size(290, 23);
            this.btnAllReports.TabIndex = 6;
            this.btnAllReports.Text = "Завантажити всі фінансові записи\n";
            this.btnAllReports.UseVisualStyleBackColor = true;
            this.btnAllReports.Click += new System.EventHandler(this.btnAllReports_Click);
            // 
            // btnDateRange
            // 
            this.btnDateRange.Location = new System.Drawing.Point(651, 245);
            this.btnDateRange.Name = "btnDateRange";
            this.btnDateRange.Size = new System.Drawing.Size(287, 23);
            this.btnDateRange.TabIndex = 7;
            this.btnDateRange.Text = "Звіт за період\n";
            this.btnDateRange.UseVisualStyleBackColor = true;
            this.btnDateRange.Click += new System.EventHandler(this.btnDateRange_Click);
            // 
            // btnByEmployee
            // 
            this.btnByEmployee.Location = new System.Drawing.Point(651, 298);
            this.btnByEmployee.Name = "btnByEmployee";
            this.btnByEmployee.Size = new System.Drawing.Size(287, 23);
            this.btnByEmployee.TabIndex = 8;
            this.btnByEmployee.Text = "Звіт по працівниках\n";
            this.btnByEmployee.UseVisualStyleBackColor = true;
            this.btnByEmployee.Click += new System.EventHandler(this.btnByEmployee_Click);
            // 
            // btnByClient
            // 
            this.btnByClient.Location = new System.Drawing.Point(651, 346);
            this.btnByClient.Name = "btnByClient";
            this.btnByClient.Size = new System.Drawing.Size(287, 23);
            this.btnByClient.TabIndex = 9;
            this.btnByClient.Text = "Звіт по клієнтах\n";
            this.btnByClient.UseVisualStyleBackColor = true;
            this.btnByClient.Click += new System.EventHandler(this.btnByClient_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(651, 398);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(287, 40);
            this.btnExportToExcel.TabIndex = 10;
            this.btnExportToExcel.Text = "Вивантаження звіту в Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 579);
            this.ControlBox = false;
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnByClient);
            this.Controls.Add(this.btnByEmployee);
            this.Controls.Add(this.btnDateRange);
            this.Controls.Add(this.btnAllReports);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.closeButtonReports);
            this.Name = "Reports";
            this.Text = "Звіти";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButtonReports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnAllReports;
        private System.Windows.Forms.Button btnDateRange;
        private System.Windows.Forms.Button btnByEmployee;
        private System.Windows.Forms.Button btnByClient;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}