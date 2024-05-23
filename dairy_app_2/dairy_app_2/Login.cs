namespace dairy_app_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pass.PasswordChar = '*';

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void farmer_id_daily_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && pass.Text == "")
            {
                home f2 = new();   //Form1 f1 = new Form1();
                f2.Show();
                Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
