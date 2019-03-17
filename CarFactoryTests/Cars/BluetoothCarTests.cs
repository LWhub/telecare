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
    public class BluetoothCarTests
    {
        [TestMethod()]
        public void BluetoothCarPriceTest()
        {
            // Arrange
            BluetoothCar carToTest = new BluetoothCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual(carToTest.GetPrice(), 6000.00m);
        }
        [TestMethod()]
        public void BluetoothCarTypeTest()
        {
            // Arrange
            BluetoothCar carToTest = new BluetoothCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual(carToTest.CarType, Cartypes.bluetooth);
        }
        [TestMethod()]
        public void BluetoothCarSafteyRatingTest()
        {
            // Arrange
            BluetoothCar carToTest = new BluetoothCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual((int)carToTest.GetSafteyRating(), 4);
        }
        [TestMethod()]
        public void BluetoothCarColorTest()
        {
            // Arrange
            BluetoothCar carToTest = new BluetoothCar();

            // Act - nothing to act on testing the ctor

            // Assert
            Assert.AreEqual(carToTest.GetColor(), "black");
        }

    }
}