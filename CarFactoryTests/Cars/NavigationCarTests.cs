using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Interfaces;

namespace CarFactory.Cars.Tests
{
    [TestClass()]
    public class NavigationCarTests
    {

        [TestMethod()]
        public void NavigationCarPriceTest()
        {
            // Arrange
            NavigationCar carToTest = new NavigationCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual(carToTest.GetPrice(), 7000.00m);
        }
        [TestMethod()]
        public void NavigationCarTypeTest()
        {
            // Arrange
            NavigationCar carToTest = new NavigationCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual(carToTest.CarType, Cartypes.navigation);
        }
        [TestMethod()]
        public void NavigationCarSafteyRatingTest()
        {
            // Arrange
            NavigationCar carToTest = new NavigationCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual((int)carToTest.GetSafteyRating(), 5);
        }
        [TestMethod()]
        public void NavigationCarColorTest()
        {
            // Arrange
            NavigationCar carToTest = new NavigationCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual(carToTest.GetColor(), "red");
        }

    }
}