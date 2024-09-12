using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Voting_System__SDP_
{
    public partial class voting_page : Form
    {
        string email, vote_name, name, gender, candidate;
        byte[] userPhoto;

        string connection_string = @"Data Source=DESKTOP-NMF9NAR\SQLEXPRESS;Initial Catalog=SDP_Voting_System;Integrated Security=True;Encrypt=False";

        public voting_page(string Email, string Vote_name)
        {
            email = Email;
            vote_name = Vote_name;
            InitializeComponent();

            string table_name = vote_name + "_candidate";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(candidate))
            {
                MessageBox.Show("Please select a candidate email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construct the UPDATE query to increment the vote_number column
            string tableName = vote_name + "_candidate";

            string query = $"UPDATE {tableName} SET vote_number = vote_number + 1 WHERE email = @Email";

            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Email", candidate);

                        // Execute the UPDATE query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vote count incremented successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Candidate email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating vote count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AddStringToTable(vote_name + "_voted", email);

            voter vtr = new voter(email);

            vtr.Show();

            this.Close();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void voting_page_Load(object sender, EventArgs e)
        {
            try
            {
                // Connect to database
                SqlConnection connection = new SqlConnection(connection_string);
                connection.Open();

                // Construct table name dynamically (avoid SQL injection)
                string tableName = vote_name + "_candidate";
                tableName = SanitizeTableName(tableName); // Sanitize user input to prevent SQL injection

                // Prepare and execute query (example: retrieve candidate list)
                string query = $"SELECT * FROM {tableName}"; // Use string interpolation for clarity
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Populate UI elements (example: combo box with candidate names)
                while (reader.Read())
                {
                    string candidateemail = reader.GetString(reader.GetOrdinal("email"));
                    comboBox1.Items.Add(candidateemail); // Add candidateEmail to combo box or other UI element
                }

                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                // Handle database connection or query execution errors
                MessageBox.Show("Error connecting to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            candidate = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(candidate))
            {
                MessageBox.Show("Please select a candidate email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT name, gender, photo FROM user_data WHERE email = @Email";

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Email", candidate);

                    // Execute the query and get the result
                    SqlDataReader reader = command.ExecuteReader();

                    // Check if a user with the provided username exists
                    if (reader.Read())
                    {
                        name = reader["name"].ToString();
                        gender = reader["gender"].ToString();
                        userPhoto = (byte[])reader["photo"];

                        if (userPhoto != null && userPhoto.Length > 0)
                        {
                            using (var ms = new MemoryStream(userPhoto)) // Create a memory stream from the byte array
                            {
                                pictureBox1.Image = Image.FromStream(ms); // Load the image from the memory stream into the PictureBox
                            }
                        }
                        else
                        {
                            // Handle the case where no image data is found (e.g., set a default image)
                            pictureBox1.Image = null; // Clear the PictureBox image
                        }

                        label3.Text = name;
                        label4.Text = gender;
                        label5.Text = candidate;
                    }
                    else
                    {
                        // User with the provided email doesn't exist
                        MessageBox.Show("User not found.");
                    }
                }
            }
        }

        private string SanitizeTableName(string tableName)
        {
            // Implement logic to escape special characters in tableName to prevent SQL injection
            // You can use methods like SqlParameter or parameterized queries for safer execution
            return tableName.Replace("[", "").Replace("]", ""); // Basic example, consider a more robust approach
        }

        private void AddStringToTable(string tableName, string newStringValue)
        {
            try
            {
                // Connect to the database
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();

                    // Construct the INSERT query
                    string query = $"INSERT INTO {tableName} (email) VALUES (@NewValue)";

                    // Create a command with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@NewValue", newStringValue);

                        // Execute the INSERT query
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding string to table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
