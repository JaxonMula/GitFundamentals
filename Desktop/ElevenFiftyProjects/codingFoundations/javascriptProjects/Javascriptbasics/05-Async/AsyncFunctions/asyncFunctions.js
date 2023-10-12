//* Async Functions

//* 'keyword async' -> it always returns a promise
// if the function returns a value then the promise will be resolved with that value
// if the function throws an exception then the promise will be rejected

//example
async function hello(){
    return "Dude HaHAHAH"
}

console.log(hello());

const throwError = async()=>{
    throw new Error("Sad");

}

console.log(throwError());

//example 2

const userAuth = async function(email,password){
    if(!email || !password){
        throw "Somethings wrong..."
    }
    if(email ==="dude@gmail.com" && password === "frogs123"){
        return `Welcome User: ${email} :) `
    }
    else{
        throw "Invalid password"
    }
}

//! lets make an error!

userAuth('dude@gmail.com','frogs123')
.then(msg=>{
    console.log("success");
    console.log(msg);
})
.catch((err)=>{
console.log('Error');
console.log(err);
});