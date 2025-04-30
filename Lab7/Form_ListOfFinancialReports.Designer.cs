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
            this.AddReportButton = new System.Windows.Forms.Button();
            this.EditReportButton = new System.Windows.Forms.Button();
            this.DeleteReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton_ListOfFinancialReports
            // 
            this.CloseButton_ListOfFinancialReports.Location = new System.Drawing.Point(696, 13);
            this.CloseButton_ListOfFinancialReports.Name = "CloseButton_ListOfFinancialReports";
            this.CloseButton_ListOfFinancialReports.Size = new System.Drawing.Size(81, 23);
            this.CloseButton_ListOfFinancialReports.TabIndex = 0;
            this.CloseButton_ListOfFinancialReports.Text = "Повернутися";
            this.CloseButton_ListOfFinancialReports.UseVisualStyleBackColor = true;
            this.CloseButton_ListOfFinancialReports.Click += new System.EventHandler(this.CloseButton_ListOfFinancialReports_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 279);
            this.dataGridView1.TabIndex = 1;
            // 
            // AddReportButton
            // 
            this.AddReportButton.Location = new System.Drawing.Point(47, 74);
            this.AddReportButton.Name = "AddReportButton";
            this.AddReportButton.Size = new System.Drawing.Size(120, 23);
            this.AddReportButton.TabIndex = 2;
            this.AddReportButton.Text = "Додати звіт";
            this.AddReportButton.UseVisualStyleBackColor = true;
            this.AddReportButton.Click += new System.EventHandler(this.AddReportButton_Click);
            // 
            // EditReportButton
            // 
            this.EditReportButton.Location = new System.Drawing.Point(47, 123);
            this.EditReportButton.Name = "EditReportButton";
            this.EditReportButton.Size = new System.Drawing.Size(120, 23);
            this.EditReportButton.TabIndex = 3;
            this.EditReportButton.Text = "Редагувати звіт";
            this.EditReportButton.UseVisualStyleBackColor = true;
            this.EditReportButton.Click += new System.EventHandler(this.EditReportButton_Click);
            // 
            // DeleteReportButton
            // 
            this.DeleteReportButton.Location = new System.Drawing.Point(47, 178);
            this.DeleteReportButton.Name = "DeleteReportButton";
            this.DeleteReportButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteReportButton.TabIndex = 4;
            this.DeleteReportButton.Text = "Видалити звіт";
            this.DeleteReportButton.UseVisualStyleBackColor = true;
            this.DeleteReportButton.Click += new System.EventHandler(this.DeleteReportButton_Click);
            // 
            // Form_ListOfFinancialReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteReportButton);
            this.Controls.Add(this.EditReportButton);
            this.Controls.Add(this.AddReportButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseButton_ListOfFinancialReports);
            this.Name = "Form_ListOfFinancialReports";
            this.Text = "Список фінансових звітів";
            this.Load += new System.EventHandler(this.Form_ListOfFinancialReports_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton_ListOfFinancialReports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddReportButton;
        private System.Windows.Forms.Button EditReportButton;
        private System.Windows.Forms.Button DeleteReportButton;
    }
}