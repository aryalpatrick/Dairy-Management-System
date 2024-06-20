using MySql.Data.MySqlClient;
using System.Data;


namespace dairy_app_2
{
    public partial class All_report : Form
    {
        private readonly Monthly mobj;
        public All_report(Monthly monthly)
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            mobj = monthly;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void All_report_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int availableWidth = this.ClientSize.Width - (50);
            int availableHeight = this.ClientSize.Height - (200);
            dataGridView1.Size = new Size(availableWidth, availableHeight);


            string connstring = "server=localhost;uid=root;pwd=SecuredPassword@123;database=dairy";
            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlDataReader reader;

            conn.Open();





            string query = mobj.QueryString;




            MySqlCommand cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;


            conn.Close();
        }
    }
}
