namespace Lab7
{
    partial class Form_ListOfOrders
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
            this.CloseButton_ListOfOrders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton_ListOfOrders
            // 
            this.CloseButton_ListOfOrders.Location = new System.Drawing.Point(704, 13);
            this.CloseButton_ListOfOrders.Name = "CloseButton_ListOfOrders";
            this.CloseButton_ListOfOrders.Size = new System.Drawing.Size(85, 23);
            this.CloseButton_ListOfOrders.TabIndex = 0;
            this.CloseButton_ListOfOrders.Text = "Повернутися";
            this.CloseButton_ListOfOrders.UseVisualStyleBackColor = true;
            this.CloseButton_ListOfOrders.Click += new System.EventHandler(this.CloseButton_ListOfOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 384);
            this.dataGridView1.TabIndex = 1;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(102, 42);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(142, 23);
            this.AddOrderButton.TabIndex = 2;
            this.AddOrderButton.Text = "Додати замовлення";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.Location = new System.Drawing.Point(102, 81);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(142, 23);
            this.EditOrderButton.TabIndex = 3;
            this.EditOrderButton.Text = "Редагувати замовлення";
            this.EditOrderButton.UseVisualStyleBackColor = true;
            this.EditOrderButton.Click += new System.EventHandler(this.EditOrderButton_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Location = new System.Drawing.Point(102, 121);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(142, 23);
            this.DeleteOrderButton.TabIndex = 4;
            this.DeleteOrderButton.Text = "Видалити замовлення";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // Form_ListOfOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.EditOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseButton_ListOfOrders);
            this.Name = "Form_ListOfOrders";
            this.Text = "Список замовлень";
            this.Load += new System.EventHandler(this.Form_ListOfOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton_ListOfOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.Button DeleteOrderButton;
    }
}