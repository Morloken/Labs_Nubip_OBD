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
            this.клієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКлієнтівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗамовленьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.історіяЗамовленьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фінансиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокФінансовихЗвітівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.звітиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формуванняЗвітівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
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
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.фінансиToolStripMenuItem,
            this.звітиToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1067, 28);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // послугиToolStripMenuItem
            // 
            this.послугиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокДоступнихПослугToolStripMenuItem});
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
            this.списокКлієнтівToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.списокКлієнтівToolStripMenuItem.Text = "Список клієнтів";
            this.списокКлієнтівToolStripMenuItem.Click += new System.EventHandler(this.списокКлієнтівToolStripMenuItem_Click);
            // 
            // замовленняToolStripMenuItem
            // 
            this.замовленняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЗамовленьToolStripMenuItem,
            this.історіяЗамовленьToolStripMenuItem});
            this.замовленняToolStripMenuItem.Name = "замовленняToolStripMenuItem";
            this.замовленняToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.замовленняToolStripMenuItem.Text = "Замовлення";
            // 
            // списокЗамовленьToolStripMenuItem
            // 
            this.списокЗамовленьToolStripMenuItem.Name = "списокЗамовленьToolStripMenuItem";
            this.списокЗамовленьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.списокЗамовленьToolStripMenuItem.Text = "Список замовлень";
            this.списокЗамовленьToolStripMenuItem.Click += new System.EventHandler(this.списокЗамовленьToolStripMenuItem_Click);
            // 
            // історіяЗамовленьToolStripMenuItem
            // 
            this.історіяЗамовленьToolStripMenuItem.Name = "історіяЗамовленьToolStripMenuItem";
            this.історіяЗамовленьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.історіяЗамовленьToolStripMenuItem.Text = "Історія замовлень";
            this.історіяЗамовленьToolStripMenuItem.Click += new System.EventHandler(this.історіяЗамовленьToolStripMenuItem_Click);
            // 
            // фінансиToolStripMenuItem
            // 
            this.фінансиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокФінансовихЗвітівToolStripMenuItem});
            this.фінансиToolStripMenuItem.Name = "фінансиToolStripMenuItem";
            this.фінансиToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.фінансиToolStripMenuItem.Text = "Фінанси";
            this.фінансиToolStripMenuItem.Click += new System.EventHandler(this.фінансиToolStripMenuItem_Click);
            // 
            // списокФінансовихЗвітівToolStripMenuItem
            // 
            this.списокФінансовихЗвітівToolStripMenuItem.Name = "списокФінансовихЗвітівToolStripMenuItem";
            this.списокФінансовихЗвітівToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.списокФінансовихЗвітівToolStripMenuItem.Text = "Список фінансових звітів";
            this.списокФінансовихЗвітівToolStripMenuItem.Click += new System.EventHandler(this.списокФінансовихЗвітівToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(805, 329);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(717, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(41, 554);
            this.progressBar1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(777, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 246);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // звітиToolStripMenuItem
            // 
            this.звітиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формуванняЗвітівToolStripMenuItem});
            this.звітиToolStripMenuItem.Name = "звітиToolStripMenuItem";
            this.звітиToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.звітиToolStripMenuItem.Text = "Звіти";
            // 
            // формуванняЗвітівToolStripMenuItem
            // 
            this.формуванняЗвітівToolStripMenuItem.Name = "формуванняЗвітівToolStripMenuItem";
            this.формуванняЗвітівToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.формуванняЗвітівToolStripMenuItem.Text = "Формування звітів";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "АРМ директора комп\'ютерного сервісного центру";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem послугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокДоступнихПослугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКлієнтівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗамовленьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фінансиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокФінансовихЗвітівToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem історіяЗамовленьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звітиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формуванняЗвітівToolStripMenuItem;
    }
}