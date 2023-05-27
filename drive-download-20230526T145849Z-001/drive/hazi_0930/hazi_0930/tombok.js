/**
 * Házi feladat - tömbök, véletlen számok
 * Töltsünk fel véletlen szám generátorral 2 és 90 közötti egész számokkal, ötször.
 * Ismétlődést ne engedjünk meg!
 * 
 * Az algoritmus válogassa ki:
 * a., a páros számokat és generáljon velük egy új tömböt
 * b., a 3-al osztható számokat és generáljon velük egy tömböt
 * c., az 5-el osztható számokat, amiket csak simán írassuk ki
 */
"use strict"
function getRandomIntInclusive(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1) + min); // The maximum is inclusive and the minimum is inclusive
}

let tomb = Array();
while (tomb.length < 5) {
    let num = getRandomIntInclusive(2, 90);
    if(!tomb.includes(num)){
        tomb.push(num);
    }
}
console.log(`random számok tömbje: ${tomb}`);

let tomb_paros = Array();
let tomb_harmas = Array();
let ottel_oszthato = String();
for (let element of tomb){
    if(element%2==0){
        tomb_paros.push(element);
    }
    if(element%3==0){
        tomb_harmas.push(element);
    }
    if(element%5==0){
        if(ottel_oszthato == ""){
            ottel_oszthato += element;
        }else{
            ottel_oszthato += ", "+element;
        }
        
    }
}

console.log(`páros tömb: ${tomb_paros}`);
console.log(`hárommal osztható tömb: ${tomb_harmas}`);
console.log(`5-el osztható számok: ${ottel_oszthato}`);
