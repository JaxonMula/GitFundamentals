//*Abstractions -> hiding details from 'outisde' sources
//*Maybe I want something to only work within the 'scope' of my object!!!

function Character(name, slogan){
    let lives = 3;
    let isDead = false;
        this.name = name;
        this.slogan = slogan;
        this.speak = function(){
            console.log(this.slogan);
        };
        this.attack = function(){
            console.log(`${this.name} just attacked!` );
        };
        this.displayLives = function(){
            console.log(lives);
        }
        this.loseLife = function(){
            if(lives > 0 && isDead){
                lives--; //bc this is 'private' we dont need the 'this' keyword
                console.log(`${this.name} just lost a life!`);
            }else{
                isDead = true;
                console.log(`${this.name} just Died!!`);

            }
        }
    }

let mario = new Character("Mario","Its a me mario");
console.log(mario.lives);

mario.loseLife();
mario.displayLives();

mario.loseLife();
mario.displayLives();

mario.loseLife();
mario.displayLives();

mario.loseLife();
mario.displayLives();

mario.loseLife();
mario.displayLives();
