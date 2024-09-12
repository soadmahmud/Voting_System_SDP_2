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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Voting_System__SDP_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Level_1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void password_hide_button_Click(object sender, EventArgs e)
        {
            if (password_textbox.UseSystemPasswordChar == true)
            {
                password_textbox.UseSystemPasswordChar = false;

                password_hide_button.BackgroundImage = Properties.Resources.Untitled_design__4_;
            }

            else
            {
                password_textbox.UseSystemPasswordChar = true;

                password_hide_button.BackgroundImage = Properties.Resources.Untitled_design__3_;
            }
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_button1_Click(object sender, EventArgs e)
        {
            string connection_string = @"Data Source=DESKTOP-NMF9NAR\SQLEXPRESS;Initial Catalog=SDP_Voting_System;Integrated Security=True;Encrypt=False";

            string email = username_textbox.Text;

            string password = password_textbox.Text;

            string query = "SELECT password, role FROM user_data WHERE email = @Email";

            using(SqlConnection connection = new SqlConnection(connection_string))
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
                        string storedPassword = reader["password"].ToString();
                        string storedRole = reader["role"].ToString();

                        // Compare the stored password with the provided password
                        if (storedPassword == password)
                        {
                            // You can proceed with opening your main form or performing other actions here

                            if(storedRole == "admin")
                            {
                                admin_panel admin_Panel = new admin_panel(email);

                                admin_Panel.Show();

                                this.Hide();
                            }


                            else
                            {
                                voter vt = new voter(email);

                                vt.Show();

                                this.Hide();
                            }
                        }
                        else
                        {
                            // Passwords don't match or role is incorrect, handle authentication failure
                            MessageBox.Show("Incorrect password.");
                        }
                    }
                    else
                    {
                        // User with the provided username doesn't exist
                        MessageBox.Show("User not found.");
                    }
                }
            }
        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
