using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PairProgramming.Repository.ProjectItemRepository;
using static System.Console;

namespace PairProgramming.UI
{
    public class ProgramUI
    {
      private readonly ProjectItemRepo _projRepo= new ProjectItemRepo();


        //always have this steup from 12-21
        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while(isRunning);
            {
                //Game code goes here!! Like stuff that shows on the console
                System.Console.WriteLine("Welcome\n"+
                                         "1. Add Prohject Item\n"+
                                         "2. Exit App\n");
                string userInput = Console.ReadLine()!;

                switch(userInput)
                {
                    case "1":
                    AddProjectItem();
                    break;

                    case "2":
                    isRunning = ExitApplication();
                    break;
                    
                    default:
                    System.Console.WriteLine("Invalid Selction!");
                    break;
                }

            }
        }

        

        private void AddProjectItem()
        {

            //probably dont need this
            Console.Clear();

            var proItem = new Data.Entities.ProjectItem();

            System.Console.WriteLine("==Add Project item ==");
            System.Console.WriteLine("Please input project item name:");

            string userInputName = Console.ReadLine()!;

             proItem.Name =  userInputName;

            if(_projRepo.AddProjectItem(proItem))
            System.Console.WriteLine("Success!");
            else
            System.Console.WriteLine("Fail");

            System.Console.WriteLine("Press any key to continue");


            Console.ReadKey();
        }
         private bool ExitApplication()
        {
            Console.Clear();
            System.Console.WriteLine("Thanks for playing! Pressany key");
            Console.ReadKey();
            return false;
        }
    }
}