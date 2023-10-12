//.splice() [removal] -> this is how we 'remove' from the 'middle' of an array...

let friends = ["Terry","Bill","Marty"];

friends.splice(1,1);

console.log(friends);

friends.splice(1,1,["item1","item2"])
console.log(friends);