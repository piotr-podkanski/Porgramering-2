namespace Övning_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double value = double.Parse(tbxValue.Text);

            if (value != 0)
            {

                double quadrant = Math.Pow(value, 2);

                lblResult.Visible = true;
                lblResult.Text = $"The quadrant of {value} is {quadrant}";
            }
            else
            {
                lblResult.Visible = true;
                lblResult.Text = "There is no quadrant for 0";
            }
        }

        private void tbxValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}