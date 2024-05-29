namespace dairy_app_2
{
    partial class Report
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            button3 = new Button();
            panel4 = new Panel();
            button5 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.dairy;
            button1.Location = new Point(48, 33);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 8;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(425, 368);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 100);
            panel1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlLight;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.34631F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.2101173F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.2101173F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.2334576F));
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.ForeColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(816, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(195, 5);
            panel2.Margin = new Padding(5, 5, 5, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 6);
            panel2.Size = new Size(220, 95);
            panel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(220, 89);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(button5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(425, 5);
            panel4.Margin = new Padding(5, 5, 5, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 6);
            panel4.Size = new Size(220, 95);
            panel4.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(220, 89);
            button5.TabIndex = 1;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Report";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Report_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button home_btn;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel4;
        private Button button5;
        private Button button3;
    }
}