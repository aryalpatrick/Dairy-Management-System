﻿namespace dairy_app_2
{
    partial class Login
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
            title = new Label();
            Welcome_txt = new Label();
            username = new TextBox();
            pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(27, 27);
            title.Name = "title";
            title.Size = new Size(230, 37);
            title.TabIndex = 2;
            title.Text = "DUDH MANAGEMENT";
            title.UseWaitCursor = true;
            // 
            // Welcome_txt
            // 
            Welcome_txt.AutoSize = true;
            Welcome_txt.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Welcome_txt.Location = new Point(472, 60);
            Welcome_txt.Name = "Welcome_txt";
            Welcome_txt.Size = new Size(132, 42);
            Welcome_txt.TabIndex = 3;
            Welcome_txt.Text = "Welcome";
            Welcome_txt.UseWaitCursor = true;
            // 
            // username
            // 
            username.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(510, 182);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(100, 25);
            username.TabIndex = 0;
            username.TextChanged += farmer_id_daily_TextChanged;
            // 
            // pass
            // 
            pass.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(510, 222);
            pass.Name = "pass";
            pass.PlaceholderText = "Password";
            pass.Size = new Size(100, 25);
            pass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(425, 183);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 6;
            label1.Text = "User ID :";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(425, 223);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 7;
            label2.Text = "Password :";
            label2.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(517, 264);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(70, 25);
            button1.TabIndex = 2;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cow1;
            pictureBox1.Location = new Point(59, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.profile;
            pictureBox2.Location = new Point(505, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Form4
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pass);
            Controls.Add(username);
            Controls.Add(Welcome_txt);
            Controls.Add(title);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Dudh Stats";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label Welcome_txt;
        private TextBox username;
        private TextBox pass;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}