using Microsoft.AspNetCore.Mvc;
using dotnetcore_sample.Controllers;
using NUnit.Framework;

namespace dotnetcore_tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void About()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.About() as ViewResult;

          // Assert
          Assert.AreEqual("Your application description page.", result.ViewData["Message"]);
        }

        [Test]
        public void Contact()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.Contact() as ViewResult;

          // Assert
          Assert.AreEqual("Your contact page.", result.ViewData["Message"]);
        }
    }
}
