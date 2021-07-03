using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphonePrgram
{
    class Program
    {
        public static void Main()
        {
            Camera _camera = new Camera();
            GPS _gps = new GPS();
            Phone _phone = new Phone();
            SmartPhone _smartphone = new SmartPhone();
            _smartphone.Camera_ref_value(_camera);
            _smartphone.GPS_ref_value(_gps);
            _smartphone.Phone_ref_value(_phone);

            Photographer photographer = new Photographer();
            photographer.Capture(_smartphone);

            Traveller traveller = new Traveller();
            traveller.Hike(_smartphone);

            Person person = new Person();
            person.Communicate(_smartphone);
            
        }
    }

}
