using MySql.Data.MySqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

namespace dairy_app_2
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();

            snf_daily.KeyPress += TextBox_KeyPress;
            fat_daily.KeyPress += TextBox_KeyPress;
            milk_litre_daily.KeyPress += TextBox_KeyPress;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {
            if (farmer_id_daily.Text != "")
            {
                String Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                string connstring = "server=localhost;uid=root;pwd=SecuredPassword@123;database=dairy";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                string query = "INSERT into daily_record (farmer_id,date,milk_litre,snf,fat,rate,total_t) VALUES('" + farmer_id_daily.Text + "','" + Date + "','" + milk_litre_daily.Text + "','" + snf_daily.Text + "','" + fat_daily.Text + "','" + Rate_daily.Text + "','" + total_daily.Text + "')";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                farmer_id_daily.Text = "";
                milk_litre_daily.Text = "";
                fat_daily.Text = "";
                snf_daily.Text = "";
                Rate_daily.Text = "";
                total_daily.Text = "";

            }

        }

        private void Rate_daily_TextChanged(object sender, EventArgs e)
        {

        }

        private void farmer_id_daily_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, decimal separator, and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                // Suppress the key press
                e.Handled = true;
            }
        }

        private void snf_daily_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(snf_daily.Text) && !string.IsNullOrWhiteSpace(fat_daily.Text) && !string.IsNullOrWhiteSpace(milk_litre_daily.Text))
            {
                if (double.TryParse(snf_daily.Text, out double snf) && double.TryParse(fat_daily.Text, out double fat) && double.TryParse(milk_litre_daily.Text, out double milk))
                {

                    double rate = snf * 2 + fat * 5;
                    Rate_daily.Text = rate.ToString();
                    double total = rate * milk;
                    total_daily.Text = total.ToString();
                }
                else
                {
                    if (!double.TryParse(snf_daily.Text, out _))
                        snf_daily.Focus();
                    else if (!double.TryParse(fat_daily.Text, out _))
                        fat_daily.Focus();
                    else
                        milk_litre_daily.Focus();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new();   //Form1 f1 = new Form1();
            f2.Show();
            Visible = false;
        }
    }
}