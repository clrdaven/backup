namespace Anytimefit
{
    partial class update
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 51);
            button1.Name = "button1";
            button1.Size = new Size(87, 38);
            button1.TabIndex = 0;
            button1.Text = "Name";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(62, 112);
            button2.Name = "button2";
            button2.Size = new Size(87, 38);
            button2.TabIndex = 1;
            button2.Text = "Age";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(62, 183);
            button3.Name = "button3";
            button3.Size = new Size(87, 38);
            button3.TabIndex = 2;
            button3.Text = "gender";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(62, 249);
            button4.Name = "button4";
            button4.Size = new Size(87, 38);
            button4.TabIndex = 3;
            button4.Text = "contact";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 104);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 4;
            label1.Text = "old";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(448, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(448, 103);
            label2.Name = "label2";
            label2.Size = new Size(125, 26);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 161);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 10;
            label3.Text = "name";
            // 
            // button5
            // 
            button5.Location = new Point(659, 249);
            button5.Name = "button5";
            button5.Size = new Size(87, 38);
            button5.TabIndex = 11;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 474);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button5;
    }
}