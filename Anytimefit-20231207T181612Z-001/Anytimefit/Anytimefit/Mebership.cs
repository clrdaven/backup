using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anytimefit
{
    public partial class Mebership : Form
    {
        Backbone bac = new Backbone();

        public Mebership()
        {
            InitializeComponent();
        }

        private void Mebership_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            SharedVariable.MemId = int.Parse(textBox1.Text);
            SharedVariable.Membershiptye = textBox2.Text;

            // Assuming Value is a DateTimePicker control
            SharedVariable.Enddate = dateTimePicker1.Value;


            bac.refreshmemberships();
            bac.Membership(SharedVariable.MemId, SharedVariable.Membershiptye, SharedVariable.Enddate);
           
        }

   

        private void button5_Click(object sender, EventArgs e)
        {
            MemberShipView membershipview = new MemberShipView();
            this.Close();
            membershipview.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            this.Close();
            homepage.Show();
        }
    }
}
