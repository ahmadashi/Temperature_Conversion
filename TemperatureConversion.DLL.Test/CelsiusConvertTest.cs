using System;
using TemperatureConversion.DLL.Convert;
using Xunit;

namespace TemperatureConversion.DLL.Test.Unit
{
    public class CelsiusConvertTest
    {
        private ICelsiusConvert _celsiusConvert;
        public CelsiusConvertTest()
        {


            _celsiusConvert = new CelsiusConvert();
        }


        [Fact]
        public void ConvertToFahrenheitTest()
        {
            double outValue = _celsiusConvert.ConvertToFahrenheit(100);
            
            Assert.Equal(212d, outValue, 5);


        }
        [Fact]
        public void ConvertToKelvinTest()
        {
            double outValue = _celsiusConvert.ConvertToKelvin(100);

            Assert.Equal(373, outValue, 2);


        }
    }
}
