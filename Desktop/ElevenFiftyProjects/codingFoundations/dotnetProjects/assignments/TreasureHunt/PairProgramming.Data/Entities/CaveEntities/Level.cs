using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PairProgramming.Data.Entities.challengeEntities;

namespace PairProgramming.Data.Entities.CaveEntities
{
    public class Level
    {
        public int ID { get; set; }
        public string Name {get; set;} = string.Empty;
        public List<Challenge> Challenges {get; set;} = new List<Challenge>();
    }
}