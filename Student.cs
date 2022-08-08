using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningObjectMethods
{


    //this is a class that has been assigned properties
     class Student
    {
        public string name;
        public string major;
        public double gpa;



        // here is a constructor that we have created for this classes objects
        public Student(string aName, string aMajor, double GPA)
        {
            name = aName;
            major = aMajor;
            gpa = GPA;
        }


        //here we made a method to determine if one of the objects properties meets a certain critera and returns an answer
        public bool HasHonors()
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
