Console.Clear();


//Bronze
// For this challenge go ahead and create a list of variables using the following 
//data types: int ,string ,bool ,decimal ,float ,double , and ulong (can only be positive) .
// For each of these types, do the following:
// Make at least two examples for each type
// Make one a declaration only
// Declare and initialize the other
// Once you have your variables, go ahead and print some of these values to the console.

int x = 25;
int p;
System.Console.WriteLine(x);

string str = "Example2";
string s;
System.Console.WriteLine(str);

bool isCool = true;
bool isCanadian;
System.Console.WriteLine(isCool);

decimal d = 2.546273m;
decimal dec;
System.Console.WriteLine(d);

float f = 3.5419f;
float flo;
System.Console.WriteLine(f);

double doub = 2.653426d;
double doubl;
System.Console.WriteLine(d);


//silver
// Concatenate two string variables. If you don't remember how to do that,
//check the Microsoft Docs here (Links to an external site.).
// Next, try to concatenate a number with a string as well and see what happens.
// Finally, print the results to the console.

int l = 5;
string name = "Jaxon's";
string color = "Green";

System.Console.WriteLine(color + " is " + name + " favorite color.");
System.Console.WriteLine(l + " is " + name + " favorite number");


//Gold
//Create an  variable to hold a year.
//ask the user to enter a string value that represents a year (whole number)
//The catch for this challenge is that you want to gather the value for the year as an int .
//Your task will be to research how to convert a string to an integer in C#.
// Once you have accomplished this, display the year in the console.

System.Console.WriteLine("Enter a year");

String yearStr = Console.ReadLine();

int yearInt = int.Parse(yearStr);

System.Console.WriteLine(yearInt);