using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.DLL.Convert
{
    public class FahrenheitConvert: IFahrenheitConvert
    {
        public double ConvertToKelvin(double inValue)
        {
            return ((5 * (inValue - 32)) / 9) + 273;
            
        }

        public double ConvertToCelsius(double inValue)
        {
            return (5 * (inValue - 32)) / 9;
        }
    }
}
