using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Voting_System__SDP_
{
    public partial class add_candidate : Form
    {

        public string vote_name, name, gender, email;

        byte[] image;

        public add_candidate(string votename)
        {
            vote_name = votename;

            InitializeComponent();
        }
        
        private void add_candidate_Load(object sender, EventArgs e)
        {

        }

        public string connection_string = "Data Source=DESKTOP-NMF9NAR\\SQLEXPRESS;Initial Catalog=SDP_Voting_System;Integrated Security=True;Encrypt=False";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            email = textBox1.Text;

            string query = "SELECT name, gender, photo FROM user_data WHERE email = @Email";

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Email", email);

                    // Execute the query and get the result
                    SqlDataReader reader = command.ExecuteReader();

                    // Check if a user with the provided username exists
                    if (reader.Read())
                    {
                        name = reader["name"].ToString();
                        gender = reader["gender"].ToString();

                        image = (byte[]) reader["photo"];

                        if (image != null && image.Length > 0)
                        {
                            using (var ms = new MemoryStream(image)) // Create a memory stream from the byte array
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
                        label5.Text = email;
                    }
                    else
                    {
                        // User with the provided username doesn't exist
                        MessageBox.Show("User not found.");
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string table_name = vote_name + "_candidate";

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string sqlQuery = $"INSERT INTO {table_name} (Email, vote_number) VALUES (@Email, 0)"; // String interpolation for dynamic table name

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@Email", email); // Add email parameter

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery(); // Execute the insert query

                    MessageBox.Show("Email inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting email: " + ex.Message); // Display error message
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            add_candidate again = new add_candidate(vote_name);

            again.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
