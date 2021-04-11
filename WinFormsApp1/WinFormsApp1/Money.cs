using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public struct Money
    {
        public double priceInGrn;
        public string moneyName;
        public Money(double priceInGrn, string moneyName)
        {
            this.priceInGrn = priceInGrn;
            this.moneyName = moneyName;
        }
        public override string ToString()
        {
            return moneyName;
        }
    }
}
