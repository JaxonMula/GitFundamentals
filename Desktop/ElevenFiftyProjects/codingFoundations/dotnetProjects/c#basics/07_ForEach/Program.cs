//foreach syntax

                               //IEnumerable (interface) -> all collection types cannot exist w/o this        
//foreach(declareIteratoro in enumerableCollection)
//{
//    body (code block)
//    
//}

//Ex:
string instructorName ="Amanda"; //now string are nothing but collections of (char)

//todo://iterating through instructorName
//todo:foreach (char c in instructorName)
//todo:{
//todo:    System.Console.WriteLine(c);
//todo:}


string[] instructors = new string[]{
    "Michael",
    "Joshua",
    instructorName
};

foreach(string instructor in instructors)
{
    System.Console.WriteLine(instructor);
}


//how to do the same thing with a for loop
for (int i=0; i<instructors.Length;i++)
{
    System.Console.WriteLine(instructors[i]);
}


int[] intArray = new int[]
{
    1,
    2,
    -3,
    4,
    5,
    0
};

// int [] myArray = new int[3]; //sets the intiial value

foreach(int number in intArray)//{
//     if(number<0)
//     System.Console.WriteLine($"This i a negative number. {number}");
//     else if (number>0)
//     System.Console.WriteLine($"This is a positive number. {number}");
//     else
//     System.Console.WriteLine($"This is a neutral number {number}");
// }

switch(number)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    System.Console.WriteLine($"This is a positive number. {number}");
    break
    case -3:
    System.Console.WriteLine($"This is a negative number. {number}");
    break
    default:
    System.Console.WriteLine($"This is a neutral number. {number}");
    break'

}
}