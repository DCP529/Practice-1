using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        public static List<Person> pers = new List<Person>();
        static void Main(string[] args)
        {

            Person person1 = new Person("Vova", 15_000, 1);
            Person person2 = new Person("Kostia", 15_000, 2);
            Person person3 = new Person("Nikita", 15_000, 4);
            Person person4 = new Person("Nikita", 15_000, 4);


            pers.AddRange(new Person[] { person1, person2 });
            Adds(person2);
            Adds(person3);

            bool result = person4.Equals(person2); 

            Console.ReadLine();

            //релизовать хранилище клиентов
            //имя счет id
            //при попытке добаления проверить его наличие в списке
        }

        public static void Adds(Person person)
        {
            if (!pers.Contains(person))
            {
                pers.Add(person); 
                Console.WriteLine("Добавление произошло успешно");
            }
            else
            {
                Console.WriteLine("Такой человек уже есть");
            }
        }
    }
}
