using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.DLL.Convert
{
    public interface IKelvinConvert
    {
        public double ConvertToCelsius(double inValue);
        public double ConvertToFahrenheit(double inValue);
        
    }
}
