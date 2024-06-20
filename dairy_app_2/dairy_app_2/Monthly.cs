using System.Text;

namespace dairy_app_2
{
    public partial class Monthly : UserControl
    {

        private StringBuilder _str;
        public Monthly()
        {
            InitializeComponent();
            _str = new StringBuilder("");
        }
        public string QueryString => _str.ToString();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            _str.Clear();
            string Date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd ");
            string Date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd ");
            _str.Append("SELECT farmer_id, SUM(milk_litre) AS t_m_l " +
                "FROM daily_record" +
                "GROUP BY farmer_id;");

            report_farmer f5 = new report_farmer(this);
            f5.Show();
            Visible = false;


        }
    }
}
