using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCompany
{
    public interface IBusPay
    {
        double TotalCost(int noOfPassengers, int noOfKilometers);
    }
}
