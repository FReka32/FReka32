/**
 * Adjunk meg egy változóban életkort, 
 * döntse-el, hogy elérte-e a 18 évet, akkor engedjen tovább - 
 * (ha nem írja ki, hogy nem vagy 18 éves, viszlát)
 * és adjuk meg változóban a mozijegy sorszámát, az ülés sorát és a szék számát külön 
 * majd function-nel írja vissza, a szék számát, a sor számát és a mozijegy sorszámát!
 * Állapítsa meg, hogy nappalis diák-e az illető (25 év alatti). 
 * Ha igen, írja ki, hogy a mozijegy ára 500 Ft, egyébként 1850 Ft.

Minden kiíratást console.log-ba kérek!*/
"use strict";
let sorszam_jelenlegi = 0;
const kedvezmenyes_ar = 500;
const teljes_ar = 1850;
const valuta = "Ft";
let szabad_helyek = [
    [true,true,true,true,true,true],
    [true,true,true,true,true,true],
    [true,true,true,true,true,true],
    [true,true,true,true,true,true],
    [true,true,true,true,true,true],
    [true,true,true,true,true,true]
]
const getSzabadHelyek = () => {
    console.log("Szabad helyek:");
    let helyek = "";
    for(let i = 0; i< szabad_helyek.length; i++){
        helyek += (i+1) + ". sor: ";
        for (let j = 0; j < szabad_helyek[i].length; j++){
            if(szabad_helyek[i][j] == true){
                helyek += (j+1) + ". "
            }
        }
        helyek += "\n";
    }
    console.log(helyek);
}

class Jegy {
    constructor(sorszam, sor, szek) {
        this.sorszam = sorszam;
        this.sor = sor;
        this.szek = szek;
    }
}

const getJegyJelenlegi = () => {

    sorszam_jelenlegi += 1;
    let sor_jelenlegi = prompt("Kérem adja meg a sor számát(1-6):");
    if(sor_jelenlegi == null){
        console.log('Viszlát!');
        return false;
    }
    while(sor_jelenlegi>6 || sor_jelenlegi<1 || szabad_helyek[sor_jelenlegi-1].includes(true) == false ){
        sor_jelenlegi = prompt(`A ${sor_jelenlegi}. sor nem elérhető! Kérem adja meg a sor számát:`);
    }
    let szek_jelenlegi = prompt("Kérem adja meg a szék számát(1-6):");
    if(szek_jelenlegi == null){
        console.log('Viszlát!');
        return false;
    }
    while(szek_jelenlegi>6 || szek_jelenlegi<1 || szabad_helyek[sor_jelenlegi-1][szek_jelenlegi-1]==false ){
        szek_jelenlegi = prompt(`A ${szek_jelenlegi}. szék nem elérhető! Kérem adja meg a szék számát:`);
    }
    szabad_helyek[sor_jelenlegi-1][szek_jelenlegi-1] = false;
    const jegy_jelenlegi = new Jegy(sorszam_jelenlegi, sor_jelenlegi, szek_jelenlegi);
    return jegy_jelenlegi;
}

const getJegy = () => {
    const eletkor = prompt("Kérem adja meg az életkorát:");
    if (eletkor < 18 ) {
        if(eletkor != null){
            console.log("Nem múltál el 18 éves!");
        }
        console.log("Viszlát!");
        return;
    } else {
        getSzabadHelyek();
        const jegy = getJegyJelenlegi();
        if(jegy){
            console.log(`Az ön jegye: ${jegy.sorszam}. sorszámú jegy, ${jegy.sor}. sor, ${jegy.szek}. szék`);
            if (eletkor < 25) {
                console.log(`A jegy ára nappalis diákoknak ${kedvezmenyes_ar} ${valuta}`);
            } else {
                console.log(`A jegy ára ${teljes_ar} ${valuta}`);
            }
        }
    }
    getUjJegy();
};
const getUjJegy = () => {
    const akare = confirm("Szeretne újabb jegyet vásárolni?");
    if(akare){
        getJegy();
    }else{
        console.log("Viszlát!")
    }
}
window.onload = (event) => {
    getJegy();
};




