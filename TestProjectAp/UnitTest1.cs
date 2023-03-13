using Microsoft.Extensions.Logging;
using NUnit.Framework;
using WebAppTest.Controllers;
using System.Linq;

namespace TestProjectAp
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
            var controller = new WeatherForecastController(_logger);
            var resultado = controller.Get();
            Assert.IsTrue(resultado != null);
            Assert.IsTrue(resultado.Any());
        }

        [Test]
        public void TestError()
        {
            var controller = new WeatherForecastController(_logger);
            var resultado = controller.Get();
            Assert.IsTrue(resultado != null);
            Assert.IsTrue(resultado.Any());
            Assert.IsTrue(resultado.Any(p => p.TemperatureC == 0));
        }
    }
}