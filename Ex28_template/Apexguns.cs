using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    internal class Apexguns : Thing
    {
        public float _ammunitioncapacity;
        public float AmmunitionCapacity
        {
            get { return _ammunitioncapacity; }
        }

        public Apexguns(float ammunitioncapacity, string name, float width, float height, float depth, float weight) : base(name, width, height, depth, weight)
        {
            _ammunitioncapacity = ammunitioncapacity;
        }
    }
}