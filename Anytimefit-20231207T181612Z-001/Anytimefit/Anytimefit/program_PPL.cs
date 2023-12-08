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
    public partial class program_PPL : Form
    {
        Backbone bac = new Backbone();

        public program_PPL()
        {
            InitializeComponent();
        }

        private void program_PPL_Load(object sender, EventArgs e)
        {

        }

        private void Push_Click(object sender, EventArgs e)
        {
            SharedVariable.categid = 1;
            bac.Program(dataGridView1, SharedVariable.categid);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SharedVariable.categid = 2;
            bac.Program(dataGridView1, SharedVariable.categid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SharedVariable.categid = 3;
            bac.Program(dataGridView1, SharedVariable.categid);
        }
    }
}
