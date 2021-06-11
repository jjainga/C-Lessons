using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectMethods
{
    class Students
    {
        public string name;
        public string major;
        public double gpa;
        public Students(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors()
        {
            if(gpa >= 3.0)
            {
                return true;
            }
            return false;
        }
    }

}
