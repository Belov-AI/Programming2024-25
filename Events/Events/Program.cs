using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alarmClock = new AlarmClock() { Name = "будильник" };

            var boy = new Person("Ваня", "OMG!");
            alarmClock.Ring += boy.Reply;

            var girl = new Person("Таня", "О как!");
            alarmClock.Ring += girl.Reply;

            var dog = new Dog("Шарик");
            alarmClock.Ring += dog.Bark;

            alarmClock.RaiseRing("Пора вставать");

            alarmClock.Ring -= boy.Reply;
            alarmClock.RaiseRing("Напоминаю");
        }
    }
}
