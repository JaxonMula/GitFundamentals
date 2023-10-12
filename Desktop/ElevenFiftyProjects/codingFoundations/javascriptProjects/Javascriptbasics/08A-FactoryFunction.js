//* Factory Functions => a generic function that will allow us to make any object that we want
//                       has its own generic properties that we can assign to the object

function CreateCharacter(firstName,slogan){
    return{
        firstName,
       slogan,
        speak: function(){
            console.log(slogan);
        }
    }
}

let mario = CreateCharacter("Mario","It's a me, Mario!");
console.log(mario);
mario.speak();

let bowser = CreateCharacter("Bowser","GRRRRRRRRR");
console.log(bowser);
bowser.speak();