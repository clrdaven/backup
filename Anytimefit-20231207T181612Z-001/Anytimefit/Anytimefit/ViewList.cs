using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Anytimefit
{


    public partial class ViewList : Form
    {
        Backbone bac = new Backbone();
        public ViewList()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SharedVariable.Search = textBox1.Text;

            bac.ViewList(SharedVariable.Search, dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            bac.RefreshDataGridView(dataGridView1);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bac.RefreshForDisplay(dataGridView1);

            bac.Delete(SharedVariable.MembernameD);

            bac.DisplayMemberData(dataGridView1);

            if 



        }

        private void button6_Click(object sender, EventArgs e)
        {


            bac.RefreshForDisplay(dataGridView1);

            bac.DisplayMemberData(dataGridView1); ;



        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Check if the clicked area is a row header
            if (e.RowIndex >= 0)
            {
                // Get the value in the first cell of the clicked row (assuming it's the membername)

                SharedVariable.MembernameD = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                // Call the delete method

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string? memidstring = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (int.TryParse(memidstring, out var memid))
            {
                SharedVariable.memid = memid;
            }
            else
            {

                SharedVariable.memid = 0;


            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (SharedVariable.memid == 0)
            {
                // nothing
            }
            else
            {
                update update = new update();
                this.Close();   
                update.Show();
            }


        }
    }
}
