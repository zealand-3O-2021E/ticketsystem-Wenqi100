using System;

namespace ClassLibraryTicketSystem
{
    public class Car : VehicleBase
    {
        /// <summary>
        /// a class “Car”, which has the following properties:
        /// public string Licenseplate
        /// public DateTime Date
        /// </summary>

        /// Refactoring: properties have been moved to VehicleBase class
        //public string Licenseplate { get; set; }
        //public DateTime Date { get; set; }

        /// <summary>
        /// public constructor Car 
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// public constructor Car with arguments bool isBrobizzEnabled
        /// </summary>
        public Car(bool isBrobizzEnabled) : base(isBrobizzEnabled)
        {  
        }

        public Car(string plate) : base(plate)
        {
        }

        /// <summary>
        /// method 
        /// public double Price() 
        /// </summary>
        /// <returns>double Price() = 240 as fixed price</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// method
        /// public string VehicleType() 
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
