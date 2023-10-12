using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PairProgramming.Data.Entities.challengeEntities;
using PairProgramming.Data.Entities.EnemyEntities;

namespace PairProgramming.Repository.ChallengeRepository
{
    public class ChallengeRepo
    {
        private readonly Monster _caveMonsterDb = new Monster();

        private readonly List<Challenge> _caveChallengeDb = new List<Challenge>();

        int _count = 0;

        public ChallengeRepo()
        {
            SeedChallenges();
        }

        //Create

        public bool AddChallenge (Challenge challenge)
        {
            if (challenge is null)
            {
                return false;
            }
            else
            {
                _count++;
                challenge.ID = _count;
                _caveChallengeDb.Add(challenge);
                return true;
            }
        }

        public List<Challenge> GetChallenges()
        {
            return _caveChallengeDb;
        }

        public Challenge GetChallenge(int challengeID)
        {
               


           foreach (var challenge in _caveChallengeDb)
           {
            if (challenge.ID == challengeID)
            return challenge;
            else
            return null!;
           }
           return null!;
        }



        private void SeedChallenges()
        {
            var room1 = new MonsterChallenge
            {
                ID =1,
                ChallengeDescription = 
                "There are three rooms\n"+
                "The Left and Right ones are unlocked\n"+
                "Find the middle room key\n",
                ChallengeTasks = new List<string>
                {
                    "Find Middle Room Key\n"
                }

            };
            var room2 = new MonsterChallenge
            {
                ID =2,
                ChallengeDescription = "Find the missing puzzle piece and put it back in its place\n",
                ChallengeTasks = new List<string>
                {
                    "Find the missing puzzle piece\n",
                    "Put it back in its place\n"
                }

            };
            var room3 = new MonsterChallenge
            {
                ID =3,
                ChallengeDescription = "Defeat the Demon with Pins in his Head!!\n",
                ChallengeTasks = new List<string>
                {
                    "Defeat the Demon with Pins in his Head!!\n"
                }

            };

            //add these to the deatabase
            _caveChallengeDb.Add(room1);
            _caveChallengeDb.Add(room2);
            _caveChallengeDb.Add(room3);
        }
    }
    }
