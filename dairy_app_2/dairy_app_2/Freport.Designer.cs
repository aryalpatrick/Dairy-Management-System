namespace dairy_app_2
{
    partial class Freport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            F_name = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            chk_1 = new CheckBox();
            chk_2 = new CheckBox();
            chk_3 = new CheckBox();
            chk_4 = new CheckBox();
            chk_5 = new CheckBox();
            chk_6 = new CheckBox();
            farmer_id_daily = new TextBox();
            btn_gen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 100);
            label1.Name = "label1";
            label1.Size = new Size(279, 32);
            label1.TabIndex = 1;
            label1.Text = "Generate Farmer's report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 171);
            label2.Name = "label2";
            label2.Size = new Size(142, 32);
            label2.TabIndex = 2;
            label2.Text = "Farmer's id: ";
            label2.Click += label2_Click;
            // 
            // F_name
            // 
            F_name.Location = new Point(472, 176);
            F_name.Name = "F_name";
            F_name.Size = new Size(150, 23);
            F_name.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(297, 171);
            label3.Name = "label3";
            label3.Size = new Size(175, 32);
            label3.TabIndex = 4;
            label3.Text = "Farmer's name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(28, 230);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 6;
            label4.Text = "Filters:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 286);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(21, 280);
            label5.Name = "label5";
            label5.Size = new Size(74, 32);
            label5.TabIndex = 8;
            label5.Text = "From:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(442, 280);
            label6.Name = "label6";
            label6.Size = new Size(44, 32);
            label6.TabIndex = 10;
            label6.Text = "To:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(507, 286);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // chk_1
            // 
            chk_1.AutoSize = true;
            chk_1.Checked = true;
            chk_1.CheckState = CheckState.Checked;
            chk_1.Enabled = false;
            chk_1.Location = new Point(60, 343);
            chk_1.Name = "chk_1";
            chk_1.Size = new Size(72, 19);
            chk_1.TabIndex = 11;
            chk_1.Text = "Milk litre";
            chk_1.UseVisualStyleBackColor = true;
            chk_1.CheckedChanged += chk_1_CheckedChanged;
            // 
            // chk_2
            // 
            chk_2.AutoSize = true;
            chk_2.Checked = true;
            chk_2.CheckState = CheckState.Checked;
            chk_2.Location = new Point(178, 343);
            chk_2.Name = "chk_2";
            chk_2.Size = new Size(49, 19);
            chk_2.TabIndex = 12;
            chk_2.Text = "Rate";
            chk_2.UseVisualStyleBackColor = true;
            chk_2.CheckedChanged += chk_2_CheckedChanged;
            // 
            // chk_3
            // 
            chk_3.AutoSize = true;
            chk_3.Checked = true;
            chk_3.CheckState = CheckState.Checked;
            chk_3.Location = new Point(321, 343);
            chk_3.Name = "chk_3";
            chk_3.Size = new Size(51, 19);
            chk_3.TabIndex = 13;
            chk_3.Text = "Total";
            chk_3.UseVisualStyleBackColor = true;
            chk_3.CheckedChanged += chk_3_CheckedChanged;
            // 
            // chk_4
            // 
            chk_4.AutoSize = true;
            chk_4.Checked = true;
            chk_4.CheckState = CheckState.Checked;
            chk_4.Location = new Point(471, 343);
            chk_4.Name = "chk_4";
            chk_4.Size = new Size(43, 19);
            chk_4.TabIndex = 14;
            chk_4.Text = "Snf";
            chk_4.UseVisualStyleBackColor = true;
            chk_4.CheckedChanged += chk_4_CheckedChanged;
            // 
            // chk_5
            // 
            chk_5.AutoSize = true;
            chk_5.Checked = true;
            chk_5.CheckState = CheckState.Checked;
            chk_5.Location = new Point(592, 343);
            chk_5.Name = "chk_5";
            chk_5.Size = new Size(42, 19);
            chk_5.TabIndex = 15;
            chk_5.Text = "Fat";
            chk_5.UseVisualStyleBackColor = true;
            chk_5.CheckedChanged += chk_5_CheckedChanged;
            // 
            // chk_6
            // 
            chk_6.AutoSize = true;
            chk_6.Checked = true;
            chk_6.CheckState = CheckState.Checked;
            chk_6.Location = new Point(118, 397);
            chk_6.Name = "chk_6";
            chk_6.Size = new Size(76, 19);
            chk_6.TabIndex = 16;
            chk_6.Text = "Check All";
            chk_6.UseVisualStyleBackColor = true;
            chk_6.CheckedChanged += chk_6_CheckedChanged;
            // 
            // farmer_id_daily
            // 
            farmer_id_daily.Location = new Point(163, 176);
            farmer_id_daily.Name = "farmer_id_daily";
            farmer_id_daily.Size = new Size(60, 23);
            farmer_id_daily.TabIndex = 17;
            farmer_id_daily.TextChanged += farmer_id_daily_TextChanged;
            // 
            // btn_gen
            // 
            btn_gen.Location = new Point(316, 397);
            btn_gen.Name = "btn_gen";
            btn_gen.Size = new Size(75, 23);
            btn_gen.TabIndex = 18;
            btn_gen.Text = "Generate";
            btn_gen.UseVisualStyleBackColor = true;
            btn_gen.Click += btn_gen_Click;
            // 
            // Freport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btn_gen);
            Controls.Add(farmer_id_daily);
            Controls.Add(chk_6);
            Controls.Add(chk_5);
            Controls.Add(chk_4);
            Controls.Add(chk_3);
            Controls.Add(chk_2);
            Controls.Add(chk_1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(F_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Freport";
            Size = new Size(900, 500);
            Load += Freport_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private TextBox btn_fid;
        private TextBox btn_fname;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        public CheckBox chk_1;
        private CheckBox chk_2;
        private CheckBox chk_3;
        private CheckBox chk_4;
        private CheckBox chk_5;
        private CheckBox chk_6;
        private TextBox F_name;
        private TextBox farmer_id_daily;
        private Button btn_gen;
    }
}
