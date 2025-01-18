using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02_Q3
{
    internal interface INotificationService
    {
        public void SendNotification(string? Recipient, string? Message);
    }
}
