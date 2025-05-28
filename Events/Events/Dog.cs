using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Dog
    {
        public string Nickname { get; set; }

        public Dog(string nickname)
        {
            Nickname = nickname;
        }

        public void Bark(object sender, AlarmEventArgs e)
        {
            Console.WriteLine($"{Nickname}: Гав-гав!");
        }
    }
}
