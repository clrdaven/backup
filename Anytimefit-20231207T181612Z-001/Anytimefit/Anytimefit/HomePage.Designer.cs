namespace Anytimefit
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            sidebar = new FlowLayoutPanel();
            menuContainer = new FlowLayoutPanel();
            pnlMenu = new Panel();
            pictureBox1 = new PictureBox();
            menu = new Button();
            pnlMember = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pnlMemship = new Panel();
            pictureBox3 = new PictureBox();
            button7 = new Button();
            pnlPayment = new Panel();
            pictureBox4 = new PictureBox();
            button5 = new Button();
            pnlViewlist = new Panel();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            pnlProgram = new Panel();
            pictureBox6 = new PictureBox();
            button4 = new Button();
            pnlReport = new Panel();
            pictureBox7 = new PictureBox();
            button6 = new Button();
            btnHam = new PictureBox();
            label1 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlMemship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlViewlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Silver;
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(pnlViewlist);
            sidebar.Controls.Add(pnlProgram);
            sidebar.Controls.Add(pnlReport);
            sidebar.Dock = DockStyle.Left;
            sidebar.ForeColor = SystemColors.ActiveCaptionText;
            sidebar.Location = new Point(0, 53);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(188, 527);
            sidebar.TabIndex = 1;
            sidebar.Paint += flowLayout_Paint;
            // 
            // menuContainer
            // 
            menuContainer.Controls.Add(pnlMenu);
            menuContainer.Controls.Add(pnlMember);
            menuContainer.Controls.Add(pnlMemship);
            menuContainer.Controls.Add(pnlPayment);
            menuContainer.Location = new Point(3, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(148, 45);
            menuContainer.TabIndex = 2;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Silver;
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Controls.Add(menu);
            pnlMenu.Location = new Point(3, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(145, 42);
            pnlMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.Location = new Point(57, 3);
            menu.Name = "menu";
            menu.Size = new Size(85, 33);
            menu.TabIndex = 0;
            menu.Text = "Menu";
            menu.UseVisualStyleBackColor = false;
            menu.Click += button8_Click;
            // 
            // pnlMember
            // 
            pnlMember.BackColor = Color.Silver;
            pnlMember.Controls.Add(pictureBox2);
            pnlMember.Controls.Add(button1);
            pnlMember.Location = new Point(3, 51);
            pnlMember.Name = "pnlMember";
            pnlMember.Size = new Size(142, 49);
            pnlMember.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(57, 8);
            button1.Name = "button1";
            button1.Size = new Size(82, 38);
            button1.TabIndex = 0;
            button1.Text = "Member";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlMemship
            // 
            pnlMemship.Controls.Add(pictureBox3);
            pnlMemship.Controls.Add(button7);
            pnlMemship.Location = new Point(3, 106);
            pnlMemship.Name = "pnlMemship";
            pnlMemship.Size = new Size(142, 44);
            pnlMemship.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // button7
            // 
            button7.Location = new Point(57, 3);
            button7.Name = "button7";
            button7.Size = new Size(82, 38);
            button7.TabIndex = 0;
            button7.Text = "Membership";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // pnlPayment
            // 
            pnlPayment.Controls.Add(pictureBox4);
            pnlPayment.Controls.Add(button5);
            pnlPayment.Location = new Point(3, 156);
            pnlPayment.Name = "pnlPayment";
            pnlPayment.Size = new Size(142, 54);
            pnlPayment.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-1, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(57, 7);
            button5.Name = "button5";
            button5.Size = new Size(82, 38);
            button5.TabIndex = 0;
            button5.Text = "Payment";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pnlViewlist
            // 
            pnlViewlist.Controls.Add(pictureBox5);
            pnlViewlist.Controls.Add(button2);
            pnlViewlist.Location = new Point(3, 54);
            pnlViewlist.Name = "pnlViewlist";
            pnlViewlist.Size = new Size(148, 49);
            pnlViewlist.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(60, 8);
            button2.Name = "button2";
            button2.Size = new Size(85, 38);
            button2.TabIndex = 0;
            button2.Text = "ViewList";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pnlProgram
            // 
            pnlProgram.Controls.Add(pictureBox6);
            pnlProgram.Controls.Add(button4);
            pnlProgram.Location = new Point(3, 109);
            pnlProgram.Name = "pnlProgram";
            pnlProgram.Size = new Size(148, 49);
            pnlProgram.TabIndex = 3;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 11);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(61, 8);
            button4.Name = "button4";
            button4.Size = new Size(84, 38);
            button4.TabIndex = 0;
            button4.Text = "Program";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pnlReport
            // 
            pnlReport.Controls.Add(pictureBox7);
            pnlReport.Controls.Add(button6);
            pnlReport.Location = new Point(3, 164);
            pnlReport.Name = "pnlReport";
            pnlReport.Size = new Size(148, 49);
            pnlReport.TabIndex = 6;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(2, 6);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(60, 3);
            button6.Name = "button6";
            button6.Size = new Size(84, 38);
            button6.TabIndex = 0;
            button6.Text = "Report";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(12, 12);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(60, 34);
            btnHam.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHam.TabIndex = 2;
            btnHam.TabStop = false;
            btnHam.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 8);
            label1.Name = "label1";
            label1.Size = new Size(153, 38);
            label1.TabIndex = 2;
            label1.Text = "GYM BROS";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(1015, 3);
            button3.Name = "button3";
            button3.Size = new Size(46, 43);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 53);
            panel1.TabIndex = 0;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += contTransition_Tick;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(908, 580);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlMemship.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlViewlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlProgram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pnlReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel sidebar;
        private Panel pnlMember;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button6;
        private PictureBox btnHam;
        private Label label1;
        private Panel pnlPayment;
        private Panel pnlViewlist;
        private Panel pnlProgram;
        private Panel pnlMemship;
        private Panel pnlReport;
        private Button button3;
        private Panel panel1;
        private FlowLayoutPanel menuContainer;
        private Panel pnlMenu;
        private Button menu;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox3;
    }
}