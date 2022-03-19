using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            bool error = false;
            float min = float.MaxValue, max = float.MinValue;
            errorProvider1.Clear();
            new List<TextBox> { firstText, secondText, thirdText }.ForEach(n =>
            {
                if (!float.TryParse(n.Text.Trim(), out float temp))
                {
                    error = true;
                    errorProvider1.SetError(n, "Vui lòng nhập 1 số!");
                }
                else
                {
                    if (temp > max)
                        max = temp;
                    if (temp < min)
                        min = temp;
                }
            });
            if (error) { MessageBox.Show("Vui lòng nhập 1 số!"); return; }
            maxText.Text = max.ToString();
            minText.Text = min.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            new List<TextBox> { firstText, secondText, thirdText, maxText, minText }.ForEach(n => n.Clear());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
