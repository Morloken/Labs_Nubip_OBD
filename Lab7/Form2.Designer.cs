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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.BackColor = System.Drawing.Color.Red;
            this.CloseFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseFormButton.FlatAppearance.BorderSize = 0;
            this.CloseFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseFormButton.Location = new System.Drawing.Point(1023, 0);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(44, 43);
            this.CloseFormButton.TabIndex = 0;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.UseVisualStyleBackColor = false;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.послугиToolStripMenuItem,
            this.клієнтиToolStripMenuItem,
            this.замовленняToolStripMenuItem,
            this.фінансиToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1067, 28);
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
            this.послугиToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.послугиToolStripMenuItem.Text = "Послуги";
            // 
            // списокДоступнихПослугToolStripMenuItem
            // 
            this.списокДоступнихПослугToolStripMenuItem.Name = "списокДоступнихПослугToolStripMenuItem";
            this.списокДоступнихПослугToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.списокДоступнихПослугToolStripMenuItem.Text = "Список доступних послуг";
            this.списокДоступнихПослугToolStripMenuItem.Click += new System.EventHandler(this.списокДоступнихПослугToolStripMenuItem_Click);
            // 
            // редагуванняПослугToolStripMenuItem
            // 
            this.редагуванняПослугToolStripMenuItem.Name = "редагуванняПослугToolStripMenuItem";
            this.редагуванняПослугToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.редагуванняПослугToolStripMenuItem.Text = "Редагування послуг";
            this.редагуванняПослугToolStripMenuItem.Click += new System.EventHandler(this.редагуванняПослугToolStripMenuItem_Click);
            // 
            // історіяПослугToolStripMenuItem
            // 
            this.історіяПослугToolStripMenuItem.Name = "історіяПослугToolStripMenuItem";
            this.історіяПослугToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.історіяПослугToolStripMenuItem.Text = "Історія послуг";
            // 
            // клієнтиToolStripMenuItem
            // 
            this.клієнтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКлієнтівToolStripMenuItem});
            this.клієнтиToolStripMenuItem.Name = "клієнтиToolStripMenuItem";
            this.клієнтиToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.клієнтиToolStripMenuItem.Text = "Клієнти";
            this.клієнтиToolStripMenuItem.Click += new System.EventHandler(this.клієнтиToolStripMenuItem_Click);
            // 
            // списокКлієнтівToolStripMenuItem
            // 
            this.списокКлієнтівToolStripMenuItem.Name = "списокКлієнтівToolStripMenuItem";
            this.списокКлієнтівToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.списокКлієнтівToolStripMenuItem.Text = "Список клієнтів";
            this.списокКлієнтівToolStripMenuItem.Click += new System.EventHandler(this.списокКлієнтівToolStripMenuItem_Click);
            // 
            // замовленняToolStripMenuItem
            // 
            this.замовленняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЗамовленьToolStripMenuItem,
            this.завершеніЗамовленняToolStripMenuItem});
            this.замовленняToolStripMenuItem.Name = "замовленняToolStripMenuItem";
            this.замовленняToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.замовленняToolStripMenuItem.Text = "Замовлення";
            // 
            // списокЗамовленьToolStripMenuItem
            // 
            this.списокЗамовленьToolStripMenuItem.Name = "списокЗамовленьToolStripMenuItem";
            this.списокЗамовленьToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.списокЗамовленьToolStripMenuItem.Text = "Список замовлень";
            this.списокЗамовленьToolStripMenuItem.Click += new System.EventHandler(this.списокЗамовленьToolStripMenuItem_Click);
            // 
            // завершеніЗамовленняToolStripMenuItem
            // 
            this.завершеніЗамовленняToolStripMenuItem.Name = "завершеніЗамовленняToolStripMenuItem";
            this.завершеніЗамовленняToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.завершеніЗамовленняToolStripMenuItem.Text = "Завершені замовлення";
            // 
            // фінансиToolStripMenuItem
            // 
            this.фінансиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокФінансовихЗвітівToolStripMenuItem,
            this.оплатаЗаПослугиToolStripMenuItem});
            this.фінансиToolStripMenuItem.Name = "фінансиToolStripMenuItem";
            this.фінансиToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.фінансиToolStripMenuItem.Text = "Фінанси";
            // 
            // списокФінансовихЗвітівToolStripMenuItem
            // 
            this.списокФінансовихЗвітівToolStripMenuItem.Name = "списокФінансовихЗвітівToolStripMenuItem";
            this.списокФінансовихЗвітівToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.списокФінансовихЗвітівToolStripMenuItem.Text = "Список фінансових звітів";
            this.списокФінансовихЗвітівToolStripMenuItem.Click += new System.EventHandler(this.списокФінансовихЗвітівToolStripMenuItem_Click);
            // 
            // оплатаЗаПослугиToolStripMenuItem
            // 
            this.оплатаЗаПослугиToolStripMenuItem.Name = "оплатаЗаПослугиToolStripMenuItem";
            this.оплатаЗаПослугиToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.оплатаЗаПослугиToolStripMenuItem.Text = "Оплата за послуги";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(805, 329);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(499, 505);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(510, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 246);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "АРМ директора комп\'ютерного сервісного центру";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}