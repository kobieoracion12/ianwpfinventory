-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 14, 2020 at 03:56 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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
  `refNo` bigint(15) NOT NULL,
  `salesNo` bigint(249) NOT NULL,
  `salesItem` varchar(249) NOT NULL,
  `salesBrand` varchar(249) NOT NULL,
  `salesDate` timestamp NOT NULL DEFAULT current_timestamp(),
  `salesSRP` int(249) NOT NULL,
  `salesRP` int(249) NOT NULL,
  `salesQty` int(249) NOT NULL,
  `salesTotal` int(249) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `datasalesinventory`
--

INSERT INTO `datasalesinventory` (`refNo`, `salesNo`, `salesItem`, `salesBrand`, `salesDate`, `salesSRP`, `salesRP`, `salesQty`, `salesTotal`) VALUES
(2, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-24 23:43:07', 102, 110, 1, 110),
(4, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-24 23:54:56', 102, 110, 1, 110),
(5, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-24 23:55:50', 24, 26, 1, 26),
(6, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-24 23:56:21', 24, 26, 1, 26),
(7, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-24 23:56:27', 24, 26, 1, 26),
(8, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', '2020-10-24 23:59:02', 35, 50, 1, 50),
(13, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', '2020-10-25 00:00:00', 12, 13, 1, 13),
(14, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', '2020-10-25 00:00:04', 12, 13, 1, 13),
(15, 4800016644801, 'Piattos Cheese', 'Jack n Jill', '2020-10-25 00:00:35', 12, 13, 1, 13),
(16, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', '2020-10-25 00:01:07', 13, 13, 1, 13),
(17, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', '2020-10-25 00:01:47', 12, 13, 1, 13),
(19, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', '2020-10-25 00:02:15', 23, 50, 1, 50),
(20, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-25 00:03:13', 102, 110, 1, 110),
(21, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-25 00:03:48', 102, 110, 1, 110),
(22, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-25 00:04:07', 102, 110, 1, 110),
(23, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', '2020-10-25 00:07:31', 12, 13, 1, 13),
(24, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-25 00:08:28', 24, 26, 1, 26),
(25, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-25 00:08:58', 24, 26, 1, 26),
(26, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-25 00:09:30', 24, 26, 1, 26),
(27, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', '2020-10-25 00:46:02', 50, 60, 1, 60),
(28, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', '2020-10-25 00:46:58', 50, 60, 1, 60);

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
  MODIFY `refNo` bigint(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=153;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
