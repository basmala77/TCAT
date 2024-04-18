using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCat5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();

            EventHandler handler1 = () => Console.WriteLine("Handler1 created");
            EventHandler handler2 = () => Console.WriteLine("Handler2 created");

            eventManager.AddEvent(handler1);
            eventManager.AddEvent(handler2);

            eventManager.TriggerEvent();

            eventManager.RemoveEvent(handler2);

            eventManager.TriggerEvent();
            Console.ReadLine();
        }
    }
    public delegate void EventHandler();
    internal class EventManager
    {
        event EventHandler Handler;

        public void AddEvent(EventHandler handler) => Handler += handler;

        public void RemoveEvent(EventHandler handler1) => Handler -= handler1;
        internal void TriggerEvent() => Handler();
    }
}
