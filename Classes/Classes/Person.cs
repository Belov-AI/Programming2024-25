using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;
        public string LastName;
        private int age;

        public void SetAge(int age)
        {
            if (age < 0 || age > 150)
                throw new ArgumentException();
            
            this.age = age;
        }
        public void PrintInfo() 
        {
            Console.WriteLine($"{Name} {LastName}, возраст: {age}");
        }
    }
}
