//.find() [reference types] -> find a single object within an array of objects

let friends = [
{
    id: 1,
    firstName: "Jaxon",
    lastName: "Mula"
},
{
    id: 2,
    firstName: "Bill",
    lastName: "Burr"
},
{
    id: 3,
    firstName: "Steven",
    lastName: "Jerkins"
},
]

let jaxon = friends.find(f=>f.id === 1)
console.log(jaxon);

let Bill = friends.find(friend=> friend.firstName === "Steven")
console.log(Bill);

let Steven = friends.find(friend=> friend.lastName === "Burr")
console.log(Steven);

let unkown = friends.find(friend=> friend.lastName === "???")
console.log(unkown);// undefined
