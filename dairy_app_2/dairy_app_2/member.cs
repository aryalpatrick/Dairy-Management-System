﻿using MySql.Data.MySqlClient;

namespace dairy_app_2
{
    public partial class member : Form
    {
        public member()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=SecuredPassword@123;database=dairy";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string query = "INSERT into farmer_details (farmer_id,farmer_name,farmer_contact,bank_account_number,bank_name,bank_branch) VALUES('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            home f2 = new();   //Form1 f1 = new Form1();
            f2.Show();
            Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
