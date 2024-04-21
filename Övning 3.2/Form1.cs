namespace Övning_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double val1 = double.Parse(tbxVal1.Text);
                double val2 = double.Parse(tbxVal2.Text);
                double sum = val1 + val2;
                lblResult.Text = $"the sum of {val1} + {val2} is {sum}";
                
            }
            

            catch (Exception ex) 
            {
                lblResult.Text = "please input numbers in both boxes";
            }

            lblResult.Visible = true;




        }
    }
}