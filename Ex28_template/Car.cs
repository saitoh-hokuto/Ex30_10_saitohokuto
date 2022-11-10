using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    internal class Car : Thing
    {
        public float _fuelconsumption;
        public float FuelConsumption
        {
           get{ return _fuelconsumption; }
        }

        public Car(float fuelconsumption, string name, float width, float height, float depth, float weight) : base(name, width, height, depth, weight)
        {
             _fuelconsumption = fuelconsumption;
        }
    }
}
