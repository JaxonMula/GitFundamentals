//Prepend goes in body of HTML
//Append goes under the script in HTML

const narutoDiv = document.querySelector('div')
console.log(narutoDiv);

//createEleement('elementName")
const divContainer = document.createElement('div');

//add bootsrap container 
divContainer.classList.add('container');

//add the divCOntainer to the D.O.M
document.body.prepend(divContainer);

const row = document.createElement9('div');
row.classList.add('row');

const col1 = document.createElement('div');
col1.classList.add('col-4');

const img = document.createElement('img');
img.src = 'https://i.pinimg.com/originals/cd/59/d9/cd59d9815ad418d1310467a363f8fc9a.jpg';
img.classList.add('w-100');

col1.append(img);

const col2 = document.createElement('div');
col2.classList.add('col-8');
const col2P = document.createElement('p');
col2P.innerText = `Lorem, ipsum dolor sit amet consectetur adipisicing elit. Iusto nemo omnis id reprehenderit doloremque dicta sint dolorum ipsum rerum porro velit, repellendus cupiditate, saepe dolor nulla? Atque voluptate alias vel!
Eum adipisci accusamus ab magni incidunt totam architecto optio tempora possimus omnis ratione alias sit, unde rerum quae atque. Perferendis recusandae commodi magnam modi vitae, cumque numquam fugiat necessitatibus quibusdam?
Dolorum minima sit nulla adipisci tempora voluptas optio saepe sunt culpa esse facere, mollitia rem a iusto assumenda deserunt ratione veritatis inventore laudantium velit eos necessitatibus. Eligendi veniam quia odit.
`;

col2.appendChild(col2P);

row.append(col1,col2);

divContainer.appendChild(row);

const anotherDiv = document.createElement('div');
const anotherImg = document.createElement('img');
anotherImg.src = 'http://wallpapercave.com/wp/pC6obas.jpg';
anotherImg.classList.add("w-100");
anotherDiv.appendChild(anotherImg);


//anotherDiv.removeChild(anotherImg);

//narutoDiv.before(anotherDiv);

narutoDiv.after(anotherDiv);