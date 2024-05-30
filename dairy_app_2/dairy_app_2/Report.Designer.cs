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
            btn_home = new Button();
            pnl_top = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnl_freport = new Panel();
            btn_freport = new Button();
            pnl_monthly = new Panel();
            btn_monthly = new Button();
            pnl_whole = new Panel();
            pnl_main = new Panel();
            pnl_top.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnl_freport.SuspendLayout();
            pnl_monthly.SuspendLayout();
            pnl_whole.SuspendLayout();
            SuspendLayout();
            // 
            // btn_home
            // 
            btn_home.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_home.Cursor = Cursors.Hand;
            btn_home.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_home.Image = Properties.Resources.dairy;
            btn_home.Location = new Point(18, 31);
            btn_home.Margin = new Padding(0);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(60, 60);
            btn_home.TabIndex = 8;
            btn_home.TabStop = false;
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += button1_Click;
            // 
            // pnl_top
            // 
            pnl_top.AccessibleDescription = "";
            pnl_top.Controls.Add(tableLayoutPanel1);
            pnl_top.Location = new Point(0, 0);
            pnl_top.Name = "pnl_top";
            pnl_top.Padding = new Padding(0, 10, 0, 0);
            pnl_top.Size = new Size(816, 100);
            pnl_top.TabIndex = 9;
            pnl_top.Paint += pnl_top_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.34631F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.2101173F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.2101173F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.2334576F));
            tableLayoutPanel1.Controls.Add(pnl_freport, 2, 0);
            tableLayoutPanel1.Controls.Add(pnl_monthly, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.ForeColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(816, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnl_freport
            // 
            pnl_freport.BackColor = Color.Silver;
            pnl_freport.Controls.Add(btn_freport);
            pnl_freport.Dock = DockStyle.Bottom;
            pnl_freport.Location = new Point(425, 5);
            pnl_freport.Margin = new Padding(5);
            pnl_freport.Name = "pnl_freport";
            pnl_freport.Padding = new Padding(0, 0, 0, 11);
            pnl_freport.Size = new Size(220, 90);
            pnl_freport.TabIndex = 2;
            // 
            // btn_freport
            // 
            btn_freport.BackColor = Color.Silver;
            btn_freport.Dock = DockStyle.Fill;
            btn_freport.FlatAppearance.BorderSize = 0;
            btn_freport.FlatStyle = FlatStyle.Flat;
            btn_freport.Location = new Point(0, 0);
            btn_freport.Name = "btn_freport";
            btn_freport.Size = new Size(220, 79);
            btn_freport.TabIndex = 1;
            btn_freport.Text = "F report";
            btn_freport.UseVisualStyleBackColor = false;
            btn_freport.Click += btn_freport_Click;
            // 
            // pnl_monthly
            // 
            pnl_monthly.AccessibleDescription = "monthly btn ko panel";
            pnl_monthly.BackColor = SystemColors.ControlText;
            pnl_monthly.Controls.Add(btn_monthly);
            pnl_monthly.Dock = DockStyle.Fill;
            pnl_monthly.Location = new Point(195, 5);
            pnl_monthly.Margin = new Padding(5);
            pnl_monthly.Name = "pnl_monthly";
            pnl_monthly.Padding = new Padding(0, 0, 0, 11);
            pnl_monthly.Size = new Size(220, 90);
            pnl_monthly.TabIndex = 0;
            // 
            // btn_monthly
            // 
            btn_monthly.BackColor = Color.Silver;
            btn_monthly.Dock = DockStyle.Fill;
            btn_monthly.FlatAppearance.BorderSize = 0;
            btn_monthly.FlatStyle = FlatStyle.Flat;
            btn_monthly.Location = new Point(0, 0);
            btn_monthly.Name = "btn_monthly";
            btn_monthly.Size = new Size(220, 79);
            btn_monthly.TabIndex = 1;
            btn_monthly.Text = "Monthly";
            btn_monthly.UseVisualStyleBackColor = false;
            btn_monthly.Click += btn_monthly_Click;
            // 
            // pnl_whole
            // 
            pnl_whole.Controls.Add(pnl_main);
            pnl_whole.Dock = DockStyle.Fill;
            pnl_whole.Location = new Point(3, 3);
            pnl_whole.Name = "pnl_whole";
            pnl_whole.Size = new Size(794, 444);
            pnl_whole.TabIndex = 10;
            // 
            // pnl_main
            // 
            pnl_main.BackColor = SystemColors.Control;
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.Location = new Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(794, 444);
            pnl_main.TabIndex = 1;
            pnl_main.Paint += pnl_main_Paint;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_home);
            Controls.Add(pnl_top);
            Controls.Add(pnl_whole);
            Name = "Report";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Report_Load;
            pnl_top.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnl_freport.ResumeLayout(false);
            pnl_monthly.ResumeLayout(false);
            pnl_whole.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_home;
        private Button home;
        private Panel pnl_top;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnl_monthly;
        private Button btn_monthly;
        private Panel pnl_freport;
        private Button btn_freport;
        private Panel pnl_whole;
        private Panel pnl_main;
    }
}