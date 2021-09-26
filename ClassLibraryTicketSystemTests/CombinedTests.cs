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
        // Test1 of Task2+3+4: Price() method
        [DataTestMethod]
        [DynamicData(nameof(When_Call_PriceMethod_ReturnFixedValue), DynamicDataSourceType.Method)]
        public void PriceMethod_ForEachVehicle(VehicleBase vehicleBase, double expectedValue)
        {
            var actual = vehicleBase.Price();
            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> When_Call_PriceMethod_ReturnFixedValue()
        {
            yield return new object[] { new Car(), 240 };
            yield return new object[] { new MC(), 125 };
        }

        // Test2 of Task2+3+4: VehicleType() method
        [DataTestMethod]
        [DynamicData(nameof(When_Call_VehicleTypeMethod_ReturnVehicleType), DynamicDataSourceType.Method)]
        public void VehicleTypeMethod_ForEachVehicle(VehicleBase vehicleBase, string expectedValue)
        {
            var actual = vehicleBase.VehicleType();
            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> When_Call_VehicleTypeMethod_ReturnVehicleType()
        {
            yield return new object[] { new Car(), "Car" };
            yield return new object[] { new MC(), "MC" };
        }

        // Test3 of Task5: IsLengthCorrect(string licenseplate) method
        //*** Don't know it is correct or not!
        [DataTestMethod]
        [DynamicData(nameof(When_Call_IsLengthCorrect_Return_TrueOrFalse), DynamicDataSourceType.Method)]
        public void LengthMethod_ForEachVehicle(VehicleBase vehicleBase, bool expectedValue)
        {
            var actual = vehicleBase.IsLengthCorrect(vehicleBase.Licenseplate);
            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> When_Call_IsLengthCorrect_Return_TrueOrFalse()
        {
            yield return new object[] { new Car("DK123456"), false};
            yield return new object[] { new Car("12345"), false };
            yield return new object[] { new MC("1234567"), true};
        }

        // Test4 of Task6: GetPriceByBrobizz(double discount) method
        [DataTestMethod]
        [DynamicData(nameof(When_Call_GetPrice_ByBrobizz_Return_Price), DynamicDataSourceType.Method)]
        public void PriceMethod_ByBrobizz_ForEachVehicle(VehicleBase vehicleBase, double expectedValue)
        {
            var actual = vehicleBase.GetPriceByBrobizz(0.05);
            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> When_Call_GetPrice_ByBrobizz_Return_Price()
        {
            yield return new object[] { new Car(true), 240 * (1 - 0.05) };
            yield return new object[] { new MC(false), 125 };
        }

    }
}
