using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wrapper.INotify;

namespace Wrapper
{
    public class DecoratorNotify : INotify
    {
        protected INotify _notifier;

        public DecoratorNotify(INotify notifier)
        {
            _notifier = notifier;
        }

        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
}

