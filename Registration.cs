using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

namespace Voting_System__SDP_
{

    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(25, 255, 255, 255);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = name_text.Text;

            string role = admin_role.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string email = email_text.Text;

            DateTime dateofbirth = dateTimePicker1.Value.Date;

            byte[] profileImage = null;

            if (pictureBox1.Image != null)
            {
                profileImage = ImageToByteArray(pictureBox1.Image);
            }

            string gender = "";

            if(radio_male.Checked)
            {
                gender = radio_male.Text;
            } 

            else if(radio_female.Checked)
            {
                gender = radio_female.Text;
            }

            string password = password_text.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early if any field is empty
            }

            if (dateofbirth == DateTime.Now)
            {
                MessageBox.Show("Please provide date of birth.");
                return;
            }

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please provide picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string connection_string = @"Data Source=DESKTOP-NMF9NAR\SQLEXPRESS;Initial Catalog=SDP_Voting_System;Integrated Security=True;Encrypt=False";


            using (SqlConnection connect = new SqlConnection(connection_string))
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM user_data WHERE email = @Email";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Email already exists. Please use a different email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return; // Exit the method early if email is not unique
                    }
                }

                query = "INSERT INTO user_data (name, email, role, date_of_birth, gender, password, photo) VALUES (@Name, @Email, @Role, @Date_of_birth, @Gender, @Password, @Photo)";


                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ROle", role);
                    cmd.Parameters.AddWithValue("@Date_of_birth", dateofbirth);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Photo", profileImage);


                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data Saved Successfully");

            this.Hide();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void picture_upload_1_FileOk(object sender, CancelEventArgs e)
        {

        }

       private void pictureBox1_Click(object sender, EventArgs e)
{
    if (picture_upload_1.ShowDialog() == DialogResult.OK)
    {
        string filePath = picture_upload_1.FileName;

        try
        {
            // Load the image from file
            System.Drawing.Image image = System.Drawing.Image.FromFile(filePath);

            // Check if the loaded image is null
            if (image == null)
            {
                MessageBox.Show("The selected file is not a valid image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate scaling factors to fit while maintaining aspect ratio
            int pictureBoxWidth = pictureBox1.Width;
            int pictureBoxHeight = pictureBox1.Height;

            double imageRatio = (double)image.Width / image.Height;
            double pictureBoxRatio = (double)pictureBoxWidth / pictureBoxHeight;

            double scaleFactor;
            if (imageRatio > pictureBoxRatio) // Wider image
            {
                scaleFactor = (double)pictureBoxWidth / image.Width;
            }
            else // Taller image or equal ratio
            {
                scaleFactor = (double)pictureBoxHeight / image.Height;
            }

            // Optional: Resize image (create a new Bitmap to avoid modifying original)
            int newWidth = (int)(image.Width * scaleFactor);
            int newHeight = (int)(image.Height * scaleFactor);
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            Graphics g = Graphics.FromImage(resizedImage);
            g.DrawImage(image, 0, 0, newWidth, newHeight);

            // Set the image on the PictureBox (use resizedImage or original image)
            pictureBox1.Image = resizedImage;

        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void admin_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Save the image as PNG format explicitly
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

    }
}
