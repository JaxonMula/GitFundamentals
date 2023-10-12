using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairProgramming.Data.Entities.playerEntities
{
    public class InGameItem
    {
        public InGameItem()
        {

        }
        public InGameItem(string name)
        {
            Name = name;
        }

        
        public string Name {get; set;}
        
    }
}