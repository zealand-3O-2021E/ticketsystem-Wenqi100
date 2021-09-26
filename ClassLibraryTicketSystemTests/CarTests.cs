using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ClassLibraryTicketSystem;
using System.Runtime.ConstrainedExecution;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        // Arrange
        //Mock mock = new Mock<Car>();       

        /// <summary>
        /// Test Method: WhenCallPriceMethod_Return240
        /// </summary>

        [TestMethod]
        public void WhenCallPriceMethod_Return240()
        {
            // Arrange
            Car car = new Car();

            //var mock = new Mock<Car>();
            //var car = mock.Object;

            // Act and Assert
            var actual = car.Price();
            Assert.AreEqual(240, actual);
        }


        /// <summary>
        /// Test Method: WhenCallVehicleMethod_ReturnStringCar
        /// </summary>
        [TestMethod]
        public void WhenCallVehicleMethod_ReturnStringCar()
        {
            // Arrange
            Car car = new Car();

            // Act and Assert
            var actual = car.VehicleType();
            Assert.AreEqual("Car", actual);
        }
    }
}