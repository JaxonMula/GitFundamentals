using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PairProgramming.Data.Entities.EnemyEntities;

namespace PairProgramming.Repository.MonsterRepo
{
    public class MonsterRepo
    {
         //*We need our 'fake database'
        public List<Monster> _caveMonsterDb = new List<Monster>();

        public int _count = 0;

        public MonsterRepo()
        {
            SeedMonster();
        }
        //helper methods for our create method
        private void AssignId(Monster boss)
        {
            _count++;
            boss.ID = _count;
        }

        private bool SaveToDatabase (Monster monster)
        {
            AssignId(monster);
            _caveMonsterDb.Add(monster);
            return true;
        }

        public bool AddMonser (Monster monster)
        {
        return (monster is null) ? false: SaveToDatabase(monster);
        }

        public Monster GetMonster()
        {
            return _caveMonsterDb.FirstOrDefault()!;
        }
         public Monster GetMonster(int id)
        {
            return _caveMonsterDb.SingleOrDefault(x => x.ID == id)!;
        }



        private void SeedMonster()
        {
            var monster = new Monster
            {
                ID = 1,
                Name = "Skeleton"
            };
            _caveMonsterDb.Add(monster);
        }
    }
    }
