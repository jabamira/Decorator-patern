﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wrapper.INotify;

namespace Wrapper
{
    public class Notifyer : INotify

    {

        public void Send(string message)
        {
            Console.WriteLine($"Email отправлено: {message}");
        }
    }
}
