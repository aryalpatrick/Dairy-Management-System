using MySql.Data.MySqlClient;
using System.Text;

namespace dairy_app_2
{
    public partial class Freport : UserControl
    {
        Entry obj = new Entry();
        private StringBuilder _str;

        public Freport()
        {
            InitializeComponent();

            farmer_id_daily.KeyPress += obj.TextBox_KeyPress2;
            _str = new StringBuilder("");
        }

        public string QueryString => _str.ToString();

        private void id_changed()
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


        private void farmer_id_daily_TextChanged(object sender, EventArgs e)
        {
            id_changed();
        }


        private void btn_gen_Click(object sender, EventArgs e)
        {
            _str.Clear();
            _str.Append("SELECT ");
            string Date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd ");
            string Date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd ");

            if (chk_6.Checked == true)
            {
                _str.Append("* ");
            }
            else if (chk_1.Checked == false && chk_2.Checked == false && chk_3.Checked == false && chk_4.Checked == false && chk_5.Checked == false)
            {
                return;
            }
            else
            {

                _str.Append(chk_1.Checked ? "milk_litre" : "");
                _str.Append(chk_2.Checked ? ",rate" : "");
                _str.Append(chk_3.Checked ? ",total_t" : "");
                _str.Append(chk_4.Checked ? ",snf" : "");
                _str.Append(chk_5.Checked ? ",fat" : "");

            }

            _str.Append(" FROM daily_record WHERE farmer_id = '" + farmer_id_daily.Text + "'");
            _str.Append(" AND date >= '" + Date1 + "'");
            _str.Append(" AND date <= '" + Date2 + "'");


            label4.Text = _str.ToString();




            report_farmer f5 = new report_farmer(this);
            f5.Show();
            Visible = false;



        }



        private void chk_6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_6.Checked)
            {
                chk_1.Checked = true;
                chk_2.Checked = true;
                chk_3.Checked = true;
                chk_4.Checked = true;
                chk_5.Checked = true;
            }

        }

        private void chk_1_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void chk_2_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void chk_3_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void chk_4_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void chk_5_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void check()
        {
            if (chk_1.Checked && chk_2.Checked && chk_3.Checked && chk_4.Checked && chk_5.Checked)
            {
                chk_6.Checked = true;
            }

            if (chk_1.Checked == false || chk_2.Checked == false || chk_3.Checked == false || chk_4.Checked == false || chk_5.Checked == false)
            {
                chk_6.Checked = false;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void Freport_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }


    }
}
