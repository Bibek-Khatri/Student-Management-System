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
            if (string.IsNullOrWhiteSpace(StdName.Text) ||
               string.IsNullOrWhiteSpace(StdRoll.Text) ||
               string.IsNullOrWhiteSpace(StdSec.Text) ||
               string.IsNullOrWhiteSpace(StdAge.Text) ||
               string.IsNullOrWhiteSpace(StdAddress.Text) ||
               string.IsNullOrWhiteSpace(StdPhone.Text))
            {
                MessageBox.Show("All fields must be filled!");
                return;
            }

            if (!int.TryParse(StdRoll.Text, out int roll))
            {
                MessageBox.Show("Roll number must be numeric!");
                return;
            }
            if (!int.TryParse(StdAge.Text, out int age))
            {
                MessageBox.Show("Age must be numeric!");
                return;
            }


            if (StdPhone.Text.Length < 7 || StdPhone.Text.Length > 15)
            {
                MessageBox.Show("Phone number must be between 7 and 15 digits!");
                return;
            }

            string query = "INSERT INTO Students ([Name], [Roll_no], [Section], [Age], [Address], [Phone_no]) " +
               "VALUES (?, ?, ?, ?, ?, ?)";

            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("?", StdName.Text);
                cmd.Parameters.AddWithValue("?", roll);
                cmd.Parameters.AddWithValue("?", StdSec.Text);
                cmd.Parameters.AddWithValue("?", age);
                cmd.Parameters.AddWithValue("?", StdAddress.Text);
                cmd.Parameters.AddWithValue("?", StdPhone.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            LoadData();
            MessageBox.Show("Student added successfully!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                StdID.Text = row.Cells["Student_ID"].Value?.ToString();
                StdName.Text = row.Cells["Name"].Value?.ToString();
                StdRoll.Text = row.Cells["Roll_no"].Value?.ToString();
                StdSec.Text = row.Cells["Section"].Value?.ToString();
                StdAge.Text = row.Cells["Age"].Value?.ToString();
                StdAddress.Text = row.Cells["Address"].Value?.ToString();
                StdPhone.Text = row.Cells["Phone_no"].Value?.ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StdID.Text))
            {
                MessageBox.Show("Please select a student first!");
                return;
            }

            if (string.IsNullOrWhiteSpace(StdName.Text) ||
                string.IsNullOrWhiteSpace(StdRoll.Text) ||
                string.IsNullOrWhiteSpace(StdSec.Text) ||
                string.IsNullOrWhiteSpace(StdAge.Text) ||
                string.IsNullOrWhiteSpace(StdAddress.Text) ||
                string.IsNullOrWhiteSpace(StdPhone.Text))
            {
                MessageBox.Show("All fields must be filled!");
                return;
            }

            if (!int.TryParse(StdRoll.Text, out int roll))
            {
                MessageBox.Show("Roll number must be numeric!");
                return;
            }

            if (!int.TryParse(StdAge.Text, out int age))
            {
                MessageBox.Show("Age must be numeric!");
                return;
            }

            string query = "UPDATE Students SET [Name] = ?, [Roll_no] = ?, [Section] = ?, " +
                           "[Age] = ?, [Address] = ?, [Phone_no] = ? " +
                           "WHERE [Student_ID] = ?";

            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("?", StdName.Text);
                cmd.Parameters.AddWithValue("?", roll);
                cmd.Parameters.AddWithValue("?", StdSec.Text);
                cmd.Parameters.AddWithValue("?", age);
                cmd.Parameters.AddWithValue("?", StdAddress.Text);
                cmd.Parameters.AddWithValue("?", StdPhone.Text);
                cmd.Parameters.AddWithValue("?", int.Parse(StdID.Text));

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            LoadData();
            MessageBox.Show("Student updated successfully!");
        }
    }
}
