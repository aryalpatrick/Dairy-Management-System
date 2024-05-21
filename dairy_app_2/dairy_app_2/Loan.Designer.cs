namespace dairy_app_2
{
    partial class Loan
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 147);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 0;
            label1.Text = "Coming Soon";
            label1.Click += label1_Click;
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
            // Loan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Loan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coming Soon - Dudh Stats";
            Load += Loan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button home_btn;
        private Button button1;
    }
}