namespace Lab7
{
    partial class Form_EditService
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditServiceButton = new System.Windows.Forms.Button();
            this.DeleteServiceButton = new System.Windows.Forms.Button();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.CloseFormButton_EditService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 527);
            this.dataGridView1.TabIndex = 0;
            // 
            // EditServiceButton
            // 
            this.EditServiceButton.Location = new System.Drawing.Point(171, 73);
            this.EditServiceButton.Name = "EditServiceButton";
            this.EditServiceButton.Size = new System.Drawing.Size(143, 23);
            this.EditServiceButton.TabIndex = 2;
            this.EditServiceButton.Text = "Редагування послуги";
            this.EditServiceButton.UseVisualStyleBackColor = true;
            // 
            // DeleteServiceButton
            // 
            this.DeleteServiceButton.Location = new System.Drawing.Point(171, 119);
            this.DeleteServiceButton.Name = "DeleteServiceButton";
            this.DeleteServiceButton.Size = new System.Drawing.Size(143, 23);
            this.DeleteServiceButton.TabIndex = 3;
            this.DeleteServiceButton.Text = "Видалення послуги";
            this.DeleteServiceButton.UseVisualStyleBackColor = true;
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.Location = new System.Drawing.Point(171, 22);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(143, 23);
            this.AddServiceButton.TabIndex = 4;
            this.AddServiceButton.Text = "Додавання послуги";
            this.AddServiceButton.UseVisualStyleBackColor = true;
            // 
            // CloseFormButton_EditService
            // 
            this.CloseFormButton_EditService.Location = new System.Drawing.Point(1152, 2);
            this.CloseFormButton_EditService.Name = "CloseFormButton_EditService";
            this.CloseFormButton_EditService.Size = new System.Drawing.Size(85, 23);
            this.CloseFormButton_EditService.TabIndex = 5;
            this.CloseFormButton_EditService.Text = "Повернутися";
            this.CloseFormButton_EditService.UseVisualStyleBackColor = true;
            this.CloseFormButton_EditService.Click += new System.EventHandler(this.CloseFormButton_EditService_Click);
            // 
            // Form_EditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 617);
            this.ControlBox = false;
            this.Controls.Add(this.CloseFormButton_EditService);
            this.Controls.Add(this.AddServiceButton);
            this.Controls.Add(this.DeleteServiceButton);
            this.Controls.Add(this.EditServiceButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_EditService";
            this.Text = "Редагування послуг";
            this.Load += new System.EventHandler(this.Form_EditService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditServiceButton;
        private System.Windows.Forms.Button DeleteServiceButton;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Button CloseFormButton_EditService;
    }
}