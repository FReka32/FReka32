-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Ápr 19. 16:50
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `mymenu`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `admin`
--

CREATE TABLE `admin` (
  `AdId` int(11) NOT NULL,
  `AdName` varchar(40) NOT NULL,
  `AdPermission` varchar(10) NOT NULL,
  `AdEmail` varchar(40) NOT NULL,
  `AdPhone` varchar(20) NOT NULL,
  `Active` int(2) NOT NULL,
  `Salt` varchar(64) NOT NULL,
  `Hash` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `admin`
--

INSERT INTO `admin` (`AdId`, `AdName`, `AdPermission`, `AdEmail`, `AdPhone`, `Active`, `Salt`, `Hash`) VALUES
(1, 'Fazekas Réka', '9', 'f@f.hu', '+3636', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(2, 'a', '9', 'p@p.hu', '+36', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(3, 'Kolyankovszky Gusztáv', '9', 'kg@kg.hu', '+3670', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(4, 'Dömötör Gyula', '9', 'dgy@dgy.hu', '+3670', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(5, 'Kukor Ica', '1', 'kukorica@freemail.hu', '+3670', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(6, 'Piz Zalán', '2', 'pizzalan@gmail.com', '+3630', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(7, 'Olivabogy Olivér', '3', 'olivabogyo@gmail.com', '*3670', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(8, 'Sonk Andrea', '4', 'sonka@citromail.hu', '+3630', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(9, 'Virs Lee', '5', 'virsli@gmail.com', '+3620', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(10, 'Füst Lee', '6', 'fustli@citromail.hu', '+3630', 0, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(11, 'Kif Lee', '7', 'kifli@gmail.com', '+3670', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d'),
(12, 'Bruce Lee', '8', 'brucelee@citromail.hu', '+3630', 1, 'hyD7KTz06AdOpATFk7KWycl2NRYH0AQuTmoEfFdcsyiZki1xysuMLmPoBBH52rR6', '7fdfcacc1bbc99a48778a18770ae72321a12e54417a05f1f8296368f4265e35d');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `commodity`
--

CREATE TABLE `commodity` (
  `CoId` int(11) NOT NULL,
  `CoName` varchar(40) NOT NULL,
  `CoUnit` int(10) NOT NULL,
  `CoCat` int(3) NOT NULL,
  `CoPrice` int(10) NOT NULL,
  `CoActive` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `commodity`
--

INSERT INTO `commodity` (`CoId`, `CoName`, `CoUnit`, `CoCat`, `CoPrice`, `CoActive`) VALUES
(1, 'sonka', 1, 2, 12, 0),
(2, 'sajt', 1, 3, 34, 0),
(3, 'szalámi', 1, 2, 56, 0),
(4, 'polip', 1, 2, 67, 1),
(5, 'hagyma', 1, 2, 50, 0),
(6, 'bab', 1, 2, 55, 0),
(7, 'pepperoni paprika', 1, 2, 30, 0),
(8, 'oregánó', 1, 2, 15, 0),
(9, 'bazsalikom', 1, 2, 15, 0),
(10, 'lilahagyma', 1, 2, 10, 0),
(11, 'bacon', 1, 2, 55, 0),
(12, 'mozzarella', 1, 2, 55, 0),
(13, 'kukorica', 1, 2, 20, 0),
(14, 'póréhagyma', 1, 2, 10, 0),
(15, 'kukorica', 1, 2, 20, 0),
(16, 'póréhagyma', 1, 2, 10, 0),
(17, 'kolbász', 1, 2, 35, 0),
(18, 'csirkemell', 1, 2, 45, 0),
(19, 'barbecue-szósz', 1, 2, 15, 0),
(20, 'bolognai ragu', 1, 2, 35, 0),
(21, 'kaliforniai paprika', 1, 2, 20, 0),
(22, 'zöldpaprika', 1, 2, 20, 0),
(23, 'jalapeno', 1, 2, 15, 0),
(24, 'kagyló', 1, 2, 20, 0),
(25, 'rák', 1, 2, 20, 0),
(26, 'gomba', 1, 2, 20, 0),
(27, 'füstölt tarja', 1, 2, 45, 0),
(28, 'feta sajt', 1, 2, 20, 0),
(29, 'cheddar sajt', 1, 2, 35, 0),
(30, 'paradicsom', 1, 2, 20, 0),
(31, 'uborka', 1, 2, 20, 0),
(32, 'zöld olivabogyó', 1, 2, 15, 0),
(33, 'fekete olivabogyó', 1, 2, 20, 0),
(34, 'tonhal', 1, 2, 35, 0),
(35, 'parmezán sajt', 1, 2, 45, 0),
(36, 'márványsajt', 1, 2, 30, 0),
(37, 'sajtkrém', 1, 2, 20, 0),
(38, 'brokkoli', 1, 2, 15, 0),
(39, 'tükörtojás', 1, 2, 35, 0),
(40, 'füstölt csülök', 1, 2, 45, 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `orders`
--

CREATE TABLE `orders` (
  `OrId` int(11) NOT NULL,
  `AdId` int(11) DEFAULT NULL,
  `Name` varchar(100) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Phone` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Status` int(11) NOT NULL,
  `LogDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `orders`
--

INSERT INTO `orders` (`OrId`, `AdId`, `Name`, `Address`, `Phone`, `Email`, `Status`, `LogDate`) VALUES
(1, NULL, 'Rend Elek', '8500 Balatonrendek, József Attila utca 9865.', '+36705555444', 'rendelek@gmail.com', 0, '2023-04-19 01:32:26'),
(2, NULL, 'Berend Elek', '8565, Balatonrendes, Rendes utca 5647.', '+36302222888', 'berendelek@freemail.hu', 0, '2023-04-19 01:34:28'),
(3, NULL, 'Megrend Elek', '9855, Herend, Megren-dűlő 6587.', '+36206666444', 'megrendelek@citromail.hu', 0, '2023-04-19 01:37:20'),
(4, NULL, 'Kirend Elek', '7845, Ököritófülpös, Rendelő köz 456.', '+36701111222', 'kirendelek@gmail.com', 0, '2023-04-19 01:40:14'),
(5, NULL, 'Elrend Elek', '6523, Elrendelőháza, Petőfi utca 4562.', '+36209999444', 'elrendelek@citromail.hu', 0, '2023-04-19 01:48:38');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `product`
--

CREATE TABLE `product` (
  `PrId` int(11) NOT NULL,
  `PrName` varchar(40) NOT NULL,
  `PrSize` varchar(10) NOT NULL,
  `PrOther` varchar(80) NOT NULL,
  `PrUrl` varchar(40) NOT NULL,
  `PrActive` int(2) NOT NULL,
  `PrPrice` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `product`
--

INSERT INTO `product` (`PrId`, `PrName`, `PrSize`, `PrOther`, `PrUrl`, `PrActive`, `PrPrice`) VALUES
(1, 'Sonkás pizza', '25, 35, 45', 'Sonka, sajt', '', 0, 1500),
(2, 'Szalámis pizza', '25, 35, 45', 'szalámi, sajt', '', 0, 1600),
(3, 'Tenger gyümölcsei', '25, 35, 45', 'kagyló, rák, polip', '', 0, 2000),
(4, 'Margherita', '25, 35, 45', 'Paradicsomszósz, sajt', '', 0, 2040),
(5, 'Prosciutto', '25, 35, 45', 'Paradicsomszósz, sajt, sonka', '', 0, 2400),
(6, 'Funghi', '25, 35, 45', 'Paradicsomszósz, sajt, gomba', '', 0, 2400),
(7, 'Tonno', '25, 35, 45', 'Paradicsomszósz, sajt, tonhal, lilahagyma, olivabogyó', '', 0, 2540),
(8, 'Quattro Formaggi', '25, 35, 45', 'Paradicsomszósz, négyféle sajt: trappista, füstölt sajt, mozzarella, camembert', '', 0, 2540),
(9, 'Quattro Stangioni', '25, 35, 45', 'Paradicsomszósz, sajt, bolognai ragu, gomba, sonka, szalámi', '', 0, 2540),
(10, 'Hawaii', '25, 35, 45', 'Paradicsomszósz, sajt, sonka, ananász\r\n', '', 0, 2540),
(11, 'Giulia', '25, 35, 45', 'Tejföl, sajt, tarja, szalámi, hagyma, bacon', '', 0, 2540),
(12, 'Vegetariana', '25, 35, 45', 'Paradicsomszósz, sajt, brokkoli, répa, gomba, paradicsom, kukorica', '', 0, 2540),
(13, 'Grandiosa', '25, 35, 45', 'Paradicsomszósz, sajt, szalámi, sonka, füstölt tarja, lilahagyma, paradicsom, ba', '', 0, 2640),
(14, 'Bolognese', '25, 35, 45', 'Bolognai ragu, sajt', '', 0, 2540),
(15, 'Greek', '25, 35, 45', 'Kapros tejföl, sajt, gyros hús, olívabogyó, paradicsom, uborka', '', 0, 2540),
(16, 'Ungherese', '25, 35, 45', 'Paradicsomszósz, sajt, szalámi, füstölt tarja, paprika, paradicsom, fokhagyma, h', '', 0, 2540),
(17, 'Mais', '25, 35, 45', 'Paradicsomszósz, sajt, sonka, szalámi, kukorica', '', 0, 2540),
(18, 'Carbonara', '25, 35, 45', 'Fokhagymás-tejszínes alap,sajt,füstölt sajt, bacon', '', 0, 2540),
(19, 'Isolana', '25, 35, 45', 'Tejföl, füstölt sajt, sajt, sonka, füstölt tarja, ruccola', '', 0, 2540),
(20, 'Mexicana', '25, 35, 45', 'Csípős bolognai ragu, sajt, bab, kukorica\r\n', '', 0, 2540),
(21, 'Diablo', '25, 35, 45', 'Paradicsomszósz, sajt, szalámi, füst. tarja, hagyma, juhtúró, bacon, pepperoni', '', 0, 2640),
(22, 'Barbecue', '25, 35, 45', 'Barbecue szósz, sajt csirkemell, füstölt tarja, lilahagyma, bacon', '', 0, 2640),
(23, 'Gambaretti', '25, 35, 45', 'Paradicsomszósz, sajt, fokhagyma, garnélarák, ruccola, paradicsom, citrom', '', 0, 2640),
(24, 'Maffia', '25, 35, 45', 'Tejföl, füstölt sajt, sonka, csirkemell', '', 0, 2540),
(25, 'Gianni', '25, 35, 45', 'Csípős tejföl, füstölt tarja, füstölt sajt, csípős pepperoni, lilahagyma', '', 0, 2540),
(26, 'Roberto', '25, 35, 45', 'Kapros tejföl, fokhagyma, sajt, csirkemell, kukorica', '', 0, 2540),
(27, 'Piedone', '25, 35, 45', 'Paradicsomszósz, sajt, bacon kocka hagyma, bab, kolbász', '', 0, 2540),
(28, 'Perfecto', '25, 35, 45', 'Paradicsomszósz, négyféle sajt, sonka,szalámi,hagyma, paradicsom karika, uborka', '', 0, 2640),
(29, 'Milano', '25, 35, 45', 'Paradicsomszósz, sajt, sonka, gomba, lilahagyma, bacon', '', 0, 2640),
(30, 'Zingaro', '25, 35, 45', 'csípős paradicsomszósz, fokhagyma, bolognai ragu, sajt, szalámi, lilahagyma, bab', '', 0, 2640),
(31, 'Brindza', '25, 35, 45', 'tejföl, juhtúró, kapor, sajt, csirkemell, fokhagyma', '', 0, 2640),
(32, 'Pippo', '25, 35, 45', 'Mustáros-tejfölös alap, sajt, füstölt tarja, lilahagyma, csemege uborka', '', 0, 2640),
(33, 'Angelo', '25, 35, 45', 'Paradicsomszósz, sajt, ananász, csirkemell, kukorica', '', 0, 2640),
(34, 'Toscana', '25, 35, 45', 'Tejföl, feta, sajt, csirkemell, gomba\r\n', '', 0, 2640),
(35, 'Songoku', '25, 35, 45', 'Paradicsomszósz, sajt, sonka, gomba, kukorica', '', 0, 2640),
(36, 'Ínyenc', '25, 35, 45', 'Paradicsomszósz, érlelt Prosciutto sonka, pepperoni, kakukkfüves sajt, füstölt s', '', 0, 2740),
(37, 'Corleone', '25, 35, 45', 'Paradicsomszósz, sajt, ropogós csülök, bab, füstölt szalonna, hagyma karika', '', 0, 2740),
(38, 'Favorito', '25, 35, 45', 'Fokhagymás–tejszínes alap, sajt, tarja, lilahagyma, zempléni sajt, füstölt sajt,', '', 0, 2740),
(39, 'Sajtimádó', '25, 35, 45', 'Paradicsomszósz, sonka, kakukkfüves sajt, zempléni füstölt sajt, zempléni sajt, ', '', 0, 2740),
(40, 'Frutti di Mare', '25, 35, 45', 'Paradicsomszósz, fokhagyma, sajt, tenger gyümölcsei, citrom', '', 0, 2740);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `receiptconn`
--

CREATE TABLE `receiptconn` (
  `ReId` int(7) NOT NULL,
  `PrId` int(11) NOT NULL,
  `CoId` int(11) NOT NULL,
  `Quantity` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `receiptconn`
--

INSERT INTO `receiptconn` (`ReId`, `PrId`, `CoId`, `Quantity`) VALUES
(1, 1, 1, 2),
(2, 1, 2, 1),
(3, 2, 3, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tetelconn`
--

CREATE TABLE `tetelconn` (
  `OrId` int(11) NOT NULL,
  `PrId` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`AdId`);

--
-- A tábla indexei `commodity`
--
ALTER TABLE `commodity`
  ADD PRIMARY KEY (`CoId`);

--
-- A tábla indexei `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrId`),
  ADD KEY `CuId` (`AdId`);

--
-- A tábla indexei `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`PrId`);

--
-- A tábla indexei `receiptconn`
--
ALTER TABLE `receiptconn`
  ADD PRIMARY KEY (`ReId`),
  ADD KEY `CoId` (`CoId`),
  ADD KEY `PrId` (`PrId`);

--
-- A tábla indexei `tetelconn`
--
ALTER TABLE `tetelconn`
  ADD PRIMARY KEY (`OrId`),
  ADD KEY `PrId` (`PrId`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `admin`
--
ALTER TABLE `admin`
  MODIFY `AdId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT a táblához `commodity`
--
ALTER TABLE `commodity`
  MODIFY `CoId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT a táblához `orders`
--
ALTER TABLE `orders`
  MODIFY `OrId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `receiptconn`
--
ALTER TABLE `receiptconn`
  MODIFY `ReId` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `tetelconn`
--
ALTER TABLE `tetelconn`
  MODIFY `OrId` int(11) NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`AdId`) REFERENCES `admin` (`AdId`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `receiptconn`
--
ALTER TABLE `receiptconn`
  ADD CONSTRAINT `receiptconn_ibfk_1` FOREIGN KEY (`PrId`) REFERENCES `product` (`PrId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `receiptconn_ibfk_2` FOREIGN KEY (`CoId`) REFERENCES `commodity` (`CoId`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `tetelconn`
--
ALTER TABLE `tetelconn`
  ADD CONSTRAINT `tetelconn_ibfk_1` FOREIGN KEY (`OrId`) REFERENCES `orders` (`OrId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tetelconn_ibfk_2` FOREIGN KEY (`PrId`) REFERENCES `product` (`PrId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
