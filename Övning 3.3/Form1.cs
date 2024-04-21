namespace Övning_3._3
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
                double val3 = double.Parse(tbxVal3.Text);

                double sum = val1 + val2 + val3;
                double avg = sum / 3;

                lblResult.Text = $"The sum is {sum} \nThe average is {avg}";

            }

            catch (Exception ex)
            {
                lblResult.Text = "please fillout all the boxes";
            }

            finally
            {
                lblResult.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 


        }
    }
}