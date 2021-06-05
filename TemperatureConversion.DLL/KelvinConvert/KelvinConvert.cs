using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.DLL.Convert
{
    public class KelvinConvert: IKelvinConvert
    {
        /// <summary>
        /// Convert from Kelvin To Celsius
        /// </summary>
        /// <param name="inValue"></param>
        /// <returns></returns>
        public double ConvertToCelsius(double inValue)
        {
            return (inValue - 273);            
        }


        /// <summary>
        /// Convert from Kelvin To Fahrenheit
        /// </summary>
        /// <param name="inValue"></param>
        /// <returns></returns>
        public double ConvertToFahrenheit(double inValue)
        {
            return ((9 * (inValue - 273)) / 5 ) + 32;
        }
    }
}
 