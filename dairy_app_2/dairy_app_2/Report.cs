namespace dairy_app_2
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            //setting default tab as monthly
            pnl_freport.BackColor = Color.Silver;
            pnl_monthly.BackColor = Color.Black;
            add_User_ctrl(new Monthly());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home f2 = new();   //Form1 f1 = new Form1();
            f2.Show();
            Visible = false;
        }



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_User_ctrl(UserControl UC_obj)
        {
            UC_obj.Dock = DockStyle.Left;
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(UC_obj);
            UC_obj.BringToFront();

        }

        private void Btn_Click(object sender, EventArgs e)
        {

        }

        private void btn_monthly_Click(object sender, EventArgs e)
        {

            pnl_freport.BackColor = Color.Silver;
            pnl_monthly.BackColor = Color.Black;
            add_User_ctrl(new Monthly());

        }

        private void btn_freport_Click(object sender, EventArgs e)
        {
            pnl_monthly.BackColor = Color.Silver;
            pnl_freport.BackColor = Color.Black;
            add_User_ctrl(new Freport());
        }

        private void pnl_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
