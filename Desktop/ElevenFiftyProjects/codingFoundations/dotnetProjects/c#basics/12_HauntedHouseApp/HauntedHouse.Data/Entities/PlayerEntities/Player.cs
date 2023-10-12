using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HauntedHouse.Data.Entities.EnemyEntities;
using HauntedHouse.Data.Utilities;

namespace HauntedHouse.Data.Entities.PlayerEntities
{
    public class Player
    {
        public Player()
        {
            SetUpPlayerInitialization();
        }

        public Player(string name)
        {
            Name = name;
            SetUpPlayerInitialization();
        }
        public int ID {get; set; }
        public string Name { get; set; } = string.Empty;
        public int HealthPoints {get; set;} = 100;
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

        public void IncreasedHealth(int pointValue =5)
        {
            if(HealthPoints > 0)
            HealthPoints += pointValue;
        }

        public void ShootPlasmaPistol(Enemy enemy, int attackPower = 15)
        {
            if(PlasmaPistol.IsUseable)
            {
                PlasmaPistol.TimesCanBeUsed--;
                System.Console.WriteLine($"You shot the Plasma Pistol at {enemy.Name}!\n"+
                $"You have {PlasmaPistol.TimesCanBeUsed} bullets left!");

                if (enemy.HealthPoints > 0)
                {
                    enemy.DecreasedHealth(attackPower);
                }
            }
            else
            {
                System.Console.WriteLine("Shoot I better find some bullets!");;
            }
        }

        public void LoadPlasmaPistol(int roundvalue)
        {
            PlasmaPistol.TimesCanBeUsed += roundvalue;
        }

        private InGameItem PlasmaPistol;
        private InGameItem Flashlight;
        private InGameItem Map;
        private InGameItem Knife;

        private void SetUpPlayerInitialization()
        {
            Items = GameUtilities.InitializePlayerStartUpItems();
            Knife = Items[0];
            Map = Items[1];
            Flashlight = Items[2];
            PlasmaPistol = Items[3];
        }



    }
}