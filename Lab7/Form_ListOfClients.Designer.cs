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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseFormButton_ListOfClients
            // 
            this.CloseFormButton_ListOfClients.Location = new System.Drawing.Point(1195, 4);
            this.CloseFormButton_ListOfClients.Margin = new System.Windows.Forms.Padding(4);
            this.CloseFormButton_ListOfClients.Name = "CloseFormButton_ListOfClients";
            this.CloseFormButton_ListOfClients.Size = new System.Drawing.Size(115, 28);
            this.CloseFormButton_ListOfClients.TabIndex = 0;
            this.CloseFormButton_ListOfClients.Text = "Повернутися";
            this.CloseFormButton_ListOfClients.UseVisualStyleBackColor = true;
            this.CloseFormButton_ListOfClients.Click += new System.EventHandler(this.CloseFormButton_ListOfClients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(791, 731);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(7, 22);
            this.AddClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(224, 28);
            this.AddClientButton.TabIndex = 2;
            this.AddClientButton.Text = "Додати клієнта";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // EditClientButton
            // 
            this.EditClientButton.Location = new System.Drawing.Point(7, 58);
            this.EditClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditClientButton.Name = "EditClientButton";
            this.EditClientButton.Size = new System.Drawing.Size(224, 28);
            this.EditClientButton.TabIndex = 3;
            this.EditClientButton.Text = "Редагувати інфо про клієнта";
            this.EditClientButton.UseVisualStyleBackColor = true;
            this.EditClientButton.Click += new System.EventHandler(this.EditClientButton_Click);
            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.Location = new System.Drawing.Point(7, 94);
            this.DeleteClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(224, 28);
            this.DeleteClientButton.TabIndex = 4;
            this.DeleteClientButton.Text = "Видалити клієнта";
            this.DeleteClientButton.UseVisualStyleBackColor = true;
            this.DeleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фільтр пошуку(по всіх полях клієнта)";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(15, 263);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 22);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Lab7.Properties.Resources.booking;
            this.pictureBox1.Location = new System.Drawing.Point(15, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 250);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddClientButton);
            this.groupBox1.Controls.Add(this.EditClientButton);
            this.groupBox1.Controls.Add(this.DeleteClientButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опції взаємодії";
            // 
            // Form_ListOfClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 768);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseFormButton_ListOfClients);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ListOfClients";
            this.Text = "Список клієнтів";
            this.Load += new System.EventHandler(this.Form_ListOfClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton_ListOfClients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button EditClientButton;
        private System.Windows.Forms.Button DeleteClientButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}