using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class VehicleBase
    {
        /// <summary>
        /// a class “VehicleBase”, which has the following properties:
        /// public string Licenseplate
        /// public DateTime Date
        /// </summary>

        // protected class members can be inherited by child class
        protected string Licenseplate { get; set; }
        protected DateTime Date { get; set; }

        /// <summary>
        /// public constructor VehicleBase 
        /// </summary>
        public VehicleBase()
        {

        }

        /// <summary>
        /// method 
        /// public abstract double Price() 
        /// </summary>
        /// <returns>double Price</returns>
        public abstract double Price();

        /// <summary>
        /// method
        /// public abstract string VehicleType() 
        /// </summary>
        /// <returns>string VehicleType</returns>
        public abstract string VehicleType();
    }
}
