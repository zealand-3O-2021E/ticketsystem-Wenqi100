using System;

namespace ClassLibraryTicketSystem
{
    public class Car
    {
        /// <summary>
        /// a class “Car”, which has the following properties:
        /// public string Licenseplate
        /// public DateTime Date
        /// </summary>
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// public constructor Car 
        /// </summary>
        public Car()
        {

        }

        /// <summary>
        /// method 
        /// public double Price() 
        /// </summary>
        /// <returns>double Price() = 240 as fixed price</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// method
        /// public string VehicleType() 
        /// </summary>
        /// <returns>"Car"</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
