using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using PairProgramming.Data.Entities;
using static System.Console;
namespace PairProgramming.Repository.ProjectItemRepository
{
    public class ProjectItemRepo
    {
        //fake database:
        List<ProjectItem> projectItemDb = new List<ProjectItem>();

        int _counter = 0;


        public bool AddProjectItem(ProjectItem item)
        {
            if(item ==null)
            {
                return false;
            }
            else
            {
                _counter++;
                item.Id = _counter;
                projectItemDb.Add(item);
                return true;
            }
            
        }
    }
}