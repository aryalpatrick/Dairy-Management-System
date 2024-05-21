namespace dairy_app_2
{
    partial class home
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
            Entry_daily = new Button();
            add_farmer = new Button();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            home_btn = new Button();
            SuspendLayout();
            // 
            // Entry_daily
            // 
            Entry_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Entry_daily.Image = Properties.Resources.milk;
            Entry_daily.ImageAlign = ContentAlignment.TopCenter;
            Entry_daily.Location = new Point(175, 120);
            Entry_daily.Name = "Entry_daily";
            Entry_daily.Padding = new Padding(0, 1, 0, 0);
            Entry_daily.Size = new Size(80, 80);
            Entry_daily.TabIndex = 2;
            Entry_daily.Text = "Daily Entry";
            Entry_daily.TextAlign = ContentAlignment.BottomCenter;
            Entry_daily.UseVisualStyleBackColor = true;
            Entry_daily.Click += Entry_daily_Click;
            // 
            // add_farmer
            // 
            add_farmer.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add_farmer.Image = Properties.Resources.farmer_1;
            add_farmer.ImageAlign = ContentAlignment.TopCenter;
            add_farmer.Location = new Point(295, 120);
            add_farmer.Name = "add_farmer";
            add_farmer.Padding = new Padding(0, 2, 0, 0);
            add_farmer.RightToLeft = RightToLeft.Yes;
            add_farmer.Size = new Size(80, 80);
            add_farmer.TabIndex = 3;
            add_farmer.Text = "Members";
            add_farmer.TextAlign = ContentAlignment.BottomCenter;
            add_farmer.UseVisualStyleBackColor = true;
            add_farmer.Click += add_farmer_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.report11;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(415, 120);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 10, 0, 0);
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(80, 80);
            button1.TabIndex = 4;
            button1.Text = "Report";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.money_11;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(535, 120);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 8, 0, 0);
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(80, 80);
            button2.TabIndex = 5;
            button2.Text = "Loan";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(484, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 25);
            dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(105, 34);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 0;
            label1.Text = "Dudh Stats";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(105, 70);
            label2.Name = "label2";
            label2.Size = new Size(76, 22);
            label2.TabIndex = 1;
            label2.Text = "Pharsatikar";
            label2.UseWaitCursor = true;
            // 
            // home_btn
            // 
            home_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            home_btn.Cursor = Cursors.Hand;
            home_btn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            home_btn.Image = Properties.Resources.dairy;
            home_btn.Location = new Point(18, 31);
            home_btn.Margin = new Padding(0);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(60, 60);
            home_btn.TabIndex = 12;
            home_btn.TabStop = false;
            home_btn.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(home_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(add_farmer);
            Controls.Add(Entry_daily);
            Name = "home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home - Dudh Stats";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Entry_daily;
        private Button add_farmer;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Button home_btn;
    }
}