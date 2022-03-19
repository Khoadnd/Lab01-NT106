using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (!int.TryParse(firstText.Text.Trim(), out int a))
            {
                errorProvider1.SetError(firstText, "Vui lòng nhập 1 số nguyên!");
                error = true;
            }
            if (!int.TryParse(secondText.Text.Trim(), out int b))
            {
                error = true;
                errorProvider1.SetError(secondText, "Vui lòng nhập 1 số nguyên!");
            }
            if (a < 1 || b < 1)
            {
                error = true;
                errorProvider1.SetError(secondText, "Vui lòng nhập 1 số nguyên dương!");
            }
            if (error) { MessageBox.Show("Vui lòng kiểm tra lại input!"); return; }



            Int64 f(int i) => Enumerable.Range(1, i < 1 ? 1 : i).Aggregate((f, x) => f * x);
            Int64 s(int i) => Enumerable.Range(1, i < 1 ? 1 : i).Aggregate((f, x) => f + x);
            int s1(int i, int j) => Enumerable.Range(1, j < 1 ? 1 : j).Aggregate(0, (x, y) => x += (int)Math.Pow(i, y));

            resultText.Text = "A! = "
                + f(a).ToString()
                + "\tB! = "
                + f(b).ToString()
                + "\r\nS1 = 1 + 2 + 3 + 4 + ... + A = "
                + s(a).ToString()
                + "\r\nS2 = 1 + 2 + 3 + 4 + ... + B = "
                + s(b).ToString()
                + "\r\nS3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = "
                + s1(a, b).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstText.Clear();
            secondText.Clear();
            resultText.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
