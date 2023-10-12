//*Promise -> returns an object that contains success/failure based on an asynchronous function.
//* Anatomy

/*
     now Promise((resolve,reject)->{
        resolve/reject methods can be called anywhere in here...
        resolve() -> returns: Promise(<resolved>: undefined)
        reject() -> returns: Promise(<rejected>: undefined)
        if there is no invocation -? promisse({<pending>: undefined})
     })
*/

//syntax

//promise that works
/*var resolvePromise = new Promise((resolve,reject)=>{
 return resolve();

})

console.log(resolvePromise);

var rejectedPromise = new Promise ((resolve,reject)=>{
    return reject();
});

console.log(rejectedPromise);
*/

//fske hitting url endpoints,
//if it takes too long to connect then will throw an arrow
//but if it doesn't we'll just give a success message

const moqPromiseRequest = function(urlAddress){
    return new Promise((resolve,reject) =>{
        const connectionTime = (Math.floor(Math.random() *10)+1)*1000;
        setTimeout(()=>{
            if (connectionTime > 3000){
                console.log("....could not connect");
                reject("STAUSCODE %)) INTERNAL SERVER ERROR")
            }else{
                console.log("....Succesffully connected");
                resolve("Status code:200, ok repsponse")
            }
        },connectionTime);
    })
}

moqPromiseRequest("https://socialApp.com/apples")
.then((data)=>{
    console.log("It worked, Accessing Page 1");
    console.log(data); //represents the data that is being returned from the url
   return moqPromiseRequest("https://socialApp.com/oranges")
})
.then((data)=>{
    console.log("It worked, Accessing Page 1");
    console.log(data)
    return moqPromiseRequest("https://socialApp.com/peaches")
})
.then((data)=>{
    console.log("It worked, Accessing Page 1");
    console.log(data)
    return moqPromiseRequest("https://socialApp.com/peaches")
})
.catch((err)=>{
     console.log("....POOP.....");
     console.log(err);
})