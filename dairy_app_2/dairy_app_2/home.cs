namespace dairy_app_2
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Entry_daily_Click(object sender, EventArgs e)
        {
            Entry f1 = new();   //Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void add_farmer_Click(object sender, EventArgs e)
        {
            member f3 = new();   //Form1 f1 = new Form1();
            f3.Show();
            Visible = false;
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loan f5 = new();   //Form1 f1 = new Form1();
            f5.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loan f5 = new();   //Form1 f1 = new Form1();
            f5.Show();
            Visible = false;
        }
    }
}
