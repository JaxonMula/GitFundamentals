const button = document.querySelector("button");

const paragraph = document.querySelector(".card-text");
button.addEventListener("click", async (e) => {
  e.preventDefault();
  let options = { headers: { Accept: "application/json" } };
  let req = await axios.get("https://icanhazdadjoke.com/", options);
  console.log(req.data);
  paragraph.innerText = req.data.joke;
});

/*button.addEventListener('click',async(e)=>{
    e.preventDefault();
    let req = await axios.get("https://icanhazdadjoke.com/");
    console.log(req.data);
    let swPeople = req.data.results;
    for(let person of swPeople){
        paragraph.innerText += `${person.name}\n`;
    }
    //paragraph.innerText = req.data.joke;
})*/
