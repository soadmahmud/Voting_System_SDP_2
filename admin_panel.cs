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

namespace Voting_System__SDP_
{
    public partial class admin_panel : Form
    {
        public string email, name;

        public admin_panel(string user_email)
        {
            InitializeComponent();

            email = user_email;

            string connection_string = @"Data Source=DESKTOP-NMF9NAR\SQLEXPRESS;Initial Catalog=SDP_Voting_System;Integrated Security=True;Encrypt=False";

            string query = "SELECT name FROM user_data WHERE email = @Email";

            try
            {
                using (SqlConnection connect = new SqlConnection(connection_string))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        connect.Open();

                        string retrievedName = (string)cmd.ExecuteScalar();
                        name = string.IsNullOrEmpty(retrievedName) ? "Null" : retrievedName; // Check for null or empty string

                        connect.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }




        private void admin_panel_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void new_vote_Click(object sender, EventArgs e)
        {
            new_vote newvote = new new_vote();

            newvote.Show();
        }

        private void running_vote_Click(object sender, EventArgs e)
        {

        }

        private void previous_vote_Click(object sender, EventArgs e)
        {

        }

        private void registered_user_Click(object sender, EventArgs e)
        {
            all_user all = new all_user();
            all.Show();
        }

        private void welcome_panel_Paint(object sender, PaintEventArgs e)
        {
            welcome_panel.BackColor = Color.FromArgb(150, 0, 0, 0);

            label1.Text = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void new_register_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Registration form
            Registration registrationForm = new Registration();

            // Show the registration form
            registrationForm.Show();
        }
    }
}
