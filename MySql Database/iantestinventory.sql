-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 28, 2020 at 09:08 AM
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
-- Table structure for table `client_information`
--

CREATE TABLE `client_information` (
  `accNo` bigint(10) NOT NULL,
  `firstName` varchar(249) NOT NULL,
  `lastName` varchar(249) NOT NULL,
  `bussName` varchar(249) NOT NULL,
  `bussBranch` varchar(249) NOT NULL,
  `bussType` varchar(249) NOT NULL,
  `bussTown` varchar(249) NOT NULL,
  `bussProvince` varchar(249) NOT NULL,
  `bussCountry` varchar(249) NOT NULL,
  `bussZipcode` int(249) NOT NULL,
  `accCreated` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `client_information`
--

INSERT INTO `client_information` (`accNo`, `firstName`, `lastName`, `bussName`, `bussBranch`, `bussType`, `bussTown`, `bussProvince`, `bussCountry`, `bussZipcode`, `accCreated`) VALUES
(6560234550, 'Kobie', 'Oracion', 'Kobie Computer Shop', 'Luisiana Branch', 'Computer Cafe', 'Luisiana', 'Laguna', 'Philippines', 4032, '0000-00-00 00:00:00'),
(6643053270, 'Kobie ', 'Oracion', 'Miras Music Studio INC.', 'Cavinti Branch', 'Music Studio', 'Cavinti', 'Laguna', 'Philippines', 4022, '0000-00-00 00:00:00'),
(8417643240, 'Robert', 'Miras', 'Team Freelance', 'Cavinti Branch', 'Freelance', 'Cavinti', 'Laguna', 'PH', 3014, '0000-00-00 00:00:00');

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
(48025522, 'Magic Sarap 8g', 'Maggi', 0, 37, 48, 15, '2020-11-17', '2020-11-29'),
(14285000051, 'UFC Hot & Spicy Banana Ketchup 320g', 'UFC', 20, 30, 32, 0, '2020-11-28', '2020-11-30'),
(14285002789, 'UFC Banana Ketchup 100g', 'UFC', 28, 9, 10, 2, '2020-11-28', '2020-11-30'),
(54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 30, 47, 57, 0, '2020-11-28', '2020-11-30'),
(78895710021, 'Lee Kum Kee Sesame Oil 270mL', 'Lee Kum Kee', 20, 168, 175, 0, '2020-11-28', '2020-11-30'),
(748485100401, 'Century Tuna Flakes in Oil 155g', 'Century Tuna', 28, 30, 32, 2, '2020-11-28', '2020-11-30'),
(748485102245, 'Century Tuna Flakes in Oil 95g', 'Century Tuna', 29, 22, 25, 1, '2020-11-28', '2020-11-30'),
(748485102252, 'Century Tuna Hot & Spicy 95g', 'Century Tuna', 18, 22, 25, 2, '2020-11-28', '2020-11-30'),
(748485801803, 'Argentina Corned Beef 100g', 'Argentina', 28, 22, 25, 2, '2020-11-28', '2020-11-30'),
(750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', -7, 50, 60, 38, '2020-11-17', '2021-03-23'),
(750515018501, 'Skyflakes Crackers 250g', 'M.Y Sans', 45, 59, 69, 5, '2020-11-27', '2020-11-30'),
(4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 34, 64, 80, 66, '2020-11-27', '2020-11-30'),
(4800016022180, 'Great Taste White Crema Twin Pack 10 x 25g', 'Universal Robina', 16, 102, 110, 17, '2020-11-28', '2020-11-22'),
(4800016043093, 'Nips White Chocolate', 'Jack n Jill', 14, 24, 26, 170, '2020-11-17', '2021-09-18'),
(4800016304019, 'Maxx Cherry 50 x 4g', 'Jack n Jill', 30, 37, 40, 0, '2020-11-28', '2020-11-30'),
(4800016306013, 'Maxx Honey Lemon 200g', 'Jack n Jill', 0, 35, 50, 15, '2020-11-28', '2021-02-28'),
(4800016551598, 'Nissin Ramen Seafood 55g', 'Nissin', 19, 8, 10, 1, '2020-11-28', '2020-11-30'),
(4800016555985, 'Payless Xtra Big Kalamansi 130g', 'Payless', 19, 14, 16, 1, '2020-11-28', '2020-11-29'),
(4800016556807, 'Payless Xtra Big Xtra Hot 130g', 'Payless', 19, 14, 16, 1, '2020-11-28', '2020-11-30'),
(4800016561269, 'Nissin Ramen Spicy Hot Beef 65g', 'Nissin', 19, 8, 10, 1, '2020-11-28', '2020-11-30'),
(4800016561436, 'Payless Xtra Big Sweet & Spicy 130g', 'Payless', 19, 14, 16, 1, '2020-11-28', '2020-11-30'),
(4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 9, 12, 13, 113, '2020-11-17', '2021-02-05'),
(4800016644801, 'Piattos Cheese', 'Jack n Jill', 0, 12, 13, 0, '2020-09-12', '2021-03-12'),
(4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', 0, 12, 13, 0, '2020-02-07', '2020-09-07'),
(4800016961625, 'Chooey Toffee 236.5g', 'Jack n Jill', 0, 40, 43, 0, '2020-11-28', '2020-11-30'),
(4800024012395, 'Del Monte Pineapple Tidbits 560g', 'Del Monte', 20, 76, 85, 0, '2020-11-28', '2020-11-30'),
(4800092113338, 'Rebisco Crackers', 'Republic Biscuit Corporation', 0, 50, 60, 0, '2020-07-12', '2021-07-12'),
(4800092330018, 'Happy Original Flavor 20 x 5g', 'JBC Food Corp.', 30, 17, 20, 0, '2020-11-28', '2020-11-30'),
(4800092330100, 'Ding Dong Mixed Peanuts 20 x 5g', 'JBC Food Corp.', 20, 17, 20, 0, '2020-11-28', '2020-11-30'),
(4800092331268, 'Hi-Ho BBQ Flavor 20 x 5g', 'JBC Food Corp.', 30, 17, 20, 0, '2020-11-28', '2020-11-29'),
(4800103341835, 'Chubby Choco Chewy Candy', 'SPI Corporation', 0, 20, 22, 0, '2020-03-17', '2021-03-17'),
(4800103343563, 'Vita Cubes Singles 90g', 'SPI Corporation', 0, 20, 22, 0, '2020-11-28', '2021-02-01'),
(4800134101033, 'Master Sardines in Tomato Sauce with Chili 155g', 'Master', 28, 28, 31, 2, '2020-11-28', '2020-11-30'),
(4800163443043, 'Ligo Sardines in Tomato Sauce 155g', 'Ligo', 28, 28, 31, 2, '2020-11-28', '2020-11-30'),
(4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 0, 7, 8, 0, '2020-02-23', '2021-02-03'),
(4800344020520, 'Datu Puti Old English Worcestershire Sauce 150mL', 'Datu Puti', 29, 29, 32, 1, '2020-11-28', '2020-11-30'),
(4800361410816, 'Bear Brand Swak Pack 33g', 'Nestle Philippines', 14, 12, 13, 6, '2020-11-27', '2020-11-29'),
(4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 0, 83, 90, 98, '2020-04-30', '2021-04-30'),
(4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 50, 102, 110, 113, '2020-07-31', '2021-07-31'),
(4800575110373, 'Alaska Classic 370mL', 'Alaska Milk Corporation', 20, 44, 50, 0, '2020-11-28', '2020-11-30'),
(4800818808760, 'Yakee! Super Asim Gumball 145.6g', 'Columbia Intl Food Product INC.', 30, 25, 28, 0, '2020-11-28', '2021-07-25'),
(4800818808906, 'Potchi Strawberyy Cream 135g', 'Columbia Intl Food Productions INC.', 20, 35, 50, 0, '2020-11-28', '2021-08-19'),
(4801668602027, 'Datu Puti Vinegar 200mL', 'Datu Puti', 18, 9, 10, 2, '2020-11-28', '2020-11-30'),
(4801668602034, 'Datu Puti Soy Sauce 200mL', 'Datu Puti', 18, 9, 10, 2, '2020-11-28', '2020-11-30'),
(4801668603659, 'Oysterrific Oyster Sauce 30g', 'Datu Puti', 0, 35, 40, 0, '2020-11-09', '2020-11-24'),
(4801668606865, 'Mafran All-Purpose Dressing  7.05oz', 'Mafran', 18, 12, 14, 2, '2020-11-28', '2020-11-30'),
(4801958349106, 'Aji-Ginisa 7g x 16', 'Ajinomoto', 20, 28, 30, 0, '2020-11-28', '2020-11-30'),
(4801981118502, 'Coca Cola 294mL', 'The CocaCola Company', 0, 10, 12, 0, '2020-11-13', '2020-11-10'),
(4804888589505, 'Hany Milk Chocolate', 'Annie Candy Manufacturing', 50, 30, 32, 0, '2020-11-28', '2021-03-14'),
(4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 0, 22, 24, 0, '2020-11-28', '2021-03-12'),
(4806014000137, 'Jolly Sweet Cream Corn 425g ', 'Jolly', 20, 46, 50, 0, '2020-11-28', '2020-11-30'),
(4806014000397, 'Jolly Cream of Mushroom 298g', 'Jolly', 20, 72, 80, 0, '2020-11-28', '2020-11-30'),
(4806014000724, 'Dona Elena Extra Virgin Olive Oil 250mL', 'Dona Elena', 17, 100, 102, 3, '2020-11-28', '2020-11-30'),
(4806504710119, 'Mega Sardines in Tomato Sauce 155g', 'Mega', 29, 18, 21, 1, '2020-11-28', '2020-11-30'),
(4806504710126, 'Mega Sardines in Tomato Sauce with Chili Added 155g', 'Mega', 98, 28, 31, 3, '2020-11-28', '2020-11-30'),
(4806507621863, 'Burst Assorted Fruit Flavor Chewy Candy', 'Guangdong Xiaomimi Foodstuff Corporation', 0, 22, 24, 0, '2020-06-19', '2022-06-19'),
(4806511013166, 'Yaahoo Marie Jumbo 25g', 'W.L Foods', 1, 1, 2, 0, '2020-11-17', '2020-11-18'),
(4806511111121, 'Topsee Milk Chocolate 18g', 'Delicatesse Food Corporation', 0, 32, 40, 0, '2020-11-28', '2021-08-26'),
(4806521791634, 'Super Bawang Garlic Flavor 20 x 18g', 'W.L. Foods', 30, 18, 20, 0, '2020-11-28', '2020-11-29'),
(4806521796202, 'Kids Choice Teeth 100g', 'W.L. Foods', 50, 15, 22, 0, '2020-11-28', '2020-11-29'),
(4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 50, 15, 17, 0, '2020-11-28', '2020-11-30'),
(4806521796240, 'Kids Choice Worm 100g', 'W.L. Foods', 50, 15, 22, 0, '2020-11-28', '2020-11-29'),
(4806525660561, 'Peanut Brittle Candy 150g', 'Rackey', 50, 27, 30, 0, '2020-11-28', '2020-11-30'),
(4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 92, 10, 15, 8, '2020-11-28', '2020-12-03'),
(4807770270024, 'Lucky Me Chicken na Chicken 55g', 'Lucky Me', 19, 8, 10, 1, '2020-11-28', '2020-11-30'),
(4807770272097, 'Lucky Me Spicy Beef Labuyo 50g', 'Lucky Me', 19, 8, 10, 1, '2020-11-28', '2020-11-30'),
(4807770273674, 'Lucky Me Pansit Canton Kalamansi Flavor 80g', 'Lucky Me', 19, 12, 14, 1, '2020-11-28', '2020-11-30'),
(4807770273681, 'Lucky Me Pansit Canton Extra Hot Chili Flavor 80g', 'Lucky Me', 19, 12, 14, 1, '2020-11-28', '2020-11-30'),
(4807770273698, 'Lucky Me Pansit Canton Chili-Mansi 80g', 'Lucky Me', 19, 12, 14, 1, '2020-11-28', '2020-11-30'),
(4807770273711, 'Lucky Me Pansit Canton Sweet & Spicy 80g', 'Lucky Me', 19, 12, 14, 1, '2020-11-28', '2020-11-30'),
(4808887011852, 'Star Corned Beef 150g', 'Star', 29, 28, 31, 1, '2020-11-28', '2020-11-30'),
(4809010686011, 'Lemon Square Cheese Cake', 'Big E Food Corporation', 0, 60, 70, 0, '2020-10-30', '2021-10-30'),
(4809011293229, 'Lumpia Shanghai Cheese Flavor 20 x 30g', 'IFP Manufacturing Corp.', 30, 17, 20, 0, '2020-11-28', '2020-11-30'),
(4902430426464, 'Downy Expert AntiBac', 'Procter & Gamble Philippines INC.', 0, 75, 85, 0, '2020-07-12', '2021-07-12'),
(4902430583169, 'Ariel Sunrise Fresh', 'Procter & Gamble Philippines INC.', 0, 60, 70, 0, '2020-07-12', '2020-07-12'),
(8851717904967, 'Delight 100ml', 'Dutch Mill Corporation', 0, 55, 60, 0, '2020-11-16', '2021-11-16'),
(8935001720126, 'Mentos Tropical Mix', 'Perfetti Van Melle', 0, 35, 50, 0, '2020-07-08', '2022-07-08'),
(8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 50, 40, 50, 0, '2020-11-28', '2020-11-30'),
(8992741942959, 'Yupi Strawberry Kiss', 'Yupi', 99, 100, 120, 1, '2020-11-27', '2020-11-28'),
(8992741942973, 'Yupi Sour Iced Cola', 'Yupi', 99, 100, 120, 1, '2020-11-27', '2020-11-28'),
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
(350, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-24 13:14:21'),
(351, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:06:49'),
(352, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:06:52'),
(353, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:06:53'),
(354, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:14:49'),
(355, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:15:56'),
(356, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:15:59'),
(357, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:17:03'),
(358, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:17:03'),
(359, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:17:04'),
(360, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:17:04'),
(361, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:17:04'),
(362, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:17:04'),
(363, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:26:37'),
(364, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:26:43'),
(365, 48025522, 'Magic Sarap 8g', 'Maggi', 37, 48, 1, 48, '2020-11-27 04:26:44'),
(366, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:28:39'),
(367, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:29:32'),
(368, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:29:33'),
(369, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:29:35'),
(370, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:30:08'),
(371, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:30:11'),
(372, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:30:12'),
(373, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:30:12'),
(374, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:30:13'),
(375, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:30:13'),
(376, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:30:13'),
(377, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:30:13'),
(378, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:31:26'),
(379, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:31:27'),
(380, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:31:27'),
(381, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:31:54'),
(382, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:31:55'),
(383, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:31:55'),
(384, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:31:55'),
(385, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:31:55'),
(386, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:32:44'),
(387, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:32:45'),
(388, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:32:45'),
(389, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:32:45'),
(390, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:32:45'),
(391, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:32:58'),
(392, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:32:58'),
(393, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:35:23'),
(394, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 50, 60, 1, 60, '2020-11-27 04:41:03'),
(395, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:42:07'),
(396, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:42:54'),
(397, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:44:06'),
(398, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:44:07'),
(399, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:45:30'),
(400, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:46:18'),
(401, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:47:01'),
(402, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:47:12'),
(403, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:50:41'),
(404, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:51:21'),
(405, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:52:02'),
(406, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:52:05'),
(407, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:52:05'),
(408, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 04:52:06'),
(409, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 35, 50, 1, 50, '2020-11-27 05:07:43'),
(410, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 05:08:56'),
(411, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 05:08:59'),
(412, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:09:08'),
(413, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:09:09'),
(414, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:11:03'),
(415, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:11:03'),
(416, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:11:03'),
(417, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:11:04'),
(418, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:11:04'),
(419, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:11:04'),
(420, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:11:04'),
(421, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:11:04'),
(422, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 12, 13, 1, 13, '2020-11-27 05:11:04'),
(423, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:41:30'),
(424, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:41:37'),
(425, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:42:17'),
(426, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:42:22'),
(427, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:42:26'),
(428, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:42:27'),
(429, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:42:29'),
(430, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:42:31'),
(431, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:43:20'),
(432, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:43:23'),
(433, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:43:25'),
(434, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:43:27'),
(435, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:43:30'),
(436, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:43:37'),
(437, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:43:59'),
(438, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:50:03'),
(439, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:50:10'),
(440, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:50:14'),
(441, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:50:18'),
(442, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:51:18'),
(443, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:51:19'),
(444, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:51:20'),
(445, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:51:21'),
(446, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:52:41'),
(447, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:52:45'),
(448, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:54:05'),
(449, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:56:31'),
(450, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:56:34'),
(451, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:56:35'),
(452, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:56:37'),
(453, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:57:19'),
(454, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:57:20'),
(455, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:57:20'),
(456, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:57:24'),
(457, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:57:24'),
(458, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 07:57:26'),
(459, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 08:48:54'),
(460, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 08:49:03'),
(461, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 08:49:06'),
(462, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 08:49:09'),
(463, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', 24, 26, 1, 26, '2020-11-27 11:43:41'),
(464, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:47:28'),
(465, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:47:31'),
(466, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:47:36'),
(467, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:47:37'),
(468, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:47:38'),
(469, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:47:38'),
(470, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:47:39'),
(471, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:47:40'),
(472, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:48:55'),
(473, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:48:58'),
(474, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:48:59'),
(475, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:49:02'),
(476, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:49:02'),
(477, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:49:03'),
(478, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:49:04'),
(479, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:49:04'),
(480, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:49:04'),
(481, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:49:05'),
(482, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:51:34'),
(483, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:51:39'),
(484, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:54:58'),
(485, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 11:54:59'),
(486, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:55:08'),
(487, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 11:55:11'),
(488, 4800361410816, 'Bear Brand Swak Pack 33g', 'Nestle Philippines', 12, 13, 1, 13, '2020-11-27 13:34:06'),
(489, 4800361410816, 'Bear Brand Swak Pack 33g', 'Nestle Philippines', 12, 13, 1, 13, '2020-11-27 13:34:09'),
(490, 4800361410816, 'Bear Brand Swak Pack 33g', 'Nestle Philippines', 12, 13, 1, 13, '2020-11-27 13:36:39'),
(491, 4800361410816, 'Bear Brand Swak Pack 33g', 'Nestle Philippines', 12, 13, 1, 13, '2020-11-27 13:36:40'),
(492, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-27 13:37:50'),
(493, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-27 13:37:50'),
(494, 750515018501, 'Skyflakes Crackers 250g', 'M.Y Sans', 59, 69, 1, 69, '2020-11-27 13:50:18'),
(495, 750515018501, 'Skyflakes Crackers 250g', 'M.Y Sans', 59, 69, 1, 69, '2020-11-27 13:50:31'),
(496, 750515018501, 'Skyflakes Crackers 250g', 'M.Y Sans', 59, 69, 1, 69, '2020-11-27 13:50:32'),
(497, 750515018501, 'Skyflakes Crackers 250g', 'M.Y Sans', 59, 69, 1, 69, '2020-11-27 13:50:37'),
(498, 4800361410816, 'Bear Brand Swak Pack 33g', 'Nestle Philippines', 12, 13, 1, 13, '2020-11-27 13:50:42'),
(499, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 13:50:46'),
(500, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 13:50:50'),
(501, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-27 13:51:37'),
(502, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-27 13:51:38'),
(503, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-27 13:51:39'),
(504, 8992741942959, 'Yupi Strawberry Kiss', 'Yupi', 100, 120, 1, 120, '2020-11-27 14:50:26'),
(505, 8992741942973, 'Yupi Sour Iced Cola', 'Yupi', 100, 120, 1, 120, '2020-11-27 14:50:30'),
(506, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-27 14:50:39'),
(507, 4800016022180, 'Great Taste White Crema', 'Universal Robina', 102, 110, 1, 110, '2020-11-27 14:50:42'),
(508, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 102, 110, 1, 110, '2020-11-27 14:50:45'),
(509, 4800361410816, 'Bear Brand Swak Pack 33g', 'Nestle Philippines', 12, 13, 1, 13, '2020-11-27 14:50:48'),
(510, 750515018501, 'Skyflakes Crackers 250g', 'M.Y Sans', 59, 69, 1, 69, '2020-11-27 14:50:52'),
(511, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 10, 15, 1, 15, '2020-11-28 01:44:15'),
(512, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 10, 15, 1, 15, '2020-11-28 01:44:19'),
(513, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 10, 15, 1, 15, '2020-11-28 01:44:21'),
(514, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:44:28'),
(515, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:44:30'),
(516, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:44:31'),
(517, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:44:31'),
(518, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:16'),
(519, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:20'),
(520, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:20'),
(521, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:21'),
(522, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:22'),
(523, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:22'),
(524, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:23'),
(525, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:24'),
(526, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:25'),
(527, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:25'),
(528, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:26'),
(529, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:27'),
(530, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:28'),
(531, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:28'),
(532, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:29'),
(533, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 01:45:30'),
(534, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:22:53'),
(535, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:22:57'),
(536, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:22:57'),
(537, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:22:58'),
(538, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:22:59'),
(539, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:23:00'),
(540, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:23:01'),
(541, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:23:03'),
(542, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:23:04'),
(543, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:27'),
(544, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:29'),
(545, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:30'),
(546, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:40'),
(547, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:43'),
(548, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:44'),
(549, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:45'),
(550, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:56'),
(551, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:58'),
(552, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:58'),
(553, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:59'),
(554, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:24:59'),
(555, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:25:00'),
(556, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:26:17'),
(557, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:26:17'),
(558, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:27:46'),
(559, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:27:47'),
(560, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:27:48'),
(561, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:29:34'),
(562, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:29:39'),
(563, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:29:40'),
(564, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:29:41'),
(565, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:32:27'),
(566, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:32:28'),
(567, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:32:29'),
(568, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:32:30'),
(569, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:32:31'),
(570, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 02:32:46'),
(571, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 10, 15, 1, 15, '2020-11-28 02:36:14'),
(572, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 10, 15, 1, 15, '2020-11-28 03:47:04'),
(573, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 10, 15, 1, 15, '2020-11-28 03:47:07'),
(574, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 10, 15, 1, 15, '2020-11-28 03:47:11'),
(575, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 10, 15, 1, 15, '2020-11-28 03:47:11'),
(576, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 03:47:16'),
(577, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 03:47:18'),
(578, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 1, 80, '2020-11-28 03:47:18'),
(579, 4806014000724, 'Dona Elena Extra Virgin Olive Oil 250mL', 'Dona Elena', 100, 102, 1, 102, '2020-11-28 07:45:53'),
(580, 4806014000724, 'Dona Elena Extra Virgin Olive Oil 250mL', 'Dona Elena', 100, 102, 1, 102, '2020-11-28 07:45:56'),
(581, 4801668602027, 'Datu Puti Vinegar 200mL', 'Datu Puti', 9, 10, 1, 10, '2020-11-28 07:45:59'),
(582, 14285002789, 'UFC Banana Ketchup 100g', 'UFC', 9, 10, 1, 10, '2020-11-28 07:46:04'),
(583, 4801668602034, 'Datu Puti Soy Sauce 200mL', 'Datu Puti', 9, 10, 1, 10, '2020-11-28 07:46:08'),
(584, 4801668606865, 'Mafran All-Purpose Dressing  7.05oz', 'Mafran', 12, 14, 1, 14, '2020-11-28 07:46:11'),
(585, 748485100401, 'Century Tuna Flakes in Oil 155g', 'Century Tuna', 30, 32, 1, 32, '2020-11-28 07:46:17'),
(586, 4808887011852, 'Star Corned Beef 150g', 'Star', 28, 31, 1, 31, '2020-11-28 07:46:39'),
(587, 4806504710119, 'Mega Sardines in Tomato Sauce 155g', 'Mega', 18, 21, 1, 21, '2020-11-28 07:46:51'),
(588, 4800163443043, 'Ligo Sardines in Tomato Sauce 155g', 'Ligo', 28, 31, 1, 31, '2020-11-28 07:46:56'),
(589, 748485801803, 'Argentina Corned Beef 100g', 'Argentina', 22, 25, 1, 25, '2020-11-28 07:47:02'),
(590, 748485102252, 'Century Tuna Hot & Spicy 95g', 'Century Tuna', 22, 25, 1, 25, '2020-11-28 07:47:07'),
(591, 748485102245, 'Century Tuna Flakes in Oil 95g', 'Century Tuna', 22, 25, 1, 25, '2020-11-28 07:47:15'),
(592, 4800134101033, 'Master Sardines in Tomato Sauce with Chili 155g', 'Master', 28, 31, 1, 31, '2020-11-28 07:47:21'),
(593, 4806504710126, 'Mega Sardines', 'Mega', 28, 31, 1, 31, '2020-11-28 07:47:26'),
(594, 4806504710126, 'Mega Sardines in Tomato Sauce with Chili Added 155g', 'Mega', 28, 31, 1, 31, '2020-11-28 07:50:48'),
(595, 4806504710126, 'Mega Sardines in Tomato Sauce with Chili Added 155g', 'Mega', 28, 31, 1, 31, '2020-11-28 07:50:55'),
(596, 4800134101033, 'Master Sardines in Tomato Sauce with Chili 155g', 'Master', 28, 31, 1, 31, '2020-11-28 07:51:00'),
(597, 4800163443043, 'Ligo Sardines in Tomato Sauce 155g', 'Ligo', 28, 31, 1, 31, '2020-11-28 07:51:05'),
(598, 4800344020520, 'Datu Puti Old English Worcestershire Sauce 150mL', 'Datu Puti', 29, 32, 1, 32, '2020-11-28 07:51:17'),
(599, 748485100401, 'Century Tuna Flakes in Oil 155g', 'Century Tuna', 30, 32, 1, 32, '2020-11-28 07:51:23'),
(600, 748485801803, 'Argentina Corned Beef 100g', 'Argentina', 22, 25, 1, 25, '2020-11-28 07:51:31'),
(601, 748485102252, 'Century Tuna Hot & Spicy 95g', 'Century Tuna', 22, 25, 1, 25, '2020-11-28 07:51:37'),
(602, 4806014000724, 'Dona Elena Extra Virgin Olive Oil 250mL', 'Dona Elena', 100, 102, 1, 102, '2020-11-28 07:51:48'),
(603, 4801668602027, 'Datu Puti Vinegar 200mL', 'Datu Puti', 9, 10, 1, 10, '2020-11-28 07:51:54'),
(604, 14285002789, 'UFC Banana Ketchup 100g', 'UFC', 9, 10, 1, 10, '2020-11-28 07:51:58'),
(605, 4801668602034, 'Datu Puti Soy Sauce 200mL', 'Datu Puti', 9, 10, 1, 10, '2020-11-28 07:52:01'),
(606, 4801668606865, 'Mafran All-Purpose Dressing  7.05oz', 'Mafran', 12, 14, 1, 14, '2020-11-28 07:52:05'),
(607, 4800016556807, 'Payless Xtra Big Xtra Hot 130g', 'Payless', 14, 16, 1, 16, '2020-11-28 08:04:15'),
(608, 4800016561436, 'Payless Xtra Big Sweet & Spicy 130g', 'Payless', 14, 16, 1, 16, '2020-11-28 08:04:21');
INSERT INTO `datasalesinventory` (`refNo`, `salesNo`, `salesItem`, `salesBrand`, `salesSRP`, `salesRP`, `salesQty`, `salesTotal`, `salesDate`) VALUES
(609, 4800016555985, 'Payless Xtra Big Kalamansi 130g', 'Payless', 14, 16, 1, 16, '2020-11-28 08:04:27'),
(610, 4800016561269, 'Nissin Ramen Spicy Hot Beef 65g', 'Nissin', 8, 10, 1, 10, '2020-11-28 08:04:34'),
(611, 4800016551598, 'Nissin Ramen Seafood 55g', 'Nissin', 8, 10, 1, 10, '2020-11-28 08:04:47'),
(612, 4807770270024, 'Lucky Me Chicken na Chicken 55g', 'Lucky Me', 8, 10, 1, 10, '2020-11-28 08:05:03'),
(613, 4807770272097, 'Lucky Me Spicy Beef Labuyo 50g', 'Lucky Me', 8, 10, 1, 10, '2020-11-28 08:05:12'),
(614, 4807770273698, 'Lucky Me Pansit Canton Chili-Mansi 80g', 'Lucky Me', 12, 14, 1, 14, '2020-11-28 08:05:18'),
(615, 4807770273711, 'Lucky Me Pansit Canton Sweet & Spicy 80g', 'Lucky Me', 12, 14, 1, 14, '2020-11-28 08:05:27'),
(616, 4807770273681, 'Lucky Me Pansit Canton Extra Hot Chili Flavor 80g', 'Lucky Me', 12, 14, 1, 14, '2020-11-28 08:05:34'),
(617, 4807770273674, 'Lucky Me Pansit Canton Kalamansi Flavor 80g', 'Lucky Me', 12, 14, 1, 14, '2020-11-28 08:05:39');

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
(5, 'Cash', 0, 110, 200, 90, '2020-11-24 03:55:31'),
(6, 'Cash', 0, 300, 500, 200, '2020-11-27 04:32:50'),
(7, 'Cash', 0, 120, 500, 380, '2020-11-27 04:33:06'),
(8, 'Cash', 0, 50, 100, 50, '2020-11-27 04:43:01'),
(9, 'Cash', 0, 100, 200, 100, '2020-11-27 04:44:11'),
(10, 'Cash', 0, 50, 100, 50, '2020-11-27 04:45:35'),
(11, 'Cash', 0, 50, 100, 50, '2020-11-27 04:46:22'),
(12, 'Cash', 0, 50, 100, 50, '2020-11-27 04:47:04'),
(13, 'Cash', 0, 246, 500, 254, '2020-11-27 05:09:12'),
(14, 'Cash', 0, 660, 700, 40, '2020-11-27 07:57:33'),
(15, 'Cash', 0, 365, 400, 35, '2020-11-28 01:44:38'),
(16, 'Cash', 0, 1280, 2000, 720, '2020-11-28 01:45:49'),
(17, 'Cash', 0, 384, 500, 116, '2020-11-28 07:52:12');

-- --------------------------------------------------------

--
-- Table structure for table `usersinventory`
--

CREATE TABLE `usersinventory` (
  `usersId` int(11) NOT NULL,
  `usersName` varchar(30) NOT NULL,
  `usersPass` text NOT NULL,
  `usersPrevileges` varchar(5) NOT NULL,
  `usersTimein` datetime DEFAULT NULL,
  `usersTimeout` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usersinventory`
--

INSERT INTO `usersinventory` (`usersId`, `usersName`, `usersPass`, `usersPrevileges`, `usersTimein`, `usersTimeout`) VALUES
(5, 'admin', '$2a$10$tihqjhR7FWrfOijOCCBDl.0uXzlOkT2WrnDKQSk0s6XJ1QxelvTHq', 'Admin', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, 'user', '$2a$10$xjyzdSJIt6cfi39A.1cDx..QNWJwl9oH5F8UjQLhG/Hh.uw6cR3p.', 'Users', '0000-00-00 00:00:00', '0000-00-00 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `client_information`
--
ALTER TABLE `client_information`
  ADD UNIQUE KEY `AccNumber` (`accNo`);

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
-- Indexes for table `usersinventory`
--
ALTER TABLE `usersinventory`
  ADD PRIMARY KEY (`usersId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `datasalesinventory`
--
ALTER TABLE `datasalesinventory`
  MODIFY `refNo` bigint(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=618;

--
-- AUTO_INCREMENT for table `sales_preview`
--
ALTER TABLE `sales_preview`
  MODIFY `ref#` int(249) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `usersinventory`
--
ALTER TABLE `usersinventory`
  MODIFY `usersId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
