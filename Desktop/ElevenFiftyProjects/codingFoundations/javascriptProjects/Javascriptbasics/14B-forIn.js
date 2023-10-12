//* for-in allows us to iterate (loop) over code blocks multilpe times
//* THIS LOOP IS ONLY USED FOR OBJECTS

//object literal

/*let bill ={
    firstName: "Bill",
    lastName: "Smith"
}

//for in loop  will iterate through the 'key's'
    for(let key in bill){
        console.log(key);
    }

*/

let bill = {
    firstName: "Bill",
    lastName: "Smith",
    friends: [
        {
            firstName: "STEve",
            lastName: "JACK",
        },
        {
            firstName: "Henry",
            lastName: "Danger",
        },
        {
            firstName: "Captain",
            lastName: "Man"
        },

    ]


};


for( let key in bill)
{
    console.log(key);
}

/*for(let friend in bill.friends){
    console.log(friend);
}*/


//each key is an index of the bill.friends array

for(let friend in bill.friends){
    console.log(bill.friends[key]);
}

