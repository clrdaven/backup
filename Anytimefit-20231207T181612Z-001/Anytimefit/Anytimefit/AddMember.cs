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
    public partial class AddMember : Form
    {
        Backbone bac = new Backbone();

        public AddMember()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SharedVariable.MemberName = txt1.Text;
            SharedVariable.PhoneNum = txt2.Text;
            SharedVariable.Age = txt3.Text;
            SharedVariable.Gender = txt5.Text;
            SharedVariable.coachid = int.Parse(text6.Text);




            bac.AddMember(SharedVariable.MemberName, SharedVariable.PhoneNum, SharedVariable.Age, SharedVariable.Gender, SharedVariable.coachid);

            bac.refreshmem();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Close();
            homePage.Show();
        }
    }
}
