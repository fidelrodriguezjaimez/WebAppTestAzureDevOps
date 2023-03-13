using Microsoft.Extensions.Logging;
using NUnit.Framework;
using WebApp.Controllers;
using System.Linq;

namespace TestProject
{
    public class Tests
    {
        private readonly ILogger<WeatherForecastController> _logger;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSucces()
        {
            var controler = new WeatherForecastController(_logger);
            var resultado = controler.Get();
            Assert.IsNotNull(resultado, "Objeto nulo");
            Assert.IsTrue(resultado.Any(), "Sin elementos");
            Assert.Pass();
        }

        [Test]
        public void TestError()
        {
            var controler = new WeatherForecastController(_logger);
            var resultado = controler.Get();
            Assert.IsNotNull(resultado, "Objeto nulo");
            Assert.IsTrue(resultado.Any(), "Sin elementos");
            Assert.IsTrue(resultado.Any(p => p.TemperatureC == 0), "Temperatura cero");
            Assert.Pass();
        }
    }
}