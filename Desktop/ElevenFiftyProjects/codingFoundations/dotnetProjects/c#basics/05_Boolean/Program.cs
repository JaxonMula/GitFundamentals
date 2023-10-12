bool isCool = false;
//later
isCool = true;

//todo: Booleans have logical operators

//And
//Or
//Not


//Not
isCool=!isCool;
System.Console.WriteLine(isCool);

 bool isTrue =! false; //true

bool isFalse=! true; //false


//and
bool trueAndExample = true && true; // true, both sides are true
bool falseAndExample = true && false; //resut is false because they both need to be true


//or
boll trueOrExample = true || false; result is true;
bool falseOrExample = false || true; result is true;


//todo:XDR Example

bool trueExclusiveOr= true ^ false;// true
bool falseExclusiveOr = true ^ true; //result is false
bool falseExclusiveOr2 = false ^ false; //result false

System.Console.WriteLine($"NOT FALSE = {isTrue}");
System.Console.WriteLine($"FALSE AND TRUE = {falseAndExample}");
System.Console.WriteLine($"TRUE OR TRUE = {trueorExample}");
System.Console.WriteLine($"TRUE XDR True = {falseExclusiveOr}");
System.Console.WriteLine($"FALSE XDR FALSE = {falseExclusiveOr2}");

System.Console.WriteLine(true ^ true);
System.Console.WriteLine(true ^ false);
System.Console.WriteLine(false ^ true);
System.Console.WriteLine(false ^ false);

//comparison operators

//equal
//declare that the values are equal

bool isGreaterThan = 10 >10;
bool isGreaterThanOrEqualTo = 10>=10;
System.Console.WriteLine($"10 >10 {isGreaterThan}, and 10>=10 is {isGreaterThanOrEqualTo}");

bool isLessThan = 5<5;
bool isLessThanOrEqualTo = 5<=5;
System.Console.WriteLine($"5< 5 is {isLessThan}, and 5<= 5 is {isLessThanOrEqualTo}");

bool equality = 17==19;
inr inequality = 17==19;
System.Console.WriteLine($"17== 19 is {equality}, and 17!= 19 is {inequality}");
