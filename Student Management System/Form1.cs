using System.Data;
using System.Data.OleDb;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        private void LoadData()
        {
            string query = "SELECT * FROM Students";
            OleDbDataAdapter da = new OleDbDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private OleDbConnection connection = new OleDbConnection(
        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Acer Nitro v16\Downloads\StudentDatabase.accdb"
    );
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
