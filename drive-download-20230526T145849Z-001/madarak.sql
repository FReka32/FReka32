-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Nov 03. 18:25
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
-- Adatbázis: `madarak`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `galambok`
--

CREATE TABLE `galambok` (
  `id` int(7) NOT NULL,
  `nev` varchar(40) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `gazda` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `eletkor` tinyint(3) NOT NULL,
  `fajta` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `nem` tinyint(1) NOT NULL,
  `labakszama` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `galambok`
--

INSERT INTO `galambok` (`id`, `nev`, `gazda`, `eletkor`, `fajta`, `nem`, `labakszama`) VALUES
(1, 'Tubuka', 'Béla', 3, 'vad', 1, 12),
(2, 'Lyenő', 'József', 32, 'házi', 0, 2),
(9, 'Jóska', 'Béla', 3, 'vad', 1, 12),
(12, 'Aladár', 'Tivadar', 1, 'szelíd', 1, 2),
(16, 'Rezsőke', 'Elemér', 3, 'szelíd', 1, 2),
(17, 'Jani', 'Béla', 3, 'vad', 1, 12);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `galambok`
--
ALTER TABLE `galambok`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nev` (`nev`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `galambok`
--
ALTER TABLE `galambok`
  MODIFY `id` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
