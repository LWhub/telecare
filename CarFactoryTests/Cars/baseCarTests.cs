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
    public class baseCarTests
    {
        [TestMethod()]
        public void baseCarPriceTest()
        {
            // Arrange
            baseCar carToTest = new baseCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual(carToTest.GetPrice(), 5000.00m);
        }
        [TestMethod()]
        public void baseCarTypeTest()
        {
            // Arrange
            baseCar carToTest = new baseCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual(carToTest.CarType, Cartypes.basecar);
        }
        [TestMethod()]
        public void baseCarSafteyRatingTest()
        {
            // Arrange
            baseCar carToTest = new baseCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual((int)carToTest.GetSafteyRating(), 3);
        }
        [TestMethod()]
        public void baseCarColorTest()
        {
            // Arrange
            baseCar carToTest = new baseCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual(carToTest.GetColor(), "white");
        }
    }
}