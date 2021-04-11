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
        private MainForm mainMenu = null;
        public MoneyCreator(Form form)
        {
            mainMenu = form as MainForm;
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Hide();
            mainMenu.Show();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (moneyName.Text == string.Empty)
                {
                    MessageBox.Show($"Название пустое");
                    return;
                }

                var newMoney = new Money(double.Parse(amountPreOne.Text), moneyName.Text);
                mainMenu.moneyKeeper.moneys.Add(newMoney);
            }
            catch(FormatException)
            {
                MessageBox.Show($"Введите деньги правильно: '0,0'");
            }
        }
    }
}
