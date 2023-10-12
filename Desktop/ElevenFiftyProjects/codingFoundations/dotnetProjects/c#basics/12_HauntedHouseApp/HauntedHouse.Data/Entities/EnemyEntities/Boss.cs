using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HauntedHouse.Data.Entities.EnemyEntities
{
    public class Boss : Enemy
    {
        public void AteRandomGhoul()
        {
            IncreasedHealth(20);
            System.Console.WriteLine($"{Name} just ate a random ghoul!\n" + $"Its health is now {HealthPoints}\n");
            
        }

    }
}