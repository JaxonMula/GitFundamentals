//* Operators -> Tells the JS INterpreter what mathematical or logica loperations is being performed

console.log(5+5);
console.log(6-6);
console.log(7*7);
console.log(7/7);
console.log(2**3);

console.log(10%9);

let x=5;
let y=2;
let z=7;

console.log(x,y,x);

//Compairson Operators

//List of Comparison Operators

/*
    '==' Equality
    '===' Strict-Equality
    '!=' Inequality
    '>' greater than
    '<' Less than
    '>=.
    '<'
    */

    //Example
    let numberTwo = 2;
    let two = '2';
    console.log(numberTwo == two); //true. not checking for type
    console.log(numberTwo === two); //false equality and type are not the same

    //*Inequality operator -> if the trwo values are different, then it will return true
    let name = "Paul";
    let age = 30;
    console.log(name != age); //print true

    //*More examples
    /*
    2 == '2' -> returns true => This checks for equality, not type
    2 == '1' -> returns falsse => This checks for equality, not type
    2 === '2' -> returns false => Equality is the same, but the type is different
    2 === 2 -> returns true => Equality and type is the same

    'Password12!!' === 'Password12!!' ->returns true => Equality qnd the type are the same

    */

    //*Shorthand operators

    let count =2;
    count = count +1;
    console.log(count);

    //or we could...
    count+=1 // we are just adding one to the count
    console.log(count);

    //or we could also...
    count++; // we are just adding one to count, but AFTER THE FACT
    //or
    ++count //before any computation we will add one to count... BEFORE THE FACT

    /*  operator     Example           Equivalent
*     +=         a += b             a = a+b;        
*     -=         a -= b             a = a-b;        
*     *=         a *= b             a = a*b;        
*     /=         a /= b             a = a/b;        
*     %=         a %= b             a = a%b;        
*/


let value = 5;
value = value +1; //6
value +=1; //7
console.log(value); //print 7

let addMe=10;
console.log(`AddMe: ${addMe}`); //10
addMe+=1; //11
console.log(`AddMe: ${addMe}`); //11

let a=20;
a-=1; //20-1 = 19
console.log(a);

let b = 25;
b*=2; //50

console.log(b); //50

let c = 50;
c/=2;
console.log(c);

let someAge = 40;
someAge+=1; //41
someAge-=20; //21
someAge*=20 //420
console.log(someAge);

console.log(2>1);
console.log(3<2);

let test = 2>=3;
console.log(test);

//concatinating a string to print out a value
console.log("Is two greater than one? " + (2>1));

console.log(3>=1);
