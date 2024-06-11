using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace dairy_app_2
{
    public partial class report_farmer : Form
    {
        private readonly Freport fobj;

        public report_farmer(Freport freport)
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            fobj = freport;


        }




        private void gen_freport_btn_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_Cell(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report_farmer_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int availableWidth = this.ClientSize.Width - (50);
            int availableHeight = this.ClientSize.Height - (200);
            dataGridView1.Size = new Size(availableWidth, availableHeight);


            string connstring = "server=localhost;uid=root;pwd=SecuredPassword@123;database=dairy";
            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlDataReader reader;

            conn.Open();





            string query = fobj.QueryString;




            MySqlCommand cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;


            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap print_bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(print_bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(print_bitmap, 0, 0);
        }
    }
}
