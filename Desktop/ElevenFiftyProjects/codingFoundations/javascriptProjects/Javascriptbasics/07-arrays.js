//Arrays => stores a collection of items (Reference Type)

// The collection starts at index 0
//They allow us to collect items like, names, usernames, ID's, prices, etc.

/*
    1.Arrays can be stored within variables
    2. Use[] to surround the 'values' within an array
    3. We seperate the values within an array with commas
    4. Can store a collection of one, or dynamically store differenet types within one collection;
*/

//* Examples

let rainbowColors =['red','orange','yellow','green','blue','indigo','violet'];

//collection of numbers
let raceWinners = [33,74,64];

//dynamic collection
let myFavoriteThings = ['Broccoli',46072,'FORTNITE'];

let secretSpyInfo = ["James Bond", 7, true];

let countryArray = ["USA", "Japan","Belgium"]

//Access some of these values...
//rainbowColors[5]
console.log(rainbowColors[5]); //Indigo

console.log(countryArray[2]);

//lets look at this further
let dogs = ['Shiba Inu','Husky','Corgi','Great Dane']
let cats = ['Main coon', 'Garfield', 'Siamese']
let birds = ['Parrot', 'Canary','Macaw']
let fish = ['gold fish','neon tetra', 'beta fish', 'guppy']

//print shibu
console.log(dogs[0]);

//print second value of second array
console.log(cats [1]);

//print guppy
console.log(fish[3]);

//print first value of birds array
console.log(birds[0]);