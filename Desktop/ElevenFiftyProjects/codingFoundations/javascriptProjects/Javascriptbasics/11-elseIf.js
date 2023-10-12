//* else/if statements

/*
    syntax
        if(condition){
?            ...code block (if true)
        } else if (condition){
?            ....code block (if true)
        }else if (condition){
?            ....code block (if true)
        }else{
?            if all else fails (default)
        }
        
*/

//* Example

let character = 'Wizard';

if (character === 'Bard'){
    console.log('You sing nice songs!');
}else if( character === 'warrior'){
    console.log('You beat things up!');
} else if( character=== 'Rogue'){
    console.log('You use stealth');
}else if (character === 'Wizard'){
    console.log('you use magic');
}else{
    console.log('what type of character is this?');
}

//*Order is important when using else-if statements
