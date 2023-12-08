using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anytimefit
{
    public partial class HomePage : Form
    {
        // formMenu menu;
        // formAddMember addmember
        // formMembership membership
        // formPayment payment
        // formProgram program
        // formViewlist viewlist
        // formReport report
        // di ako sure dine pero are yung amgcoconnect nasa yt hindi ako sure kung alin ang form tangina mo

        AddMember? AddMember = null;
        public HomePage()
        {
            InitializeComponent();
        }
        bool menuExpand = false;

        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (AddMember == null)
                {
                    AddMember = new AddMember();
                    AddMember.FormClosed += AddMember_FormClosed;

                    AddMember.Show();
                }
                else
                {
                    AddMember.Activate();
                }
            }
        }
        private void AddMember_FormClosed(object sender, EventArgs e)
        {

            AddMember = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewList viewList = new ViewList();
            this.Hide();
            viewList.Show();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            program_PPL program = new program_PPL();
            this.Hide();
            program.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Mebership mebership = new Mebership();
            this.Hide();
            mebership.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            this.Hide();
            transaction.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                sidebar.Height += 47;
                if (sidebar.Height >= 229)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 50)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            menuTransition.Start();

            if (menu == null)
            {
                 ////menu = new formMenu(); 
                 //menu.FormClosed += menu_FormClosed;
                 //menu.Midparent = this;
                 //menu.Show();
            }
        }

        bool sidebarExpand = true; 
        private void flowLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 60 )
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnlMenu.Width = sidebar.Width;
                    pnlMember.Width = sidebar.Width;
                    pnlMemship.Width = sidebar.Width;
                    pnlPayment.Width = sidebar.Width;
                    pnlViewlist.Width = sidebar.Width;
                    pnlProgram.Width = sidebar.Width;
                    pnlReport.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 206)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnlMenu.Width = sidebar.Width;
                    pnlMember.Width = sidebar.Width;
                    pnlMemship.Width = sidebar.Width;
                    pnlPayment.Width = sidebar.Width;
                    pnlViewlist.Width = sidebar.Width;
                    pnlProgram.Width = sidebar.Width;
                    pnlReport.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }

            //private void Menu_FormClosed(object sender, FormClosedEventArgs e)
            // {
                 //menu = null;
            // }
        }
    }
}
