using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09_Inheritance
{
    public class Cat : Animal
    {
        public Cat()
        {
            System.Console.WriteLine("This is the cat cinstructor");
            IsMammal = true;
            DietType = DietType.Carnivore;
        }

        public double ClawLength { get; set; }

       public virtual void MakeSound()
       {
        System.Console.WriteLine("Meow");
       }
       public override void Move()
       {
        base.Move();
        System.Console.WriteLine($"This {GetType().Name} moves quickly");
       }
    }

    public class TabbyCat : Cat
    {
        public TabbyCat()
        {
            System.Console.WriteLine("This is the tabby cat construcot");
        }
        public override void MakeSound()
        {
           //base.MakeSound(); // -> this allows us to have our parent  methods behavior 
         System.Console.WriteLine("Purr...");
        }
    }
}