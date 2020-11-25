-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2020 at 03:48 AM
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
-- Table structure for table `datainventory`
--

CREATE TABLE `datainventory` (
  `prodNo` bigint(15) NOT NULL,
  `prodItem` varchar(999) NOT NULL,
  `prodBrand` varchar(999) NOT NULL,
  `prodQty` int(249) NOT NULL,
  `prodSRP` int(255) NOT NULL,
  `prodRP` int(250) NOT NULL,
  `prodBought` int(249) NOT NULL,
  `prodDOA` date NOT NULL,
  `prodEXPD` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `datainventory`
--

INSERT INTO `datainventory` (`prodNo`, `prodItem`, `prodBrand`, `prodQty`, `prodSRP`, `prodRP`, `prodBought`, `prodDOA`, `prodEXPD`) VALUES
(48025522, 'Magic Sarap 8g', 'Maggi', 10, 37, 48, 3, '2020-11-17', '2020-11-29'),
(750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 20, 50, 60, 6, '2020-11-17', '2021-03-23'),
(4800016022180, 'Great Taste White Crema', 'Universal Robina', 20, 102, 110, 0, '2020-11-17', '2020-11-22'),
(4800016043093, 'Nips White Chocolate', 'Jack n Jill', 15, 24, 26, 169, '2020-11-17', '2021-09-18'),
(4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 100, 35, 50, 0, '2020-11-17', '2021-02-28'),
(4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 20, 12, 13, 102, '2020-11-17', '2021-02-05'),
(4800016644801, 'Piattos Cheese', 'Jack n Jill', 0, 12, 13, 0, '2020-09-12', '2021-03-12'),
(4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', 0, 12, 13, 0, '2020-02-07', '2020-09-07'),
(4800092113338, 'Rebisco Crackers', 'Republic Biscuit Corporation', 0, 50, 60, 0, '2020-07-12', '2021-07-12'),
(4800103341835, 'Chubby Choco Chewy Candy', 'SPI Corporation', 0, 20, 22, 0, '2020-03-17', '2021-03-17'),
(4800103343563, 'Vita Cubes Singles', 'SPI Corporation', 0, 20, 22, 0, '2020-02-01', '2021-02-01'),
(4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 0, 7, 8, 0, '2020-02-23', '2021-02-03'),
(4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 0, 83, 90, 98, '2020-04-30', '2021-04-30'),
(4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 0, 102, 110, 60, '2020-07-31', '2021-07-31'),
(4800818808760, 'Yakee! Super Asim Gumball', 'Columbia Intl Food Product INC.', 0, 25, 28, 0, '2020-07-27', '2021-07-25'),
(4800818808906, 'Potchi Strawberyy Cream', 'Columbia Intl Food Productions INC.', 0, 35, 50, 0, '2020-08-19', '2021-08-19'),
(4801668603659, 'Oysterrific Oyster Sauce 30g', 'Datu Puti', 0, 35, 40, 0, '2020-11-09', '2020-11-24'),
(4801981118502, 'Coca Cola 294mL', 'The CocaCola Company', 0, 10, 12, 0, '2020-11-13', '2020-11-10'),
(4804888589505, 'Hany Milk Chocolate', 'Annie Candy Manufacturing', 0, 30, 32, 0, '2020-08-14', '2021-03-14'),
(4804888589987, 'Ube Purple Yam Candy', 'Annie Candy Manufacturing', 0, 22, 24, 0, '2020-09-12', '2021-03-12'),
(4806507621863, 'Burst Assorted Fruit Flavor Chewy Candy', 'Guangdong Xiaomimi Foodstuff Corporation', 0, 22, 24, 0, '2020-06-19', '2022-06-19'),
(4806511013166, 'Yaahoo Marie Jumbo 25g', 'W.L Foods', 1, 1, 2, 0, '2020-11-17', '2020-11-18'),
(4806511111121, 'Topsee Milk Chocolate', 'Delicatesse Food Corporation', 0, 22, 24, 0, '2020-08-26', '2021-08-26'),
(4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 0, 10, 15, 0, '2020-11-13', '2020-12-03'),
(4809010686011, 'Lemon Square Cheese Cake', 'Big E Food Corporation', 0, 60, 70, 0, '2020-10-30', '2021-10-30'),
(4902430426464, 'Downy Expert AntiBac', 'Procter & Gamble Philippines INC.', 0, 75, 85, 0, '2020-07-12', '2021-07-12'),
(4902430583169, 'Ariel Sunrise Fresh', 'Procter & Gamble Philippines INC.', 0, 60, 70, 0, '2020-07-12', '2020-07-12'),
(8851717904967, 'Delight 100ml', 'Dutch Mill Corporation', 0, 55, 60, 0, '2020-11-16', '2021-11-16'),
(8935001720126, 'Mentos Tropical Mix', 'Perfetti Van Melle', 0, 35, 50, 0, '2020-07-08', '2022-07-08'),
(8993175537124, 'Richeese Cheese Wafer', 'Enerlife Philippines INC.', 0, 88, 98, 0, '2020-07-23', '2021-07-23'),
(8993175559890, 'Richoco Chocolate Wafer', 'Enerlife Philippines INC.', 0, 88, 98, 0, '2020-07-26', '2021-07-26');

-- --------------------------------------------------------

--
-- Table structure for table `datasalesinventory`
--

CREATE TABLE `datasalesinventory` (
  `refNo` bigint(15) NOT NULL,
  `salesNo` bigint(249) NOT NULL,
  `salesItem` varchar(249) NOT NULL,
  `salesBrand` varchar(249) NOT NULL,
  `salesSRP` int(249) NOT NULL,
  `salesRP` int(249) NOT NULL,
  `salesQty` int(249) NOT NULL,
  `salesTotal` int(249) NOT NULL,
  `salesDate` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `datasalesinventory`
--

INSERT INTO `datasalesinventory` (`refNo`, `salesNo`, `salesItem`, `salesBrand`, `salesSRP`, `salesRP`, `salesQty`, `salesTotal`, `salesDate`) VALUES
(2, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-10-24 23:43:07'),
(4, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-10-24 23:54:56'),
(5, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', 24, 26, 1, 26, '2020-10-24 23:55:50'),
(6, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', 24, 26, 1, 26, '2020-10-24 23:56:21'),
(7, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', 24, 26, 1, 26, '2020-10-24 23:56:27'),
(8, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-10-24 23:59:02'),
(13, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-10-25 00:00:00'),
(14, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-10-25 00:00:04'),
(15, 4800016644801, 'Piattos Cheese', 'Jack n Jill', 12, 13, 1, 13, '2020-10-25 00:00:35'),
(16, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', 13, 13, 1, 13, '2020-10-25 00:01:07'),
(17, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', 12, 13, 1, 13, '2020-10-25 00:01:47'),
(19, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 23, 50, 1, 50, '2020-10-25 00:02:15'),
(20, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-10-25 00:03:13'),
(21, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-10-25 00:03:48'),
(22, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-10-25 00:04:07'),
(23, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', 12, 13, 1, 13, '2020-10-25 00:07:31'),
(24, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', 24, 26, 1, 26, '2020-10-25 00:08:28'),
(25, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', 24, 26, 1, 26, '2020-10-25 00:08:58'),
(26, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', 24, 26, 1, 26, '2020-10-25 00:09:30'),
(27, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-10-25 00:46:02'),
(28, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-10-25 00:46:58'),
(153, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 0, 1, 83, '2020-11-18 16:00:00'),
(154, 0, '', '', 0, 0, 1, 0, '2020-11-18 16:00:00'),
(155, 0, '', '', 0, 0, 0, 0, '2020-11-18 16:00:00'),
(156, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 0, 1, 7, '2020-11-18 16:00:00'),
(157, 0, '', '', 0, 0, 1, 0, '2020-11-18 16:00:00'),
(158, 0, '', '', 0, 0, 0, 0, '2020-11-18 16:00:00'),
(159, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 0, 1, 7, '2020-11-18 16:00:00'),
(160, 0, '', '', 0, 0, 1, 0, '2020-11-18 16:00:00'),
(161, 0, '', '', 0, 0, 0, 0, '2020-11-18 16:00:00'),
(162, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 0, 1, 83, '2020-11-18 16:00:00'),
(163, 0, '', '', 0, 0, 1, 0, '2020-11-18 16:00:00'),
(164, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 0, 1, 83, '2020-11-18 16:00:00'),
(165, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 0, 1, 83, '2020-11-18 16:00:00'),
(166, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 0, 1, 83, '2020-11-18 16:00:00'),
(167, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 0, 90, 1, 0, '2020-11-18 16:00:00'),
(168, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 0, 110, 1, 0, '2020-11-20 16:00:00'),
(169, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 0, 8, 1, 0, '2020-11-20 16:00:00'),
(170, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 0, 1, 7, '2020-11-20 16:00:00'),
(171, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 0, 1, 7, '2020-11-20 16:00:00'),
(172, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 0, 1, 102, '2020-11-21 16:00:00'),
(173, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-21 16:00:00'),
(174, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-21 16:00:00'),
(175, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-21 16:00:00'),
(176, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-21 16:00:00'),
(177, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-21 16:00:00'),
(178, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(179, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(180, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(181, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(182, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(183, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(184, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(185, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(186, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(187, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(188, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(189, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(190, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(191, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(192, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(193, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(194, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 0, '2020-11-21 16:00:00'),
(195, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 0, '2020-11-21 16:00:00'),
(196, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-21 16:00:00'),
(197, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-21 16:00:00'),
(198, 10, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-21 16:00:00'),
(199, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-21 16:00:00'),
(200, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-22 16:00:00'),
(201, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-22 16:00:00'),
(202, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-22 16:00:00'),
(203, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-22 16:00:00'),
(204, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:09:58'),
(205, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:11:21'),
(206, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:13:09'),
(207, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:16:04'),
(208, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:16:08'),
(209, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:17:47'),
(210, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:18:51'),
(211, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:27:56'),
(212, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:28:00'),
(213, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:28:02'),
(214, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:28:03'),
(215, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:28:05'),
(216, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:28:29'),
(217, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:28:31'),
(218, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:28:32'),
(219, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:28:33'),
(220, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:28:34'),
(221, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:28:54'),
(222, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:28:58'),
(223, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:29:39'),
(224, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:29:45'),
(225, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:29:46'),
(226, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:30:43'),
(227, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:30:45'),
(228, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:31:14'),
(229, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:31:17'),
(230, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:31:35'),
(231, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:31:37'),
(232, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:31:38'),
(233, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:33:22'),
(234, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:33:24'),
(235, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:33:24'),
(236, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:33:25'),
(237, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:33:25'),
(238, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:33:25'),
(239, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:33:25'),
(240, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:33:26'),
(241, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:33:26'),
(242, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:34:27'),
(243, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:34:28'),
(244, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:34:31'),
(245, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:34:31'),
(246, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:34:31'),
(247, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:34:32'),
(248, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-23 04:34:32'),
(249, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:34:38'),
(250, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:34:41'),
(251, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:34:42'),
(252, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:34:42'),
(253, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 7, 8, 1, 8, '2020-11-23 04:34:42'),
(254, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-24 03:07:35'),
(255, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 83, 90, 1, 90, '2020-11-24 03:08:05'),
(256, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:25:57'),
(257, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:25:58'),
(258, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:25:58'),
(259, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:25:58'),
(260, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:25:58'),
(261, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:26:41'),
(262, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:26:41'),
(263, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:26:41'),
(264, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:26:41'),
(265, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:26:41'),
(266, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:26:42'),
(267, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:31:24'),
(268, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:31:24'),
(269, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:31:24'),
(270, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:34:14'),
(271, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:34:14'),
(272, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:34:14'),
(273, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:34:14'),
(274, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:34:52'),
(275, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:34:54'),
(276, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:34:55'),
(277, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:34:55'),
(278, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:37:09'),
(279, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:37:10'),
(280, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:37:10'),
(281, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:37:47'),
(282, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:39:20'),
(283, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:40:34'),
(284, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:41:07'),
(285, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:41:47'),
(286, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:41:48'),
(287, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:41:49'),
(288, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:41:49'),
(289, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:43:54'),
(290, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:43:54'),
(291, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:21'),
(292, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:21'),
(293, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:21'),
(294, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:23'),
(295, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:23'),
(296, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:23'),
(297, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:24'),
(298, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:24'),
(299, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:24'),
(300, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:24'),
(301, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:25'),
(302, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:25'),
(303, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:25'),
(304, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:26'),
(305, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:26'),
(306, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:27'),
(307, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:27'),
(308, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:28'),
(309, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:38'),
(310, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:45:39'),
(311, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:48:30'),
(312, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:49:04'),
(313, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:49:04'),
(314, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:49:04'),
(315, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:49:04'),
(316, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:49:04'),
(317, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:49:05'),
(318, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:49:44'),
(319, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:49:44'),
(320, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:49:45'),
(321, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:50:29'),
(322, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:50:39'),
(323, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:50:40'),
(324, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:52:50'),
(325, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:53:47'),
(326, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:54:54'),
(327, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:55:02'),
(328, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:55:03'),
(329, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-24 03:55:28'),
(330, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 12:22:00'),
(331, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 12:26:22'),
(332, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 12:28:52'),
(333, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 12:42:25'),
(334, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 12:42:41'),
(335, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 13:03:56'),
(336, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 13:04:59'),
(337, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 13:10:10'),
(338, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 13:10:26'),
(339, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 13:12:37'),
(340, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 13:12:37'),
(341, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 13:12:40'),
(342, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 13:12:40'),
(343, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 13:13:44'),
(344, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-24 13:13:46'),
(345, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-24 13:14:18'),
(346, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-24 13:14:19'),
(347, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-24 13:14:19'),
(348, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-24 13:14:20'),
(349, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-24 13:14:20'),
(350, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-24 13:14:21');

-- --------------------------------------------------------

--
-- Table structure for table `sales_preview`
--

CREATE TABLE `sales_preview` (
  `ref#` int(249) NOT NULL,
  `payment_method` varchar(249) NOT NULL,
  `payment_vat` int(249) NOT NULL,
  `payment_total` int(249) NOT NULL,
  `payment_paid` int(249) NOT NULL,
  `payment_due` int(249) NOT NULL,
  `payment_date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sales_preview`
--

INSERT INTO `sales_preview` (`ref#`, `payment_method`, `payment_vat`, `payment_total`, `payment_paid`, `payment_due`, `payment_date`) VALUES
(1, 'Cash', 0, 440, 500, 0, '2020-11-24 03:41:53'),
(2, 'Cash', 0, 220, 300, 80, '2020-11-24 03:43:59'),
(3, 'Cash', 0, 110, 200, 90, '2020-11-24 03:48:34'),
(4, 'Cash', 0, 220, 300, 80, '2020-11-24 03:55:07'),
(5, 'Cash', 0, 110, 200, 90, '2020-11-24 03:55:31');

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

--
-- Indexes for dumped tables
--

--
-- Indexes for table `datainventory`
--
ALTER TABLE `datainventory`
  ADD PRIMARY KEY (`prodNo`);

--
-- Indexes for table `datasalesinventory`
--
ALTER TABLE `datasalesinventory`
  ADD UNIQUE KEY `refNo` (`refNo`);

--
-- Indexes for table `sales_preview`
--
ALTER TABLE `sales_preview`
  ADD UNIQUE KEY `salesReference` (`ref#`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `datasalesinventory`
--
ALTER TABLE `datasalesinventory`
  MODIFY `refNo` bigint(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=351;

--
-- AUTO_INCREMENT for table `sales_preview`
--
ALTER TABLE `sales_preview`
  MODIFY `ref#` int(249) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
