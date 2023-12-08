namespace Anytimefit
{
    partial class Mebership
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
            label4 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 53);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 19;
            label4.Text = "MemberID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 65);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 24;
            label2.Text = "MembershipType";
            // 
            // button1
            // 
            button1.Location = new Point(274, 275);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(135, 275);
            button2.Name = "button2";
            button2.Size = new Size(95, 31);
            button2.TabIndex = 26;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(408, 275);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 27;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(313, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 27);
            textBox2.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(287, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(119, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 158);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 31;
            label1.Text = "End date";
            // 
            // button5
            // 
            button5.Location = new Point(477, 12);
            button5.Name = "button5";
            button5.Size = new Size(168, 29);
            button5.TabIndex = 32;
            button5.Text = "membership";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Mebership
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 387);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mebership";
            Text = "Mebership";
            Load += Mebership_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button button5;
    }
}