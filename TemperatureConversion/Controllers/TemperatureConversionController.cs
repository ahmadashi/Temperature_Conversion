using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TemperatureConversion.DLL.Convert;
using TemperatureConversion.ViewModel;

namespace TemperatureConversion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureConversionController : ControllerBase
    {        

        private readonly ILogger<TemperatureConversionController> _logger;
        ICelsiusConvert _celsiusConvert;
        IFahrenheitConvert _fahrenheitConvert;
        IKelvinConvert _kelvinConvert;
        public TemperatureConversionController(ILogger<TemperatureConversionController> logger,
            ICelsiusConvert celsiusConvert,
        IFahrenheitConvert fahrenheitConvert,
        IKelvinConvert kelvinConvert
        )
        {
            _logger = logger;
            _celsiusConvert = celsiusConvert;
            _fahrenheitConvert = fahrenheitConvert;
            _kelvinConvert = kelvinConvert;
        }


        /// <summary>
        /// end point for conversion not secuired 
        /// </summary>
        /// <param name="tempConversion"></param>
        /// <returns></returns>
        [Route("ConvertTemperature")]        
        public  ActionResult ConvertTemperature([FromBody] TempConversion tempConversion)
        {
            try
            {
                // to do : add more validation 
                // to do : move this to new end point (create secuired web API to perform the calculation, and just call it from here )
                if(tempConversion==null)
                {
                    _logger.LogError("Error: invalied input data");
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                switch(tempConversion.inputType)
                {
                    case "Celsius":
                        {
                            tempConversion.outputValue = convertFromCelsius(tempConversion);
                            break;
                        }
                    case "Fahrenheit":
                        {
                            tempConversion.outputValue = convertFromFahrenheit(tempConversion);
                            break;
                        }
                    case "Kelvin":
                        {
                            tempConversion.outputValue = convertFromKelvin(tempConversion);
                            break;
                        }
                    default:
                        {
                            _logger.LogError("Error: invalied input type");
                            return StatusCode(StatusCodes.Status500InternalServerError);
                        }

                }



                return  Ok(tempConversion);
            }
            
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// convert From Kelvin
        /// </summary>
        /// <param name="tempConversion"></param>
        /// <returns></returns>

        private double convertFromKelvin(TempConversion tempConversion)
        {
            switch (tempConversion.outputType)
            {
                case "Celsius":
                    return (_kelvinConvert.ConvertToCelsius(tempConversion.inputValue));                                       
                case "Fahrenheit":
                    return (_kelvinConvert.ConvertToFahrenheit(tempConversion.inputValue));                    
                default:
                    {
                        _logger.LogError("Error: invalied out type");
                        throw new Exception("Error: invalied out type");
                    }
            }
            
        }
        /// <summary>
        /// convert From Fahrenheit
        /// </summary>
        /// <param name="tempConversion"></param>
        /// <returns></returns>
        private double convertFromFahrenheit(TempConversion tempConversion)
        {
            switch (tempConversion.outputType)
            {
                case "Celsius":
                    return (_fahrenheitConvert.ConvertToCelsius(tempConversion.inputValue));
                case "Kelvin":
                    return (_fahrenheitConvert.ConvertToKelvin(tempConversion.inputValue));
                default:
                    {
                        _logger.LogError("Error: invalied out type");
                        throw new Exception("Error: invalied out type");
                    }
            }
        }

        /// <summary>
        /// convert From Celsius
        /// </summary>
        /// <param name="tempConversion"></param>
        /// <returns></returns>
        private double convertFromCelsius(TempConversion tempConversion)
        {
            switch (tempConversion.outputType)
            {
                case "Kelvin":
                    return (_celsiusConvert.ConvertToKelvin(tempConversion.inputValue));
                case "Fahrenheit":
                    return (_celsiusConvert.ConvertToFahrenheit(tempConversion.inputValue));
                default:
                    {
                        _logger.LogError("Error: invalied out type");
                        throw new Exception("Error: invalied out type");
                    }
            }
        }
    }
}
