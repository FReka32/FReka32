-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Dec 06. 18:23
-- Kiszolgáló verziója: 10.4.20-MariaDB
-- PHP verzió: 7.3.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `autopiac`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `felhasznalo`
--

CREATE TABLE `felhasznalo` (
  `ID` int(7) NOT NULL,
  `FelhasznaloNeve` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `TeljesNev` varchar(40) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `Salt` varchar(64) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `Hash` varchar(64) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `Email` varchar(45) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `Jogosultsag` int(1) NOT NULL,
  `Aktiv` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `felhasznalo`
--

INSERT INTO `felhasznalo` (`ID`, `FelhasznaloNeve`, `TeljesNev`, `Salt`, `Hash`, `Email`, `Jogosultsag`, `Aktiv`) VALUES
(1, 'a', 'Adminisztrátor', 'dkBczmjgWSy0aujs7sjUppKkICH17L0eYo2XGYUCmOp9Dia1uWrsCDjyZaUxeriL', '9eb55e5fe5a8745da5bb73d2a5babf6888d1dbdb03da9c83f95ff2c08d775c4f', 'fazekasr@kkszki.hu', 9, 1),
(2, 'b', 'Adminisztrátor 2', 'V6QzCF1tp5GRLFDXMGeIBrokR1Iz7wknscRSmNZpw8JYB9O2n5koD83oSqhL6Bw2', '06d3eb825241f08af486236f39db2b8874d30bc53b3ffee1563c0c1a6f57cb73', 'b@kkszki.hu', 9, 1),
(3, 'c', 'Adminisztrátor 3', 'kVzayoNLyejw3ijPFvLYDnR0kW0ZWRP2GxFzq3llyXCetJ3EUkiXLs37D9zcxyzh', '907675411faff3314d138e33cccdb85315c2355c9d39cea5a0b1087b9f3b94ae', 'c@kkszki.hu', 9, 1),
(4, 'joska', 'József', 'ZmnifZ27vhFdkc61UPVtNEcyvtzAhIevov39MKupQpqFBvadGkiZZuPVJywwj2Zm', '3304726816fcdae400c7ff53d5b784d0aaa22c90fd8712e55957c377f499bcde', 'jozsef@kkszki.hu', 9, 1),
(5, 'bb', 'Béla', 'OoXc3QYo40u0zeD9kxDvLxzQxU9fuY481HLOE7gSnohoqWUx4OjXoVBbzHojR23f', '7efb611d4dd782984c6742c1431e7773ba72ab2d1aa7c93ce83ef5d2a0f68157', 'bela', 9, 1);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `felhasznalo`
--
ALTER TABLE `felhasznalo`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `FelhasznaloNeve` (`FelhasznaloNeve`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `felhasznalo`
--
ALTER TABLE `felhasznalo`
  MODIFY `ID` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
