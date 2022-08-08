using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //these are objects created from the class 
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);


            //here we are calling upon a method created over on another file
            Console.WriteLine("Does " + student1.name + " have honors? " + student1.HasHonors());
            Console.WriteLine("Does " + student2.name + " have honors? " + student2.HasHonors());

            Console.ReadLine();
        }
    }
}