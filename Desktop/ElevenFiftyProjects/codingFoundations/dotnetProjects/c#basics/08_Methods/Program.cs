using System.Linq;
using System;

//Methods

//these are usually in classes, but we will explore them here (functional programming)

//perfrom small modular tasks

//they can give us something back (return value)

//they can give us nothing back (void)


//?        1      2     3        4
//?     public void SayHello(string Name)
//?     {      
//?                   5
//?         Console.WriteLine(Name);
//?     }


//*1. Access Modifier (4 types) public (every class/assembly can use this), 
//*                             private (only used within "Object/Class" scope) 
//*                             internal (can only be accessed within the current assemblies "Classes")
//*                             protected (inherited Members have access to private values)


//*2 Return type -> what we are giving back after we perform som ework

//*3 Method Name -> what we call the method

//*4 Method Parameters -> this is the data that will be 'passed-into' the emethod
//*                       this could be a calculation that is being done to the data

//todo: Method Name + Parameters 'SayHello(string Name)' = Method Signature
//todo:                          'SayHello(string Name, int Age)  //different Method signature (compiler :))

//*5 Method Body -> So, where the 'work' of the "Method-Machine" will happen


//*This method only works if you pass in a variable container of type 'string'
void SayHello(string name)
{
    System.Console.WriteLine(name);
}

//Method in action
SayHello("Bill Esquire");
SayHello("Ted Theodore Rorgan");

//sometimes methods have no parameters
void Greeting()
{
    System.Console.WriteLine("Hello");
}

Greeting();
Greeting();
Greeting();
Greeting();

//* Add 2 int together -> 2 parameters (b/c we are scafolding this method)
int AddMe(int valueA, int valueB)
{
    int sum = valueA+valueB;
    return sum;
    //or
    //return valueA+valueB
    //both get same results
}

System.Console.WriteLine(AddMe(3,5));

//When we are using methods with return types, we can store them into a variable
//A VARIABLE IS NOTHING MORE THAN A CONTAINER -> A BOX THAT HOLDS STUFF

int sum = AddMe(10,2);

//so lets use this

System.Console.WriteLine(AddMe(sum,sum));

//subtraction

//? int SubtractMe(int valueA, int valueB)
//? (
//?     int sub = valueA-valueB;
//?     return sub;
//? )

//? System.Console.WriteLine(SubtractMe(10,20));

//? int sub = SubtractMe(20,10)




//? int SubtractMeDouble(double valueA, double valueB)
//? {
//?     return Convert.ToInt32(valueB-valueA);

//? }

//? System.Console.WriteLine(SubtractMeDouble(10.5,20,20.5));

//? //squared


//? double SquareMe(int value)
//? {
//?     return value* value;
//? }

//? System.Console.WriteLine(SquareMe(3));

//? System.Console.WriteLine(SquareMe(AddMe(sum,3)));


int CrazyMath_AddUs(params int[] values)
{
   //this is where we will start
   int grandTotal = 0;

   foreach(int value in values)
   {
    grandTotal +=value;
   }
   return grandTotal;

}

int grandTotal = CrazyMath_AddUs(100,1000,300,3,20,12,1400);
System.Console.WriteLine(grandTotal);

string[] availableGreetings = {
        "Hello",
        "Howdy",
        "Hola",
        "Yo",
        "Greetings"
    };
    string[] availableGreetings2 = {
        "Hello Johnny",
        "Howdy Mark",
        "Hola Mandy",
        "Yo Greg",
        "Greetings The Chosen"
    };
void GetRandomGreeting(string[] ThisCanBeAnyName)
{
    Random _random = new Random();

    int randomNumber = _random.Next(0,ThisCanBeAnyName.Length);

    string randomGreeting = ThisCanBeAnyName[randomNumber];

    System.Console.WriteLine($"{randomGreeting}");
}
GetRandomGreeting(availableGreetings);
GetRandomGreeting(availableGreetings2);