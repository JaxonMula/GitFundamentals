//Strings -> just a bunch of charaters that are 'strung' together

//can be created with double quotes "your string here"
// or single quotes 'your string here'

//*Examples
let userNamer = "RealStickMan715";

const stateName = 'Indiana';

let currentLanguage = 'Javascript';

let phrase = "The quick brown fox jumped over the lazy dog";

let emptyString = " ";

//*Escape Characters

let escapedString = 'I just can\'t believe it\'s not butter';
console.log(escapedString);

let withQuote = "The doctor said, \"Where is my patient\", while he ran out the door."
console.log(withQuote);

let escapedStringRef = "I just can't beleieve it's not butter"
console.log(escapedStringRef);

let withQuoteRef = 'The doctor said, "Where is my patient", while he ran out the door';
console.log(withQuoteRef);

//Dynamic String (string template literal)
let firstName = "Jane"
let carItems = 5;
let greeting = 'Welcome $(firstName)! You have $(cartItems) in your cart.';

//this is just an array of characters
const dayOfTheWeek = 'MTWTF';

//todo: lets access this array
console.log(dayOfTheWeek[0]);
console.log(dayOfTheWeek[1]);
console.log(dayOfTheWeek[2]);
console.log(dayOfTheWeek[3]);
console.log(dayOfTheWeek[4]);

//Manipulating an existing string
const oldMarkup = "The Apples are the best fruit. Apples will dominate other fruits. ";
let newMarkup = oldMarkup.replaceAll("Apples", "Oranges") //This is case sensitive
console.log(newMarkup);

//todo: see if the string contains a word or a character
//* .includes() (Array Method)
let stockChoices = 'AAPL,MSFT,GOOG,AMZN,FB'
let containsNewtFlixStock = stockChoices.includes('NFLX'); //this method returns true/false, goes in the stockvhoices to look for NFLX(Returns boolean)
console.log(containsNewtFlixStock);

//todo: changing all letters to uppercase/lowercase
let userEmail = 'Mycoolmaail@google';
let allUpperCase = userEmail.toUpperCase();
console.log(allUpperCase);

let allLowerCase = userEmail.toLowerCase();
console.log(allLowerCase);

