//loops 0 use these to repeat lines of code

//we can have a specific operation, function, and 'wrap' a loop around it

//while loops
//define a variable -> this is used for the while loops "boolean expression"

int number =0;

//while 'number' is less than or equal to 100, lets do something

while(number <= 100)
{
    //write to the console
    System.Console.WriteLine(number);
    number++;
}



//!infinite loops (OUR ENEMY)
//while(number ==0)
// {
//     System.Console.WriteLine("damn we stuck in this bitch fr fr");
// }



//we can control the behavior
int value2 =100;
while(value2>0)
{
value2--;
if (value2 ==90){
    System.Console.WriteLine("We are going to jump out of the loop");
    break;
}
if(value2 == 80)
{
    System.Console.WriteLine("we are gonna leav ethis loop");
    return;
}
if(value2 == 10)
{
    System.Console.WriteLine($"Lets just carry on with the loop. {value2}");
    continue;
}
System.Console.WriteLine($"value2: {value2}");
}




System.Console.WriteLine("==Do While==");

//do while
//runs atleast once
string valueString = "Hello";
do{
    System.Console.WriteLine($"Hello World {value2}");
    value2--;
}while (valueString=="101");