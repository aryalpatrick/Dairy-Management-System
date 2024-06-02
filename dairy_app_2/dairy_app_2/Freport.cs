using MySql.Data.MySqlClient;

namespace dairy_app_2
{
    public partial class Freport : UserControl
    {
        Entry obj = new Entry();
        public string str = "SELECT ";
        public Freport()
        {
            InitializeComponent();

            farmer_id_daily.KeyPress += obj.TextBox_KeyPress2;
        }

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Freport_Load(object sender, EventArgs e)
        {

        }

        private void farmer_id_daily_TextChanged(object sender, EventArgs e)
        {
            id_changed();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void makeItCheck()
        {
            if (chk_1.Checked == false || chk_2.Checked == false || chk_3.Checked == false || chk_4.Checked == false || chk_5.Checked)
            {
                chk_6.Checked = false;
            }
            else if (chk_1.Checked == true && chk_2.Checked && true && chk_3.Checked == true && chk_4.Checked == true && chk_5.Checked)
            {
                chk_6.Checked = true;
            }
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {

            string Date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd ");
            string Date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd ");
            if (chk_6.Checked == false)
            {
                return;
            }
            else if (chk_6.Checked == true) 
            {
                str += "* ";
            }
            else
            {
                str += chk_1.Checked ? "milk_litre" : "";
                str += chk_2.Checked ? ",rate" : "";
                str += chk_3.Checked ? ",total_t" : "";
                str += chk_4.Checked ? ",snf" : "";
                str += chk_5.Checked ? ",fat" : "";

            }

            str += " FROM WHERE farmer_id = '" + farmer_id_daily.Text + "'";
            str += "AND date >= '" + Date1;
            str += "AND date <= '" + Date2;

            report_farmer f5 = new();
            f5.Show();
            Visible = false;

        }


        private void chk_6_CheckedChanged(object sender, EventArgs e)
        {
            makeItCheck();
            check_check();
        }

        private void chk_1_CheckedChanged(object sender, EventArgs e)
        {
            check_check();
        }
        private void chk_2_CheckedChanged(object sender, EventArgs e)
        {
            makeItCheck();
            check_check();
        }

        private void chk_3_CheckedChanged(object sender, EventArgs e)
        {
            makeItCheck();
            check_check();
        }

        private void chk_4_CheckedChanged(object sender, EventArgs e)
        {
            makeItCheck();
            check_check();
        }

        private void chk_5_CheckedChanged(object sender, EventArgs e)
        {
            makeItCheck();
            check_check();
        }
        private void check_check()
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
    }
}
