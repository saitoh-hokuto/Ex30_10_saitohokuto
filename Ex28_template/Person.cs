using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    internal class Person: Creature
    {
        public int _lifespan;
        public int _age;
        public int Age
        {
            get { return _age; }
        }
        public int LifeSpan
        {
            get { return _lifespan; }
        }

        public Person(int age, int lifespan, DateTime birthday, string name, float width, float height, float depth, float weight) : base(birthday, name, width, height, depth, weight)
        {
            _age = age;
            _lifespan = lifespan;
        }
    }
}
