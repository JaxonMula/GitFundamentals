// S3 ways to make a string
//1 Concatination
//2 composite formatting
//3 Interpolation


//todo: concatination

string first = "The cars we sell are";
string second = " BMV Lexus, and Mercedes";

string concatinatedResult = first + second;
System.Console.WriteLine(concatinatedResult);

//composite formatting
string firstName = "John";
string lastName = "Smith";

string compositeResult = string.Format("Her name is {0} {1}", firstName, lastName;
System.Console.WriteLine(compositeResult);

//Inerpolation is the most popular one
string InterpolationResult = $"Her name is still {firstName} [lastName]";
System.Console.WriteLine(InterpolationResult);