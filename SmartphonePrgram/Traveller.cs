using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphonePrgram
{
    public class Traveller
    {
        public void Hike(IGPS gps)
        {
            gps.Navigate();
        }
    }
}
