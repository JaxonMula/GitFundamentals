using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09_Inheritance
{
    public class Sloth : Animal
    {
        System.Console.WriteLine("This is the sloth constructor");
        public bool IsSlow //read only property
   {
    get{
        return true;
    }

   }
       public override Move()
       {
        System.Console.WriteLine("The sloth moves slowly");
       }
    
    }
   
    public class Megatherium Sloth
    {
        public Megatherium()
        {
            System.Console.WriteLine("This sloth is extinct");
        }
        public ovveride void Move()
        {
            System.Console.WriteLine("Megatherium uses move! its not super effective...");
        }
    }
}