using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_Interfaces.Fruits
{
    public class Banana : IFruit
    {
        public Banana(){}

        public Banana(bool isPeeled)
        {
           this.IsPeeled = isPeeled;
        }
       // public string Name  => "Banana";
       public string Name
         {get
         {
             return"Banana";
        }}

        public bool IsPeeled { get; private set;}

        public string FruitClasses()
        {
            throw new NotImplementedException();
        }

        public string Peel()
        {
            IsPeeled = true;
            return "You Peel the Banana";
        }
    }


public class Orange: IFruit
{
    public FruitClasses(){}
    public FruitClasses(bool isPeeled)
    {
        
       IsPeeled = isPeeled;
    }
    public bool IsPeeled {get; private set;}
    public string Name => "Orange";

        public string FruitClasses()
        {
            throw new NotImplementedException();
        }

        public string Peel()
    {
        IsPeeled = true;
        return "You Peeled the Orange.";
    }
    public string Squeeze()
    {
        return "you squeeed the orange and juice came out.";
    }
}

    public class Grape : IFruit
    {
        public string Name => "Grape";

        public bool IsPeeled => false;

        public string Peel()
        {
            return "Who Peels grapes.";
        }
    }
}



