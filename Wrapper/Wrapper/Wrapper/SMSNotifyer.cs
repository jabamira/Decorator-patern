using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrapper
{
    public class SMSNotifyer : DecoratorNotify
    {
        public SMSNotifyer(INotify notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"SMS отправлено: {message}");
        }
    }
}
