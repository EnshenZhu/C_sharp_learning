using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_methods
{
    internal class Students
    {
        public string name;
        public string major;
        public double gpa;
        public Students(string aName,string Major, double aGpa) // constructor
        {
            name = aName;
            major = Major;  
            gpa = aGpa;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
