// Put your code here

const spells = [
    {
        name: "Turn enemy into a newt",
        isEvil: true,
        energyRequired: 5.1
    },
    {
        name: "Conjure some gold for a local charity",
        isEvil: false,
        energyRequired: 2.99
    },
    {
        name: "Give a deaf person the ability to heal",
        isEvil: false,
        energyRequired: 12.2
    },
    {
        name: "Make yourself emperor of the universe",
        isEvil: true,
        energyRequired: 100.0
    },
    {
        name: "Convince your relatives your political views are correct",
        isEvil: false,
        energyRequired: 2921.5
    }
]

console.log("Do you believe in magic?");
console.log("------------------------");

// for (const spell of spells) {
//     if (spell.isEvil === true) {
//         console.log("Good Book")
//         console.log(`${spell.name}`)
//     }
//     else {
//         console.log("Evil Book")
//         console.log(`${spell.name}`)
//     }
// }

const goodBookSpells = spells.filter(s => s.isEvil === false)
const evilBookSpells = spells.filter(e => e.isEvil === true)

console.log("Good Book")
for (const goodBookSpell of goodBookSpells) {
console.log(`    ${goodBookSpell.name}`)
}
console.log("")
console.log("Evil Book")
for (const evilBookSpell of evilBookSpells) {
console.log(`    ${evilBookSpell.name}`)
}