using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (!((sender as Button)?.Text == "." && txtNumber.TextLength == 0))
                txtNumber.Text += (sender as Button)?.Text;
            else
                txtNumber.Text += "0.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = string.Empty;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string formattedCalculation = txtNumber.Text.Replace("×", "*").ToString().Replace("÷", "/");

            try
            {
                // DataTable().Compute() metodunu internetde rahat yolla hesbablama etmek uchun axtaranda tapdim
                double result =double.Parse(new DataTable().Compute(formattedCalculation, null).ToString()!);

                if (result.ToString() == "∞")
                    throw new DivideByZeroException();

                txtNumber.Text =  result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect please try again","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtNumber.Text = string.Empty;
            }
        }
    }
}