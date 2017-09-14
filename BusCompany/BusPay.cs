using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCompany
{
    public class BusPay : IBusPay
    {
        public double TotalCost(int noOfPassengers, int noOfKilometers)
        {
            if (noOfKilometers < 100)
            {
                return (130 + (noOfKilometers * 3.2));
            }
            
            
            else if (noOfKilometers > 100 && noOfKilometers < 500)
            {
                if (noOfPassengers >= 12)
                {
                    return (130 + (3 * noOfKilometers));
                }
                
                return (130 + (2.75 * noOfKilometers));
            }
            else
            {
                return (130 + (2.25 * noOfKilometers));
            }
            





            
        }
    }
}
