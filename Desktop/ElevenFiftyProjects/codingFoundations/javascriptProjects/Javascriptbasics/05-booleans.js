//booleans -> true or false

/*
*           Data Type that defines:
            1.Yes/No
            2. on/off
            3. True/false
            4. 0 or 1
*/

let isLoggedIn = true;
let isAuthenticated = true;
let hasLoggedInToday = false;
let hasToken = false;

//Comparison Operators
//todo: comparison/relational operators evaluate booleans...

console.log(2 == '2'); //true -> loosely-strict comparison
console.log(2 === '2'); //false -> strict-comparison (values HAVE TO MATCH!!)

console.log("2(number)", typeof 2);
console.log("2(string)", typeof '2');

console.log(2 != 3);
console.log(2 !== '3');

console.log(5>5);
console.log(5>=5);

console.log(7<=8);
console.log(8<=8);

let test = 2>=3;
console.log("test:", test);

//* logical operators -> we will 'operands' that will be either 'true' or 'false'

let operandA = true;
let operandB = true;

//* Logical AND (&&), both have to be true to make the boolean true
//True && True = True
//False && False = false


//* Logical OR (||), one or the other has to be true to make the boolean true

//*Logical NOT (!) -> opposite (if true it will be switched to false and vice versa)
