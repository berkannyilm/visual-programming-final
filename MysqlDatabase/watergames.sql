-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost
-- Üretim Zamanı: 02 Oca 2023, 20:36:33
-- Sunucu sürümü: 8.0.17
-- PHP Sürümü: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `watergames`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `atheletestatistics`
--

CREATE TABLE `atheletestatistics` (
  `Id` int(11) NOT NULL,
  `AtheleteId` int(11) NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `CommitteeId` int(11) NOT NULL,
  `CompetitionId` int(11) NOT NULL,
  `Ranking` int(11) NOT NULL,
  `Duration` time NOT NULL,
  `Performance` int(11) NOT NULL,
  `Point` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `atheletestatistics`
--

INSERT INTO `atheletestatistics` (`Id`, `AtheleteId`, `CategoryId`, `CommitteeId`, `CompetitionId`, `Ranking`, `Duration`, `Performance`, `Point`, `CreatedDate`) VALUES
(1, 12, 4, 15, 1, 1, '08:58:00', 134, 98, '2022-12-31 23:02:12'),
(2, 12, 1, 15, 1, 32, '05:18:18', 432, 32, '2023-01-03 23:07:37'),
(3, 29, 4, 15, 1, 2, '07:05:00', 100, 97, '2023-01-01 21:28:46'),
(4, 12, 3, 15, 1, 2, '07:20:26', 2, 2, '2023-01-01 23:36:38'),
(5, 36, 7, 17, 3, 8, '07:20:21', 170, 900, '2023-01-02 23:28:42'),
(6, 36, 7, 17, 3, 6, '08:07:08', 140, 65, '2023-01-02 23:34:26');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `athletecategories`
--

CREATE TABLE `athletecategories` (
  `Id` int(11) NOT NULL,
  `Title` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `athletecategories`
--

INSERT INTO `athletecategories` (`Id`, `Title`) VALUES
(1, 'Yelken'),
(3, 'Teniss'),
(4, 'Dalış'),
(7, 'Su Topu');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `athletes`
--

CREATE TABLE `athletes` (
  `Id` int(11) NOT NULL,
  `athleteCategoryId` int(11) NOT NULL,
  `Firstname` varchar(50) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Address` varchar(250) NOT NULL,
  `District` varchar(50) NOT NULL,
  `City` varchar(50) NOT NULL,
  `Weight` int(11) NOT NULL,
  `Age` int(11) NOT NULL,
  `Height` int(11) NOT NULL,
  `IpAddress` varchar(50) NOT NULL,
  `DateOfBirth` datetime DEFAULT CURRENT_TIMESTAMP,
  `LastLoginDate` datetime DEFAULT NULL,
  `UpdatedDate` datetime DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `ApplyStatus` enum('Active','InActive') CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'InActive',
  `LicenseStatus` enum('Active','InActive') CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `LicenseStartedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `LicenseFinishedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `Status` enum('0','1') NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `athletes`
--

INSERT INTO `athletes` (`Id`, `athleteCategoryId`, `Firstname`, `Lastname`, `Username`, `Password`, `Address`, `District`, `City`, `Weight`, `Age`, `Height`, `IpAddress`, `DateOfBirth`, `LastLoginDate`, `UpdatedDate`, `CreatedDate`, `ApplyStatus`, `LicenseStatus`, `LicenseStartedDate`, `LicenseFinishedDate`, `Status`) VALUES
(12, 1, 'Berkan', 'Yılmaz', 'berkanium', 'Ll0JzZzk8gN+AlMyuR/S3A==', 'adres', 'Çay', 'AFYONKARAHİSAR', 75, 45, 5, '192.168.1.61', '2023-01-02 00:00:00', '2023-01-02 23:34:59', '2023-01-02 23:25:23', '2023-01-01 21:26:46', 'Active', 'Active', '2023-02-11 00:00:00', '2023-02-18 00:00:00', '1'),
(34, 1, 'Ayşe ', 'Günay', 'ayseium', 'Ll0JzZzk8gN+AlMyuR/S3A==', 'Address Bilgisi', 'Çay', 'AFYONKARAHİSAR', 0, 0, 0, '192.168.1.61', '2023-01-04 00:00:00', NULL, '2023-01-02 23:17:16', '2023-01-02 23:17:16', 'Active', 'Active', '2023-01-31 00:00:00', '2023-01-20 00:00:00', '1'),
(35, 4, 'Eslem', 'Gürbüz', '123456', 'uQHBfS1zALNilJhZ/DMxeQ==', 'Adres buraya gelecek', 'Bolvadin', 'AFYONKARAHİSAR', 0, 0, 0, '192.168.1.61', '2023-01-25 00:00:00', NULL, '2023-01-02 23:20:35', '2023-01-02 23:20:35', 'Active', 'Active', '2023-01-27 00:00:00', '2023-01-18 00:00:00', '1'),
(36, 3, 'Alara', 'Aslan', 'alara', 'Ll0JzZzk8gN+AlMyuR/S3A==', 'Adres buraya gelecek', 'Şavşat', 'ARTVİN', 58, 20, 174, '192.168.1.61', '2023-01-02 00:00:00', '2023-01-02 23:32:40', '2023-01-02 23:25:23', '2023-01-02 23:26:12', 'Active', 'Active', '2023-01-02 00:00:00', '2023-02-05 00:00:00', '1');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `committees`
--

CREATE TABLE `committees` (
  `Id` int(11) NOT NULL,
  `Firstname` varchar(100) NOT NULL,
  `Lastname` varchar(100) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Address` varchar(250) NOT NULL,
  `District` varchar(50) NOT NULL,
  `City` varchar(50) NOT NULL,
  `IpAddress` varchar(50) NOT NULL,
  `Status` enum('0','1') CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '1',
  `DateOfBirth` datetime DEFAULT NULL,
  `LastLoginDate` datetime DEFAULT NULL,
  `UpdatedDate` datetime DEFAULT NULL,
  `CreatedDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `committees`
--

INSERT INTO `committees` (`Id`, `Firstname`, `Lastname`, `Username`, `Password`, `Address`, `District`, `City`, `IpAddress`, `Status`, `DateOfBirth`, `LastLoginDate`, `UpdatedDate`, `CreatedDate`) VALUES
(15, 'Emre', 'Ülger', 'emreium', 'IVEX3W5FpTymsjcFovVM7A==', 'hj', 'Besni', 'ADIYAMAN', '192.168.1.61', '1', '2023-01-02 00:00:00', NULL, '0001-01-01 00:00:00', '2022-12-31 22:40:29'),
(17, 'Berkan', 'Yılmaz', 'berkanium', 'Ll0JzZzk8gN+AlMyuR/S3A==', 'Adres', 'Mutki', 'BİTLİS', '192.168.1.61', '1', '2022-08-11 00:00:00', NULL, '0001-01-01 00:00:00', '2023-01-02 23:27:51');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `competitions`
--

CREATE TABLE `competitions` (
  `Id` int(11) NOT NULL,
  `categoryId` int(11) NOT NULL,
  `Title` varchar(100) NOT NULL,
  `Record` varchar(50) NOT NULL,
  `MaximumCapacity` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `competitions`
--

INSERT INTO `competitions` (`Id`, `categoryId`, `Title`, `Record`, `MaximumCapacity`, `CreatedDate`) VALUES
(1, 1, 'Yelken Yarışları', '08:11:05', 150, '2022-12-31 03:54:42'),
(3, 4, 'Dalış Yarışmaları', '08:05:00', 150, '2023-01-02 23:22:55');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `managers`
--

CREATE TABLE `managers` (
  `Id` int(2) NOT NULL,
  `Firstname` varchar(100) NOT NULL,
  `Lastname` varchar(100) NOT NULL,
  `Username` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `IpAddress` varchar(50) NOT NULL,
  `LastLoginDate` datetime DEFAULT NULL,
  `UpdatedDate` datetime DEFAULT NULL,
  `CreatedDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `managers`
--

INSERT INTO `managers` (`Id`, `Firstname`, `Lastname`, `Username`, `Password`, `IpAddress`, `LastLoginDate`, `UpdatedDate`, `CreatedDate`) VALUES
(22, 'Berkan', 'Yılmaz', 'berkanium', 'Ll0JzZzk8gN+AlMyuR/S3A==', '192.168.1.61', '2023-01-02 23:33:07', '2023-01-01 22:32:37', '2023-01-01 22:27:07');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `atheletestatistics`
--
ALTER TABLE `atheletestatistics`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `athletecategories`
--
ALTER TABLE `athletecategories`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `athletes`
--
ALTER TABLE `athletes`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `committees`
--
ALTER TABLE `committees`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `competitions`
--
ALTER TABLE `competitions`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `managers`
--
ALTER TABLE `managers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `atheletestatistics`
--
ALTER TABLE `atheletestatistics`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `athletecategories`
--
ALTER TABLE `athletecategories`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Tablo için AUTO_INCREMENT değeri `athletes`
--
ALTER TABLE `athletes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- Tablo için AUTO_INCREMENT değeri `committees`
--
ALTER TABLE `committees`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Tablo için AUTO_INCREMENT değeri `competitions`
--
ALTER TABLE `competitions`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `managers`
--
ALTER TABLE `managers`
  MODIFY `Id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
