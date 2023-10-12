//C# Types 
Console.Clear();
//Variable Naming Conventions: 
// camel-cased : '(camelCased)'

//bool -> true/false
bool isLoggedIn = true;
System.Console.WriteLine(isLoggedIn);

//integers -> whole numbers
int age = 20;
System.Console.WriteLine(age);

int i = 0;                                            //32 bit value
short sh = 32767;                                     //16 bit value
Int16 anotherShortEx = 32000;                         //16 bit value
byte by = 255;                                        //a group of binary digits (usually eight) operated as a unit;




//decimal -> float (most precise)
//we need the 'suffix' of 'm' or 'M'
decimal accountBalance = 90_000m;
System.Console.WriteLine(accountBalance);


//string
string s = "hey!";
System.Console.WriteLine(s.Length);   //the string object itself has its own methods/properties  'Length' is a property for example

//char -> single character
char c = 'i';
System.Console.WriteLine(c);

string s2 = @"f:\tree";  //use the @ symbol to access/storing a directory (relative path)



decimal d = 99.9999999m;                             //'m' or 'M' at the end, 128 bit percision, 28-29 decimal places
double db = 7.800001d;                               // 'd' at the end (optional) [default], 15-16 digits after decimal

float f = 10.8f;                                     // 'f' at the end, half the size of a  double, the least percise

//dealing with decimals
//these values should truncate
System.Console.WriteLine(1.25878058705150144511210841f);
System.Console.WriteLine(1.25878058705150144511210841d);
System.Console.WriteLine(1.25878058705150144511210841m);



//DateTime
DateTime today = DateTime.Today;
System.Console.WriteLine(today);

DateTime birthday = new DateTime(1972,06,20);
System.Console.WriteLine(birthday);

//Enums -> types that are represented by numbers
//create an enum by right clicking on file you want it, hover over new C# and select enum

PastryType myPastry = PastryType.Cake;
PastryType AnotherOne = PastryType.Croissant;

System.Console.WriteLine("I like "+ myPastry + " and "+ AnotherOne); //concatenation