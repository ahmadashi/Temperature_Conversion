using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.DLL.Convert
{
    public interface IFahrenheitConvert
    {
        public double ConvertToKelvin(double inValue);
        public double ConvertToCelsius(double inValue);
        
    }
}
