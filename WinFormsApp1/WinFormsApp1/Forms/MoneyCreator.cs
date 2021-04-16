using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MoneyCreator : Form
    {
        private MainForm _mainMenu = null;
        public MoneyCreator(Form form)
        {
            _mainMenu = form as MainForm;
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Hide();
            _mainMenu?.Show();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            double money = 0;
            if (moneyName.Text == string.Empty) {
                MessageBox.Show($"Название пустое");
                return;
            }

            if(double.TryParse(pricePerOnePaperText.Text, out money)) {
                _mainMenu.moneyKeeper.Create(moneyName.Text, money);
            }
            else {
                MessageBox.Show($"Введите деньги правильно: '0,0'");
            }
        }
    }
}
