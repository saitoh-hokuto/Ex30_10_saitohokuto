using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28_template
{
    internal class Machine: Thing
    {
        public float _boxw, _boxh, _boxd;
        public float _powerconsumption;
        public float PowerConsumption
        {
            get { return _powerconsumption; }
        }
        public float BoxWeight
        {
            get { return _boxw; }
        }
        public float BoxHeight
        {
            get { return _boxh; }
        }
        public float BoxDepth
        {
            get { return _boxd; }
        }
        public Machine(float powerconsumption, float boxw, float boxh, float boxd, string name, float weight, float width, float height, float depth) : base(name, weight, width, height, depth)
        {
            _powerconsumption = powerconsumption;
            _boxw = boxw;
            _boxh = boxh;
            _boxd = boxd;
        }
    }
}
