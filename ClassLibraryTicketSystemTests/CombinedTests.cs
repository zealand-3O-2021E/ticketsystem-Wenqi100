using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ClassLibraryTicketSystemTests
{
    [TestClass]
    public class CombinedTests
    {
        // Test of Price() method
        [DataTestMethod]
        [DynamicData(nameof(PriceMethodTestData), DynamicDataSourceType.Method)]
        public void PriceMethod_ForEachCoffeeSort_Test(VehicleBase vehicleBase, double expectedValue)
        {
            var actual = vehicleBase.Price();
            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> PriceMethodTestData()
        {
            yield return new object[] { new Car(), 240 };
            yield return new object[] { new MC(), 125 };
        }

        // Test of VehicleType() method
        /*
        [DataTestMethod]
        [DynamicData(nameof(VehicleTypeMethodTestData), DynamicDataSourceType.Method)]
        public void VehicleTypeMethodTestData(VehicleBase vehicleBase, string expectedValue)
        {
            var actual = vehicleBase.VehicleType();
            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> VehicleTypeMethodTestData()
        {
            yield return new object[] { new Car(), "Car" };
            yield return new object[] { new MC(), "MC" };
        }
        */
    }
}
