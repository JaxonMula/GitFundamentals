//variables -> containers for storing info

//They care declared and initialized with a value

//* variable declaration: its just "declaredd" no value has been assigned to it

let myFirstVariable;
console.log(myFirstVariable); //undefined -> intentionally not there

/*
*                       Variable rules
todo: 1. Must begin with a letter, dollar sign($), or an underscore(_)
todo: 2. We cannot use a 'reserved' Javascrpit Keyword (for, let, const, etc.)
todo: 3. Naming should be descriptive and brief
todo: Ex: isTrue, environmentStatus, etc.
*/

//declaration and initialization
let patientID = 120023;

console.log("patientID: ", patientID);

//DEeclaration
let lastName;

//later in code..
//Initialization
lastName = "Goober";
console.log(lastName);

//later in code...
//Re-initialization
lastName = "Smith";
console.log(lastName);

//! var -> old way to dynamically store a variable, not considered to be a good practice b/c of 'hoisting'
//! hoisting -> when the application is running everything with the 'var' keyword is 'hoisted' or put to
//!             top of the file. This can be detremental to any variable with the same name that is nested
//!             within another method.

//*Let -> new way to dynamically store a variable, will not allow hoisting!

//* const -> (short for constant), once we declare/initialize this variable we cannot change it!

const today = "Tuesday";
today = "Wednesday";
console.log(today); //! we get: TypeError: Assignment to constant variable

//* Naming conventions
//* camelCaseNamingConventions -> first letter of the first word is lowercased, and any following words are attatched and the first letter is Capatalized

//* PascalCasedNamingConvention -> first letter of the first word is Capatalized and any following words are attatched their first letter is Capatalized

//* snake_case_naming_convention -> using underscore to seperate words

//* Our focus will be on camelCased, and sometimes Pascal
