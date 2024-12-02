using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name { get; set; } //свойство
        public string LastName; //поле

        private int age;
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0 || value >150)
                    throw new ArgumentException();

                age = value;
            }
        }

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public Person() : this("John", "Doe", 15) { }

        public string FullName => Name + " " + LastName;
        public void PrintInfo() 
        {
            Console.WriteLine($"{FullName}, возраст: {age}");
        }
    }
}
