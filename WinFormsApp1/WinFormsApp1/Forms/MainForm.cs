using System.Windows.Forms;
using System;
using System.Linq;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MoneyKeeper moneyKeeper;
        public string startType = string.Empty;
        public string endType = string.Empty;
        private MoneyCreator _moneyCreator = null;
        public MainForm()
        {
            moneyKeeper = new MoneyKeeper();
            _moneyCreator = new MoneyCreator(this);
            InitializeComponent();            
        }
        private void MoneyCalc_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Деньги: {moneyKeeper.Convert(startType, endType, double.Parse(moneyAmount.Text)):0.00}");
            }
            catch (FormatException)
            {
                MessageBox.Show($"Введите деньги правильно: '0,0'");
            }
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
        private void AddMoney_Click(object sender, EventArgs e)
        {
            _moneyCreator.Show();
            Hide();
        }

        private void globalBankBtn_Click(object sender, EventArgs e)
        {
            moneyKeeper.LoadBankValues();
            MessageBox.Show(moneyKeeper.ToString());
        }
    }
}
