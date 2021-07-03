using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphonePrgram
{
    public class Phone : IPhone
    {
        public void Hangup() { Console.WriteLine("Call is Connected"); }
        public void Release() { Console.WriteLine("Call is disConnected"); }

    }
}
