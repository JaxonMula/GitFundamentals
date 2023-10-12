//*Constructor FUnction

function Character(name, slogan){
    console.log("this:",this);
        this.name = name;
        this.slogan = slogan;
        this.speak = function(){
            console.log(this.slogan);
        };
        this.attack = function(){
            console.log(`${this.name} just attacked!` );
        };
    }

    let mario = new Character("Mario","???");

    //we want to display 'all' the keys
    for(let key in mario){
        console.log(key);
    }

    //display the key/value pairs
    for(let key in mario){
        console.log(key,mario[key]);
    }

    console.log('------------------------------------------------------------------');

    //lets display key/value pairs that aren't functions 
    for(let key in mario){
        if(typeof mario[key]!=='function')
        console.log(key,mario[key]);
    }
