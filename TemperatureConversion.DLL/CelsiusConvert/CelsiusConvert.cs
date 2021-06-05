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
        /// <summary>
        /// Convert from  Celsius To Kelvin
        /// </summary>
        /// <param name="inValue"></param>
        /// <returns></returns>
        public double ConvertToKelvin(double inValue)
        {
            return (inValue + 273);            
        }
        /// <summary>
        /// Convert from  Celsius To Fahrenheit
        /// </summary>
        /// <param name="inValue"></param>
        /// <returns></returns>
        public double ConvertToFahrenheit(double inValue)
        {
            return ((9 * inValue) / 5) + 32;
        }
    }
}
