namespace Lab7
{
    partial class Form_ListOfClients
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
            this.CloseFormButton_ListOfClients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.EditClientButton = new System.Windows.Forms.Button();
            this.DeleteClientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseFormButton_ListOfClients
            // 
            this.CloseFormButton_ListOfClients.Location = new System.Drawing.Point(896, 3);
            this.CloseFormButton_ListOfClients.Name = "CloseFormButton_ListOfClients";
            this.CloseFormButton_ListOfClients.Size = new System.Drawing.Size(86, 23);
            this.CloseFormButton_ListOfClients.TabIndex = 0;
            this.CloseFormButton_ListOfClients.Text = "Повернутися";
            this.CloseFormButton_ListOfClients.UseVisualStyleBackColor = true;
            this.CloseFormButton_ListOfClients.Click += new System.EventHandler(this.CloseFormButton_ListOfClients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 594);
            this.dataGridView1.TabIndex = 1;
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(92, 24);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(150, 23);
            this.AddClientButton.TabIndex = 2;
            this.AddClientButton.Text = "Додати клієнта";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // EditClientButton
            // 
            this.EditClientButton.Location = new System.Drawing.Point(92, 81);
            this.EditClientButton.Name = "EditClientButton";
            this.EditClientButton.Size = new System.Drawing.Size(168, 23);
            this.EditClientButton.TabIndex = 3;
            this.EditClientButton.Text = "Редагувати інфо про клієнта";
            this.EditClientButton.UseVisualStyleBackColor = true;
            this.EditClientButton.Click += new System.EventHandler(this.EditClientButton_Click);
            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.Location = new System.Drawing.Point(92, 137);
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(150, 23);
            this.DeleteClientButton.TabIndex = 4;
            this.DeleteClientButton.Text = "Видалити клієнта";
            this.DeleteClientButton.UseVisualStyleBackColor = true;
            this.DeleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // Form_ListOfClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 624);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteClientButton);
            this.Controls.Add(this.EditClientButton);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseFormButton_ListOfClients);
            this.Name = "Form_ListOfClients";
            this.Text = "Список клієнтів";
            this.Load += new System.EventHandler(this.Form_ListOfClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton_ListOfClients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button EditClientButton;
        private System.Windows.Forms.Button DeleteClientButton;
    }
}