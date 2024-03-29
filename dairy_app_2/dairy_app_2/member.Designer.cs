namespace dairy_app_2
{
    partial class member
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            home_btn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(142, 105);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Id";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(326, 105);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Bank Account no";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(142, 161);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Name";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(142, 217);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Phone Number";
            textBox4.Size = new Size(100, 25);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(326, 161);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Bank Name";
            textBox5.Size = new Size(100, 25);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(327, 217);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Branch";
            textBox6.Size = new Size(100, 25);
            textBox6.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(332, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // home_btn
            // 
            home_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            home_btn.Cursor = Cursors.Hand;
            home_btn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            home_btn.Image = Properties.Resources.dairy;
            home_btn.Location = new Point(73, 28);
            home_btn.Margin = new Padding(0);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(60, 60);
            home_btn.TabIndex = 7;
            home_btn.TabStop = false;
            home_btn.UseVisualStyleBackColor = true;
            home_btn.Click += home_btn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(home_btn);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button home_btn;
    }
}