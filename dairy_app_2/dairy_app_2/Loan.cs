﻿namespace dairy_app_2
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home f2 = new();   //Form1 f1 = new Form1();
            f2.Show();
            Visible = false;
        }
    }
}
