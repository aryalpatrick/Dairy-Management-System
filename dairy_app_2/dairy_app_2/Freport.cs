using MySql.Data.MySqlClient;

namespace dairy_app_2
{
    public partial class Freport : UserControl
    {
        Entry obj = new Entry();
        String str = new String("SElECT ");
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

        private void btn_gen_Click(object sender, EventArgs e)
        {

            string Date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd ");
            string Date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd ");
            if (chk_6.Checked)
            {
                str += "* ";
            }
            else if (chk_6.Checked = false)
            {
                //make do nothing
            }
            else
            {
                if (chk_1.Checked)
                {
                    str+="milk"
                }
            }

        }

        private void chk_2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
