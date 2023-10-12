using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//constructor -> what we use to "new-up" a version of the object
//"versions" -> called 'Overloads'

//syntax of a constructor (ctor is shortcut for this)

//*1. Access Modifier -> piblic, private, internal, protected
//*2. Name of the Type -> our Donut (in this case)
//*3. A pair of paranthesis that can contain parameters
//*4. The 'body' that executes the code.

namespace _08_Constructor
{
    public class Donuts
    {
        //Public field -> a variable that lives w/n a class
        public string? _donutType;

//        1       2       3 = these are the calues that the user will pass by

        public Donuts(string donutType)
        {
//            4 body      
           _donutType = donutType;      
        }
        
    }
}
