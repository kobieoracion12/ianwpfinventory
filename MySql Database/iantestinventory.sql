-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2020 at 06:57 AM
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
-- Table structure for table `cashierinventory`
--

CREATE TABLE `cashierinventory` (
  `itemNo` bigint(20) NOT NULL,
  `itemName` varchar(249) NOT NULL,
  `itemBrand` varchar(249) NOT NULL,
  `itemRP` int(249) NOT NULL,
  `itemSRP` int(249) NOT NULL,
  `itemDOA` date NOT NULL,
  `itemEXPD` date NOT NULL,
  `cashierName` varchar(249) NOT NULL,
  `cashierNo` int(12) NOT NULL,
  `itemStatus` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cashierinventory`
--

INSERT INTO `cashierinventory` (`itemNo`, `itemName`, `itemBrand`, `itemRP`, `itemSRP`, `itemDOA`, `itemEXPD`, `cashierName`, `cashierNo`, `itemStatus`) VALUES
(4806789440121, 'caasdas', 'Yakult Philippines INC.', 123, 123, '2020-12-04', '2020-12-21', '', 0, 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `client_information`
--

CREATE TABLE `client_information` (
  `accNo` bigint(20) NOT NULL,
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
(4658428402, 'William ', 'Smith', 'Microsoft', 'Microsot Philippines', 'Enterprise', 'Taguig City', 'Makati', 'Philippines', 1224, '0000-00-00 00:00:00'),
(6560234550, 'Kobie', 'Oracion', 'Kobie Computer Shop', 'Luisiana Branch', 'Computer Cafe', 'Luisiana', 'Laguna', 'Philippines', 4032, '2020-12-02 03:15:55'),
(6643053270, 'Kobie ', 'Oracion', 'Miras Music Studio INC.', 'Cavinti Branch', 'Music Studio', 'Cavinti', 'Laguna', 'Philippines', 4022, '2020-12-02 03:16:03'),
(8417643240, 'Robert', 'Miras', 'Team Freelance', 'Cavinti Branch', 'Freelance', 'Cavinti', 'Laguna', 'PH', 3014, '2020-12-02 03:16:10');

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
(54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 14, 47, 57, 16, '2020-11-28', '2020-11-30'),
(78895710021, 'Lee Kum Kee Sesame Oil 270mL', 'Lee Kum Kee', 20, 168, 175, 0, '2020-11-28', '2020-11-30'),
(748485100401, 'Century Tuna Flakes in Oil 155g', 'Century Tuna', 28, 30, 32, 2, '2020-11-28', '2020-11-30'),
(748485102245, 'Century Tuna Flakes in Oil 95g', 'Century Tuna', 29, 22, 25, 1, '2020-11-28', '2020-11-30'),
(748485102252, 'Century Tuna Hot & Spicy 95g', 'Century Tuna', 18, 22, 25, 2, '2020-11-28', '2020-11-30'),
(748485801803, 'Argentina Corned Beef 100g', 'Argentina', 28, 22, 25, 2, '2020-11-28', '2020-11-30'),
(750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 100, 50, 60, 38, '2020-11-17', '2021-03-23'),
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
(4800818808760, 'Yakee! Super Asim Gumball 145.6g', 'Columbia Intl Food Product INC.', 0, 25, 28, 30, '2020-11-28', '2021-07-25'),
(4800818808906, 'Potchi Strawberyy Cream 135g', 'Columbia Intl Food Productions INC.', 0, 35, 50, 20, '2020-11-28', '2021-08-19'),
(4801668602027, 'Datu Puti Vinegar 200mL', 'Datu Puti', 18, 9, 10, 2, '2020-11-28', '2020-11-30'),
(4801668602034, 'Datu Puti Soy Sauce 200mL', 'Datu Puti', 18, 9, 10, 2, '2020-11-28', '2020-11-30'),
(4801668603659, 'Oysterrific Oyster Sauce 30g', 'Datu Puti', 0, 35, 40, 0, '2020-11-09', '2020-11-24'),
(4801668606865, 'Mafran All-Purpose Dressing  7.05oz', 'Mafran', 18, 12, 14, 2, '2020-11-28', '2020-11-30'),
(4801958349106, 'Aji-Ginisa 7g x 16', 'Ajinomoto', 20, 28, 30, 0, '2020-11-28', '2020-11-30'),
(4801981118502, 'Coca Cola 294mL', 'The CocaCola Company', 0, 10, 12, 0, '2020-11-13', '2020-11-10'),
(4804888589505, 'Hany Milk Chocolate', 'Annie Candy Manufacturing', 22, 30, 32, 28, '2020-11-28', '2021-03-14'),
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
(4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 48, 15, 17, 2, '2020-11-28', '2020-11-30'),
(4806521796240, 'Kids Choice Worm 100g', 'W.L. Foods', 50, 15, 22, 0, '2020-11-28', '2020-11-29'),
(4806525660561, 'Peanut Brittle Candy 150g', 'Rackey', 50, 27, 30, 0, '2020-11-28', '2020-11-30'),
(4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 91, 10, 15, 9, '2020-11-28', '2020-12-03'),
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
(8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 44, 40, 50, 6, '2020-11-28', '2020-11-30'),
(8992741942959, 'Yupi Strawberry Kiss', 'Yupi', 99, 100, 120, 1, '2020-11-27', '2020-11-28'),
(8992741942973, 'Yupi Sour Iced Cola', 'Yupi', 99, 100, 120, 1, '2020-11-27', '2020-11-28'),
(8993175537124, 'Richeese Cheese Wafer', 'Enerlife Philippines INC.', 0, 88, 98, 0, '2020-07-23', '2021-07-23'),
(8993175559890, 'Richoco Chocolate Wafer', 'Enerlife Philippines INC.', 0, 88, 98, 0, '2020-07-26', '2021-07-26');

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
  `salesQty` int(249) NOT NULL,
  `salesTotal` int(249) NOT NULL,
  `salesDate` timestamp NOT NULL DEFAULT current_timestamp(),
  `salesStatus` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `datasalesinventory`
--

INSERT INTO `datasalesinventory` (`salesTransNo`, `refNo`, `salesNo`, `salesItem`, `salesBrand`, `salesSRP`, `salesRP`, `salesQty`, `salesTotal`, `salesDate`, `salesStatus`) VALUES
(782223671324, 699, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:42:47', 'Pending'),
(771063338846, 700, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:49:19', 'Pending'),
(231270362108, 701, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:51:21', 'Pending'),
(231270362108, 702, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:51:21', 'Pending'),
(231270362108, 703, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:51:21', 'Pending'),
(231270362108, 704, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:51:21', 'Pending'),
(643832135201, 705, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:53:42', 'Pending'),
(643832135201, 706, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:53:42', 'Pending'),
(643832135201, 707, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:53:42', 'Pending'),
(643832135201, 708, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:53:42', 'Pending'),
(643832135201, 709, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:53:42', 'Pending'),
(643832135201, 710, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:53:42', 'Pending'),
(643832135201, 711, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 1, 57, '2020-12-03 06:53:42', 'Pending'),
(800545011852, 712, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 10, 15, 10, 15, '2020-12-04 04:42:39', 'Pending'),
(800545011852, 713, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 1, 17, '2020-12-04 04:42:39', 'Pending'),
(800545011852, 714, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 1, 17, '2020-12-04 04:42:39', 'Pending'),
(484153148476, 715, 8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 40, 50, 1, 50, '2020-12-04 04:52:59', 'Pending'),
(484153148476, 716, 8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 40, 50, 1, 50, '2020-12-04 04:52:59', 'Pending'),
(484153148476, 717, 8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 40, 50, 1, 50, '2020-12-04 04:52:59', 'Pending'),
(484153148476, 718, 8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 40, 50, 1, 50, '2020-12-04 04:52:59', 'Pending'),
(484153148476, 719, 8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 40, 50, 1, 50, '2020-12-04 04:52:59', 'Pending'),
(484153148476, 720, 8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 40, 50, 1, 50, '2020-12-04 04:52:59', 'Pending');

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
(17, 'Cash', 0, 384, 500, 116, '2020-11-28 07:52:12'),
(18, 'Cash', 0, 50, 500, 450, '2020-12-03 02:32:24'),
(19, 'Cash', 0, 50, 500, 450, '2020-12-03 02:34:53'),
(20, 'Cash', 0, 165, 200, 35, '2020-12-03 03:50:19'),
(21, 'Cash', 0, 165, 200, 35, '2020-12-03 03:51:31');

-- --------------------------------------------------------

--
-- Table structure for table `usersinventory`
--

CREATE TABLE `usersinventory` (
  `acc_no` bigint(20) NOT NULL,
  `usersName` varchar(30) NOT NULL,
  `usersPass` text NOT NULL,
  `usersPrevileges` varchar(10) NOT NULL,
  `usersTimein` datetime DEFAULT NULL,
  `usersTimeout` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usersinventory`
--

INSERT INTO `usersinventory` (`acc_no`, `usersName`, `usersPass`, `usersPrevileges`, `usersTimein`, `usersTimeout`) VALUES
(4658428402, 'WilliamSmith03', '$2a$10$ImB14cTHutNDFOiCdizfnO2fy7BHaNirnLwAVatcc181xx/7QHSfi', 'Cashier', NULL, NULL),
(6560234550, 'admin', '$2a$10$tihqjhR7FWrfOijOCCBDl.0uXzlOkT2WrnDKQSk0s6XJ1QxelvTHq', 'Admin', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6643053270, 'cashier', '$2a$10$KeqVWq/Z8PK9k78pxHR55OVQgbzVCra71vSgixOss6hvciqOboZ.K', 'Cashier', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(8417643240, 'user', '$2a$10$xjyzdSJIt6cfi39A.1cDx..QNWJwl9oH5F8UjQLhG/Hh.uw6cR3p.', 'Users', '0000-00-00 00:00:00', '0000-00-00 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cashierinventory`
--
ALTER TABLE `cashierinventory`
  ADD PRIMARY KEY (`itemNo`);

--
-- Indexes for table `client_information`
--
ALTER TABLE `client_information`
  ADD PRIMARY KEY (`accNo`);

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
  ADD PRIMARY KEY (`acc_no`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `datasalesinventory`
--
ALTER TABLE `datasalesinventory`
  MODIFY `refNo` bigint(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=721;

--
-- AUTO_INCREMENT for table `sales_preview`
--
ALTER TABLE `sales_preview`
  MODIFY `ref#` int(249) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `client_information`
--
ALTER TABLE `client_information`
  ADD CONSTRAINT `acc_no` FOREIGN KEY (`accNo`) REFERENCES `usersinventory` (`acc_no`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
