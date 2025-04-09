namespace Lab7
{
    partial class Form2
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
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.послугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокДоступнихПослугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняПослугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.історіяПослугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКлієнтівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗамовленьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершеніЗамовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фінансиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокФінансовихЗвітівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатаЗаПослугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.BackColor = System.Drawing.Color.Red;
            this.CloseFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseFormButton.FlatAppearance.BorderSize = 0;
            this.CloseFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseFormButton.Location = new System.Drawing.Point(767, 0);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(33, 35);
            this.CloseFormButton.TabIndex = 0;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.UseVisualStyleBackColor = false;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.послугиToolStripMenuItem,
            this.клієнтиToolStripMenuItem,
            this.замовленняToolStripMenuItem,
            this.фінансиToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // послугиToolStripMenuItem
            // 
            this.послугиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокДоступнихПослугToolStripMenuItem,
            this.редагуванняПослугToolStripMenuItem,
            this.історіяПослугToolStripMenuItem});
            this.послугиToolStripMenuItem.Name = "послугиToolStripMenuItem";
            this.послугиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.послугиToolStripMenuItem.Text = "Послуги";
            // 
            // списокДоступнихПослугToolStripMenuItem
            // 
            this.списокДоступнихПослугToolStripMenuItem.Name = "списокДоступнихПослугToolStripMenuItem";
            this.списокДоступнихПослугToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.списокДоступнихПослугToolStripMenuItem.Text = "Список доступних послуг";
            this.списокДоступнихПослугToolStripMenuItem.Click += new System.EventHandler(this.списокДоступнихПослугToolStripMenuItem_Click);
            // 
            // редагуванняПослугToolStripMenuItem
            // 
            this.редагуванняПослугToolStripMenuItem.Name = "редагуванняПослугToolStripMenuItem";
            this.редагуванняПослугToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.редагуванняПослугToolStripMenuItem.Text = "Редагування послуг";
            this.редагуванняПослугToolStripMenuItem.Click += new System.EventHandler(this.редагуванняПослугToolStripMenuItem_Click);
            // 
            // історіяПослугToolStripMenuItem
            // 
            this.історіяПослугToolStripMenuItem.Name = "історіяПослугToolStripMenuItem";
            this.історіяПослугToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.історіяПослугToolStripMenuItem.Text = "Історія послуг";
            // 
            // клієнтиToolStripMenuItem
            // 
            this.клієнтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКлієнтівToolStripMenuItem});
            this.клієнтиToolStripMenuItem.Name = "клієнтиToolStripMenuItem";
            this.клієнтиToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.клієнтиToolStripMenuItem.Text = "Клієнти";
            this.клієнтиToolStripMenuItem.Click += new System.EventHandler(this.клієнтиToolStripMenuItem_Click);
            // 
            // списокКлієнтівToolStripMenuItem
            // 
            this.списокКлієнтівToolStripMenuItem.Name = "списокКлієнтівToolStripMenuItem";
            this.списокКлієнтівToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.списокКлієнтівToolStripMenuItem.Text = "Список клієнтів";
            this.списокКлієнтівToolStripMenuItem.Click += new System.EventHandler(this.списокКлієнтівToolStripMenuItem_Click);
            // 
            // замовленняToolStripMenuItem
            // 
            this.замовленняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЗамовленьToolStripMenuItem,
            this.завершеніЗамовленняToolStripMenuItem});
            this.замовленняToolStripMenuItem.Name = "замовленняToolStripMenuItem";
            this.замовленняToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.замовленняToolStripMenuItem.Text = "Замовлення";
            // 
            // списокЗамовленьToolStripMenuItem
            // 
            this.списокЗамовленьToolStripMenuItem.Name = "списокЗамовленьToolStripMenuItem";
            this.списокЗамовленьToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.списокЗамовленьToolStripMenuItem.Text = "Список замовлень";
            this.списокЗамовленьToolStripMenuItem.Click += new System.EventHandler(this.списокЗамовленьToolStripMenuItem_Click);
            // 
            // завершеніЗамовленняToolStripMenuItem
            // 
            this.завершеніЗамовленняToolStripMenuItem.Name = "завершеніЗамовленняToolStripMenuItem";
            this.завершеніЗамовленняToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.завершеніЗамовленняToolStripMenuItem.Text = "Завершені замовлення";
            // 
            // фінансиToolStripMenuItem
            // 
            this.фінансиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокФінансовихЗвітівToolStripMenuItem,
            this.оплатаЗаПослугиToolStripMenuItem});
            this.фінансиToolStripMenuItem.Name = "фінансиToolStripMenuItem";
            this.фінансиToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.фінансиToolStripMenuItem.Text = "Фінанси";
            // 
            // списокФінансовихЗвітівToolStripMenuItem
            // 
            this.списокФінансовихЗвітівToolStripMenuItem.Name = "списокФінансовихЗвітівToolStripMenuItem";
            this.списокФінансовихЗвітівToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.списокФінансовихЗвітівToolStripMenuItem.Text = "Список фінансових звітів";
            this.списокФінансовихЗвітівToolStripMenuItem.Click += new System.EventHandler(this.списокФінансовихЗвітівToolStripMenuItem_Click);
            // 
            // оплатаЗаПослугиToolStripMenuItem
            // 
            this.оплатаЗаПослугиToolStripMenuItem.Name = "оплатаЗаПослугиToolStripMenuItem";
            this.оплатаЗаПослугиToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.оплатаЗаПослугиToolStripMenuItem.Text = "Оплата за послуги";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "Form2";
            this.Text = "АРМ директора комп\'ютерного сервісного центру";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem послугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокДоступнихПослугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняПослугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem історіяПослугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКлієнтівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗамовленьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершеніЗамовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фінансиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокФінансовихЗвітівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оплатаЗаПослугиToolStripMenuItem;
    }
}