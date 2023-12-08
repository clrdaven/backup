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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            label3.Text = SharedVariable.total.ToString("N2");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Error are you pssy?");
                return;
            }
            if (double.TryParse(textBox1.Text, out double amounth) && amounth > 0)
            {

                if (amounth >= SharedVariable.total)
                {

                    SharedVariable.amounth = amounth;
                    SharedVariable.Change = SharedVariable.amounth - SharedVariable.total;

                    Payment payment = new Payment();
                    this.Hide();
                    payment.Show();
                }
                else
                {
                    MessageBox.Show("PUssy kulang");
                  
                }



            }
            if(int.TryParse(textBox2.Text, out int id))
            {
                SharedVariable.memberidT = id;
            }



        }
    }
}
