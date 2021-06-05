using System;
using TemperatureConversion.DLL.Convert;
using Xunit;

namespace TemperatureConversion.DLL.Test.Unit
{
    public class KelvinConvertTest
    {
        private IKelvinConvert _kelvinConvert;
        public KelvinConvertTest()
        {


            _kelvinConvert = new KelvinConvert();
        }


        [Fact]
        public void ConvertToFahrenheitTest()
        {
            double outValue = _kelvinConvert.ConvertToFahrenheit(100);
            
            Assert.Equal(-279.4d, outValue, 5);


        }
        [Fact]
        public void ConvertToCelsiusTest()
        {
            double outValue = _kelvinConvert.ConvertToCelsius(100);

            Assert.Equal(-173, outValue, 5);


        }
    }
}
