using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    class Thing
    {
        readonly public string _name;
        public float _weight;
        public float _width;
        public float _height;
        public float _depth;
        public string Name
        {
            get { return _name; }
        }
        public float Weight
        {
            get { return _weight; }
        }
        public float Width
        {
            get { return _width; }
        }
        public float Height
        {
            get { return _height; }
        }
        public float Depth
        {
            get { return _depth; }
        }
        public Thing(string name = "", float width = 0, float height = 0, float depth = 0, float weight = 0)
        {
            this._name = name;
            this._weight = weight;
            this._width = width;
            this._height = height;
            this._depth = depth;
        }
    }
}
