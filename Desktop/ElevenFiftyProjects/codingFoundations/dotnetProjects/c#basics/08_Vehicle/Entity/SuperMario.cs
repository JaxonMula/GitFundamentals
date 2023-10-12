using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_Vehicle.Entity
{
    public class SuperMario
    {
      public int Lives {get;set;} = 3;
      public int speed {get;set;} = 3.7f;
      public Powerup Powerup { get; set; }

      public void Powerup()
      {
        Random rnd = new Random();
        Thread.Sleep(500);
        int PowerupValue = rnd.Next(0,3);

        switch(PowerupValue)
        {
            case 1:
            System.Console.WriteLine("You activated the fireflower");
            break
            case 2;
            System.Console.WriteLine("You activated the Ice Flower");
            break;
            default:
            System.Console.WriteLine("You activated the Mushroom...Big...");
            break;
        }
        
        
      }
}
}