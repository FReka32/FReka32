A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!









/*1. Listázd ki a Szegedi tulajdonosok minden adatát!*/
1. feladat: SELECT * FROM bank where bank.varos = "Szeged";
/*2. Kinek legnagyobb az egyenleg a számláján! (Teljes neve)*/
2. feladat: SELECT bank.vezeteknev, bank.keresztnev FROM bank ORDER BY bank.egyenleg DESC LIMIT 1;
/*3. Roz Márta bankszámlaszámát keresném.*/
3. feladat: SELECT bank.szamlaszam FROM `bank` WHERE bank.vezeteknev = "Roz" AND bank.keresztnev = "Márta";
/*4. Bármi Áron-nak milyen kocsija van?*/
4. feladat: SELECT `auto`.`szin`, `auto`.`tipus` FROM `auto` WHERE `auto`.`utalo_fel_neve` = "Bármi Áron";
/*5. Listázd ki a fehér színű autók tulajdonosainak nevét, lakcímét*/
5. feladat: SELECT `auto`.`utalo_fel_neve`, `bank`.`lakcim` FROM `auto` INNER JOIN `bank` ON `auto`.`utalo_fel_szamlaszama` = `bank`.`szamlaszam` WHERE `auto`.`szin` = "fehér";
/*6. A legidősebb autó típusa színe és rendszáma.*/
6. feladat: SELECT `auto`.`tipus`, `auto`.`szin`, `auto`.`rendszam` FROM `auto` ORDER BY `auto`.`gyartas_datuma` ASC LIMIT 1;
/*7. Mely városokból hányan dolgoznak a gyárban? A mezők cimkéi: város, fő*/
7. feladat: SELECT bank.varos as "város", count(bank.id) as "fő" FROM bank GROUP BY bank.varos;

8.feladat:

9. feladat:

10. feladat:

11. feladat:
