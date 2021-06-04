using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.DLL.Convert
{
    public class CelsiusConvert: ICelsiusConvert
    {

        public CelsiusConvert()
        {
            
        }

        public double ConvertToKelvin(double inValue)
        {
            return (inValue + 273);            
        }

        public double ConvertToFahrenheit(double inValue)
        {
            return ((9 * inValue) / 5) + 32;
        }
    }
}
