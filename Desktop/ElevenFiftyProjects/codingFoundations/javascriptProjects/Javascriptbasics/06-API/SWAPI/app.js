
//grab ul

let swPeopleList = document.querySelector('ul');

//* fetch (keyword) -> returns a promise, but this will look familiar

fetch("https://swapi.dev/api/people/1")
.then(function(response){
    console.log(response.json);
    return response.json();
})

.then(function(json){
    console.log(json);
    let people = json.results;
    for(let p of people){
        const li = document.createElement9('li');
        li.textContent = `
        Name: ${person.name}
        Height: ${person.height}
        Mass: ${person.mass}
        Hair Color: ${person.hair_color}
        Skin COlor: ${person.skin_color}
        `
        swPeopleList.appendChild(li);
    }

})

console.log(person);
