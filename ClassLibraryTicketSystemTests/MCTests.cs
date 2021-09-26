using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        /// <summary>
        /// Test Method: WhenCallPriceMethodOfMC_Return240
        /// </summary>

        [TestMethod]
        public void WhenCallPriceMethodOfMC_Return125()
        {
            // Arrange
            MC mc = new MC();

            // Act and Assert
            var actual = mc.Price();
            Assert.AreEqual(125, actual);
        }


        /// <summary>
        /// Test Method: WhenCallVehicleMethodOfMC_ReturnStringCar
        /// </summary>
        [TestMethod]
        public void WhenCallVehicleMethodOfMC_ReturnStringMC()
        {
            // Arrange
            MC mc = new MC();

            // Act and Assert
            var actual = mc.VehicleType();
            Assert.AreEqual("MC", actual);
        }
    }
}