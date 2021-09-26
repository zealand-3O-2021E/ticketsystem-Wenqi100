using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC
    {
        /// <summary>
        /// a class “MC”, which has the following properties:
        /// public string Licenseplate
        /// public DateTime Date
        /// </summary>
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

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
        public double Price()
        {
            return 125;
        }

        /// <summary>
        /// method
        /// public string VehicleType() 
        /// </summary>
        /// <returns>"MC"</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
