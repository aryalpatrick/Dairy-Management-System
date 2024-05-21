using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace dairy_app_2
{
    partial class Entry
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            farmer_id_daily = new TextBox();
            milk_litre_daily = new TextBox();
            fat_daily = new TextBox();
            snf_daily = new TextBox();
            total_daily = new TextBox();
            Rate_daily = new TextBox();
            button_save_daily = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            home_btn = new Button();
            F_name = new TextBox();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 106);
            label1.Name = "label1";
            label1.Size = new Size(99, 22);
            label1.TabIndex = 0;
            label1.Text = "Daily recording";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // farmer_id_daily
            // 
            farmer_id_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            farmer_id_daily.Location = new Point(66, 163);
            farmer_id_daily.Name = "farmer_id_daily";
            farmer_id_daily.PlaceholderText = "Farmer’s ID";
            farmer_id_daily.Size = new Size(100, 25);
            farmer_id_daily.TabIndex = 0;
            farmer_id_daily.TextChanged += farmer_id_daily_TextChanged;
            farmer_id_daily.KeyDown += Entry_KeyDown;
            // 
            // milk_litre_daily
            // 
            milk_litre_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            milk_litre_daily.Location = new Point(66, 220);
            milk_litre_daily.Name = "milk_litre_daily";
            milk_litre_daily.PlaceholderText = "Milk in liters";
            milk_litre_daily.Size = new Size(100, 25);
            milk_litre_daily.TabIndex = 1;
            milk_litre_daily.TextChanged += textBox2_TextChanged;
            milk_litre_daily.KeyDown += Entry_KeyDown;
            // 
            // fat_daily
            // 
            fat_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fat_daily.Location = new Point(66, 277);
            fat_daily.Name = "fat_daily";
            fat_daily.PlaceholderText = "Fat";
            fat_daily.Size = new Size(100, 25);
            fat_daily.TabIndex = 2;
            fat_daily.TextChanged += fat_daily_TextChanged;
            fat_daily.KeyDown += fat_daily_KeyDown;
            // 
            // snf_daily
            // 
            snf_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            snf_daily.Location = new Point(66, 334);
            snf_daily.Name = "snf_daily";
            snf_daily.PlaceholderText = "SNF";
            snf_daily.Size = new Size(100, 25);
            snf_daily.TabIndex = 3;
            snf_daily.TextChanged += snf_daily_TextChanged;
            snf_daily.KeyDown += snf_daily_KeyDown;
            // 
            // total_daily
            // 
            total_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            total_daily.Location = new Point(286, 277);
            total_daily.Name = "total_daily";
            total_daily.PlaceholderText = "Total";
            total_daily.Size = new Size(100, 25);
            total_daily.TabIndex = 7;
            total_daily.TabStop = false;
            // 
            // Rate_daily
            // 
            Rate_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Rate_daily.Location = new Point(285, 242);
            Rate_daily.Name = "Rate_daily";
            Rate_daily.PlaceholderText = "Rate";
            Rate_daily.Size = new Size(100, 25);
            Rate_daily.TabIndex = 6;
            Rate_daily.TabStop = false;
            Rate_daily.TextChanged += Rate_daily_TextChanged;
            // 
            // button_save_daily
            // 
            button_save_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_save_daily.Location = new Point(294, 312);
            button_save_daily.Name = "button_save_daily";
            button_save_daily.Size = new Size(75, 23);
            button_save_daily.TabIndex = 4;
            button_save_daily.Text = "Save";
            button_save_daily.UseVisualStyleBackColor = true;
            button_save_daily.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AllowDrop = true;
            dateTimePicker1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(322, 111);
            dateTimePicker1.Margin = new Padding(0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 25);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 141);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 13;
            label2.Text = "Farmer id : ";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 198);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 14;
            label3.Text = "Milk Quantity :";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 255);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 15;
            label4.Text = "Fat Rate :";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 312);
            label5.Name = "label5";
            label5.Size = new Size(49, 22);
            label5.TabIndex = 16;
            label5.Text = "SNF % :";
            label5.UseWaitCursor = true;
            label5.Click += label5_Click;
            // 
            // home_btn
            // 
            home_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            home_btn.Cursor = Cursors.Hand;
            home_btn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            home_btn.Image = Properties.Resources.dairy;
            home_btn.Location = new Point(49, 24);
            home_btn.Margin = new Padding(0);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(60, 60);
            home_btn.TabIndex = 0;
            home_btn.TabStop = false;
            home_btn.UseVisualStyleBackColor = true;
            home_btn.Click += home_btn_Click;
            // 
            // F_name
            // 
            F_name.Location = new Point(359, 166);
            F_name.Name = "F_name";
            F_name.Size = new Size(150, 23);
            F_name.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(285, 167);
            label6.Name = "label6";
            label6.Size = new Size(51, 22);
            label6.TabIndex = 18;
            label6.Text = "Name :";
            label6.UseWaitCursor = true;
            // 
            // Entry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(F_name);
            Controls.Add(home_btn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button_save_daily);
            Controls.Add(Rate_daily);
            Controls.Add(total_daily);
            Controls.Add(snf_daily);
            Controls.Add(fat_daily);
            Controls.Add(milk_litre_daily);
            Controls.Add(farmer_id_daily);
            Controls.Add(label1);
            Name = "Entry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daily Entry - Dudh Stats";
            Load += Form1_Load;
            KeyDown += Entry_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox farmer_id_daily;
        private TextBox milk_litre_daily;
        private TextBox fat_daily;
        private TextBox snf_daily;
        private TextBox total_daily;
        private TextBox Rate_daily;
        private Button button_save_daily;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button home_btn;
        private TextBox F_name;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Timer timer1;
        private Label datetime;
        private System.Windows.Forms.Timer timer2;
    }
}