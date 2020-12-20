-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 20, 2020 at 08:03 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `iantestinventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `datasalesinventory`
--

CREATE TABLE `datasalesinventory` (
  `salesTransNo` bigint(12) NOT NULL,
  `refNo` bigint(15) NOT NULL,
  `salesNo` bigint(249) NOT NULL,
  `salesItem` varchar(249) NOT NULL,
  `salesBrand` varchar(249) NOT NULL,
  `salesSRP` int(249) NOT NULL,
  `salesRP` int(249) NOT NULL,
  `salesVAT` double NOT NULL,
  `salesQty` int(249) NOT NULL,
  `salesTotal` int(249) NOT NULL,
  `salesDate` timestamp NOT NULL DEFAULT current_timestamp(),
  `salesStatus` varchar(10) DEFAULT NULL,
  `salesCategory` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `datasalesinventory`
--
ALTER TABLE `datasalesinventory`
  ADD UNIQUE KEY `refNo` (`refNo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `datasalesinventory`
--
ALTER TABLE `datasalesinventory`
  MODIFY `refNo` bigint(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1118;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
