//do wile loops -> allows us to iterate (loop) over code blocks multiple times
// The difference here is that the code will ALWYAS run atleast once

let count = 2;

let maxCount = 3;

/*do{
 get();
}while (count<maxCount);

function get(){
    console.log("HEllo");
}
*/

do {
  if (count === 3) {
    break;
  }
  gret();
  count++;
} while (count < maxCount);

function gret() {
  console.log("HEllo");
}
