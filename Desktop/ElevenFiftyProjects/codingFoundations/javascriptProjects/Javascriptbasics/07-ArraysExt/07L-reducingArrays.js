//.reduce() 

let numericValues = [5,10,15,20,25];

//add together with for loop
let accumulater = 0;

for(let i =0; i<numericValues.length; i++){
    accumulater+=numericValues[i];
}

console.log(accumulater);


//*ANOTHER WAY

let sum = numericValues.reduce((accumulater,currentValue)=>{

return accumulater+=currentValue;


},0);


console.log(sum);

//acc=0, c=5, 0+5 now acc = 5
//acc =5, c=10, 5+10 = 15 now acc =15
//...
//...