//spread operator -> simplifies the ability to 'combine' arrays

let friends = ["Terry","Bill","Marty"];

let monsters = ["Freddy","Jason","Myers","Pinhead"];

//want to combine these two arrays [...nameofArray]

let combination= [...friends,...monsters]
console.log(combination);
console.log(friends);
console.log(monsters);