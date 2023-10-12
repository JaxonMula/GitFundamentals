//.pop() -> This is how we 'remove' from the 'end' of an array
//This method also returns the removed item, so you can store the removed item for 
//future use

let friends = ["Terry","Bill","Marty"];

let removedFriend = friends.pop();

console.log(friends);
console.log("Removed Friend:", removedFriend);

removedFriend = friends.pop();
console.log(friends);
console.log("Removed Friend:", removedFriend);
