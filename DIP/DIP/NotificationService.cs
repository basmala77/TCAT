using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class NotificationService
    {
        public readonly List<IMessageService> _messages;
        public NotificationService(List<IMessageService> messages)
        {
            _messages = messages;
        }

        public void Notify()
        {
            foreach (var message in _messages) { message.Send(); }
        }
    }
    class NotificationService1
    {
        // Property Injection
        public List<IMessageService> Services { get; private set; } = new List<IMessageService>();
        public void Notify()
        {
            foreach (var service in Services) { service.Send(); }
        }
        public void SetServices(List<IMessageService> services)
        { this.Services = services; }
    }
    class NotificationService2
    {
        //Method Injection
        public void Notify(List<IMessageService> services)
        {
            foreach (var service in services) { service.Send();}
        }
    }
}

