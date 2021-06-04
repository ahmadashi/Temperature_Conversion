using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.DLL.Convert
{
    public class KelvinConvert: IKelvinConvert
    {
        public double ConvertToCelsius(double inValue)
        {
            return (inValue - 273);            
        }

        public double ConvertToFahrenheit(double inValue)
        {
            return ((9 * (inValue - 273)) / 5 ) + 32;
        }
    }
}
 