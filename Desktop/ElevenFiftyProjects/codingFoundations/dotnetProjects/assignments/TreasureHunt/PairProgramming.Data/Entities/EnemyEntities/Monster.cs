using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairProgramming.Data.Entities.EnemyEntities
{
    public class Monster :Enemy
    {
        public void AttackPlayer()
        {
            DecreaseHealth(20);
            System.Console.WriteLine($"{Name} just attacked you for 20 HP");
        }
    }
}