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

        private void Add_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO Students ([Name], [Roll_no], [Section], [Age], [Address], [Phone_no]) " +
               "VALUES (@name, @roll, @section, @age, @address, @phone)";

            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("?", StdName.Text);
                cmd.Parameters.AddWithValue("?", int.Parse(StdRoll.Text));
                cmd.Parameters.AddWithValue("?", StdSec.Text);
                cmd.Parameters.AddWithValue("?", int.Parse(StdAge.Text));
                cmd.Parameters.AddWithValue("?", StdAddress.Text);
                cmd.Parameters.AddWithValue("?", StdPhone.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            LoadData();
            MessageBox.Show("Student added successfully!");
        }
    }
}
