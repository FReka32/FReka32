"use strict";
//1., Arrow function-nel kérjen be egy hónap nevét! Többszörös elágazással ? : összefüggés használatával írja ki, hogy az adott hónap melyik betűvel - console-ra!
/*let honap = () => prompt("Kérem írja be a hónap számát", 1);
let honap_szam = Number(honap());
let honap_neve = (honap_szam == 1) ? "január" : 
        (honap_szam == 2) ? "február" :
        (honap_szam == 3) ? "március" :
        (honap_szam == 4) ? "április" :
        (honap_szam == 5) ? "május" :
        (honap_szam == 6) ? "június" :
        (honap_szam == 7) ? "július" :
        (honap_szam == 8) ? "augusztus" :
        (honap_szam == 9) ? "szeptember" :
        (honap_szam == 10) ? "október" :
        (honap_szam == 11) ? "december" :
        (honap_szam == 12) ? "február" :
        "nincs ilyen hónap";
console.log(honap_neve); */
//2., Kérjen be prompt-al szöveget, melyet konvertáljon számmá, és írja ki az eredményt - console-ra!
/*let szoveges_szam = prompt("Kérem írjon be egy számot", 1);
console.log(szoveges_szam, typeof szoveges_szam);
let szam = Number(szoveges_szam)
console.log(szam, typeof szam);*/
//3., Kérjen be prompt-al - "Kérlek írd be, hogy igaz-e, hogy tanultál?" -> igaz beírásra az eredményt konvertálja true-ra, hamis beírásra false-ra,  
//úgy, hogy boolean típus legyen, ha típus-lekérdezéssel megvizsgáljuk! Majd vizsgáljuk meg és azt is írjuk a console-ra!
/*let tanultal_e = prompt("Kérlek írd be, hogy igaz-e, hogy tanultál?", "igaz");
let valasz;
if(tanultal_e === "igaz"){
    valasz = Boolean(true);
}else if(tanultal_e === "hamis"){
    valasz = Boolean(false);
}else{
    valasz = "ezt nem tudom értelmezni. írj be 'igaz'-at vagy 'hamis'-at!";
}
console.log(`A válasz: ${valasz}, típusa: ${typeof valasz}`);*/
//4., Kérjünk be prompt-al számot, melyet szöveggé alakítunk és kiíratjuk a console-ra!
/*let szoveges_szam_2 = Number(prompt("Kérem írjon be egy számot", 1));
console.log(szoveges_szam_2, typeof szoveges_szam_2);
let szam_2 = String(szoveges_szam_2)
console.log(szam_2, typeof szam_2);
*/
//5., Az előző feladatokat alakítsuk úgy át, hogy function-ökként meghívva / vagy arrow function-ként meghívva működjenek!
let HonapFunction = () => {
    let honap = () => prompt("Kérem írja be a hónap számát", 1);
    let honap_szam = Number(honap());
    let honap_neve = (honap_szam == 1) ? "január" : 
            (honap_szam == 2) ? "február" :
            (honap_szam == 3) ? "március" :
            (honap_szam == 4) ? "április" :
            (honap_szam == 5) ? "május" :
            (honap_szam == 6) ? "június" :
            (honap_szam == 7) ? "július" :
            (honap_szam == 8) ? "augusztus" :
            (honap_szam == 9) ? "szeptember" :
            (honap_szam == 10) ? "október" :
            (honap_szam == 11) ? "december" :
            (honap_szam == 12) ? "február" :
            "nincs ilyen hónap";
            console.log(honap_neve);
}
let SzamKonverzioFunction = () => {
    let szoveges_szam = prompt("Kérem írjon be egy számot", 1);
    console.log(szoveges_szam, typeof szoveges_szam);
    let szam = Number(szoveges_szam)
    console.log(szam, typeof szam);
}
let TanultalEFunction = () => {
    let tanultal_e = prompt("Kérlek írd be, hogy igaz-e, hogy tanultál?", "igaz");
    let valasz;
    if(tanultal_e === "igaz"){
        valasz = Boolean(true);
    }else if(tanultal_e === "hamis"){
        valasz = Boolean(false);
    }else{
        valasz = "ezt nem tudom értelmezni. írj be 'igaz'-at vagy 'hamis'-at!";
    }
    console.log(`A válasz: ${valasz}, típusa: ${typeof valasz}`);
}
let SzovegkonverzioFunction = () => {
    let szoveges_szam_2 = Number(prompt("Kérem írjon be egy számot", 1));
    console.log(szoveges_szam_2, typeof szoveges_szam_2);
    let szam_2 = String(szoveges_szam_2)
    console.log(szam_2, typeof szam_2);
}
HonapFunction();
SzamKonverzioFunction();
TanultalEFunction();
SzovegkonverzioFunction();