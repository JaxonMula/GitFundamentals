using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HauntedHouse.Data.Entities.ChallengeEntities;
using HauntedHouse.Data.Entities.PlayerEntities;

namespace HauntedHouse.Data.Entities.HouseEntities
{
    public class HauntedHouse
    {
        public HauntedHouse()
        {
            Name = "BooVille Farms";
            Address = "1357 Evil Lane";
            City = "MonsyerVille Indiana";
            Player = new Player ("Buddy");
        }
        public int ID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public Player Player { get; set; }
        public List<Floor> FloorsInHouse {get;set;} = new List<Floor>();

        public override string ToString()
        {
           var str = $"ID: {ID}\n"+
           $"Name: {Name}\n"+
           $"Address: {Address}\n"+
           $"City: {City}\n"+
           $"Player: {Player.Name}"+
           "----- Floors in House -----\n";

           foreach(Floor floor in FloorsInHouse)
           {
            str += $"FloorID: {floor.ID}\n"+
            $"Floor Nam: {floor.Name}\n"+
            "===== Floor Challenges =====\n";
            foreach(Challenge floorChallenge in floor.Challenges)
            {
                str += $"Floor Challenge ID: {floorChallenge.ID}\n"+
                $"Floor Challenge Description: {floorChallenge.ChallengeDescription}";
                foreach(string task in floorChallenge.ChallengeTasks)
                {
                    str+=$"{task}";
                }
                str += $"Floor Challenge Complete: {floorChallenge.IsComplete}";
            }
           }


           return str;

        }
    }
}