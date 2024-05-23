using System.Drawing.Printing;

namespace dairy_app_2
{
    partial class report_farmer
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

            gen_freport_btn = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gen_freport_btn
            // 
            gen_freport_btn.Location = new Point(47, 25);
            gen_freport_btn.Name = "gen_freport_btn";
            gen_freport_btn.Size = new Size(75, 23);
            gen_freport_btn.TabIndex = 1;
            gen_freport_btn.Text = "Generate";
            gen_freport_btn.UseVisualStyleBackColor = true;
            gen_freport_btn.Click += gen_freport_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.Location = new Point(30, 80);
            dataGridView1.Margin = new Padding(0, 0, 0, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(30, 380);
            panel1.Margin = new Padding(0, 38, 0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 40);
            panel1.TabIndex = 2;
            // 
            // report_farmer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(gen_freport_btn);
            Controls.Add(dataGridView1);
            Name = "report_farmer";
            Padding = new Padding(30, 80, 30, 30);
            RightToLeftLayout = true;
            Text = "report_farmer";
            Load += report_farmer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button gen_freport_btn;
        private Panel panel1;
    }
}