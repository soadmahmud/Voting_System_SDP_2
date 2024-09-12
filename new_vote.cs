using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Voting_System__SDP_
{
    public partial class new_vote : Form
    {
        public new_vote()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string vote_name = this.vote_name.Text;

            DateTime start = start_date.Value.Date;
            DateTime end = end_date.Value.Date;

            string connection_string = @"Data Source=DESKTOP-NMF9NAR\SQLEXPRESS;Initial Catalog=SDP_Voting_System;Integrated Security=True;Encrypt=False";

            using (SqlConnection connect = new SqlConnection(connection_string))
            {
                connect.Open();

                // Check if vote_name already exists
                string query = "SELECT COUNT(*) FROM votelist WHERE vote_name = @Vote_name";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Vote_name", vote_name);  // Corrected parameter name

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This Vote Name already exists. Please use a different Vote Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method early if vote_name is not unique
                    }
                }

                // Insert into votelist
                query = "INSERT INTO votelist (vote_name, start_date, end_date) VALUES (@Vote_name, @Start_date, @End_date)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Vote_name", vote_name);
                    cmd.Parameters.AddWithValue("@Start_date", start);
                    cmd.Parameters.AddWithValue("@End_date", end);

                    cmd.ExecuteNonQuery();
                }

                // Create candidate table
                string candidate = vote_name + "_candidate";
                string createTableQuery = $"CREATE TABLE {candidate} (" + "email NVARCHAR(100) PRIMARY KEY, " + "vote_number INT NOT NULL DEFAULT 0)";

                try
                {
                    using (SqlCommand command = new SqlCommand(createTableQuery, connect))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating candidate table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Create voted table
                string voted = vote_name + "_voted";
                createTableQuery = $"CREATE TABLE {voted} (" +  "email NVARCHAR(100) PRIMARY KEY)";

                try
                {
                    using (SqlCommand command = new SqlCommand(createTableQuery, connect))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating voted table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            add_candidate ad_cndt = new add_candidate(vote_name);

            ad_cndt.Show();

            this.Hide();


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

    private void vote_name_KeyPress(object sender, KeyPressEventArgs e)
    {
        char keyChar = e.KeyChar;
        if (!char.IsLetter(keyChar) && keyChar != Char.MinValue && keyChar != '_' && !char.IsLetterOrDigit(keyChar))
        {
            e.Handled = true; // Prevent invalid character from being entered
        }
    }

    private void vote_name_TextChanged(object sender, EventArgs e)
    {
        string text = vote_name.Text;
        string formatRegex = "^[a-zA-Z][a-zA-Z0-9_]*$";
        if (!Regex.IsMatch(text, formatRegex))
        {
            MessageBox.Show("Please enter a value starting with an alphabet and containing only alphabets, numbers, and underscores.");
            vote_name.Text = text.Substring(0, Math.Max(text.Length - 1, 0)); // Remove last character if invalid
        }
        vote_name.Select(vote_name.Text.Length, 0); // Set cursor to the end after TextChanged
    }

}
}
