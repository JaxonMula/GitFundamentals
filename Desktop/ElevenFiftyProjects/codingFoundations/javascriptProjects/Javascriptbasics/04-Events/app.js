//favtory function

let customer = function(firstName,lastName,customerComplaint){
    return{
        firstName,
        lastName,
        customerComplaint,
        fullName: function(){
            return`${firstName} - ${lastName}`;
        }
    }
}
//golablly scoped
const customerCard = document.querySelector('.card');

//accessing inputs w/n our form...
let firstNameInput = document.querySelector('#firstName');
console.log(firstNameInput);

let lastNameInput = document.querySelector('#lastName')
console.log(lastNameInput);

let customerComplaintInput = document.querySelector('#complaint')
console.log(customerComplaintInput);

const nutton = document.querySelector('button')

//addEvenetListener()... use this to make something happen...
nutton.addEventListener('click',function(e){
e.preventDefault();

let customerData = customer(
    firstNameInput.value,
    lastNameInput.value,
    customerComplaintInput.value

);
console.log(customerData);

displayCustomerData(customerData);
});

function displayCustomerData(customer){
let customerCardTitle = document.querySelector(".card-title");
let customerCardText = document.querySelector(".card-text")

customerCardTitle.innerText = `${customer.fullName()}`;
customerCardText.innerText = `${customer.complaint}`;
customerCard.classList.toggle('hidden');
}

const resetButton = document.querySelector('.resetButton');
resetButton.addEventListener("click",reset);
function reset(){
    firstNameInput.value = '';
    lastNameInput.value = '';
    customerComplaintInput.value = '';
    customerCard.classList.toggle("hidden");
}
