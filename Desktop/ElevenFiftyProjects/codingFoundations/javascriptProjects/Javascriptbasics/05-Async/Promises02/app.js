let img = document.querySelector('img');

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

displayImg(pic1,0.001)
.then(()=> displayImg(pic2,2))
.then(()=> displayImg(pic2,))
.then(()=> displayImg(pic3,3))
.catch((err)=>{
    console.log(err);
})