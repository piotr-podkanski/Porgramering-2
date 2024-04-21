namespace Övning7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit(object sender, EventArgs e)
        {
            string user_input = txbAge.Text;
            int price = 0;
            try
            {
                int num = int.Parse(user_input);


                if (num <= 65 && num >= 15)
                {
                    price = 20;
                }
                else
                {
                    price = 10;
                }

                lblResult.Text = "The price is " + price + "kr";
            }

            catch (System.FormatException)
            {
                lblResult.Text = "You need to input numbers";
            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}