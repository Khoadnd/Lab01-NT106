using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            long sum = 0;

            errorProvider1.Clear();
            bool error = false;

            new List<TextBox> { firstText, secondText }.ForEach(n =>
            {
                if (!int.TryParse(n.Text.Trim(), out int temp))
                {
                    error = true;
                    errorProvider1.SetError(n, "Vui lòng nhập 1 số nguyên!");
                }
                else sum += temp;
            });

            if (error) { MessageBox.Show("Vui lòng nhập 1 số!"); return; }
            resultText.Text = sum.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
