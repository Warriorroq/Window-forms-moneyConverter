using System.Windows.Forms;
using System;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void MoneyCalc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Денег нет");

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Где деньги Либовский?");
            Close();
        }
    }
}
