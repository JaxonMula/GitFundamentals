//* Return keyword

/*
           The 'return' keyword is mostly used along with 'functions'.
?          What does it do?
        1. The 'return' keyword stops the execution of a function.
        2. The 'return' keyword "pushes" information out of a 'function' and makes it available
           to use elseware.
todo:    *Remember 'return' and 'console.log' are two DIFFERENT things with DIFFERENT behaviors*
 */

 function getMyBattingAverage(atBats, numberOfHits){
let myAverage = numberOfHits/atBats;
return myAverage

 }

 console.log(getMyBattingAverage(250,91)); 

 function add(x,y){
    return x + y;
 }

 function multiplyByTwo(x){
    return x*2;
 }

 let addition1 = add(3,7);

 let valueMultiplyByTwo = multiplyByTwo(addition1);

 console.log(valueMultiplyByTwo);

 //*CHALLENGES!
//todo: write a function to return the sum of two numbers (parameters)
//todo: write a function with the first and last name as parameters and return the full name
//todo: write a function to calculate and return the totalPrice of a quantity of products, including a 7% tax
