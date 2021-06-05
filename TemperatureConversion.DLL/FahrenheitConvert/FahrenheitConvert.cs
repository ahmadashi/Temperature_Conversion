using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.DLL.Convert
{
    public class FahrenheitConvert: IFahrenheitConvert
    {
        /// <summary>
        /// 
        /// </summary>Convert from Fahrenheit To Kelvin
        /// <param name="inValue"></param>
        /// <returns></returns>
        public double ConvertToKelvin(double inValue)
        {
            return ((5 * (inValue - 32)) / 9) + 273;
            
        }

        /// <summary>
        /// 
        /// </summary>Convert from Fahrenheit To Celsius
        /// <param name="inValue"></param>
        /// <returns></returns>
        public double ConvertToCelsius(double inValue)
        {
            return (5 * (inValue - 32)) / 9;
        }
    }
}
