using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai04 : Form
    {
        private readonly int[] rate = { 22772, 28132, 31538, 17286, 214 };
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!float.TryParse(inputText.Text.Trim(), out float input))
            {
                errorProvider1.SetError(inputText, "Vui lòng nhập 1 số!");
                MessageBox.Show("Vui lòng nhập số!");
                return;
            }
            if (cboCurrency.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboCurrency, "Vui lòng chọn 1 trong các đơn vị!");
                MessageBox.Show("Vui lòng chọn đơn vị!");
                return;
            }
            int selected = cboCurrency.SelectedIndex;
            resultText.Text = (input * rate[selected]).ToString();
            rateText.Text = "1 " + cboCurrency.SelectedItem.ToString() + " = " + rate[selected].ToString() + " VND";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
