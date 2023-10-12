using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//todo: This is a "HAS A" relationship
//todo: This is a CONTRACT 
//todo: I don't care wha you do, just impletment the contract
//todo: Interfaces are always public

namespace _10_Interfaces.Fruits
{
    public interface IFruit
    {
        string Name {get;} // we only want this to be read only
        bool IsPeeled {get;}
        string Peel();        

    }
}