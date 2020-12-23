-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 23, 2020 at 07:44 AM
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
-- Table structure for table `stock_in`
--

CREATE TABLE `stock_in` (
  `stockinRefNo` bigint(20) NOT NULL,
  `stockinPcode` bigint(20) NOT NULL,
  `stockinItem` varchar(250) NOT NULL,
  `stockinQty` int(11) NOT NULL,
  `stockinPrice` int(11) NOT NULL,
  `stockinDate` datetime NOT NULL,
  `stockinId` bigint(20) NOT NULL,
  `stockinStatus` varchar(100) NOT NULL DEFAULT 'Stock In Pending',
  `stockinBy` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `stock_in`
--

INSERT INTO `stock_in` (`stockinRefNo`, `stockinPcode`, `stockinItem`, `stockinQty`, `stockinPrice`, `stockinDate`, `stockinId`, `stockinStatus`, `stockinBy`) VALUES
(503735031713, 700, 'Chicken Nuggets', 10, 60, '2020-12-23 14:10:37', 5, 'Stock In', NULL),
(503735031713, 6969, 'Chicken Longganisa', 10, 21, '2020-12-23 14:10:41', 6, 'Stock In', NULL),
(578415653666, 6969, 'Chicken Longganisa', 10, 21, '2020-12-23 14:15:33', 10, 'Stock In', NULL),
(578415653666, 700, 'Chicken Nuggets', 10, 60, '2020-12-23 14:15:36', 11, 'Stock In', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `stock_in`
--
ALTER TABLE `stock_in`
  ADD PRIMARY KEY (`stockinId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `stock_in`
--
ALTER TABLE `stock_in`
  MODIFY `stockinId` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
