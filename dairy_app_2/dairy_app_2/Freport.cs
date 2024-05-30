using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dairy_app_2
{
    public partial class Freport : UserControl
    {
        Entry obj = new Entry();
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
    }
}
