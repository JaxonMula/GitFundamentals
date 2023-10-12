//* Arguments and Parameters

//* 'Functions' can also accept values known as 'arguments' if the correct 'parameters' are set up.

//* Parameters -> are the names listed in the parentheses of the function definition (when we are creating the function)

//* Arguments -> are the real values received by the 'function' when you call it.

/*
todo:   *Think of being the devloper and defining a function for future use*
todo:                    (bottle,cap) -> these are the Parameters (slots), which are placeholders for inputs*
todo:                                       for future use (when we invoke the function)*
*    function bottleCapper(bottle,cap){
*        return bottle + cap;
*    }

*         when this function is called later in the application
          bottleCapper("green bottle","white cap");
todo:                 ("green bottle","white cap") => these are the 'arguments' that are being passed into the 
todo:                                                 function/method at runtime. 
 */


//* Single Parameter Function

function numberEntered(num){
    console.log(`The number entered was ${num}. `);

}

numberEntered(100)
numberEntered(1000)
numberEntered(1000)
numberEntered(300)

//multiple parameter function

function addTwoNumbers(num1, num2){
    console.log(num1 + num2);
}

addTwoNumbers(1,2)
addTwoNumbers(19,27)
addTwoNumbers(600,66)
addTwoNumbers(40,20)

//*Challenge
//todo: Name a function 'subtractTwoNumbers'
//todo: it will have two parameters: 'firstNum' and 'secondNum'
//todo: print in the console firstNum - secondNum

function subtractTwoNumbers(num3, num4){
    console.log(num3 - num4);
}

addTwoNumbers(1,2)
addTwoNumbers(19,27)
addTwoNumbers(600,66)
addTwoNumbers(40,20)