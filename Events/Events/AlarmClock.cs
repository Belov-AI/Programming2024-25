using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class AlarmEventArgs : EventArgs
    {
        public DateTime Time;
        public string Description;
    }

    public delegate void AlarmEventHandler(object sender, AlarmEventArgs e);

    public class AlarmClock
    {
        public string Name {  get; set; }

        public event AlarmEventHandler Ring;

        protected virtual void OnRing(AlarmEventArgs e) 
        {
            Console.WriteLine($"{e.Description}!!! Уже {e.Time.ToShortTimeString()}");

            if (Ring != null) 
                Ring(this, e);
        }

        public void RaiseRing(string description)
        { 
            var e = new AlarmEventArgs();
            e.Description = description;
            e.Time = DateTime.Now;

            OnRing(e);
        }
    }
}
