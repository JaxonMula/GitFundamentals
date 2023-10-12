//Numbers (JS Type) -> how we represent most kinds of numbers
// 'type' is the 'number' type.

//* They come in many forms, but its just a number

/*
`0,
1 -> positive number,
.99 -> decimal
-42 -> negative number
NaN -> NOT A NUMBER (THIS IS BAD)....
*/
// store some numbers in some variable...
let meaningOfLife = 42;
console.log(typeof meaningOfLife);

const indianaIncomeTaxRate = 0.0323;
console.log(typeof indianaIncomeTaxRate);


let powerLevel = 9001;
console.log(typeof powerLevel);

let southPoleTempF = -44;

let spaceStationCrewCount = 7;

const imNotANumber = NaN;

//Arithmec Operators
1+1         // Addition
12-10       // Subtraction
125*17      //Multiplication
125/4       //Division
10**2       //Exponential -> taking the first number and 'raising' its power
15%2        //Modulus -> get the remainder 

//* by default Numbers aren't super duper accurate...

console.log(0.1+0.2);  //0.30000000000000004

console.log(1.1 * 1.1); //1.2100000000000002

console.log(Math.floor(1.1*1.1)); //1

//Putting things together:

/*
    You are out after a dinner with friends in Indiana and the bill hits the table. It's a whopping $132.96. 
    Instead of waiting on everyone to fumble with their phones and open a calculator app (or the friend who might solve it on a napkin), 
    you decide you want to "flex" your newfound programming skills and show off to your friends. 
    Everyone decides to split the bill evenly after calculating tax. A quick survey of the table shows there are 4 people. 
    With the JavaScript lets write out a procedure that gives everyone the correct amount to contribute toward the bill.
*/


//* Identify the problem

//* Dinner in IN has a sales tac of: (0.07)

//*The total Bill 132.96

//*4 friends

// todo: lets code

//identify variables
let billAmount = 132.96

let totalPeople = 5

let salesTax = 0.07

//calculations
let taxAmount = billAmount * salesTax;

let grandTotal = taxAmount + billAmount

let individualContribution = grandTotal/totalPeople

//output
console.log(individualContribution); //$28.45344


