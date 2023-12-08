namespace Anytimefit
{
    partial class AddMember
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
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            txt5 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            text6 = new TextBox();
            Membership = new Button();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(154, 82);
            txt1.Multiline = true;
            txt1.Name = "txt1";
            txt1.Size = new Size(194, 34);
            txt1.TabIndex = 0;
            // 
            // txt2
            // 
            txt2.Location = new Point(381, 82);
            txt2.Multiline = true;
            txt2.Name = "txt2";
            txt2.Size = new Size(194, 34);
            txt2.TabIndex = 1;
            // 
            // txt3
            // 
            txt3.Location = new Point(628, 82);
            txt3.Multiline = true;
            txt3.Name = "txt3";
            txt3.Size = new Size(194, 34);
            txt3.TabIndex = 2;
            // 
            // txt5
            // 
            txt5.FormattingEnabled = true;
            txt5.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txt5.Location = new Point(307, 206);
            txt5.Name = "txt5";
            txt5.Size = new Size(151, 28);
            txt5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 59);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 7;
            label1.Text = "MemberName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 59);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 8;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(675, 59);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 9;
            label3.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 167);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 11;
            label5.Text = "Gender";
            // 
            // button1
            // 
            button1.Location = new Point(169, 365);
            button1.Name = "button1";
            button1.Size = new Size(130, 38);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(405, 365);
            button2.Name = "button2";
            button2.Size = new Size(130, 38);
            button2.TabIndex = 15;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(653, 365);
            button3.Name = "button3";
            button3.Size = new Size(130, 38);
            button3.TabIndex = 16;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(581, 167);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 18;
            label4.Text = "coach";
            // 
            // text6
            // 
            text6.Location = new Point(534, 206);
            text6.Name = "text6";
            text6.Size = new Size(139, 27);
            text6.TabIndex = 19;
            // 
            // Membership
            // 
            Membership.Location = new Point(829, 12);
            Membership.Name = "Membership";
            Membership.Size = new Size(137, 29);
            Membership.TabIndex = 20;
            Membership.Text = "MemberShip";
            Membership.UseVisualStyleBackColor = true;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 543);
            Controls.Add(Membership);
            Controls.Add(text6);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt5);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMember";
            Text = "AddMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private ComboBox txt5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox text6;
        private Button Membership;
    }
}