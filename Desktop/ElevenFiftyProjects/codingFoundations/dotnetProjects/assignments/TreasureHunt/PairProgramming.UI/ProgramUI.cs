using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PairProgramming.Repository;



using static System.Console;
using CaveTreasureHunt.Repository.CaveRepository;
using PairProgramming.Data.Entities.CaveEntities;
using PairProgramming.Data.Utilities;
using System.Reflection.Metadata;
using PairProgramming.Data.Entities.Enums;
using PairProgramming.Data.Entities.EnemyEntities;
using PairProgramming.Data.Entities.challengeEntities;
using PairProgramming.Repository.MonsterRepo;
using PairProgramming.Repository.TrapRepository;

namespace PairProgramming.UI
{
    public class ProgramUI
    {

        private readonly CaveRepo _caveRepo = new CaveRepo();
        private readonly MonsterRepo _monsterRepo = new MonsterRepo();
        private readonly TrapRepo _trapRepo = new TrapRepo();

        private Cave _cave;
        private Monster _monster;
        private Trap _trap;

        private bool IsRunning = true;

        private int _challengeCounter;
        private bool _hasTreasureKey;


        public ProgramUI()
        {
            _cave = _caveRepo.GetCave();
            _monster = _monsterRepo.GetMonster();
        }
        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning && _cave.Player.IsDead == false) //infinite loop running the game
            {
                Clear();
                // ...Game code goes here
                System.Console.WriteLine("Welcome\n" +
                                        "1. Start Game\n" +
                                        "2. Exit App\n");
                string userInput = ReadLine()!;




                switch (userInput)
                {
                    case "1":

                        StartGame();
                        break;
                    case "2":
                        isRunning = ExitApplication();
                        break;
                    default:
                        WriteLine("Invalid Selection.");
                        break;
                }

            }
        }

        private void GetKeyFalse()
        {
            _hasTreasureKey = false;
        }

        private void StartGame()
        {
            Clear();
            GetKeyFalse();
            while (!_cave.Player.IsDead && IsRunning)

            {
                GameUtilities.TellTheStory($"You name is John and you're a Treasure Hunter,\nand you found a mysterious cave called {_cave.Name} to explore {_cave.Location}" +
                                          $"... Press any Key to Continue...");

                ReadKey();
                Clear();



                LoadIntro();

                string userInput = ReadLine()!;






                switch (userInput)
                {
                    case "1":
                        LoadChallengeOne();
                        break;

                    case "2":
                        LoadChallengeTwo();
                        break;

                    case "3":
                        LoadChallengeThree();
                        break;

                    default:
                        System.Console.WriteLine("Invalid Selection");
                        break;
                }



                ReadKey();
            }
        }
        private void LoadIntro()
        {

            GameUtilities.TellTheStory("You enter the cave and see three different tunnels.\n one to your left, one to your right, and one straight ahead.");

            GameUtilities.TellTheStory("Which room would you like to enter?\n" +
                                       " 1. Left\n" +
                                       " 2. Right\n" +
                                       " 3. Straight");
        }

        private void LoadChallengeTwo()
        {
            Clear();

            GameUtilities.TellTheStory($"You get ambused by a {_monster.Name} !!\n");
            _monster.AttackPlayer();
            _cave.Player.DecreasedHealth(20);

            GameUtilities.TellTheStory($"Fight {_monster.Name} !!\n" + "Press Key to Swing your Sword!");

            ReadKey();

            _cave.Player.SwingSword(_monster, 100);

            Clear();


            GameUtilities.TellTheStory($"You have {_cave.Player.HealthPoints} health left.");

            Clear();
            if (_cave.Player.HealthPoints <= 0)
            {
                IsDead();

            }
            else
            {

                GameUtilities.TellTheStory("ROOM 2: After you beat the Monster, you have the choice of going forward into in the only tunnel or going back.\n" +
                                             "1. Go Forward\n" +
                                             "2. Go Back");

                var userInput = ReadLine();
                switch (userInput)
                {
                    case "1":
                        LoadChallenge6();
                        break;
                    case "2":
                        StartGame();
                        break;
                    default:
                        WriteLine("Invalid Selection.");
                        break;
                }

            }
        }


        private void IsDead()
        {
            Clear();
            GameUtilities.TellTheStory("YOU DIED");
            // _cave = _caveRepo.GetCave();
            // _monster = _monsterRepo.GetMonster();
            // _hasTreasureKey = false;
            System.Console.WriteLine("Press any key to return to main menu");
            ReadKey();
            StartGame();

        }

        private void LoadChallenge6()
        {
            Clear();


            _cave.Player.DecreasedHealth(20);
            if (_cave.Player.HealthPoints <= 0)
            {
                IsDead();

            }
            else
            {

                GameUtilities.TellTheStory("There is a partially opened chest in this room");

                GameUtilities.TellTheStory($"You approach it to claim your treasure\n But its a mimic!\n It bites you and you lose health.\n You run into the fist tunnel you see.\n You have {_cave.Player.HealthPoints} health left." +

                                             "Press any key to continue");

                ReadKey();
                LoadChallenge5();
            }

        }

        private void LoadChallengeThree()
        {
            Clear();
            var currentChallenge = _cave.RoomsInCave[(int)ChallengesIndex.Room_3];


            GameUtilities.TellTheStory("You find a nice crystal clear pool in the middle of the room\nOn the other side is the only exit tunnel.");

            GameUtilities.TellTheStory("You swim across and progress forward?\n" +
                                         "Press any key to continue");
            ReadKey();
            LoadChallenge7();


        }

        private void LoadChallenge7()
        {
            Clear();
            var currentChallenge = _cave.RoomsInCave[(int)ChallengesIndex.Room_2];


            GameUtilities.TellTheStory("You entered the room and see two tunnels");

            //_cave.Player.SwingSword(, 50);


            GameUtilities.TellTheStory("Which tunnel do you choose\n" +
                                         "1.Right\n" +
                                         "2.Left\n");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    LoadChallenge8();
                    break;
                case "2":
                    LoadChallenge9();
                    break;
                default:
                    WriteLine("Invalid Selection.");
                    break;

            }
        }

        private void LoadChallenge9()
        {
            Clear();
            GameUtilities.TellTheStory($"You get ambused by a {_monster.Name} !!\n");
            _monster.AttackPlayer();
            _cave.Player.DecreasedHealth(20);

            GameUtilities.TellTheStory($"Fight {_monster.Name} !!\n" + "Press Key to Swing your Sword!");

            ReadKey();

            _cave.Player.SwingSword(_monster, 100);

            Clear();

            GameUtilities.TellTheStory($"You have {_cave.Player.HealthPoints} health left.");
             if (_cave.Player.HealthPoints <= 0)
            {
                IsDead();

            }
            else
            {


            GameUtilities.TellTheStory("You defeated the monster. There is only one more tunnel to go down?\n" +
                                         "Press any key to continue ");

            ReadKey();
            LoadChallenge11();
            }

        }

        private void LoadChallenge11()
        {
            Clear();


            GameUtilities.TellTheStory("You crawl your way to the deepest part of the cave and you start seeing glowing\n At the end of the tunnel you find a huge room with gold and at the end is a large treasure chest");
            if (_hasTreasureKey == true)
            {

                GameUtilities.TellTheStory("You use the treasure key to open the chest\nYou officially found Black Beard's treasure and are richer than you ever could have imaginedd\n" +
                                             "Press any key to retire from treasure hunting");


                ReadKey();
                ExitApplication();
                RunApplication();
            }
            else
            {
                GameUtilities.TellTheStory("You try to open the chest but you have no key!");
                GameUtilities.TellTheStory("Looks like you have to turn back");
                ReadKey();
                LoadChallenge7();
            }
        }

        private void LoadChallenge8()
        {
            Clear();
            var currentChallenge = _cave.RoomsInCave[(int)ChallengesIndex.Room_2];


            GameUtilities.TellTheStory("You notice a shiny object on a dead pirate.\nYou take a closer look and see a key!\n You decide to take it and find the treasure!");


            GameUtilities.TellTheStory("You hear growling ahead, but that tunnel is the only way to go further into the cave\n You have no other choice but to progress forward.\n" +
                                         "Press any key to continue");

            getTreasureKey();

            ReadKey();
            LoadChallenge9();


        }

        private void getTreasureKey()
        {
            _hasTreasureKey = true;
        }

        private void LoadChallengeOne()
        {
            Clear();
            var currentChallenge = _cave.RoomsInCave[(int)ChallengesIndex.Room_1];


            GameUtilities.TellTheStory("You are in the main Room");

            GameUtilities.TellTheStory("Which Tunnel will you select?\n" +
                                         "1. Tunnel on the Left\n" +
                                         "2. Tunnel on the Right\n" +
                                         "3. Turn Back");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    LoadChallenge4();
                    break;
                case "2":
                    LoadChallenge5();
                    break;

                case "3":
                    LoadIntro();
                    break;

                default:
                    WriteLine("Invalid Selection.");
                    break;
            }

        }

        private void LoadChallenge5()
        {
            Clear();
            var currentChallenge = _cave.RoomsInCave[(int)ChallengesIndex.Room_1];


            GameUtilities.TellTheStory("There's only one tunnel ahead");

            GameUtilities.TellTheStory("Proceed froward??\n" +
                                         "1. Go Fowrad\n" +
                                         "2. TurnBack\n");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    LoadChallenge10();
                    break;

                case "2":
                    LoadChallengeOne();
                    break;

                default:
                    WriteLine("Invalid Selection.");
                    break;
            }
        }

        private void LoadChallenge10()
        {
            Clear();

            _cave.Player.DecreasedHealth(10);



            GameUtilities.TellTheStory("The tunnel behind you collapses, but you get hit with some rocks!.");

            GameUtilities.TellTheStory("You see an old abandoned minecart. Looks like its your only option\n" +
                                         "Press any key to continue\n");

            GameUtilities.TellTheStory($"You have {_cave.Player.HealthPoints} health left.");
             if (_cave.Player.HealthPoints <= 0)
            {
                IsDead();

            }
            else
            {


            ReadKey();
            LoadChallengeThree();
            }
        }

        private void LoadChallenge4()
        {
            Clear();

            _cave.Player.DecreasedHealth(50);



            GameUtilities.TellTheStory("You fell into a Spike trap and lost 20 HP! You are forced to turn back to Room 1\n" +
                                        " Press any key to turn back");

            GameUtilities.TellTheStory($"You have {_cave.Player.HealthPoints} health left.");
             if (_cave.Player.HealthPoints <= 0)
            {
                IsDead();

            }
            else
            {

            ReadKey();
            LoadChallengeOne();
            }

        }

        private bool ExitApplication()
        {
            Clear();
            WriteLine("Thanks for playing! Press any key.");
            ReadKey();
            return true;
        }



    }



}
