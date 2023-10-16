using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H0meTask12
{
    internal interface IRefuellable:IVehicle
    {
        public bool Refuel(double amount)
        {
            return true;
        }
    }
}
