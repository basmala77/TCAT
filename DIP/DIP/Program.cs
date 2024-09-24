using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = Repo.customers;
            foreach (var customer in customers)
            {
                var messageService = new List<IMessageService>
                {
                   new EmailService { EmailAddress = customer.EmailAddress},
                   new SMSService { MobileNo = customer.MobileNo}
                };
                //constructor injection
                var notificationService = new NotificationService(messageService);
                notificationService.Notify();

                // property injection
                var notificationService1 = new NotificationService1();
                notificationService1.SetServices(messageService);
                //notificationService1.Notify();


                // method injection
                var notificationService2 = new NotificationService2();
                notificationService2.Notify(messageService);
            }
            Console.ReadLine();  
        }
    }
}
