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
-- Table structure for table `userinventory`
--

CREATE TABLE `userinventory` (
  `userNo.` int(11) NOT NULL,
  `userName` varchar(12) NOT NULL,
  `userPass` varchar(12) NOT NULL,
  `userPrivilages` int(11) NOT NULL,
  `userTimein` datetime NOT NULL,
  `userTimeout` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `userinventory`
--

INSERT INTO `userinventory` (`userNo.`, `userName`, `userPass`, `userPrivilages`, `userTimein`, `userTimeout`) VALUES
(1, 'Nefarry1', 'aislife22', 1, '2020-10-29 00:00:00', '2020-10-29 00:00:00'),
(2, 'adminkobs', 'dikoalam', 1, '2020-11-11 12:04:06', '2020-11-19 12:04:06');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
