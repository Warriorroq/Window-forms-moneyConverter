using System;
using System.Collections.Generic;
namespace WinFormsApp1
{
    public class MoneyKeeper
    {
        public List<Money> moneyTypes = new List<Money>();
        public BankParcer bank = new BankParcer();
        public MoneyKeeper()
        {
            LoadStandart();
        }
        public double Convert(string moneyType, string endType, double velue)
        {
            var moneyStart = Find(moneyType);
            var moneyEnd = Find(endType);
            return moneyStart.priceInGrn * velue / moneyEnd.priceInGrn;
        }
        private Money Find(string name)
        {
            foreach (var money in moneyTypes) {
                if (money.moneyName == name) {
                    return money;
                }
            }
            return new Money(1, string.Empty);
        }
        public void Create(string name, double price)
        {
           moneyTypes.Add(new Money(price, name));
        }
        private bool Contains(string name)
        {
            foreach (var money in moneyTypes) {
                if (money.moneyName == name) {
                    return true;
                }
            }
            return false;
        }
        public List<Money> BankParse()
        {
            var bankParse = bank.Parce();
            if(bankParse is null) {
                return null;
            }

            List<Money> moneys = new List<Money>();
            foreach (var moneyBank in bankParse) {
                var price = double.Parse(moneyBank.Item1.Replace('.', ','));
                moneys.Add(new Money(price, moneyBank.Item2));
            }
            return moneys;
        }
        public void LoadBankValues(List<Money> moneysBank)
        {
            moneyTypes.Clear();
            moneyTypes.Add(new Money(1, "UAH"));
            moneyTypes.AddRange(moneysBank);
        }
        private void LoadStandart()
        {
            moneyTypes.Add(new Money(0.36, "RUB"));
            moneyTypes.Add(new Money(1, "GRN"));
            moneyTypes.Add(new Money(27.88, "USD"));
            moneyTypes.Add(new Money(33.18, "EUR"));
        }
        public override string ToString()
        {
            string message = string.Empty;
            foreach(var money in moneyTypes) {
                message += $"{money.moneyName}: {money.priceInGrn} \n";
            }
            return message;
        }
    }
}
