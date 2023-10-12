//Operators

//adition(+)

//subtraction(-)

//multiplicaation(*)

//division(/)

//remainder [Modulus,Modulo] (%)

//unary Operators
//Ex: increment++ (counting up by one)
//Ex: increment-- (counting down by one)

//lets assume that we have a 'studentCount' variable container that holds 30 students;
int studentCount = 30;

//todo lets add one to the studentcount
//this addition happens after the fact -> add the value second
studentCount++;
System.Console.WriteLine(studentCount);

//so add the value first
++studentCount;
System.Console.WriteLine(studentCount);

//decriment
studentCount--;
--studentCount;



int addResult = 5+2;
System.Console.WriteLine("5+3 = "+addResult);

int subResult = 5-2;
System.Console.WriteLine("5-2 = "+subResult);

int multResult = 5*2;
System.Console.WriteLine("5*2 - "+multResult);

int divResult = 10/2;
System.Console.WriteLine("10/2 = "+divResult);

//modulus

Console.WriteLine(10%2);
Console.WriteLine(10%9);
Console.WriteLine(16%3);
Console.WriteLine(19%5);