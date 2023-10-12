//.splice [Addition] -> adding to the whole methof


let friends = ["Terry","Hank","Marty"];

//we want to add to the middle of this array....

friends.splice(1,0,"Tim");

console.log(friends);

friends.splice("Apu","Jeff");

console.log(friends);
console.log(friends[3][1]);