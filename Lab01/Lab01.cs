using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bai01Form = new Lab01_Bai01();
            bai01Form.FormClosed += new FormClosedEventHandler(childFormClosed);
            bai01Form.Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bai02Form = new Lab01_Bai02();
            bai02Form.FormClosed += new FormClosedEventHandler(childFormClosed);
            bai02Form.Show();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bai03Form = new Lab01_Bai03();
            bai03Form.FormClosed += new FormClosedEventHandler(childFormClosed);
            bai03Form.Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bai04Form = new Lab01_Bai04();
            bai04Form.FormClosed += new FormClosedEventHandler(childFormClosed);
            bai04Form.Show();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bai05Form = new Lab01_Bai05();
            bai05Form.FormClosed += new FormClosedEventHandler(childFormClosed);
            bai05Form.Show();
        }
        private void btnBai06_click(object sender, EventArgs e)
        {
            this.Hide();
            var bai06Form = new Lab01_Bai06();
            bai06Form.FormClosed += new FormClosedEventHandler(childFormClosed);
            bai06Form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void childFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
