//.push() -> this adds items to the end of an array

let friends = ["Terry", "Bill"]

//and we ewant to add to the end of this array

friends.push("TIM")
console.log(friends);

//now, we can add an entire array to an es=xisting array

let moreFriends = ["Andrew","Marty"];

friends.push(moreFriends);
console.log(friends);

console.log(friends[3][0]);  //Andrew
console.log(friends[3][1]);  //Marty