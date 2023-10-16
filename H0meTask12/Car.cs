using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H0meTask12
{
    internal class Car
    {
        private double MileAge { get; set; }
        private double Fuel { get; set; }   
        private double FuelConsumption { get; set; }
        private double TankCapacity { get; set; }


        public Car(double fuel=20 , double fuelConsumption =40,double tankCapacity=10)
        {
                Fuel= fuel;
            FuelConsumption= fuelConsumption;
            TankCapacity= tankCapacity;

        }
    }
}
