using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    internal class Refrigerator : Machine
    {
        public float _capacity;
        public float Capacity
        {
            get { return _capacity; }
        }

        public Refrigerator(float capacity, float powerconsumption, float boxw, float boxh, float boxd, string name, float width, float height, float depth, float weight) : base(powerconsumption, boxw, boxh, boxd, name, width, height, depth, weight)
        {
            _capacity = capacity;
        }
    }
}
