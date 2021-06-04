using Moq;
using System;
using TemperatureConversion.DLL.Convert;
using Xunit;

namespace TemperatureConversion.DLL.Test.Unit
{
    public class FahrenheitConvertTest
    {
        
        private IFahrenheitConvert _fahrenheitConvert;
        public FahrenheitConvertTest()
        {
            _fahrenheitConvert = new FahrenheitConvert();
        }


        [Fact]
        public void ConvertToKelvinTest()
        {
            double outValue = _fahrenheitConvert.ConvertToKelvin(100);
            
            Assert.Equal(310.77778d, outValue, 5);


        }
        [Fact]
        public void ConvertToCelsiusTest()
        {
            double outValue = _fahrenheitConvert.ConvertToCelsius(100);

            Assert.Equal(37.77778d, outValue, 5);


        }
    }
}
