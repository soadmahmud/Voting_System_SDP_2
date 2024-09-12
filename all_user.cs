using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_System__SDP_
{
    public partial class all_user : Form
    {
        public all_user()
        {
            InitializeComponent();
        }

        private void all_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sDP_Voting_SystemDataSet2.user_data' table. You can move, or remove it, as needed.
            this.user_dataTableAdapter.Fill(this.sDP_Voting_SystemDataSet2.user_data);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int numRows = dataGridView1.RowCount - 1;

            label1.Text = label1.Text + numRows.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
