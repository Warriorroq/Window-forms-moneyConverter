using System;
using System.Collections.Generic;
namespace WinFormsApp1
{
    public class MoneyKeeper
    {
        public List<Money> moneys = new List<Money>();
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
            foreach (var money in moneys)
                if (money.moneyName == name)
                    return money;
            return new Money(1, string.Empty);
        }
        private bool Contains(string name)
        {
            foreach (var money in moneys)
                if (money.moneyName == name)
                    return true;
            return false;
        }
        public void LoadBankValues()
        {
            var moneysBank = bank.Parce();
            moneys.Clear();
            moneys.Add(new Money(1, "GRN"));
            foreach (var moneyBank in moneysBank)
            {
                if(moneyBank.Item2 != "RUB")
                {
                    var price = double.Parse(moneyBank.Item1.Replace('.', ','));
                    moneys.Add(new Money(price, moneyBank.Item2));
                }
                else
                {
                    moneys.Add(new Money(0.36, "RUB"));
                }
            }
        }
        private void LoadStandart()
        {
            moneys.Add(new Money(0.36, "RUB"));
            moneys.Add(new Money(1, "GRN"));
            moneys.Add(new Money(27.88, "USD"));
            moneys.Add(new Money(33.18, "EUR"));
        }
        public override string ToString()
        {
            string message = string.Empty;
            foreach(var money in moneys)
                message += $"{money.moneyName}: {money.priceInGrn} \n";
            return message;
        }
    }
}
