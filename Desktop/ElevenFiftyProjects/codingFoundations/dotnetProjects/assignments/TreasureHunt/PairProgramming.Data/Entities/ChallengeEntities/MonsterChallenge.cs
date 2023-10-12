using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PairProgramming.Data.Entities.EnemyEntities;

namespace PairProgramming.Data.Entities.challengeEntities
{
      public class MonsterChallenge : Challenge
    {
        public Monster ? monster {get; set;} = new Monster();
    }
}