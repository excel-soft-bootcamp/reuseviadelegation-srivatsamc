using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphonePrgram
{
    public class SmartPhone : ICamera, IGPS, IPhone
    {
        ICamera camera_ref;
        IGPS gps_ref;
        IPhone _phone_ref;

        public void Camera_ref_value(ICamera _camera)
        {
            this.camera_ref = _camera;
        }
        public void GPS_ref_value(IGPS _gps)
        {
            this.gps_ref = _gps;
        }
        public void Phone_ref_value(IPhone _phone)
        {
            this._phone_ref = _phone;
        }
        public void Click()
        {
            this.camera_ref.Click();
        }
        public void Hangup()
        {
            this._phone_ref.Hangup();
        }
        public void Release()
        {
            this._phone_ref.Release();
        }
        public void Navigate()
        {
            this.gps_ref.Navigate();
        }

    }
}
