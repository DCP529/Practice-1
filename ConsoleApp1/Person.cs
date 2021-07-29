using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        string Name { get; set; }
        decimal Dollar { get; set; }
        int Id { get; set; }

        public Person(string name, decimal dollar, int id)
        {
            Name = name;
            Dollar = dollar;
            Id = id;
        }

        public override bool Equals(object obj)
        {
            Person result = (Person)obj;
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Person))
            {
                return false;
            }
            return result.Name == Name && result.Dollar == Dollar && result.Id == Id;
        }        

    }
}
