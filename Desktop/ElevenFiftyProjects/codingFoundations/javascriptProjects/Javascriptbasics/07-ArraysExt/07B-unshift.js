//.unshift() -> this adds items to the beginning of an array

let friends = ["Terry", "Bill"];

//add to the beginning...

friends.unshift("Tim")

console.log(friends);

//we can also add an array...

let moreFriends = ["Jesse","Henry"]

friends.unshift(moreFriends);
console.log(friends);
console.log(friends [0]);   // Jesse, Henry
console.log(friends [0][1]); //Henry