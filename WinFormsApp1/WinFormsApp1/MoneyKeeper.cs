using System;
using System.Collections.Generic;
namespace WinFormsApp1
{
    public class MoneyKeeper
    {
        public List<Money> moneys = new List<Money>();
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
        private void LoadStandart()
        {
            moneys.Add(new Money(0.36, "rub"));
            moneys.Add(new Money(1, "grn"));
            moneys.Add(new Money(27.88, "dollar"));
            moneys.Add(new Money(33.18, "euro"));
        }
    }
}
