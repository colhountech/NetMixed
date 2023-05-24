using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// This is a netstandard2.0 class library
using Mixed.Models;

// this Controller is a .NET Framework 4.6.1 API Controller

namespace Mixed.NetFramework461.Web.Controllers
{
    public class WeatherForecastController : ApiController
    {
        private static readonly string[] Summaries = new[]
       {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        // GET api/values
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
           

            Random random = new Random();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                Temperature = random.Next(-20, 55),
                Summary = Summaries[random.Next(Summaries.Length)]
            })
            .ToArray();
        }

     
    }
}
