//*Selectpr
//getElementById -> select an existing object by its Id
//                  if no id, then it reyurns null

const dbzPic = document.getElementById('dbz');
console.log(dbzPic);
console.dir(dbzPic);

//getElementByTagName -> selects an existing element from the dom based on its 'tagName'
//                       returnns HTMLCollection[], acts like an array but its not an array
//                       if no tag name, returns null.

const title = document.getElementsByTagName('title');
console.dir(title);

// getELementByClassName -> select an existing element from the dom based on its 'class'
const reviewElements = document.getElementsByClassName('review');
//console.dir(reviewElements);

for(let element of reviewElements){
    console.log(element.innerText);
}

//querySelectors
//the first img is the DOM
const firstImg = document.querySelector('img');
console.log(firstImg);


//get by class..
const firstTextCenter = document.querySelector('.text-center');
console.log(FirstTectCenter);

//get by id...
const hellsing = document.querySelector('#helsing');
console.log(hellsing);
console.dir(hellsing.nextElementSibling);

//getting an obj based on its descendantt..
let firstPWithStrong = document.querySelector('p strong');
console.log(firstPWithStrong);

//get all matching paragraphs
const allParagraphs = document.querySelectorAll('p')
console.log(allParagraphs);

for (let p of allParagraphs){
    console.log(p.textContent);
}