using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    internal class Fish : Creature
    {
        public bool _eatable;
        public bool Eatable
        {
            get { return _eatable; }
        }
        public Fish(bool eatable, DateTime birthday, string name, float width, float height, float depth, float weight) : base(birthday, name, width, height, depth, weight)
        {
            _eatable = eatable;
        }
    }
}