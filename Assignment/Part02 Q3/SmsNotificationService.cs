using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02_Q3
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string? Recipient, string? Message)
        {
            Console.WriteLine($"From Your SMS: {Message}");
        }
    }
}
