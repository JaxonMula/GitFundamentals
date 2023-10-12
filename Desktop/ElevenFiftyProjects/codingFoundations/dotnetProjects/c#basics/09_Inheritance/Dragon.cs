using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09_Inheritance
{
    public class Dragon : Animal
    {
        public Dragon()
        {
            hasFur = false;
            IsMammal = false;
            DietType = DietType.Carnivore;
            System.Console.WriteLine("This is the dragon constucrot");
        }
    }

     public class Wyrm : Dragon
     {
        public Wyrm()
        {
            NumberOfLegs = 0;
            System.Console.WriteLine("This is the MYRM Construcot");
        }
     }


public class Hydra : Dragon
{
    public Hydra(int headcount = 5)
    {
        HeadCount = headcount;
        System.Console.WriteLine("This is the Hydra Constrocuter");
    }
    public int HeadCount {get;set;}
    
}

public class IceDragon : Dragon
{
    public void ShootIce()
    {
        System.Console.WriteLine("I shoot fire");
    }
}

public class FireDragon : Dragon
{
public void ShootFire()
    {
        System.Console.WriteLine("I shoot fire");
    }
}

public class SuperDuperDragon : IceDragon, FireDragon
{
    
}
}
