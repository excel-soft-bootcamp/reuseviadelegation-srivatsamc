using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphonePrgram
{
    public class Camera : ICamera
    {
        public void Click() { Console.WriteLine("Captured through Camera"); }

    }
}
