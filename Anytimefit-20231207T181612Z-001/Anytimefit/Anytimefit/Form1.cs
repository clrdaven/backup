namespace Anytimefit
{
    public partial class Form1 : Form
    {   
        Backbone bac = new Backbone();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int Username))
            {
                SharedVariable.Username = Username;
                SharedVariable.PassName = textBox2.Text.ToUpper();
                bac.Admin(SharedVariable.Username, SharedVariable.PassName);
               

            }
            else { 
            
                // Handle the case where the input is not a valid integer
                MessageBox.Show("Invalid input for Username. Please enter a valid integer.");
            }

        }
    }
}
