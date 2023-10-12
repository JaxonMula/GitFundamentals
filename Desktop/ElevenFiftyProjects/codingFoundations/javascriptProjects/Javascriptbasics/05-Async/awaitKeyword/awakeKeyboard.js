//*await -> ability to write asynchronous code that looks synchronous

//* THIS ONLY WORKS W/N(within) AN 'AYSYNC FUNCTION'
//* Pauses the execution fo the function, 'waits for the promise to be resolved'

let img = document.querySelector('img');
console.log(img);

let pic1 = "https://tse2.mm.bing.net/th?id=OIP.4DIPAp3Xfm1U03agVUHj-AHaFj&pid=Api&P=0&h=180";
let pic2 = "https://assets.wired.com/photos/w_1920/wp-content/uploads/2016/02/353-Ranitomeya-imitator_juvenile_John-P.-Clare.jpg";
let pic3=  "https://cdn.britannica.com/q:60/84/206384-050-00698723/Javan-gliding-tree-frog.jpg";


const displayImg = (picUrl,delay)=>{
    let interval = delay*1000;
    return new Promise((resolve,reject)=>{
        setTimeout(()=>{
            if(!picUrl || !delay){
                console.log("poop poop");
                reject("INVALID PIC?DELSY BVALUES")
            }else{
                console.log("Success")
                img.setAttribute('src',picUrl);
                resolve("Success")
            }
        }, interval);
    })
}


async function displayImgTryCatch(){
    try{
      await displayImg(pic2,0.001);
      await displayImg(pic3,2);
      await displayImg(pic1,1);
    }catch(e){
        console.log("Error",e);
    }
}

displayImgTryCatch();