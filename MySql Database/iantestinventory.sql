-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2020 at 03:00 PM
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
-- Table structure for table `brand`
--

CREATE TABLE `brand` (
  `bId` bigint(20) NOT NULL,
  `brand_name` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `brand`
--

INSERT INTO `brand` (`bId`, `brand_name`) VALUES
(6, 'Coca Cola'),
(7, 'Lucy Me');

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
  `itemVAT` int(11) NOT NULL,
  `itemDOA` date NOT NULL,
  `itemEXPD` date NOT NULL,
  `cashierName` varchar(249) NOT NULL,
  `cashierNo` int(12) NOT NULL,
  `itemStatus` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cashierinventory`
--

INSERT INTO `cashierinventory` (`itemNo`, `itemName`, `itemBrand`, `itemRP`, `itemSRP`, `itemVAT`, `itemDOA`, `itemEXPD`, `cashierName`, `cashierNo`, `itemStatus`) VALUES
(4801958341100, 'Ajinomoto Seasoning 18 x 11g', 'Ajinomoto', 18, 20, 0, '2020-12-07', '2020-12-14', 'Kobie Oracion', 2147483647, 'Approved'),
(4902430495141, 'Safeguard Floral Pink with Aloe 130g', 'Safeguard', 41, 45, 0, '2020-12-07', '2020-12-08', 'Kobie Oracion', 2147483647, 'Approved'),
(4902430587907, 'Tide Original Jumbo 12 x 80g', 'Tide', 120, 144, 0, '2020-12-07', '2020-12-21', 'Kobie Oracion', 2147483647, 'Pending'),
(8850006493014, 'Palmolive Sachet Intensive Moisture Shampoo 6 x 15ml', 'Palmolive', 31, 32, 0, '2020-12-07', '2020-12-08', 'Kobie Oracion', 2147483647, 'Approved');

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `cId` bigint(20) NOT NULL,
  `category_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`cId`, `category_name`) VALUES
(12, 'Frozen Foods'),
(13, 'Meat '),
(14, 'Produce '),
(15, 'Cleaners '),
(16, 'Breads'),
(17, 'Beverages'),
(18, 'Computer Hardware'),
(19, 'Fruits and Vegetables'),
(20, 'Condiment'),
(21, 'Milk & Dairy'),
(22, 'Canned Goods'),
(23, 'Sweets'),
(24, 'Pharmacy'),
(25, 'Snacks'),
(26, 'Dry Goods'),
(27, 'Personal Care');

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
  `prodId` int(11) NOT NULL,
  `prodNo` bigint(15) NOT NULL,
  `prodItem` varchar(999) NOT NULL,
  `prodBrand` varchar(999) NOT NULL,
  `prodQty` int(249) NOT NULL,
  `prodSRP` int(255) NOT NULL,
  `prodRP` int(250) NOT NULL,
  `prodVAT` int(11) NOT NULL,
  `prodBought` int(249) NOT NULL,
  `prodDOA` date NOT NULL,
  `prodCategory` varchar(249) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `datainventory`
--

INSERT INTO `datainventory` (`prodId`, `prodNo`, `prodItem`, `prodBrand`, `prodQty`, `prodSRP`, `prodRP`, `prodVAT`, `prodBought`, `prodDOA`, `prodCategory`) VALUES
(1, 48025522, 'Magic Sarap 8g', 'Maggi', 116, 37, 48, 0, 15, '2020-11-17', 'Condiment'),
(2, 14285000051, 'UFC Hot & Spicy Banana Ketchup 320g', 'UFC', 116, 30, 32, 0, 0, '2020-11-28', 'Condiment'),
(3, 14285002789, 'UFC Banana Ketchup 100g', 'UFC', 0, 9, 10, 0, 2, '2020-11-28', 'Condiment'),
(4, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 80, 47, 57, 0, 22, '2020-12-05', 'Beverages'),
(5, 78895710021, 'Lee Kum Kee Sesame Oil 270mL', 'Lee Kum Kee', 6, 168, 175, 0, 0, '2020-11-28', 'Condiment'),
(6, 748485100401, 'Century Tuna Flakes in Oil 155g', 'Century Tuna', 116, 30, 32, 0, 2, '2020-11-28', 'Canned Goods'),
(7, 748485102245, 'Century Tuna Flakes in Oil 95g', 'Century Tuna', 0, 22, 25, 0, 1, '2020-11-28', 'Canned Goods'),
(8, 748485102252, 'Century Tuna Hot & Spicy 95g', 'Century Tuna', 0, 22, 25, 0, 2, '2020-11-28', 'Canned Goods'),
(9, 748485801803, 'Argentina Corned Beef 100g', 'Argentina', 116, 22, 25, 0, 2, '2020-11-28', 'Canned Goods'),
(10, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 116, 50, 60, 0, 38, '2020-11-17', 'Snacks'),
(11, 750515018501, 'Skyflakes Crackers 250g', 'M.Y Sans', 116, 59, 69, 0, 5, '2020-11-27', 'Snacks'),
(12, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 122, 64, 80, 0, 66, '2020-12-05', 'Sweets'),
(13, 4800016022180, 'Great Taste White Crema Twin Pack 10 x 25g', 'Universal Robina', 116, 102, 110, 0, 17, '2020-12-05', 'Beverages'),
(14, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', 116, 24, 26, 0, 170, '2020-11-17', 'Sweets'),
(15, 4800016304019, 'Maxx Cherry 50 x 4g', 'Jack n Jill', 116, 37, 40, 0, 0, '2020-11-28', 'Sweets'),
(16, 4800016306013, 'Maxx Honey Lemon 200g', 'Jack n Jill', 116, 35, 50, 0, 15, '2020-12-05', 'Sweets'),
(17, 4800016551598, 'Nissin Ramen Seafood 55g', 'Nissin', 116, 8, 10, 0, 1, '2020-11-28', 'Dry Goods'),
(18, 4800016555985, 'Payless Xtra Big Kalamansi 130g', 'Payless', 116, 14, 16, 0, 1, '2020-11-28', 'Dry Goods'),
(19, 4800016556807, 'Payless Xtra Big Xtra Hot 130g', 'Payless', 116, 14, 16, 0, 1, '2020-11-28', 'Dry Goods'),
(20, 4800016561269, 'Nissin Ramen Spicy Hot Beef 65g', 'Nissin', 116, 8, 10, 0, 1, '2020-11-28', 'Dry Goods'),
(21, 4800016561436, 'Payless Xtra Big Sweet & Spicy 130g', 'Payless', 116, 14, 16, 0, 1, '2020-11-28', 'Dry Goods'),
(22, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 116, 12, 13, 0, 122, '2020-11-17', 'Snacks'),
(23, 4800016644801, 'Piattos Cheese', 'Jack n Jill', 116, 12, 13, 0, 0, '2020-09-12', 'Snacks'),
(24, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', 116, 12, 13, 0, 0, '2020-02-07', 'Snacks'),
(25, 4800016961625, 'Chooey Toffee 236.5g', 'Jack n Jill', 116, 40, 43, 0, 0, '2020-12-05', 'Sweets'),
(26, 4800024012395, 'Del Monte Pineapple Tidbits 560g', 'Del Monte', 116, 76, 85, 0, 0, '2020-11-28', 'Canned Goods'),
(27, 4800092113338, 'Rebisco Crackers', 'Republic Biscuit Corporation', 116, 50, 60, 0, 0, '2020-07-12', 'Snacks'),
(28, 4800092330018, 'Happy Original Flavor 20 x 5g', 'JBC Food Corp.', 116, 17, 20, 0, 0, '2020-11-28', 'Snacks'),
(29, 4800092330100, 'Ding Dong Mixed Peanuts 20 x 5g', 'JBC Food Corp.', 116, 17, 20, 0, 0, '2020-11-28', 'Snacks'),
(30, 4800092331268, 'Hi-Ho BBQ Flavor 20 x 5g', 'JBC Food Corp.', 116, 17, 20, 0, 0, '2020-11-28', 'Snacks'),
(31, 4800103341835, 'Chubby Choco Chewy Candy', 'SPI Corporation', 116, 20, 22, 0, 0, '2020-03-17', 'Sweets'),
(32, 4800103343563, 'Vita Cubes Singles 90g', 'SPI Corporation', 125, 20, 22, 0, 0, '2020-12-05', 'Sweets'),
(33, 4800134101033, 'Master Sardines in Tomato Sauce with Chili 155g', 'Master', 116, 28, 31, 0, 2, '2020-11-28', 'Canned Goods'),
(34, 4800163443043, 'Ligo Sardines in Tomato Sauce 155g', 'Ligo', 116, 28, 31, 0, 2, '2020-11-28', 'Canned Goods'),
(35, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 116, 7, 8, 0, 0, '2020-02-23', 'Snacks'),
(36, 4800344020520, 'Datu Puti Old English Worcestershire Sauce 150mL', 'Datu Puti', 116, 29, 32, 0, 1, '2020-11-28', 'Condiment'),
(37, 4800361410816, 'Bear Brand Swak Pack 33g', 'Nestle Philippines', 116, 12, 13, 0, 6, '2020-11-27', 'Beverages'),
(38, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 116, 83, 90, 0, 98, '2020-04-30', 'Beverages'),
(39, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 116, 102, 110, 0, 113, '2020-12-05', 'Beverages'),
(40, 4800575110373, 'Alaska Classic 370mL', 'Alaska Milk Corporation', 116, 44, 50, 0, 0, '2020-11-28', 'Milk & Dairy'),
(41, 4800818808760, 'Yakee! Super Asim Gumball 145.6g', 'Columbia Intl Food Product INC.', 117, 25, 28, 0, 30, '2020-12-05', 'Sweets'),
(42, 4800818808906, 'Potchi Strawberyy Cream 135g', 'Columbia Intl Food Productions INC.', 116, 35, 50, 0, 20, '2020-12-08', 'Sweets'),
(43, 4801668602027, 'Datu Puti Vinegar 200mL', 'Datu Puti', 116, 9, 10, 0, 2, '2020-11-28', 'Condiment'),
(44, 4801668602034, 'Datu Puti Soy Sauce 200mL', 'Datu Puti', 116, 9, 10, 0, 2, '2020-11-28', 'Condiment'),
(45, 4801668603659, 'Oysterrific Oyster Sauce 30g', 'Datu Puti', 116, 35, 40, 0, 0, '2020-11-09', 'Condiment'),
(46, 4801668606865, 'Mafran All-Purpose Dressing  7.05oz', 'Mafran', 116, 12, 14, 0, 2, '2020-11-28', 'Condiment'),
(47, 4801958341100, 'Ajinomoto Seasoning 18 x 11g', 'Ajinomoto', 116, 20, 18, 0, 0, '2020-12-08', 'Condiment'),
(48, 4801958349106, 'Aji-Ginisa 7g x 16', 'Ajinomoto', 116, 28, 30, 0, 0, '2020-12-05', 'Condiment'),
(49, 4801981118502, 'Coca Cola 294mL', 'The CocaCola Company', 116, 10, 12, 0, 0, '2020-11-13', 'Beverages'),
(50, 4804888589505, 'Hany Milk Chocolate', 'Annie Candy Manufacturing', 116, 30, 32, 0, 28, '2020-12-05', 'Sweets'),
(51, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 115, 22, 24, 0, 0, '2020-12-05', 'Sweets'),
(52, 4806014000137, 'Jolly Sweet Cream Corn 425g ', 'Jolly', 116, 46, 50, 0, 0, '2020-11-28', 'Canned Goods'),
(53, 4806014000397, 'Jolly Cream of Mushroom 298g', 'Jolly', 116, 72, 80, 0, 0, '2020-11-28', 'Canned Goods'),
(54, 4806014000724, 'Dona Elena Extra Virgin Olive Oil 250mL', 'Dona Elena', 116, 100, 102, 0, 3, '2020-11-28', 'Condiment'),
(55, 4806504710119, 'Mega Sardines in Tomato Sauce 155g', 'Mega', 116, 18, 21, 0, 1, '2020-11-28', 'Canned Goods'),
(56, 4806504710126, 'Mega Sardines in Tomato Sauce with Chili Added 155g', 'Mega', 116, 28, 31, 0, 3, '2020-11-28', 'Canned Goods'),
(57, 4806507621863, 'Burst Assorted Fruit Flavor Chewy Candy', 'Guangdong Xiaomimi Foodstuff Corporation', 116, 22, 24, 0, 0, '2020-06-19', 'Sweets'),
(58, 4806511013166, 'Yaahoo Marie Jumbo 25g', 'W.L Foods', 116, 1, 2, 0, 0, '2020-11-17', 'Snacks'),
(59, 4806511111121, 'Topsee Milk Chocolate 18g', 'Delicatesse Food Corporation', 117, 32, 40, 0, 0, '2020-12-05', 'Sweets'),
(60, 4806521791634, 'Super Bawang Garlic Flavor 20 x 18g', 'W.L. Foods', 116, 18, 20, 0, 0, '2020-11-28', 'Snacks'),
(61, 4806521796202, 'Kids Choice Teeth 100g', 'W.L. Foods', 116, 15, 22, 0, 0, '2020-12-05', 'Sweets'),
(62, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 119, 15, 17, 0, 7, '2020-12-05', 'Sweets'),
(63, 4806521796240, 'Kids Choice Worm 100g', 'W.L. Foods', 118, 15, 22, 0, 0, '2020-12-05', 'Sweets'),
(64, 4806525660561, 'Peanut Brittle Candy 150g', 'Rackey', 132, 27, 30, 0, 4, '2020-12-05', 'Sweets'),
(65, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 116, 10, 15, 0, 9, '2020-12-05', 'Sweets'),
(66, 4807770270024, 'Lucky Me Chicken na Chicken 55g', 'Lucky Me', 116, 8, 10, 0, 1, '2020-11-28', 'Dry Goods'),
(67, 4807770272097, 'Lucky Me Spicy Beef Labuyo 50g', 'Lucky Me', 116, 8, 10, 0, 1, '2020-11-28', 'Dry Goods'),
(68, 4807770273674, 'Lucky Me Pansit Canton Kalamansi Flavor 80g', 'Lucky Me', 116, 12, 14, 0, 1, '2020-11-28', 'Dry Goods'),
(69, 4807770273681, 'Lucky Me Pansit Canton Extra Hot Chili Flavor 80g', 'Lucky Me', 116, 12, 14, 0, 1, '2020-11-28', 'Dry Goods'),
(70, 4807770273698, 'Lucky Me Pansit Canton Chili-Mansi 80g', 'Lucky Me', 116, 12, 14, 0, 1, '2020-11-28', 'Dry Goods'),
(71, 4807770273711, 'Lucky Me Pansit Canton Sweet & Spicy 80g', 'Lucky Me', 116, 12, 14, 0, 1, '2020-11-28', 'Dry Goods'),
(72, 4808887011852, 'Star Corned Beef 150g', 'Star', 116, 28, 31, 0, 1, '2020-11-28', 'Canned Goods'),
(73, 4809010686011, 'Lemon Square Cheese Cake', 'Big E Food Corporation', 116, 60, 70, 0, 0, '2020-10-30', 'Breads'),
(74, 4809011293229, 'Lumpia Shanghai Cheese Flavor 20 x 30g', 'IFP Manufacturing Corp.', 116, 17, 20, 0, 0, '2020-11-28', 'Snacks'),
(75, 4902430426464, 'Downy Expert AntiBac', 'Procter & Gamble Philippines INC.', 116, 75, 85, 0, 0, '2020-07-12', 'Cleaners '),
(76, 4902430495141, 'Safeguard Floral Pink with Aloe 130g', 'Safeguard', 116, 45, 41, 0, 0, '2020-12-08', 'Personal Care'),
(77, 4902430583169, 'Ariel Sunrise Fresh', 'Procter & Gamble Philippines INC.', 116, 60, 70, 0, 0, '2020-07-12', 'Cleaners '),
(78, 8850006493014, 'Palmolive Sachet Intensive Moisture Shampoo 6 x 15ml', 'Palmolive', 116, 32, 31, 0, 0, '2020-12-08', 'Personal Care'),
(79, 8851717904967, 'Delight 100ml', 'Dutch Mill Corporation', 116, 55, 60, 0, 0, '2020-11-16', 'Beverages'),
(86, 8853428003458, 'Calcium Carbonate Calcimate 100 x 12.5g', 'Singapore Genebio INC.', 30, 310, 300, 10, 0, '2020-12-15', 'Pharmacy'),
(80, 8935001720126, 'Mentos Tropical Mix', 'Perfetti Van Melle', 116, 35, 50, 0, 0, '2020-07-08', 'Sweets'),
(81, 8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 116, 40, 50, 0, 14, '2020-12-05', 'Sweets'),
(82, 8992741942959, 'Yupi Strawberry Kiss', 'Yupi', 116, 100, 120, 0, 1, '2020-11-27', 'Sweets'),
(83, 8992741942973, 'Yupi Sour Iced Cola', 'Yupi', 116, 100, 120, 0, 1, '2020-11-27', 'Sweets'),
(84, 8993175537124, 'Richeese Cheese Wafer', 'Enerlife Philippines INC.', 116, 88, 98, 0, 0, '2020-07-23', 'Snacks'),
(85, 8993175559890, 'Richoco Chocolate Wafer', 'Enerlife Philippines INC.', 116, 88, 98, 0, 0, '2020-07-26', 'Snacks');

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
  `salesVAT` int(11) NOT NULL,
  `salesQty` int(249) NOT NULL,
  `salesTotal` int(249) NOT NULL,
  `salesDate` timestamp NOT NULL DEFAULT current_timestamp(),
  `salesStatus` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `datasalesinventory`
--

INSERT INTO `datasalesinventory` (`salesTransNo`, `refNo`, `salesNo`, `salesItem`, `salesBrand`, `salesSRP`, `salesRP`, `salesVAT`, `salesQty`, `salesTotal`, `salesDate`, `salesStatus`) VALUES
(148115705300, 971, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 0, 1, 80, '2020-12-08 06:20:28', 'Pending'),
(148115705300, 972, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 1, 57, '2020-12-08 06:20:28', 'Pending'),
(148115705300, 973, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 1, 24, '2020-12-08 06:20:28', 'Pending'),
(148115705300, 974, 8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 40, 50, 0, 1, 50, '2020-12-08 06:20:28', 'Pending'),
(148115705300, 975, 4800818808906, 'Potchi Strawberyy Cream 135g', 'Columbia Intl Food Productions INC.', 35, 50, 0, 1, 50, '2020-12-08 06:20:28', 'Pending'),
(628316868077, 976, 4800818808760, 'Yakee! Super Asim Gumball 145.6g', 'Columbia Intl Food Product INC.', 25, 28, 0, 1, 28, '2020-12-08 07:16:31', 'Sold'),
(628316868077, 977, 4800016306013, 'Maxx Honey Lemon 200g', 'Jack n Jill', 35, 50, 0, 1, 50, '2020-12-08 07:16:31', 'Sold'),
(628316868077, 978, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 1, 57, '2020-12-08 07:16:31', 'Sold'),
(628316868077, 979, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 1, 24, '2020-12-08 07:16:31', 'Sold'),
(656811488437, 982, 4800818808760, 'Yakee! Super Asim Gumball 145.6g', 'Columbia Intl Food Product INC.', 25, 28, 0, 1, 28, '2020-12-09 06:43:24', 'Pending'),
(881602668257, 983, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 5, 285, '2020-12-11 13:32:51', 'Cancelled'),
(74037116730, 985, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 2, 114, '2020-12-11 14:24:22', 'Pending'),
(444130852587, 986, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 2, 114, '2020-12-11 14:30:47', 'Pending'),
(627080583044, 990, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 1, 57, '2020-12-11 14:32:50', 'Pending'),
(341048854377, 995, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 2, 114, '2020-12-11 14:40:15', 'Pending'),
(341048854377, 996, 4800818808760, 'Yakee! Super Asim Gumball 145.6g', 'Columbia Intl Food Product INC.', 25, 28, 0, 3, 84, '2020-12-11 14:40:15', 'Pending'),
(341048854377, 997, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 1, 24, '2020-12-11 14:40:15', 'Pending'),
(341048854377, 998, 4800016961625, 'Chooey Toffee 236.5g', 'Jack n Jill', 40, 43, 0, 1, 43, '2020-12-11 14:40:15', 'Pending'),
(223477757362, 1000, 4800103343563, 'Vita Cubes Singles 90g', 'SPI Corporation', 20, 22, 0, 1, 22, '2020-12-11 14:42:00', 'Sold'),
(223477757362, 1001, 4800818808760, 'Yakee! Super Asim Gumball 145.6g', 'Columbia Intl Food Product INC.', 25, 28, 0, 7, 196, '2020-12-11 14:42:00', 'Sold'),
(223477757362, 1002, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 9, 216, '2020-12-11 14:42:00', 'Sold'),
(223477757362, 1003, 4806521796240, 'Kids Choice Worm 100g', 'W.L. Foods', 15, 22, 0, 2, 44, '2020-12-11 14:42:00', 'Sold'),
(223477757362, 1004, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 9, 513, '2020-12-11 14:43:14', 'Sold'),
(223477757362, 1005, 4800016961625, 'Chooey Toffee 236.5g', 'Jack n Jill', 40, 43, 0, 1, 43, '2020-12-11 14:43:14', 'Sold'),
(223477757362, 1006, 4806525660561, 'Peanut Brittle Candy 150g', 'Rackey', 27, 30, 0, 8, 240, '2020-12-11 14:43:14', 'Refunded'),
(223477757362, 1007, 4806511111121, 'Topsee Milk Chocolate 18g', 'Delicatesse Food Corporation', 32, 40, 0, 1, 40, '2020-12-11 14:43:14', 'Refunded'),
(223477757362, 1008, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 64, 80, 0, 3, 240, '2020-12-11 14:43:14', 'Refunded'),
(223477757362, 1009, 4800016306013, 'Maxx Honey Lemon 200g', 'Jack n Jill', 35, 50, 0, 6, 300, '2020-12-11 14:46:10', 'Pending'),
(36435256245, 1010, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 2, 114, '2020-12-11 14:53:23', 'Refunded'),
(36435256245, 1011, 4800103343563, 'Vita Cubes Singles 90g', 'SPI Corporation', 20, 22, 0, 1, 22, '2020-12-11 14:53:23', 'Refunded'),
(36435256245, 1012, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 0, 1, 17, '2020-12-11 14:53:23', 'Refunded'),
(468580624717, 1014, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 0, 1, 17, '2020-12-11 14:54:24', 'Refunded'),
(468580624717, 1015, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 1, 57, '2020-12-11 14:54:24', 'Pending'),
(387430612574, 1016, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 0, 1, 17, '2020-12-11 14:57:57', 'Refunded'),
(387430612574, 1017, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 47, 57, 0, 1, 57, '2020-12-11 14:57:57', 'Cancelled'),
(262225472180, 1018, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 0, 1, 17, '2020-12-11 15:01:28', 'Refunded'),
(562374181848, 1019, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 0, 1, 17, '2020-12-11 15:05:33', 'Refunded'),
(884834006714, 1020, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 0, 1, 17, '2020-12-11 15:17:17', 'Refunded'),
(35514550313, 1021, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 0, 1, 17, '2020-12-11 15:20:37', 'Refunded'),
(38747745523, 1022, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 0, 2, 34, '2020-12-11 15:25:08', 'Refunded'),
(768320636754, 1023, 4806525660561, 'Peanut Brittle Candy 150g', 'Rackey', 27, 30, 0, 1, 30, '2020-12-12 01:17:05', 'Pending'),
(768320636754, 1024, 4800016306013, 'Maxx Honey Lemon 200g', 'Jack n Jill', 35, 50, 0, 1, 50, '2020-12-12 01:17:05', 'Pending'),
(768320636754, 1025, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 1, 24, '2020-12-12 01:17:05', 'Pending'),
(768320636754, 1026, 4800103343563, 'Vita Cubes Singles 90g', 'SPI Corporation', 20, 22, 0, 1, 22, '2020-12-12 01:17:05', 'Pending'),
(243315824804, 1027, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 1, 24, '2020-12-12 07:53:50', 'Pending'),
(243315824804, 1028, 4800016306013, 'Maxx Honey Lemon 200g', 'Jack n Jill', 35, 50, 0, 1, 50, '2020-12-12 07:53:50', 'Pending'),
(243315824804, 1029, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 15, 17, 0, 1, 17, '2020-12-12 07:53:50', 'Pending'),
(688458037320, 1030, 4806525660561, 'Peanut Brittle Candy 150g', 'Rackey', 27, 30, 0, 1, 30, '2020-12-12 07:56:37', 'Pending'),
(873106381826, 1031, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 1, 24, '2020-12-12 07:58:50', 'Pending'),
(304762766558, 1032, 4806525660561, 'Peanut Brittle Candy 150g', 'Rackey', 27, 30, 0, 1, 30, '2020-12-12 08:02:20', 'Pending'),
(663645462883, 1033, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 1, 24, '2020-12-12 08:03:48', 'Pending'),
(520417211361, 1034, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 1, 24, '2020-12-12 08:06:32', 'Pending'),
(641515726551, 1035, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 1, 24, '2020-12-12 08:07:29', 'Sold'),
(717413003185, 1036, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 22, 24, 0, 1, 24, '2020-12-12 08:07:45', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `sales_preview`
--

CREATE TABLE `sales_preview` (
  `refNo` int(249) NOT NULL,
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

INSERT INTO `sales_preview` (`refNo`, `payment_method`, `payment_vat`, `payment_total`, `payment_paid`, `payment_due`, `payment_date`) VALUES
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
(21, 'Cash', 0, 165, 200, 35, '2020-12-03 03:51:31'),
(22, 'Cash', 0, 111, 1000, 373, '2020-12-05 02:30:30'),
(23, 'Cash', 0, 32, 500, 180, '2020-12-05 02:36:40'),
(24, 'Cash', 0, 699, 1000, 301, '2020-12-05 06:18:18'),
(25, 'Cash', 0, 54, 100, 46, '2020-12-05 06:20:15'),
(26, 'Cash', 0, 15, 20, 5, '2020-12-05 06:22:40'),
(27, 'Cash', 0, 45, 50, 5, '2020-12-05 06:24:48'),
(28, 'Cash', 0, 244, 300, 56, '2020-12-05 06:35:58'),
(29, 'Cash', 0, 162, 200, 38, '2020-12-05 06:38:44'),
(30, 'Cash', 0, 219, 250, 31, '2020-12-05 06:40:03'),
(31, 'Cash', 0, 80, 100, 20, '2020-12-05 06:40:33'),
(32, 'Cash', 0, 138, 200, 62, '2020-12-05 06:42:19'),
(33, 'Cash', 0, 24, 100, 76, '2020-12-05 06:45:21'),
(34, 'Cash', 0, 81, 100, 19, '2020-12-06 13:23:47'),
(35, 'Cash', 0, 89, 300, 13, '2020-12-06 13:29:36'),
(36, 'Cash', 0, 44, 100, 56, '2020-12-06 13:44:34'),
(37, 'Cash', 0, 280, 300, 20, '2020-12-07 02:15:08'),
(38, 'Cash', 0, 280, 300, 20, '2020-12-07 02:17:15'),
(39, 'Cash', 0, 280, 300, 20, '2020-12-07 02:19:52'),
(40, 'Cash', 0, 280, 300, 20, '2020-12-07 02:22:12'),
(41, 'Cash', 0, 280, 300, 20, '2020-12-07 02:26:42'),
(42, 'Cash', 0, 280, 400, 120, '2020-12-07 02:28:02'),
(43, 'Cash', 0, 280, 300, 20, '2020-12-07 02:31:43'),
(44, 'Cash', 0, 280, 300, 20, '2020-12-07 02:35:58'),
(45, 'Cash', 0, 280, 300, 20, '2020-12-07 02:40:33'),
(46, 'Cash', 0, 280, 300, 20, '2020-12-07 02:46:03'),
(47, 'Cash', 0, 308, 400, 92, '2020-12-07 02:47:54'),
(48, 'Cash', 0, 280, 300, 20, '2020-12-07 02:51:36'),
(49, 'Cash', 0, 418, 500, 82, '2020-12-07 02:55:10'),
(50, 'Cash', 0, 280, 300, 20, '2020-12-07 02:58:42'),
(51, 'Cash', 0, 252, 300, 48, '2020-12-07 03:03:30'),
(52, 'Cash', 0, 362, 400, 38, '2020-12-07 03:05:25'),
(53, 'Cash', 0, 252, 300, 48, '2020-12-07 03:08:08'),
(54, 'Cash', 0, 142, 200, 58, '2020-12-07 03:19:33'),
(55, 'Cash', 0, 252, 300, 48, '2020-12-07 03:28:52'),
(56, 'Cash', 0, 174, 200, 26, '2020-12-07 03:33:19'),
(57, 'Cash', 0, 252, 300, 48, '2020-12-07 03:34:18'),
(58, 'Cash', 0, 252, 300, 48, '2020-12-07 03:35:28'),
(59, 'Cash', 0, 252, 300, 48, '2020-12-07 03:36:46'),
(60, 'Cash', 0, 252, 300, 48, '2020-12-07 03:38:05'),
(61, 'Cash', 0, 252, 300, 48, '2020-12-07 03:42:58'),
(62, 'Cash', 0, 252, 300, 48, '2020-12-07 03:46:33'),
(63, 'Cash', 0, 252, 300, 48, '2020-12-07 03:57:04'),
(64, 'Cash', 0, 252, 300, 48, '2020-12-07 03:58:27'),
(65, 'Cash', 0, 252, 300, 48, '2020-12-07 03:59:10'),
(66, 'Cash', 0, 252, 300, 48, '2020-12-07 04:00:26'),
(67, 'Cash', 0, 362, 400, 38, '2020-12-07 04:02:33'),
(68, 'Cash', 0, 1155, 2000, 845, '2020-12-07 04:19:35'),
(69, 'Cash', 0, 291, 1000, 709, '2020-12-08 05:30:00'),
(70, 'Cash', 0, 261, 300, 39, '2020-12-08 05:45:06'),
(71, 'Cash', 0, 261, 300, 39, '2020-12-08 05:46:35'),
(72, 'Cash', 0, 261, 300, 39, '2020-12-08 06:20:46'),
(73, 'Cash', 0, 159, 160, 1, '2020-12-08 07:17:08'),
(74, 'Cash', 0, 124, 200, 76, '2020-12-11 14:42:27'),
(75, 'Cash', 0, 1032, 10000, 9294, '2020-12-11 14:45:19'),
(76, 'Cash', 0, 153, 200, 47, '2020-12-11 14:53:54'),
(77, 'Cash', 0, 17, 10, -7, '2020-12-11 15:17:33'),
(78, 'Cash', 0, 17, 10, -7, '2020-12-11 15:20:43'),
(79, 'Cash', 0, 34, 20, -14, '2020-12-11 15:25:17'),
(80, 'Cash', 0, 91, 50, -41, '2020-12-12 07:54:38'),
(81, 'Cash', 0, 30, 0, -30, '2020-12-12 07:56:56'),
(82, 'Cash', 0, 24, 30, 6, '2020-12-12 08:07:38'),
(83, 'Cash', 0, 24, 20, -4, '2020-12-12 08:07:55');

-- --------------------------------------------------------

--
-- Table structure for table `stock_out`
--

CREATE TABLE `stock_out` (
  `stockoutTransNo` bigint(20) NOT NULL,
  `stockoutNo` varchar(249) NOT NULL,
  `stockoutItem` varchar(249) NOT NULL,
  `stockoutQty` int(11) NOT NULL,
  `stockoutPrice` int(11) NOT NULL,
  `stockoutDate` datetime NOT NULL,
  `stockoutId` int(11) NOT NULL,
  `stockoutStatus` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `stock_out`
--

INSERT INTO `stock_out` (`stockoutTransNo`, `stockoutNo`, `stockoutItem`, `stockoutQty`, `stockoutPrice`, `stockoutDate`, `stockoutId`, `stockoutStatus`) VALUES
(124589730289, '054028367911', 'Yakult Probiotic Drink 5 x 80mL', 60, 2400, '2020-12-13 17:35:24', 1, 'Stock Out'),
(159686247859, '78895710021', 'Lee Kum Kee Sesame Oil 270mL', 2, 1160, '2020-12-13 17:35:24', 2, 'Stock Out'),
(865249753259, '748485100401', 'Century Tuna Flakes in Oil 155g', 10, 300, '2020-12-13 17:35:24', 3, 'Pending'),
(12221261451, '8853428003458', 'Calcium Carbonate Calcimate 100 x 12.5g', 10, 300, '2020-12-15 19:16:17', 4, 'Stock Out');

-- --------------------------------------------------------

--
-- Table structure for table `store`
--

CREATE TABLE `store` (
  `store_id` int(11) NOT NULL,
  `store_name` varchar(250) NOT NULL,
  `store_address` varchar(250) NOT NULL,
  `store_tin` varchar(250) DEFAULT NULL,
  `store_serial_number` varchar(250) DEFAULT NULL,
  `store_min` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `store`
--

INSERT INTO `store` (`store_id`, `store_name`, `store_address`, `store_tin`, `store_serial_number`, `store_min`) VALUES
(1, 'MIRAS COMPUTER CAFE AND STORE', '34 A MABINI ST. POBLACION CAVINTI, LAGUNA', '000-000-000', 'WTF000001', '000000001');

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
-- Indexes for table `brand`
--
ALTER TABLE `brand`
  ADD PRIMARY KEY (`bId`);

--
-- Indexes for table `cashierinventory`
--
ALTER TABLE `cashierinventory`
  ADD PRIMARY KEY (`itemNo`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`cId`);

--
-- Indexes for table `client_information`
--
ALTER TABLE `client_information`
  ADD PRIMARY KEY (`accNo`);

--
-- Indexes for table `datainventory`
--
ALTER TABLE `datainventory`
  ADD PRIMARY KEY (`prodNo`),
  ADD UNIQUE KEY `prodId` (`prodId`);

--
-- Indexes for table `datasalesinventory`
--
ALTER TABLE `datasalesinventory`
  ADD UNIQUE KEY `refNo` (`refNo`);

--
-- Indexes for table `sales_preview`
--
ALTER TABLE `sales_preview`
  ADD UNIQUE KEY `salesReference` (`refNo`);

--
-- Indexes for table `stock_out`
--
ALTER TABLE `stock_out`
  ADD PRIMARY KEY (`stockoutId`);

--
-- Indexes for table `store`
--
ALTER TABLE `store`
  ADD PRIMARY KEY (`store_id`);

--
-- Indexes for table `usersinventory`
--
ALTER TABLE `usersinventory`
  ADD PRIMARY KEY (`acc_no`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `brand`
--
ALTER TABLE `brand`
  MODIFY `bId` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `cId` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `datainventory`
--
ALTER TABLE `datainventory`
  MODIFY `prodId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87;

--
-- AUTO_INCREMENT for table `datasalesinventory`
--
ALTER TABLE `datasalesinventory`
  MODIFY `refNo` bigint(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1037;

--
-- AUTO_INCREMENT for table `sales_preview`
--
ALTER TABLE `sales_preview`
  MODIFY `refNo` int(249) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;

--
-- AUTO_INCREMENT for table `stock_out`
--
ALTER TABLE `stock_out`
  MODIFY `stockoutId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `store`
--
ALTER TABLE `store`
  MODIFY `store_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

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
