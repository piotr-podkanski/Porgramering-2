namespace Övning_2._2
{
    public partial class Övning : Form
    {
        public Övning()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMsg_click(object sender, EventArgs e)
        {
            MessageBox.Show("Is this program fun?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}