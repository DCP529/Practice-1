using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Иван", 1);
            var account1 = new Account(150, new Rub());

            var person2 = new Person("Алексей", 2);
            var account2 = new Account(100, new Ua());

            var person3 = new Person("Генадий", 3);
            var account3 = new Account(200, new Rub());

            Dictionary<Person, Account> persons = new Dictionary<Person, Account>()
            {
                { person1, account1},
                { person2, account2},
                { person3, account3}
            };

            var convert = Converter(15_000, new Rub(), new Ua());

            Console.ReadLine();

        }
        public static decimal Converter(decimal money, Currency currencyType1, Currency currencyType2)
        {

            var result = (money / currencyType1.Price) * currencyType2.Price;

            return result;
        }
    }
}
