using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using PairProgramming.Data.Entities.CaveEntities;
using PairProgramming.Data.Entities.challengeEntities;
using PairProgramming.Data.Entities.playerEntities;

namespace PairProgramming.Data.Utilities
{
    public class GameUtilities
    {

        public static void TellTheStory(string storySection)
        {
            System.Console.WriteLine(storySection);
        }
        public static List<InGameItem> InitializePlayerStartUpItems()
        {
            List<InGameItem> playerStartingItems = new List<InGameItem>();
             return playerStartingItems;
        }



        public static void DisplayCaveChallengeInfo(PairProgramming.Data.Entities.CaveEntities.Cave _cave)
        {
            foreach (Room room in _cave.RoomsInCave)
            {
                foreach(Challenge Challenge in room.Challenges)
                {
                    System.Console.WriteLine(Challenge.ChallengeDescription);
                }
            }
        }
    }



}