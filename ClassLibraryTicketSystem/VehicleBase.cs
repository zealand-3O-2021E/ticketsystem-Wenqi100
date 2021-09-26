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
        protected string Licenseplate
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
        protected DateTime Date { get; set; }

        /// <summary>
        /// protected bool field, isBrobizzEnabled;
        /// default value is false
        /// </summary>
        protected readonly bool _isBrobizzEnabled;  // default value = false


        /// <summary>
        /// public constructor VehicleBase with no arguments
        /// </summary>
        public VehicleBase()
        {

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
