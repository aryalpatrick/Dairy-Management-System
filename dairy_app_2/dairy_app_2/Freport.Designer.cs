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
            milk_lt_chk = new CheckBox();
            rate_chk = new CheckBox();
            total_chk = new CheckBox();
            snf_chk = new CheckBox();
            fat_chk = new CheckBox();
            all_chk = new CheckBox();
            farmer_id_daily = new TextBox();
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
            // 
            // F_name
            // 
            F_name.Location = new Point(439, 176);
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
            label3.Size = new Size(142, 32);
            label3.TabIndex = 4;
            label3.Text = "Farmer's id: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(28, 230);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 6;
            label4.Text = "Filters:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 286);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
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
            label6.Location = new Point(422, 280);
            label6.Name = "label6";
            label6.Size = new Size(74, 32);
            label6.TabIndex = 10;
            label6.Text = "From:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(507, 286);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // milk_lt_chk
            // 
            milk_lt_chk.AutoSize = true;
            milk_lt_chk.Location = new Point(60, 343);
            milk_lt_chk.Name = "milk_lt_chk";
            milk_lt_chk.Size = new Size(83, 19);
            milk_lt_chk.TabIndex = 11;
            milk_lt_chk.Text = "checkBox1";
            milk_lt_chk.UseVisualStyleBackColor = true;
            // 
            // rate_chk
            // 
            rate_chk.AutoSize = true;
            rate_chk.Location = new Point(178, 343);
            rate_chk.Name = "rate_chk";
            rate_chk.Size = new Size(83, 19);
            rate_chk.TabIndex = 12;
            rate_chk.Text = "checkBox2";
            rate_chk.UseVisualStyleBackColor = true;
            // 
            // total_chk
            // 
            total_chk.AutoSize = true;
            total_chk.Location = new Point(321, 343);
            total_chk.Name = "total_chk";
            total_chk.Size = new Size(83, 19);
            total_chk.TabIndex = 13;
            total_chk.Text = "checkBox3";
            total_chk.UseVisualStyleBackColor = true;
            // 
            // snf_chk
            // 
            snf_chk.AutoSize = true;
            snf_chk.Location = new Point(471, 343);
            snf_chk.Name = "snf_chk";
            snf_chk.Size = new Size(83, 19);
            snf_chk.TabIndex = 14;
            snf_chk.Text = "checkBox4";
            snf_chk.UseVisualStyleBackColor = true;
            // 
            // fat_chk
            // 
            fat_chk.AutoSize = true;
            fat_chk.Location = new Point(592, 343);
            fat_chk.Name = "fat_chk";
            fat_chk.Size = new Size(83, 19);
            fat_chk.TabIndex = 15;
            fat_chk.Text = "checkBox5";
            fat_chk.UseVisualStyleBackColor = true;
            // 
            // all_chk
            // 
            all_chk.AutoSize = true;
            all_chk.Location = new Point(117, 417);
            all_chk.Name = "all_chk";
            all_chk.Size = new Size(83, 19);
            all_chk.TabIndex = 16;
            all_chk.Text = "checkBox6";
            all_chk.UseVisualStyleBackColor = true;
            // 
            // farmer_id_daily
            // 
            farmer_id_daily.Location = new Point(163, 176);
            farmer_id_daily.Name = "farmer_id_daily";
            farmer_id_daily.Size = new Size(60, 23);
            farmer_id_daily.TabIndex = 17;
            farmer_id_daily.TextChanged += farmer_id_daily_TextChanged;
            // 
            // Freport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(farmer_id_daily);
            Controls.Add(all_chk);
            Controls.Add(fat_chk);
            Controls.Add(snf_chk);
            Controls.Add(total_chk);
            Controls.Add(rate_chk);
            Controls.Add(milk_lt_chk);
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
        private CheckBox milk_lt_chk;
        private CheckBox rate_chk;
        private CheckBox total_chk;
        private CheckBox snf_chk;
        private CheckBox fat_chk;
        private CheckBox all_chk;
        private TextBox F_name;
        private TextBox farmer_id_daily;
    }
}
