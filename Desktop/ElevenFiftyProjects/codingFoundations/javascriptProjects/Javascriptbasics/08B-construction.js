//* Factory function:

function CreateCharacter(firstName,slogan){
    return{
        firstName,
       slogan,
        speak: function(){
            console.log(slogan);
        }
    }
}

//If an object has 1 or more methods(functoin), then it is said to have behavior!

//In the browser 'this' refers to the 'GLOBAL' obj of the browser, whch is the 'window;
//In the node 'this' refers to the 'GLOBAL' obj 

//* Constructor Function

function Character(name, slogan){
console.log("this:",this);
    this.name = name;
    this.slogan = slogan;
    this.speak = function(){
        console.log(this.slogan);
    }
    this.attack = function(){
        console.log(`${this.name} just attacked!` );
    }
}

let mario = new Character("Mario","Lets a go!");
let bowser = new Character("Bowser","GRRRRR!!");

//behind the scense, we will need to construct a new character
//anything prepended with this will be added to the newly conrtcued constructor

//{name:name,slogan:slogan,speak:f(),attackf()}, will be assigned to a variable container


console.log(mario);
console.log(bowser);

mario.attack();
bowser.attack();