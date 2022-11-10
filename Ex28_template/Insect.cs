using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    class Insect : Creature
    {
        public bool _flyable;
        public bool Flyable
        {
            get { return _flyable; }
        }
        public Insect(bool flyable, DateTime birthday, string name, float width, float height, float depth, float weight) : base(birthday, name, width, height, depth, weight)
        {
            _flyable = flyable;
        }
    }
}