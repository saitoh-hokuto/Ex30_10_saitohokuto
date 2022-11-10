using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_template
{
    internal class Student : Person
    {
        public int _studentnumber;
        public int StudentNumber
        {
            get { return _studentnumber; }
        }
        public Student(int studentnumber, int age, int lifespan, DateTime birthday, string name, float width, float height, float depth, float weight) : base(age, lifespan, birthday, name, width, height, depth, weight)
        {
            _studentnumber = studentnumber;
        }
    }
}
