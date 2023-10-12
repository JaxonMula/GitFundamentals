//filter -> allows you to query items w/n an array

const numbers = [-1,2,3]

const filtered = numbers.filter(function(value){
    if (value >=0) {
        return value;
        
    }
});

console.log(filtered);

const filteredRefactored = numbers.filter(value => value >=0);
console.log(filteredRefactored);

const friends = ["Terry","Tim","Tom","Mary","Jack"];

let filteredFriends = friends.filter((name)=> name.includes('T'));
console.log(filteredFriends);

let filteredFriendsInverse = friends.filter((name)=> !name.includes('T'));
console.log(filteredFriendsInverse);