using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.DLL.Convert
{
    public interface ICelsiusConvert
    {
        public double ConvertToKelvin(double inValue);
        public double ConvertToFahrenheit(double inValue);
        
    }
} 
