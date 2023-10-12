//* Constructor Function
function Character(name, slogan) {
    let lives = 3;
    let isDead = false;
    let coins = 0;
    this.name = name;
    this.slogan = slogan;
    this.speak = function () {
      console.log(this.slogan);
    };
    this.attack = function () {
      console.log(`${this.name} just Attacked!`);
    };
    this.displayLives = function () {
      console.log(lives);
    };
    this.loseLife = function () {
      if (lives > 0 && !isDead) {
        lives--; //b/c this is 'private' we don't need the 'this' keyword
        console.log(`${this.name} just lost a life!!!`);
      } else {
        isDead = true;
        console.log(`${this.name} just Died!!!`);
      }
    };
    this.aquireCoin = function (value) {
      coins += value;
      console.log(coins);
      if (coins >= 100) {
        lives++;
        coins = 0;
        console.log(coins);
      }
    };
    Object.defineProperty(this, "coins", {
      get: function () {
        //I have access to 'read' the data
        return coins;
      },
      set: function (value) {
        //I have access to 'write' to the data
        coins = value;
      },
    });
  }
  
  let mario = new Character("Mario", "It's me Mario!!!");
  mario.aquireCoin(10);
  console.log(mario.coins);
  
  mario.coins = 10;
  console.log(mario.coins);
  
  mario.aquireCoin(100);
  console.log(mario.coins);
  
  mario.displayLives();
  
  function createCharacter2(name, slogan) {
    let lives = 3;
    let isDead = false;
    let coins = 0;
    Object.defineProperty(this, "coins", {
      get: function () {
        //I have access to 'read' the data
        return coins;
      },
      set: function (value) {
        //I have access to 'write' to the data
        coins = value;
      },
    });
    return {
      name: name,
      slogan: slogan,
      speak: function () {
        console.log(this.slogan);
      },
      attack: function () {
        console.log(`${this.name} just Attacked!`);
      },
      displayLives: function () {
        console.log(lives);
      },
      loseLife: function () {
        if (lives > 0 && !isDead) {
          lives--; //b/c this is 'private' we don't need the 'this' keyword
          console.log(`${this.name} just lost a life!!!`);
        } else {
          isDead = true;
          console.log(`${this.name} just Died!!!`);
        }
      },
      aquireCoin: function (value) {
        coins += value;
        console.log(coins);
        if (coins >= 100) {
          lives++;
          coins = 0;
          console.log(coins);
        }
      },
    };
  }
  
  let luigi = createCharacter2("Luigi","It's me Luigi!!!");
  
  luigi.coins = 10;
  console.log(luigi.coins);
  
  luigi.loseLife();
  luigi.loseLife();
  luigi.loseLife();
  luigi.loseLife();