// Put your code here

console.log("Let's roll some dice, baby!");
console.log("---------------------------");

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

for (let i = 0; i < 10; i++) {
    
    die1 = getRandomInt(1, 6)
    die2 = getRandomInt(1, 6)

    if (die1 == die2) {
        console.log(`${die1} + ${die2} == ${die1 + die2} DOUBLES!`)
    }
    else {
        console.log(`${die1} + ${die2} == ${die1 + die2}`)
    }
}