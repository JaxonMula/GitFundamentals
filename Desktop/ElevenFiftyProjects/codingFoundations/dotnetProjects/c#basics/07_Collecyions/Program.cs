using System.Collections.Generic;
using System;
using System.Linq;




//Line 54
List <int> listOfIntegers = new List<int>();

//add allows us to add to our collection
listOfStrings.Add("Tj");
listOfStrings.Add("James");
listOfStrings.Add("Heb");

ListofIntegers.Add(455);

//lets access the list of strings
System.Console.WriteLine($"listOfStrings[0]: {listofStrings[0]}");

//remove -> this will remove an item from list
Int Tj = lustOfStrings.IndexOf("Tj"); //.IndexOf returns the index value

System.Console.WriteLine(Tj);

listOfStrings.Remove(listOfStrings.IndexOf("TJ"));

//removeALL() this will remove items from the list

List<string> stuff2 = new List<string>{
    "Item1".
    "Item2"
};

//AddRange allows us to add a list of things all at once
listOfStrings.AddRange(stuff2);
System.Console.WriteLine(listOfStrings);

;//System.Collection.Generic.List`1(System.String) => you have to iterae or loop through this object to see the data
foreach(string str in listOfStrings){
    System.Console.WriteLine(str);
};

listOfStrings.RemveAll(x => x.Contains("Item")); //.contains => returns true/false
System.Console.WriteLine(listOfStrings.Count()); //count displays how many items are in the collection

//remove Results:
foreach(string str in listOfStrings){
    System.Console.WriteLine(str);
};

//Queue <T>
//FIFO => First in first out
//whoever is first in line gets serviced first

//new Queue<string>() => we are constructing a new item in memory. storing it on the Heap
Queue<string> firstInFirstOut = new Queue<string>();

//add to eht queue => .Enqueue(value <T>) <T> means any type, Enqueue("string value")

firstInFirstOut.Enqueue("Im first");
firstInFirstOut.Enqueue("Im second");

//see whos next in line
string FirstIn = firstInFirstOut.Peek();
System.Console.WriteLine(FirstIn);

//to service whos in line we use the .Dequeue()
//get rid of the first one
firstInFirstOut.Dequeue();
System.Console.WriteLine("----------------------");
FirstIn = firstInFirstOut.Peek(); //"Im second"
System.Console.WriteLine(FirstIn);

//if ou use the .Peek() method make sure to check the collection count
//it does not account for zero,if no items in the collection it will "Blow up"
if(firstInFirstOut.Count() > 0)
{
    firstInFirstOut.Dequeue();
}else{
    System.Console.WriteLine("Sorry there are no items available");
};

//Dictionary<key,Value>
//cant hace the same 'key'
//when it comes to itterating or looping through a dictionary, we can constain them by 'key' or 'value'
Dictionary<int,string> keyAndValue = new Dictionary<int, string>();

//.add(key,value)
keyAndValue.Add(1,"Jaxon");
keyAndValue.Add(2,"Jerry");
//keyAndValue.Add (1,"Tj"); //Error; item with the sam ekey has already been added key:1

//Looping through with no constraints
foreach(KeyValuePair<int,string> values in keyAndValue)
{
    System.Console.WriteLine(values);
};

//looping through with 'key constraints'
foreach(int key in keyAndValue.Keys)
{
    System.Console.WriteLine(value); //this gives back the 'value of the key'
};

//looping through with value constraints
foreach(string value in keyAndValue.Values)
{
    System.Console.WriteLine(value); //this gives bacl the value of the values
};

string Jaxon = keyAndValue[1]; //access the values just like an array but passin the key
System.Console.WriteLine(terry);

//*Honrable Mentions:
SortedList<int,string> sortedKeyValuePair = new SortedList<int, string>();
HasSet<int> uniqueList = new HasSet<int>();
Stack<string> lastInFirstOut = new Stack<string>();

//and just to be random...

//random class -> based on cpw clock ticks

Random rnd = new Random();

//first number 5 is inclusive and the last number 20 is exclusive, so 5-19.
int number = rnd.Next(5,20);
System.Console.WriteLine(number);

