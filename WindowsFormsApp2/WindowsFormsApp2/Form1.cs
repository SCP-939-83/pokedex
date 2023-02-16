using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=thijs;database=scpfoundation1;port=3306;password=thijs;");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
            // Load data into DataGridView when the form loads
            LoadData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            // Open database connection
            conn.Open();
            // Execute query to retrieve data
            cmd = new MySqlCommand("SELECT * FROM scp", conn);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            // Set DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = dt;
            // Close database connection
            conn.Close();
        }

         private void Insert_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=scpfoundation1;user=thijs;password=thijs;";
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand("INSERT INTO scp (id, scpnaam, nickname, smalldescription) VALUES (@id, @scpnaam, @nickname, @smalldescription)", connection);
                command.Parameters.AddWithValue("@id", int.Parse(ID.Text));
                command.Parameters.AddWithValue("@scpnaam", scpname.Text);
                command.Parameters.AddWithValue("@nickname", nickname.Text);
                command.Parameters.AddWithValue("@smalldescription", shortdescription.Text);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully.");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            // Open database connection
            conn.Open();
            // Execute query to update data
            cmd = new MySqlCommand("UPDATE scp SET scpnaam = @scpnaam, nickname = @nickname, smalldescription = @smalldescription WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@scpnaam", scpname.Text);
            cmd.Parameters.AddWithValue("@nickname", nickname.Text);
            cmd.Parameters.AddWithValue("@smalldescription", shortdescription.Text);
            cmd.Parameters.AddWithValue("@id", ID.Text);
            cmd.ExecuteNonQuery();
            // Close database connection
            conn.Close();
            // Refresh DataGridView to show updated data
            LoadData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Open database connection
            conn.Open();
            // Execute query to delete data
            cmd = new MySqlCommand("DELETE FROM scp WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", ID.Text);
            cmd.ExecuteNonQuery();
            // Close database connection
            conn.Close();
            // Refresh DataGridView to show updated data
            LoadData();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            // Open database connection
            conn.Open();
            // Execute query to search data
            cmd = new MySqlCommand("SELECT * FROM scp WHERE scpnaam LIKE @scpnaam OR nickname LIKE @nickname OR smalldescription LIKE @smalldescription", conn);
            cmd.Parameters.AddWithValue("@scpnaam", "%" + scpname.Text + "%");
            cmd.Parameters.AddWithValue("@nickname", "%" + nickname.Text + "%");
            cmd.Parameters.AddWithValue("@smalldescription", "%" + shortdescription.Text + "%");
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            // Set DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = dt;
            // Close database connection
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display data from the selected row in the TextBoxes
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            ID.Text = row.Cells[0].Value.ToString();
            scpname.Text = row.Cells[1].Value.ToString();
            nickname.Text = row.Cells[2].Value.ToString();
            shortdescription.Text = row.Cells[3].Value.ToString();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=scpfoundation1;Uid=thijs;Pwd=thijs;";
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand("UPDATE scp SET scpnaam = @scpnaam, nickname = @nickname, smalldescription = @smalldescription WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(ID.Text));
                command.Parameters.AddWithValue("@scpnaam", scpname.Text);
                command.Parameters.AddWithValue("@nickname", nickname.Text);
                command.Parameters.AddWithValue("@smalldescription", shortdescription.Text);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data updated successfully.");
                }
                else
                {
                    MessageBox.Show("No records were updated.");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void scp_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}