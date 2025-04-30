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
            this.SuspendLayout();
            // 
            // CloseFormButton_ListOfAvailableServices
            // 
            this.CloseFormButton_ListOfAvailableServices.Location = new System.Drawing.Point(710, 1);
            this.CloseFormButton_ListOfAvailableServices.Name = "CloseFormButton_ListOfAvailableServices";
            this.CloseFormButton_ListOfAvailableServices.Size = new System.Drawing.Size(89, 23);
            this.CloseFormButton_ListOfAvailableServices.TabIndex = 0;
            this.CloseFormButton_ListOfAvailableServices.Text = "Повернутися";
            this.CloseFormButton_ListOfAvailableServices.UseVisualStyleBackColor = true;
            this.CloseFormButton_ListOfAvailableServices.Click += new System.EventHandler(this.CloseFormButton_ListOfAvailableServices_Click);
            // 
            // Form_ListOfAvailableServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CloseFormButton_ListOfAvailableServices);
            this.Name = "Form_ListOfAvailableServices";
            this.Text = "Список доступних послуг";
            this.Load += new System.EventHandler(this.Form_ListOfAvailableServices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton_ListOfAvailableServices;
    }
}