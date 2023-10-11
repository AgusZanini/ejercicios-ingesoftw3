using Microsoft.Extensions.Logging;
using NUnit.Framework;
using SimpleWebAPI.Controllers;
using System;
using System.Linq;

namespace SimpleWebAPI.Tests
{
    [TestFixture]
    public class WeatherForecastControllerTests
    {
        [Test]
        public void Get_ReturnsWeatherForecasts()
        {
            // Arrange
            ILogger<WeatherForecastController> logger = new LoggerFactory().CreateLogger<WeatherForecastController>();
            var controller = new WeatherForecastController(logger);

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(5, result.Count());
        }
    }
}