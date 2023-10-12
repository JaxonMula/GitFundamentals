using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using HauntedHouse.Repository.Haunted_HouseRepository;
using HauntedHouse.Data.Utilities;
using System.Runtime.CompilerServices;
using HauntedHouse.Data.Entities;
using HauntedHouse.Data.Entities.ChallengeEntities;

namespace HauntedHouse.UI
{
    public class ProgramUI
    {
        private readonly HauntedHouseRepository _hauntedHouseRepo = new HauntedHouseRepository();
        private HauntedHouse.Repository.Haunted_HouseRepository.HauntedHouse _house;
        private int _challengeCounter;
        private bool IsRunning = true;
        public bool _hasMiddleRoomKey;
        public bool _hasPuzzlePiece;

        public ProgramUI()
        {
            SeedData();
            _house = _hauntedHouseRepo.GetHauntedHouse();
            
        }

        private void SeedData()
        {
            _hauntedHouseRepo.SeedData();
        }

        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            while (IsRunning){
                System.Console.WriteLine("Welcome to the Haunted House, Please make a selecttion:\n"+
                "1.Start Game\n"+
                "2. End Game\n");

                var userInput = ReadLine();
                switch(userInput)
                {
                    case "1":
                    StartGame();
                    break;
                    case "2":
                    IsRunning = CloseGame();
                    break;
                    default:
                    System.Console.WriteLine("Invalid Selection.");
                    break;

                }
            }
        }

        private bool CloseGame()
        {
            System.Console.WriteLine("Thanks for playing");
            PressAnyKeyToContinue();
            return false;
        }

        private void PressAnyKeyToContinue()
        {
            System.Console.WriteLine("Press any key to continue.");
            ReadKey();
        }

        private void StartGame()
        {
            Clear();

            while(!_house.Player.IsDead && IsRunning)
            {
                GameUtilities.TellTheStory($"You are a paranormal investigator,\nand you have been ordered to enter a haunted house on {_house.Address}"+
                                          $"You notice... Press any Key to Continue....");

                ReadKey();
                while(_hasMiddleRoomKey == false)
                {
                    LoadFirstChallenge();
                    
                }
                GameUtilitiest.TellTheStory("yOU USE THE LEY TO GO TO THE MIDDLE ROOM!!\n")
                GameUtilities.TellTheStory("You go up the stairs, your on the next floor!")

                while(_hasPuzzlePiece == false)
                {
                    LoadSecondChallenge();
                }
                LoadFinalChallenge();

                ReadKey();
            }
            if(_house.Player.IsDead)
            {
                IsRunning = CloseGame();
            }
        }

    

        private void LoadFinalChallenge()
        {
            Clear();
            ClearChallengeCounter();
            
            var currentChallenge = _house.FloorsInHouse[(int)ChallengesIndex.SecondChallenge].Challenges[_challengeCounter];
            GameUtilities.TellTheStory("You place the puzzle piece inside of a missing section of the puzzle\nDAEKNESS SURROUNDS YOU\n"+
            "A creepy man with pins in his head approaches, what will you do?\n"+
            "1.Shoot the Damn Demon!\n"+
            "2. Ask him what he wants\n"+
            "3. Try to escape\n");

            var userInput = ReadLine();
            switch(userInput)
            {
                case "1":
                ShootTheDamNDemon();
                break;

                case "2":
                AskWhatHeWants();
                break;

                case "3":
                TryToEscape();
                break;

                default:
                System.Console.WriteLine("Invalid selection, this can cost you your life");
                break;
            }
        }

        private void TryToEscape()
        {
            Clear();
            BossChallenge currentChallenge = (BossChallenge) _house.FloorsInHouse[1].Challenges[0];
            GameUtilities.TellTheStory("You tried to get away, fishhooks fly from noweher and attatch to you.\nTHEY RIP YOU APART!!"+
            "The man with pins in his head laughs, 'HA HA HA HA HA' ");
            
            currentChallenge.Boss!.Attack(_house.Player,1000,"Fish-Hooks of Destruction");
            _hasPuzzlePiece = false;

        }

        private void AskWhatHeWants()
        {
           Clear();
            BossChallenge currentChallenge = (BossChallenge) _house.FloorsInHouse[1].Challenges[0];
            GameUtilities.TellTheStory("You ask him what he wants.\nYOUR SOUL!\n"+
            "The man with pins in his head laughs, 'HA HA HA HA HA' ");
            
            currentChallenge.Boss!.Attack(_house.Player,1000,"Fish-Hooks of Destruction");
            _hasPuzzlePiece = false;
        }

        private void ShootTheDamNDemon()
        {
            Clear();
            BossChallenge currentChallenge = (BossChallenge) _house.FloorsInHouse[1].Challenges[0];
            GameUtilities.TellTheStory("You shoot the damn demon");
            _house.Player.ShootPlasmaPistol(currentChallenge.Boss!,50);
            while(currentChallenge.Boss.HealthPoints > 0)
            {
                GameUtilities.TellTheStory("Will you shoot again y/n")
                var userInput = ReadLine();
                if(userInput != "Y".ToLower())
                {
                    Clear();
                    GameUtilities.TellTheStory("You tried to get away, fishhooks fly from noweher and attatch to you.\nTHEY RIP YOU APART!!"+
            "The man with pins in his head laughs, 'HA HA HA HA HA' ");
            
            currentChallenge.Boss!.Attack(_house.Player,1000,"Fish-Hooks of Destruction");
                        _hasPuzzlePiece = false;

                }else
                {
                    _house.Player.ShootPlasmaPistol(currentChallenge.Boss,20);
                }
            }
            System.Console.WriteLine("You killed the demon with pins in his head!!!... or so you thought");
            IsRunning = CloseGame();

        }

        private void LoadSecondChallenge()
        {
            Clear();
            ClearChallengeCounter();
            var currentChallenge = _house.FloorsInHouse[(int)ChallengeIndex.FirstChallenge].Challenges[++_challengeCounter];
            GameUtilities.TellTheStory("There is a large puzzle in the middle of the hall");
            GameUtilities.TellTheStory(currentChallenge.ChallengeDescription);
            GameUtilities.TellTheStory("Which room will you select this time?\n"+
                                       "1. The Room down the hall and to the left?\n"+
                                       "1. The Rom down the hall and to the right?\n");

                var userInput= ReadLine();
                switch(userInput)
                {
                    case "1":
                    LoadTheRoomDownTheHall_ToTheLeft();
                    break;
                    case "2";
                    LoadTheRoomDownTheHall_ToTheRight();
                    break;
                    default:
                    System.Console.WriteLine("Invalid Selection");
                    break;
                }
            
        }

        private void LoadTheRoomDownTheHall_ToTheRight()
        {
            bool hasLeftRoom = false;
            while(!hasLeftRoom)
            {
                Clear();
                GameUtilities.TellTheStory("You entered the room. Its just a basic room.\nLets invesitage further...\n"+
                "1. Inside a coffee cup?\n"+
                "2. A shiny box (it looks like a puzzle box)\n"+
                "3. A dead body thats slumped over the fireplace.\n"+
                "4. Leave the room.");

                var userInput = ReadLine();

                switch(userInput)
                {
                    case "1":
                    Clear();
                    GameUtilities.TellTheStory("You look inside...Nothing");
                    PressAnyKeyToContinue();
                    break;

                    case "2":
                    Clear();
                    GameUtilities.TellTheStory("You rub the box... It reconfigures itself.. It looks like what we have been looking for!");
                    _hasPuzzlePiece = true;
                    hasLeftRoom = true;
                    PressAnyKeyToContinue();
                    break;

                    case "3":
                    Clear();
                    GameUtilities.TellTheStory("you move it around and its head falls off");
                    PressAnyKeyToContinue();
                    break;

                    case "4":
                     GameUtilities.TellTheStory("you exit the room");
                    PressAnyKeyToContinue();
                    hasLeftRoom = true;
                    LoadSecondChallenge();
                    break;

                    default:
                    System.Console.WriteLine("Invalid selction");
                    break;
                }

            }
        }

        private void LoadTheRoomDownTheHall_ToTheLeft()
        {
            bool hasLeftRoom = false;
            while(!hasLeftRoom)
            {
                Clear();
                GameUtilities.TellTheStory("You Entered the room. Its some sort of theater of lost souls, lets investigate further.\n"+
                "1.Inside the Broken Globe in the middle of the room\n"+
                "2. A random purse on the floor\n"+
                "3. A dead body that is stapled to the wall\n"+
                "4. Leave the room.");

                var userInput = ReadLine();
                switch (userInput)
                {
                    case "1":
                    Clear();
                    GameUtilities.TellTheStory("You look inside... Nothing");
                    PressAnyKeyToContinue();
                    break;

                    case "2":
                    Clear();
                    GameUtilities.TellTheStory("You look inside .. Random Stuff");
                    PressAnyKeyToContinue();
                    break;

                    case "3":
                    GameUtilities.TellTheStory("You move it around and... yuck its head falls off");
                    PressAnyKeyToContinue();
                    break;

                    case "4":
                    Clear();
                    GameUtilities.TellTheStory("You exit the room");
                    PressAnyKeyToContinue();
                    hasLeftRoom = true;
                    LoadSecondChallenge();
                    break;
                
                    default:
                    System.Console.WriteLine("Invalid Selection");
                    break;
                }
            }
        }

        private void ClearChallengeCounter()
        {
            _challengeCounter= 0;
        }

        private void LoadFirstChallenge()
        {
            Clear();

            var currentChallenge = _house.FloorsInHouse[(int)ChallengeIndex.FirstChallenge].Challenges[++_challengeCounter];

            GameUtilities.TellTheStory(currentChallenge.ChallengeDescription);
            GameUtilities.TellTheStory("Which Room will you select?\n"+
                                        "1. ROom on the left\n"+
                                        "2. Room on the Right\n");

                        var userInput = ReadLine();
                        switch(userInput)
                        {
                            case "1":
                            YouChoseTheLefttRoom();
                            break;
                            case "2":
                            YouChoseTheRightRoom();
                            break;
                            default
                            System.Console.WriteLine("Invalid Selection.");
                            break;
                                                    
                        }
        }

        private void YouChoseTheLefttRoom()
        {
            Clear();

            bool hasLeftRoom = false;
            while(!hasLeftRoom)
            {
                GameUtilities.TellTheStory("You enetered the left room\nIts the living room, and its a mess.\nBut lets investigate further.\nWhere do you want to look.\n"+
                                        "1. On the couch\n"+
                                        "2. On the Coffee Table\n"+
                                        "3. Inside the broken Televisio\n"+
                                        "4. Leave the room\n");

                var userInput = ReadLine();

                switch (userInput)
                {
                    case "1":
                    GameUtilities.TellTheStory("You check the couch...Nothing!");
                    PressAnyKeyToContinue();
                    break;
                    case "2":
                    GameUtilities.TellTheStory("You check the Coffee Table...Nothing! You take a look at the tv and see a shiny object");
                    PressAnyKeyToContinue();
                    break;
                    case "3":
                    GameUtilities.TellTheStory("You check the tv and find the middle room key!");
                    _hasMiddleRoomKey = true;
                    GameUtilities.TellTheStory("You Exit the room");
                    hasLeftRoom = true;
                    PressAnyKeyToContinue();
                    break;
                    case "4":
                    GameUtilities.TellTheStory("You exit the room!");
                    PressAnyKeyToContinue();
                    hasLeftRoom = true;
                    LoadFirstChallenge(0);
                    break;
                    default:
                    System.Console.WriteLinvRe("Invalid Selection");
            }

                }
        }

        private void YouChoseTheRightRoom()
        {
bool hasLeftRoom = false;
        while (!hasLeftRoom)
        {
            Clear();
            GameUtilities.TellTheStory("You Entered the Right Room. Its the Kitchen, and its a mess. But, lets investigate further. Where do you want to look?\n" +
            "1. In the Refrigerator\n" +
            "2. On top of the Kitchen Island\n" +
            "3. In the Lower Cabinets\n" +
            "4. Leave The Room");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    Clear();
                    GameUtilities.TellTheStory("You open the refrigerator door...NOTHING...");
                    PressAnyKeyToContinue();
                    break;
                case "2":
                    Clear();
                    GameUtilities.TellTheStory("You look on top of the Kitchen Island. Its completely covered with random stuff..");
                    PressAnyKeyToContinue();
                    break;
                case "3":
                    Clear();
                    GameUtilities.TellTheStory("You check the Lower Cabinets...Again Theres NOTHING...");
                    PressAnyKeyToContinue();
                    break;
                case "4":
                    Clear();
                    GameUtilities.TellTheStory("You Exit the Room.");
                    PressAnyKeyToContinue();
                    hasLeftRoom = true;
                    LoadFirstChallenge();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }        }
    }
}
}