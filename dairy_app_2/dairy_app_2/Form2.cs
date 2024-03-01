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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Entry_daily_Click(object sender, EventArgs e)
        {
            Form1 f1 = new();   //Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void add_farmer_Click(object sender, EventArgs e)
        {
            Form3 f3 = new();   //Form1 f1 = new Form1();
            f3.Show();
            Visible = false;
        }
    }
}
