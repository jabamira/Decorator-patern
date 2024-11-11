using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wrapper.INotify;

namespace Wrapper
{
    public class FacebookNotifyer : DecoratorNotify
    {
        public FacebookNotifyer(INotify notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Facebook сообщение отправлено: {message}");
        }
    }
}
