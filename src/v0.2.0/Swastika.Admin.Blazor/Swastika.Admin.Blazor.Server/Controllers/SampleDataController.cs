using Swastika.Admin.Blazor.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swastika.Admin.Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }


        [HttpGet("[action]")]
        public IEnumerable<Product> Products()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Product
            {
                id = rng.Next(-20, 55),
                priority = rng.Next(-20, 55),
                code = rng.Next(-20, 55),
                createdDateTime = DateTime.Now.AddDays(index),
                title = "ABC",
                image = "images...",
                imageUrl = "imageUrl...",
                createdBy = "Huy Nguyen...",
                detailsUrl = "detailsUrl..."
            });
        }
    }
}
