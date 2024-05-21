using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dairy_app_2
{
    public partial class Entry : Form
    {




        public Entry()
        {
            InitializeComponent();


            farmer_id_daily.KeyPress += TextBox_KeyPress2;
            snf_daily.KeyPress += TextBox_KeyPress;
            fat_daily.KeyPress += TextBox_KeyPress;
            milk_litre_daily.KeyPress += TextBox_KeyPress;



        }

        private void Entry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
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
            string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd ");


            DateTime dt = DateTime.Now;
            string time = dt.ToString("HH:mm:ss");
            string Datentime = Date + time;




            if (farmer_id_daily.Text != "" && milk_litre_daily.Text != "" && fat_daily.Text != "" && snf_daily.Text != "")
            {


                string connstring = "server=localhost;uid=root;pwd=SecuredPassword@123;database=dairy";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                string query = "INSERT into daily_record (farmer_id,date,milk_litre,snf,fat,rate,total_t) VALUES('" + farmer_id_daily.Text + "','" + Datentime + "','" + milk_litre_daily.Text + "','" + snf_daily.Text + "','" + fat_daily.Text + "','" + Rate_daily.Text + "','" + total_daily.Text + "')";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                farmer_id_daily.Text = "";
                milk_litre_daily.Text = "";
                fat_daily.Text = "";
                snf_daily.Text = "";
                Rate_daily.Text = "";
                total_daily.Text = "";
                F_name.Text = "";


                farmer_id_daily.Focus();


            }

        }

        private void Rate_daily_TextChanged(object sender, EventArgs e)
        {

        }

        private void farmer_id_daily_TextChanged(object sender, EventArgs e)
        {

            if (farmer_id_daily.Text != "")
            {
                string connstring = "server=localhost;uid=root;pwd=SecuredPassword@123;database=dairy";
                MySqlConnection conn = new MySqlConnection(connstring);
                MySqlDataReader reader;

                conn.Open();

                string query = "SELECT farmer_name FROM farmer_details WHERE farmer_id = '" + farmer_id_daily.Text + "';";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    F_name.Text = Convert.ToString(reader["farmer_name"]);
                }
                else
                {
                    F_name.Text = "No farmer found";
                }



                conn.Close();
            }
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
        private void TextBox_KeyPress2(object sender, KeyPressEventArgs e)
        {
            // Allow digits, decimal separator, and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
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

                    double rate = snf * 4.55 + fat * 7.15;
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
            home f2 = new();   //Form1 f1 = new Form1();
            f2.Show();
            Visible = false;
        }

        private void fat_daily_TextChanged(object sender, EventArgs e)
        {

        }

        private void fat_daily_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(fat_daily.Text))
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyData == Keys.Enter && string.IsNullOrWhiteSpace(fat_daily.Text))
            {
                SendKeys.Send("{TAB}");
                string connstring = "server=localhost;uid=root;pwd=SecuredPassword@123;database=dairy";
                MySqlConnection conn = new MySqlConnection(connstring);
                MySqlDataReader reader;

                conn.Open();

                string query = "SELECT fat" +
                    " FROM daily_record WHERE farmer_id = '" + farmer_id_daily.Text + "'" +
                    " ORDER BY date DESC" +
                    " Limit 1;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    fat_daily.Text = Convert.ToString(reader["fat"]);
                }
                conn.Close();

            }



        }

        private void snf_daily_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(snf_daily.Text))
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyData == Keys.Enter && string.IsNullOrWhiteSpace(snf_daily.Text))
            {
                SendKeys.Send("{TAB}");
                string connstring = "server=localhost;uid=root;pwd=SecuredPassword@123;database=dairy";
                MySqlConnection conn = new MySqlConnection(connstring);
                MySqlDataReader reader;

                conn.Open();

                string query = "SELECT snf" +
                    " FROM daily_record WHERE farmer_id = '" + farmer_id_daily.Text + "'" +
                    " ORDER BY date DESC" +
                    " Limit 1;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    snf_daily.Text = Convert.ToString(reader["snf"]);
                }
                conn.Close();

            }



        }

    }
}