//*value type behavior

/*

todo: let a=20;
todo: let b=a;
todo: 
todo: a=30;
todo: 
todo: console.log("a:",a);
todo: console.log("b:",b);
*/

//a and b are two independent variables

//a starts with the value of 20

//b is only a copy of a's value, whcih is 20 at line 4

//a is changed to 30 and b is still 20...

//* Reference type bahvior

let a = {someValue: 30};
let b= a;
a.someValue=200;
console.log(a);
console.log(b);
b.someValue = 800;
console.log(a);
console.log(b);
/*
    A
   AX1234 --------> 
                      AX1234
    B   ---------->  {value:10}
   AX1234
        **The both point to the same object in memory **
        ** If there are changes in either a or b they will be updated in BOTH variables **
*/

//**Primative types are copied by VALUE */

let numericValue = 40;

//we want to pass the value into a function

function incrementNumber(numericValue){
    //40 -> 41, this value only lives in the 'scope of these two '{}'
    numericValue;
}

incrementNumber(numericValue)
console.log(numericValue);


//**Object types are copied by REFERENCES */

let numericObject = {someValue: 30};
function incrementNumericObjectValue(obj){
    obj.someValue++;
}

//invoke method...
incrementNumericObjectValue(numericObject);
console.log(numericObject);