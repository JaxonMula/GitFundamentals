//Objects => a datatype that will allow us to store properties and methods

//*  Object literal

//1         //2
let zelda = {
    //3                 //4
    name    :       'Zelda',
    age     :       '17',
    title   :       'Princess',
    isCaptyured :      true
}
 
/*
* 1. Objects can be stored w/n variables
* 2. Objects user {} to surround the key/value pairs
* 3.[name], [age], [title], [isCaptured] are the properties referred to as 'keys'
* 4. represent the 'value' that is connected to the 'key' property
*/

//* Dot Notation -> we can use the (.) operator to access the values on an object

console.log(zelda.name);

console.log(zelda.title);

//JS has no order. I can put anything anywhere tbh
//I can put the middle name here now

zelda.middleName = "HELP";

console.log(zelda.middleName);



console.log(zelda); //prints out everything in the object

//Make a friend object with at least 4 properties

let friend ={
firstName: 'Bailey',
age : 20,
job : 'TikTok Influencer',
momIsHot : true

}

console.log(friend);

let movie ={
    comedy: 'Little Man',
    horror: 'Scream',
    romance: 'Notebook',
    naturalDisaster: 'Sharknado'
}
console.log(movie);

let mario ={
    name: 'Mario',
    slogan: 'Its a me mario!',
    speak: function(){
        return `${this.slogan}`;
    }
}
console.log("mario.speak():", mario.speak());