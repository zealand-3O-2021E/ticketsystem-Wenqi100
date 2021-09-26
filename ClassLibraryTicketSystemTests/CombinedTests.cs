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
        [DynamicData(nameof(When_Call_PriceMethod_ReturnFixedValue), DynamicDataSourceType.Method)]
        public void PriceMethod_ForEachVehicle_Test(VehicleBase vehicleBase, double expectedValue)
        {
            var actual = vehicleBase.Price();
            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> When_Call_PriceMethod_ReturnFixedValue()
        {
            yield return new object[] { new Car(), 240 };
            yield return new object[] { new MC(), 125 };
        }

        // Test of GetPriceByBrobizz(double discount) method
        [DataTestMethod]
        [DynamicData(nameof(When_Call_GetPrice_ByBrobizz_Return_Price), DynamicDataSourceType.Method)]
        public void PriceMethod_ByBrobizz_ForEachVehicle_Test(VehicleBase vehicleBase, double expectedValue)
        {
            var actual = vehicleBase.GetPriceByBrobizz(0.05);
            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> When_Call_GetPrice_ByBrobizz_Return_Price()
        {
            yield return new object[] { new Car(true), 240*(1-0.05)};
            yield return new object[] { new MC(false), 125 };
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

        // Test of IsLengthCorrect(string licenseplate) method
        /*
        [DataTestMethod]
        [DynamicData(nameof(LengthMethodTestData), DynamicDataSourceType.Method)]
        public void LengthMethodTestData(VehicleBase vehicleBase, bool expectedValue)
        {
            
            var actual = vehicleBase.IsLengthCorrect();
            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> LengthMethodTestData()
        {
            yield return new object[] { new Car(),  };
            yield return new object[] { new MC(), 125 };
        }
        */



    }
}
