//* Loops -> allows us repeatedly execute a line of code if a condition is met.

/*
    Syntax
                1.                       2.                          3.
                                                        (your choice-> default is incrementExpression)
        for([initialExpression];[contidtionalExpression];[incrementExpression/decrementExpression])
        {
            For loop body (code to be executed each loop)
        }
 */

// 1. 'initialExpression' -> sets the starting value of a loop control variable (LCV).

// 2. 'conditionExpression' -> is evaluated, if 'true', stay in the loop, otherwise exit the loop.

// 3. 'incrementExpression' -> updates the LCV.

for(let i=0; i<100; i++){
    console.log("i:", i);
}

//ex 2;

//loop from 0- 50 by 5's

for( let i=0; i<=50; i+=5){
    console.log("i:", i);
}