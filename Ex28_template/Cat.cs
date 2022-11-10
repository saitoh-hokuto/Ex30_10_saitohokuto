using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    internal class Cat : Creature
    {
        public string _cattype;
        public string CatType
        {
            get { return _cattype; }
        }
        public Cat(string cattype, DateTime birthday, string name, float width, float height, float depth, float weight) : base(birthday, name, width, height, depth, weight)
        {
            _cattype = cattype;
        }
    }
}