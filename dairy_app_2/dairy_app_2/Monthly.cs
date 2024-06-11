using System;
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
            _str.Append("SELECT ");
            string Date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd ");
            string Date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd ");


        }
    }
}
