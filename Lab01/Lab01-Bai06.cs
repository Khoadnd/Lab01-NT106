using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai06 : Form
    {

        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        public static string ranks(float average, float lowest) => new (Func<float, bool> condition, Func<float, string> ranks)[]
        {
            (x => x < 3.5f, x => "Kém"),
            (x => x < 5f, x => x >= 2f ? "Yếu" : "Kém"),
            (x => x < 6.5f, x => x >= 3.5f ? "Trung bình" : "Yếu"),
            (x => x < 8f, x => x >= 5f ? "Khá" : "Trung bình"),
            (x => true, x => x >= 6.5f ? "Giỏi" : "Khá")
        }.First(x => x.condition(average)).ranks(lowest);

        private void btnExecute_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lstScore.Items.Clear();
            List<float> score = new List<float>();
            new List<string>(txtInput.Text.Trim().Split(", ")).ForEach(n =>
            {
                if (!float.TryParse(n, out float temp))
                {
                    MessageBox.Show("Vui lòng kiểm tra lại input");
                    errorProvider1.SetError(txtInput, "Vui lòng kiểm tra lại input!\r\nNhập vào dưới dạng mảng 1 chiều, mỗi phần tử cách nhau bởi dấu ', '\r\nVD: 7.5, 8, 10, 9, 10, 3");
                    return;
                }
                if (temp < 0 || temp > 10)
                {
                    MessageBox.Show("Điểm nhập vào không hợp lệ");
                    errorProvider1.SetError(txtInput, "Điểm không hợp lệ, vui lòng kiểm tra lại!");
                    return;
                }
                score.Add(temp);
            });

            Enumerable.Range(0, score.Count()).ToList().ForEach(n => lstScore.Items.Add("Môn " + (n + 1).ToString() + ": " + score[n].ToString()));

            txtAverage.Text = score.Average().ToString();

            txtMaxMin.Text = lstScore.Items[score.IndexOf(score.Max())].ToString()
                           + " / " + lstScore.Items[score.IndexOf(score.Min())].ToString();

            int passed = 0, failed = 0; ;
            score.ForEach(x =>
            {
                if (x >= 5)
                    passed++;
                else
                    failed++;
            });

            txtPassCount.Text = passed.ToString();
            txtFailCount.Text = failed.ToString();
            txtRank.Text = ranks(score.Average(), score.Min());
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
