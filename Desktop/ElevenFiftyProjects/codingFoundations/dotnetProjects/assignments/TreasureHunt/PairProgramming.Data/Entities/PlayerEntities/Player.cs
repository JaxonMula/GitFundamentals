using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using  PairProgramming.Data.Entities.EnemyEntities;
using PairProgramming.Data.Utilities;

namespace PairProgramming.Data.Entities.playerEntities
{
    public class Player
    {
        // public Player()
        // {
        //     //SetUpPlayerInitialization();
        // }

        public Player(string name)
        {
            this.Name = name;
            //SetUpPlayerInitialization();
            HealthPoints = 100;
        }
       
                public string Name {get; set;} = string.Empty;
        public int HealthPoints {get; set;}
        public bool IsDead 
        {
            get{
                return (HealthPoints <= 0) ? true: false;
            }
            
        }
        public List<InGameItem> Items;

          public void DecreasedHealth (int pointValue = 5)
        {
            if(HealthPoints >= 0)
            HealthPoints -=pointValue;
        }

      
    //   private void SetUpPlayerInitialization()
    // {
    //     Items = GameUtilities.InitializePlayerStartUpItems();
    //     Sword = Items[0];
    // }  

    private readonly InGameItem Sword;


        public void SwingSword(Monster monster, int attackPower = 35)
   {
    System.Console.WriteLine($"You attacked {monster.Name} with your sword");
    if (monster.HealthPoints > 0)
    {
    monster.DecreaseHealth(attackPower);
    }
   }
    }
}
