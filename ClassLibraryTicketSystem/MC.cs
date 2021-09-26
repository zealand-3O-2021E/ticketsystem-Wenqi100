using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : VehicleBase
    {
        /// <summary>
        /// a class “MC”, which has the following properties:
        /// public string Licenseplate
        /// public DateTime Date
        /// </summary>

        /// Refactoring: properties have been moved to VehicleBase class
        //public string Licenseplate { get; set; }
        //public DateTime Date { get; set; }

        /// <summary>
        /// public constructor MC 
        /// </summary>
        public MC()
        {

        }

        /// <summary>
        /// method 
        /// public double Price() 
        /// </summary>
        /// <returns>double Price() = 125 as fixed price</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// method
        /// public string VehicleType() 
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
