//* Loops Challenges:

//todo: Bronze:
//todo: Write a for loop to print the numbers 500 through 525.
//todo: starting point i = 500; (initialization)
//todo: boolean expression i<=525 (the loop will run as long as this is TRUE)
//todo: it will increment up by one as long as bool value is TRUE

for(int i=500;i<=525;i++){
    System.Console.WriteLine(i);
}


System.Console.WriteLine("------------------------");
//todo: Silver:
//todo: Create a for loop to print the numbers from 0-100 by 5's.

for(int x=0;x<=100;x+=5){
    System.Console.WriteLine(x);
}



System.Console.WriteLine("------------------------");
//todo: Gold:
//todo: Create a for loop to print the numbers 1-100. 
//todo: If it's divisible by both 3 and 5, print 'FizzBuzz' otherwise print the number.
//todo: If the number is divisible by 3, print 'Fizz' instead of the number. 
//todo: If it's divisible by 5, print 'Buzz', instead of the number

for(int y=1;y<=100;y++)
{
    bool isDivisibleBy3 = (y%3 ==0);
    bool isDivisibleBy5 = (y%5 ==0);

    if( isDivisibleBy3 && isDivisibleBy5){
        System.Console.WriteLine("FizzBuzz");
    }
     else if (isDivisibleBy3)
    {
        Console.WriteLine("Fizz");
    }
    else if (isDivisibleBy5)
    {
    Console.WriteLine("Buzz");
    }
    else
    {
    Console.WriteLine(y);
    }
}