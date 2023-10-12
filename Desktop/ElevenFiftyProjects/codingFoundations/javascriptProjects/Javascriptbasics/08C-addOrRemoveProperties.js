function CreateCharacter(name, slogan){
        name = name;
        slogan = slogan;
        speak = function(){
            console.log(slogan);
        }
        this.attack = function(){
            console.log(`${this.name} just attacked!` );
        }
    }
    

    //we can dynamically create/delete properties

    const mario = CreateCharacter("Mario","Some slohgan...");


    //we want to add a property to this obj...

    mario.acquiredPowerUpItems = ["Mushroom","Fire-FlowerPower"];
    console.log(mario);

    //what if we want to delete

    delete mario.acquiredPowerUpItems;
    console.log(mario);