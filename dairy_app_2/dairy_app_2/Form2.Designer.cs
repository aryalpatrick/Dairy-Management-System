namespace dairy_app_2
{
    partial class Form2
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
            Entry_daily = new Button();
            add_farmer = new Button();
            SuspendLayout();
            // 
            // Entry_daily
            // 
            Entry_daily.Location = new Point(346, 73);
            Entry_daily.Name = "Entry_daily";
            Entry_daily.Size = new Size(75, 23);
            Entry_daily.TabIndex = 0;
            Entry_daily.Text = "Entry_daily";
            Entry_daily.UseVisualStyleBackColor = true;
            Entry_daily.Click += Entry_daily_Click;
            // 
            // add_farmer
            // 
            add_farmer.Location = new Point(215, 74);
            add_farmer.Name = "add_farmer";
            add_farmer.Size = new Size(75, 23);
            add_farmer.TabIndex = 1;
            add_farmer.Text = "Add_farmer";
            add_farmer.TextAlign = ContentAlignment.MiddleLeft;
            add_farmer.UseVisualStyleBackColor = true;
            add_farmer.Click += add_farmer_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add_farmer);
            Controls.Add(Entry_daily);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button Entry_daily;
        private Button add_farmer;
    }
}