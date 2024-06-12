using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            _str.Append(@"
        SELECT
            dr.farmer_id,
            fd.name,
            SUM(dr.milk_litre) AS total_milk_litre,
            AVG(dr.rate) AS average_rate,
            SUM(dr.total_t) AS total_amount
        FROM
            daily_records dr
        JOIN
            farmers_detail fd ON dr.farmer_id = fd.farmer_id
        WHERE
            dr.date BETWEEN "+@Date1+" AND "+@Date2+"
        @"GROUP BY
            dr.farmer_id, fd.name;");

            report_farmer f5 = new report_farmer(this);
            f5.Show();
            Visible = false;


        }
    }
}
