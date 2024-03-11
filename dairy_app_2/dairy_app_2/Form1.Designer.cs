using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace dairy_app_2
{
    partial class Form1
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
            label1 = new Label();
            farmer_id_daily = new TextBox();
            milk_litre_daily = new TextBox();
            fat_daily = new TextBox();
            snf_daily = new TextBox();
            total_daily = new TextBox();
            Rate_daily = new TextBox();
            button_save_daily = new Button();
            Rate_Lbl = new Label();
            Total_Lbl = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 44);
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
            farmer_id_daily.Location = new Point(50, 82);
            farmer_id_daily.Name = "farmer_id_daily";
            farmer_id_daily.PlaceholderText = "Farmer's ID";
            farmer_id_daily.Size = new Size(100, 25);
            farmer_id_daily.TabIndex = 1;
            farmer_id_daily.TextChanged += farmer_id_daily_TextChanged;
            // 
            // milk_litre_daily
            // 
            milk_litre_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            milk_litre_daily.Location = new Point(50, 129);
            milk_litre_daily.Name = "milk_litre_daily";
            milk_litre_daily.PlaceholderText = "Milk lt";
            milk_litre_daily.Size = new Size(100, 25);
            milk_litre_daily.TabIndex = 2;
            milk_litre_daily.TextChanged += textBox2_TextChanged;
            // 
            // fat_daily
            // 
            fat_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fat_daily.Location = new Point(51, 173);
            fat_daily.Name = "fat_daily";
            fat_daily.PlaceholderText = "Fat";
            fat_daily.Size = new Size(100, 25);
            fat_daily.TabIndex = 3;
            // 
            // snf_daily
            // 
            snf_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            snf_daily.Location = new Point(52, 217);
            snf_daily.Name = "snf_daily";
            snf_daily.PlaceholderText = "SNF";
            snf_daily.Size = new Size(100, 25);
            snf_daily.TabIndex = 4;
            snf_daily.TextChanged += snf_daily_TextChanged;
            // 
            // total_daily
            // 
            total_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            total_daily.Location = new Point(270, 180);
            total_daily.Name = "total_daily";
            total_daily.PlaceholderText = "Total";
            total_daily.Size = new Size(100, 25);
            total_daily.TabIndex = 7;
            // 
            // Rate_daily
            // 
            Rate_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Rate_daily.Location = new Point(269, 132);
            Rate_daily.Name = "Rate_daily";
            Rate_daily.PlaceholderText = "Rate";
            Rate_daily.Size = new Size(100, 25);
            Rate_daily.TabIndex = 6;
            Rate_daily.TextChanged += Rate_daily_TextChanged;
            // 
            // button_save_daily
            // 
            button_save_daily.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_save_daily.Location = new Point(278, 221);
            button_save_daily.Name = "button_save_daily";
            button_save_daily.Size = new Size(75, 23);
            button_save_daily.TabIndex = 5;
            button_save_daily.Text = "Save";
            button_save_daily.UseVisualStyleBackColor = true;
            button_save_daily.Click += button1_Click;
            // 
            // Rate_Lbl
            // 
            Rate_Lbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Rate_Lbl.Location = new Point(0, 0);
            Rate_Lbl.Name = "Rate_Lbl";
            Rate_Lbl.Size = new Size(100, 23);
            Rate_Lbl.TabIndex = 12;
            // 
            // Total_Lbl
            // 
            Total_Lbl.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Total_Lbl.Location = new Point(0, 0);
            Total_Lbl.Name = "Total_Lbl";
            Total_Lbl.Size = new Size(100, 23);
            Total_Lbl.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(306, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(Total_Lbl);
            Controls.Add(Rate_Lbl);
            Controls.Add(button_save_daily);
            Controls.Add(Rate_daily);
            Controls.Add(total_daily);
            Controls.Add(snf_daily);
            Controls.Add(fat_daily);
            Controls.Add(milk_litre_daily);
            Controls.Add(farmer_id_daily);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dairy App";
            Load += Form1_Load;
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
        private Label Rate_Lbl;
        private Label Total_Lbl;
        private DateTimePicker dateTimePicker1;
    }
}