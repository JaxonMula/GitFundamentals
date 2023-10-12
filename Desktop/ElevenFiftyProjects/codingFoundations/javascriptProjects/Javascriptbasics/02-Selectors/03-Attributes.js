

const img = document.querySelector('img');

let imgValue = img.getAttribute(img)
console.log(img);

const paragraphReview = document.querySelector('.review');
console.log(paragraphReview);

//note: this creates an inline style -> everybody via specifically...

paragraphReview.setAttribute('style','background-color: violet');
console.log(paragraphReview);

img.setAttribute('style','border: 5px solid black');