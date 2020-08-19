using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _440_DelegateChains
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify Event0ccured;
    }
    class EventListener
    {
        private string name;
        public EventListener(string name)
        { 
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappend : {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.Event0ccured += listener1.SomethingHappend;
            notifier.Event0ccured += listener2.SomethingHappend;
            notifier.Event0ccured += listener3.SomethingHappend;
            notifier.Event0ccured("You've got mail");

            Console.WriteLine();

            notifier.Event0ccured -= listener2.SomethingHappend;
            notifier.Event0ccured("download complete.");

            Console.WriteLine();

            notifier.Event0ccured = new Notify(listener2.SomethingHappend) + new Notify(listener3.SomethingHappend);
            notifier.Event0ccured("Nuclear launch detected.");

            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);

            notifier.Event0ccured = (Notify)Delegate.Combine(notify1, notify2);
            notifier.Event0ccured("Fire!!");

            Console.WriteLine();

            notifier.Event0ccured = (Notify)Delegate.Remove(notifier.Event0ccured, notify2);
            notifier.Event0ccured("RPG!");
        }
    }
}
