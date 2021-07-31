using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }
        int Id { get; set; }

        public Person(string name, int id)
        {
            Name = name;
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
            return result.Name == Name &&  result.Id == Id;
        }

        public override int GetHashCode()
        {
            int result = Name.GetHashCode() + Id.GetHashCode();
            return result;
        }

    }
}
