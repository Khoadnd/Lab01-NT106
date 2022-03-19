using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai03 : Form
    {
        private enum num
        {
            Không = 0,
            Một = 1,
            Hai = 2,
            Ba = 3,
            Bốn = 4,
            Năm = 5,
            Sáu = 6,
            Bảy = 7,
            Tám = 8,
            Chín = 9
        };
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void btnRead_click(object sender, EventArgs e)
        {
            if (!int.TryParse(inputText.Text.Trim(), out int input))
            {
                errorProvider1.SetError(inputText, "Vui lòng nhập 1 số nguyên!");
                MessageBox.Show("Vui lòng nhập 1 số!");
            }
            else
                resultText.Text = ((num)input).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            inputText.Clear();
            resultText.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
