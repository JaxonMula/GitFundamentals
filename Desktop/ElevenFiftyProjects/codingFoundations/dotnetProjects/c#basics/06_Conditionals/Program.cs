//Conditionals

//anytime we want out application to do work based on a condition (true/false)

using System.ComponentModel;

bool isRaining = true;
bool isGoingOutside = false;

//if statements
//?formula


// if(boolean expression)
// {
//    so, if boolean evaluates to 'true' then this code block will run
// }


if(isRaining)
{
System.Console.WriteLine("better bring out an umbrella");
}

if(isRaining && isGoingOutside)
{
System.Console.WriteLine("better bring out an umbrella");
}