using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Person
    {
        public string Name { get; set; }

        public string Message { get; set; }

        public Person(string name, string message)  
        {
            Name = name;
            Message = message;
        }

        public void Reply(object sender, AlarmEventArgs e)
        {
            if (sender is AlarmClock alarmClock)
                Console.WriteLine(
                    $"{Name}: Эй, {alarmClock.Name}! Уже {e.Time.ToShortTimeString()}, {Message}");
        }
    }
}
