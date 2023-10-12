using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Inheritance
//Minimize repeatec cide
//top-down representation of related data
//!We can only inherit from one object

namespace _09_Inheritance
{
    public abstract class Animal  //abstract keyword, hey this is the base class (cannot be newed up)
    {
        public Animal()
        {
            System.Console.WriteLine("This is an Animal constructor");
        }

        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool hasFur { get; set; }
        public DietType DietType {get;set;}



       //virtual keyword
       //allows us to create specific behavior for this class and
       //we can over-ride this method in any inheriting classes

       public virtual void Move()
       {
        System.Console.WriteLine($"This {GetType().Name} moves");
       }


    }
}