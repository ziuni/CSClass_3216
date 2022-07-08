using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass_3216
{
    internal class Student
    {
        public string name;
        public int grade;

        public override string ToString()
        {
            return this.name + " : " + this.grade;
        }
    }
}
