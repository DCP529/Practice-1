using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Account
    {
        decimal Money { get; set; }
        Currency CurrencyType { get; set; }

        public Account(decimal money, Currency currencyType)
        {
            Money = money;
            CurrencyType = currencyType;
        }
    }
}
