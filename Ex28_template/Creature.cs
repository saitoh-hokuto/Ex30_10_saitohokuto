using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    internal class Creature:Thing
    {
        readonly private string _name;
        readonly private DateTime _birthday = new DateTime();
        public DateTime BirthDay
        {
            get { return _birthday; }
        }
        public string Name
        {
            get { return _name; }
        }
        public bool GetTodayBirthDay()
        {
            if(BirthDay.Date == DateTime.Today.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Creature(DateTime birthday, string name, float width, float height, float depth, float weight) : base(name, weight, width, height, depth)
        {
            this._birthday = birthday;
            this._name = name;
        }
    }
}
