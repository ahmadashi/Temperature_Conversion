using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TemperatureConversion.ViewModel;

namespace TemperatureConversion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureConversionController : ControllerBase
    {        

        private readonly ILogger<TemperatureConversionController> _logger;

        public TemperatureConversionController(ILogger<TemperatureConversionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TempConversion> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new TempConversion
            {
                inputUnit = "C",
                inputValue = 105,
                OutputUnit = "F",
                OutputValue = 3550,
            })
            .ToArray();
        }
    }
}
