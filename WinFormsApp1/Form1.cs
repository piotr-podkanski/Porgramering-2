namespace Övning7_3
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
            Random random = new Random();
            int num = random.Next(1, 7);
            lblResult.Text = num.ToString();

            if (num == 6)
            {
                MessageBox.Show("You did it you threw a 6", "Congrats");
            }



        }

        private void LblDice_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}