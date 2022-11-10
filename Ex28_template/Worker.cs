using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    internal class Worker : Person
    {
        public string _companyname;
        public string CompanyName
        {
            get { return _companyname; }
        }
        public Worker(string companyname, int age, int lifespan, DateTime birthday, string name, float width, float height, float depth, float weight) : base(age, lifespan, birthday, name, width, height, depth, weight)
        {
            _companyname = companyname;
        }
    }
}