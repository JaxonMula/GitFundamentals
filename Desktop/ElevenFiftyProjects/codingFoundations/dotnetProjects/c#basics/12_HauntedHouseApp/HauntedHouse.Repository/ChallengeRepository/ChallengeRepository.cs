using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HauntedHouse.Data.Entities.ChallengeEntities;
using HauntedHouse.Repository.Boss_Repository;

namespace HauntedHouse.Repository.ChallengeRepository
{
    public class ChallengeRepository
    {
        //* give challenge repository access tot bossRepository
        private readonly BossRepository _hHouseBossRepo = new BossRepository();

        //fake db
        private readonly List<Challenge> _hHouseChallengeDb = new List<Challenge>();

        int _count = 0;

        public ChallengeRepository()
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
                _hHouseChallengeDb.Add(challenge);
                return true;
            }
        }

        //Read all data in db
        public List<Challenge> GetChallenges()
        {
            return _hHouseChallengeDb;
        }

        public Challenge GetChallenge(int challengeID)
        {
               //todo: MY 3 OPTIONS
            ///SQL LINK QUERY SYNTAX (OPTIONAL)
            // return (from challenge in _hHouseChallengeDb
            // where challenge.ID == challengeID
            // select challenge).FirstOrDefault!;

           // return _hHouseChallengeDb.FirstOrDefault(challenge=> challenge.ID == challengeID)!;

           foreach (var challenge in _hHouseChallengeDb)
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
            var floor1 = new FloorChallenge
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
            var floor2 = new FloorChallenge
            {
                ID =2,
                ChallengeDescription = "Find the missing puzzle piece and put it back in its place\n",
                ChallengeTasks = new List<string>
                {
                    "Find the missing puzzle piece\n",
                    "Put it back in its place\n"
                }

            };
            var floor3 = new FloorChallenge
            {
                ID =3,
                ChallengeDescription = "Defeat the Demon with Pins in his Head!!\n",
                ChallengeTasks = new List<string>
                {
                    "Defeat the Demon with Pins in his Head!!\n"
                }

            };

            //add these to the deatabase
            _hHouseChallengeDb.Add(floor1);
            _hHouseChallengeDb.Add(floor2);
            _hHouseChallengeDb.Add(floor3);
        }
    }
}