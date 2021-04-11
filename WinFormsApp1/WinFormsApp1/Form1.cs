using System.Windows.Forms;
using System;
using System.Linq;
using System.Drawing;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public MoneyKeeper moneyKeeper = new MoneyKeeper();
        public string startType = string.Empty;
        public string endType = string.Empty;
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void MoneyCalc_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Денег нет {moneyKeeper.Convert(startType, endType, 1):0.00}");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Где деньги Либовский?");
            Close();
        }

        private void startType_SelectBox(object sender, EventArgs e)
        {
            startType = startTypeMoney.SelectedItem.ToString();
        }
        private void endType_SelectBox(object sender, EventArgs e)
        {
            endType = endTypeMoney.SelectedItem.ToString();            
        }
        private void moneyTypes_DropDown(object sender, EventArgs e)
        {
            (sender as ComboBox)?.Items.Clear();
            (sender as ComboBox)?.Items.AddRange(moneyKeeper.moneys.Select(x => x.moneyName).ToArray());
        }
    }
}
