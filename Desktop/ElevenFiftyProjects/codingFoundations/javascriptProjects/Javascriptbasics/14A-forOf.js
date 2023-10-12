//* for -of -> allows us to iterate (loop) over code blocks multiple times
//* THIS LOOP IS ONLY FOR ARRAYS

//lets create an array
const friends = ["bill","Steve","Greg","Tim"]


 //1      2     3     4
for(let friend of friends){
    //5
    console.log(friend);
}

//1. for (keyword)
//2. initialization of the 'friend' variable, this represents one 'friend' in many 'friends'
//3. 'of' (keyword), indicating that we want to iterate (loop) through an array
//4. 'friends' is the actual array that we want to loop through
//5. code to be ran each iteration (loop)

//todo: PLEASE TAKE THE TIME TO USE THE DEBUGGER