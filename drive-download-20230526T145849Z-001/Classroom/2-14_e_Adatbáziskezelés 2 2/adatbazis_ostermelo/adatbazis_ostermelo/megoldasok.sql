A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat: CREATE DATABASE `ostermelok` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;

3. feladat: SELECT DISTINCT `telepules` FROM `partnerek` ORDER BY `telepules` ASC;

4. feladat: SELECT COUNT(*) as "alkalmak" FROM kiszallitasok INNER JOIN partnerek ON kiszallitasok.partnerid = partnerek.id WHERE telepules = "Vác";

5. feladat: SELECT MAX(kiszallitasok.karton) as "legtobb" FROM kiszallitasok WHERE YEAR(kiszallitasok.datum) = 2016 AND MONTH(kiszallitasok.datum) = 5;

6. feladat: SELECT telepules FROM (SELECT telepules, COUNT(*) as darab FROM partnerek GROUP BY partnerek.telepules) as tbl WHERE tbl.darab > 1;

7. feladat: SELECT `gyumolcslevek`.`gynev` AS ital, SUM((`kiszallitasok`.`karton`)*6) AS doboz FROM `gyumolcslevek` INNER JOIN `kiszallitasok` ON `kiszallitasok`.`gyumleid` = `gyumolcslevek`.`id` group by `gynev` ORDER BY doboz DESC LIMIT 3;

