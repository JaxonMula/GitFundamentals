//Switch Statements

/*  
    syntax:

    switch (expression){
 ?       case x:
 *       code block
 !       break;
 ?       case y:
 *       code block
 !       break;
 ?       case default:
 *       code block
 !       break;
    }

*/

//*Example

let ingredients = "Salmon";

switch(ingredients){
case "Ground Beef":
    console.log("I Like hamboreger");
    break;

case ("Salmon"):
    console.log("MMMM SALMNOELLA");
    break;


case ("Chicken"):
    console.log("MMMM CHIRKCNEN");
    break;

default:
    console.log("I gotta order somethin");
    break;
}


let answer = "B";

if (answer === "A" || answer === "B") {
    console.log("Gryffindor");
  } else if (answer === "C" || answer === "D") {
    console.log("Hufflepuff");
  } else if (answer === "E" || answer === "F") {
    console.log("Ravenclaw");
  } else if (answer === "G" || answer === "H") {
    console.log("Slytherin");
  } else {
    console.log("Must be a Muggle.");
  }
  

switch(answer){
    case "A":
    case "B":
        console.log("Gryffindor");
        break;
    case "C":
    case "D":
        console.log("Hufflepuff");
        break;
    case "E":
    case "F":
        console.log("Ravenclaw");
        break;
    case "G":
    case "H":
        console.log("Slytherin");
        break;
    default:
        console.log("Must be a Muggle.");
        break;
}