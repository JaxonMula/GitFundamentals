
//'innterHTML; -> Dynamically create HTML within a specific objects text location
const paragraphReview = document.querySelector('.review');

paragraphReview.innerHTML =
`
<div class = "container container-width">
    <div class = "row container-width">
          <div class = "boxA text-white">Yabba Dabba do</div>
          <div class = "boxB text-white">Guns and roses</div>
    </div>
</div>
`;


//'textContent' -> grabs the text from the browser, ignores any html tags
console.log(paragraphReview.textContent);

//'innerText' -> same as textContext, ignores any HTML tags
console.log(paragraphReview.innerText);