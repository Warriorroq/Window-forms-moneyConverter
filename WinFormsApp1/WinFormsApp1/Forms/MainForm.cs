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
            double money = 0;

            if (double.TryParse(moneyAmount.Text, out money)) {
                MessageBox.Show($"Деньги: {moneyKeeper.Convert(startType, endType, double.Parse(moneyAmount.Text)):0.00}");
            }
            else {
                MessageBox.Show($"В вводе есть ошибки!");
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
            (sender as ComboBox)?.Items.AddRange(moneyKeeper.moneyTypes.Select(x => x.moneyName).ToArray());
        }
        private void AddMoney_Click(object sender, EventArgs e)
        {
            _moneyCreator.Show();
            Hide();
        }

        private void globalBankBtn_Click(object sender, EventArgs e)
        {
            var bankParse = moneyKeeper.BankParse();
            if(bankParse is null) {
                MessageBox.Show("Нет подключения");
                return;
            }

            moneyKeeper.LoadBankValues(bankParse);
            MessageBox.Show(moneyKeeper.ToString());
        }

        private void moneyAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.')) {
                e.KeyChar = ',';
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1)) {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }
        }
    }
}
