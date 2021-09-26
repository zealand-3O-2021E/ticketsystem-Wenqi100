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

        // protected class members can be inherited by child class, but can't be see in the test project
        public string Licenseplate
        {
            get => Licenseplate;
            set
            {
                if (!IsLengthCorrect(Licenseplate))
                {
                    throw new ArgumentException("The length of Licenseplate can not longer than 7.");
                }
                Licenseplate = value;
            }
        }
        public DateTime Date { get; set; }

        /// <summary>
        /// protected bool field, isBrobizzEnabled;
        /// default value is false
        /// </summary>
        public readonly bool _isBrobizzEnabled;  // default value = false


        /// <summary>
        /// public constructor VehicleBase with no arguments
        /// </summary>
        public VehicleBase()
        {

        }


        /// <summary>
        /// public constructor VehicleBase with arguments string plate
        /// </summary>
        public VehicleBase(string plate)
        {
            this.Licenseplate = plate;
        }

        /// <summary>
        /// public constructor VehicleBase with arguments bool isBrobizzEnabled
        /// default value is false
        /// </summary>
        public VehicleBase(bool isBrobizzEnabled)
        {
            this._isBrobizzEnabled = isBrobizzEnabled;
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
        public bool IsLengthCorrect(string licenseplate)
        {
            return licenseplate.Length <=7? true : false;             
        }

        /// <summary>
        /// method
        /// public bool IsBrobizzUsed() 
        /// </summary>
        /// <returns>bool _isBrobizzEnabled</returns>

        public bool IsBrobizzUsed()
        {
            return _isBrobizzEnabled;
        }

        /// <summary>
        /// method
        /// public double GetPriceByBrobizz(double discount) 
        /// </summary>
        /// <returns>double priceWithBrobizz</returns>
        public double GetPriceByBrobizz(double discount)
        {
            if (IsBrobizzUsed() == true)
            {
                discount = 5.0 / 100;
                double priceWithBrobizz = Price() * (1.0 - discount);
                return priceWithBrobizz;
            }

            return Price();            
        }
    }
}
