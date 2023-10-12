//Arrays -> .index -> checking to see if something exist withins the array
//                    id not the item exists then we wukk get back that iten 'index'
//                    if not, we will all get the value of -1

let friends = ["Terry","Hank","Marty"]

//first we will just 'pass-in' something that doesn't exist
let notExist = friends.indexOf("Yabba Dabba Doo!")
console.log(notExist); //we should get -1

let exist = friends.indexOf("Hank");
console.log(exist); //we should get 1

let userInput = ""

if(friends.indexOf(`${userInput}`) !== -1){
    console.log("Terry is here");
}else{
    console.log("Terry Aint here");
}
