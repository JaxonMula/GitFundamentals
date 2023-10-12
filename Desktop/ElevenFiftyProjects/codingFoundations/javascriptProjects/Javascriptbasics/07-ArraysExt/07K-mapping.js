//.map() -> Allows you to transform items w/n an array

// we are going to take some array data and turn it into HTML

const friends = ["Terry","Tim","Tom","Mary","Jack"];

//lets use .map()

let mappedData = friends.map(friend => `<li>${friend}</li>`)

console.log(mappedData);

//.join() => turn the mappedData into a collection of type string
//.replace(',','') -> remove every (,) and replace it with empty space


const html = mappedData.join(",");
console.log(html)
let refactoredHtml;

for(let e of html){
    if(e===",")
e = '';
refactoredHtml+=e;
}else{
    refactoredHtml +=
}


console.log(html);
console.log(refacotredHtml);

let refHTML = mappedData.reduce((acc,currVal)=>{
    if(currVal===',')
        currVal=' ';
    
});
        return acc+currVal

console.log(refHTML);
//! We have a bug