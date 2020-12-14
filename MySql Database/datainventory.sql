-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 14, 2020 at 05:42 AM
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
  `prodId` int(11) NOT NULL,
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

INSERT INTO `datainventory` (`prodId`, `prodNo`, `prodItem`, `prodBrand`, `prodQty`, `prodSRP`, `prodRP`, `prodBought`, `prodDOA`, `prodEXPD`) VALUES
(1, 48025522, 'Magic Sarap 8g', 'Maggi', 116, 37, 48, 15, '2020-11-17', '2020-11-29'),
(2, 14285000051, 'UFC Hot & Spicy Banana Ketchup 320g', 'UFC', 116, 30, 32, 0, '2020-11-28', '2020-11-30'),
(3, 14285002789, 'UFC Banana Ketchup 100g', 'UFC', 0, 9, 10, 2, '2020-11-28', '2020-11-30'),
(4, 54028367911, 'Yakult Probiotic Drink 5 x 80mL', 'Yakult Philippines INC.', 80, 47, 57, 22, '2020-12-05', '2020-11-30'),
(5, 78895710021, 'Lee Kum Kee Sesame Oil 270mL', 'Lee Kum Kee', 6, 168, 175, 0, '2020-11-28', '2020-11-30'),
(6, 748485100401, 'Century Tuna Flakes in Oil 155g', 'Century Tuna', 116, 30, 32, 2, '2020-11-28', '2020-11-30'),
(7, 748485102245, 'Century Tuna Flakes in Oil 95g', 'Century Tuna', 0, 22, 25, 1, '2020-11-28', '2020-11-30'),
(8, 748485102252, 'Century Tuna Hot & Spicy 95g', 'Century Tuna', 0, 22, 25, 2, '2020-11-28', '2020-11-30'),
(9, 748485801803, 'Argentina Corned Beef 100g', 'Argentina', 116, 22, 25, 2, '2020-11-28', '2020-11-30'),
(10, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 116, 50, 60, 38, '2020-11-17', '2021-03-23'),
(11, 750515018501, 'Skyflakes Crackers 250g', 'M.Y Sans', 116, 59, 69, 5, '2020-11-27', '2020-11-30'),
(12, 4800010781076, 'Cloud 9 Classic 336g', 'Jack n Jill', 122, 64, 80, 66, '2020-12-05', '2020-11-30'),
(13, 4800016022180, 'Great Taste White Crema Twin Pack 10 x 25g', 'Universal Robina', 116, 102, 110, 17, '2020-12-05', '2020-11-22'),
(14, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', 116, 24, 26, 170, '2020-11-17', '2021-09-18'),
(15, 4800016304019, 'Maxx Cherry 50 x 4g', 'Jack n Jill', 116, 37, 40, 0, '2020-11-28', '2020-11-30'),
(16, 4800016306013, 'Maxx Honey Lemon 200g', 'Jack n Jill', 116, 35, 50, 15, '2020-12-05', '2021-02-28'),
(17, 4800016551598, 'Nissin Ramen Seafood 55g', 'Nissin', 116, 8, 10, 1, '2020-11-28', '2020-11-30'),
(18, 4800016555985, 'Payless Xtra Big Kalamansi 130g', 'Payless', 116, 14, 16, 1, '2020-11-28', '2020-11-29'),
(19, 4800016556807, 'Payless Xtra Big Xtra Hot 130g', 'Payless', 116, 14, 16, 1, '2020-11-28', '2020-11-30'),
(20, 4800016561269, 'Nissin Ramen Spicy Hot Beef 65g', 'Nissin', 116, 8, 10, 1, '2020-11-28', '2020-11-30'),
(21, 4800016561436, 'Payless Xtra Big Sweet & Spicy 130g', 'Payless', 116, 14, 16, 1, '2020-11-28', '2020-11-30'),
(22, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 116, 12, 13, 122, '2020-11-17', '2021-02-05'),
(23, 4800016644801, 'Piattos Cheese', 'Jack n Jill', 116, 12, 13, 0, '2020-09-12', '2021-03-12'),
(24, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', 116, 12, 13, 0, '2020-02-07', '2020-09-07'),
(25, 4800016961625, 'Chooey Toffee 236.5g', 'Jack n Jill', 116, 40, 43, 0, '2020-12-05', '2020-11-30'),
(26, 4800024012395, 'Del Monte Pineapple Tidbits 560g', 'Del Monte', 116, 76, 85, 0, '2020-11-28', '2020-11-30'),
(27, 4800092113338, 'Rebisco Crackers', 'Republic Biscuit Corporation', 116, 50, 60, 0, '2020-07-12', '2021-07-12'),
(28, 4800092330018, 'Happy Original Flavor 20 x 5g', 'JBC Food Corp.', 116, 17, 20, 0, '2020-11-28', '2020-11-30'),
(29, 4800092330100, 'Ding Dong Mixed Peanuts 20 x 5g', 'JBC Food Corp.', 116, 17, 20, 0, '2020-11-28', '2020-11-30'),
(30, 4800092331268, 'Hi-Ho BBQ Flavor 20 x 5g', 'JBC Food Corp.', 116, 17, 20, 0, '2020-11-28', '2020-11-29'),
(31, 4800103341835, 'Chubby Choco Chewy Candy', 'SPI Corporation', 116, 20, 22, 0, '2020-03-17', '2021-03-17'),
(32, 4800103343563, 'Vita Cubes Singles 90g', 'SPI Corporation', 125, 20, 22, 0, '2020-12-05', '2021-02-01'),
(33, 4800134101033, 'Master Sardines in Tomato Sauce with Chili 155g', 'Master', 116, 28, 31, 2, '2020-11-28', '2020-11-30'),
(34, 4800163443043, 'Ligo Sardines in Tomato Sauce 155g', 'Ligo', 116, 28, 31, 2, '2020-11-28', '2020-11-30'),
(35, 4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 116, 7, 8, 0, '2020-02-23', '2021-02-03'),
(36, 4800344020520, 'Datu Puti Old English Worcestershire Sauce 150mL', 'Datu Puti', 116, 29, 32, 1, '2020-11-28', '2020-11-30'),
(37, 4800361410816, 'Bear Brand Swak Pack 33g', 'Nestle Philippines', 116, 12, 13, 6, '2020-11-27', '2020-11-29'),
(38, 4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 116, 83, 90, 98, '2020-04-30', '2021-04-30'),
(39, 4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 116, 102, 110, 113, '2020-12-05', '2021-07-31'),
(40, 4800575110373, 'Alaska Classic 370mL', 'Alaska Milk Corporation', 116, 44, 50, 0, '2020-11-28', '2020-11-30'),
(41, 4800818808760, 'Yakee! Super Asim Gumball 145.6g', 'Columbia Intl Food Product INC.', 117, 25, 28, 30, '2020-12-05', '2021-07-25'),
(42, 4800818808906, 'Potchi Strawberyy Cream 135g', 'Columbia Intl Food Productions INC.', 116, 35, 50, 20, '2020-12-08', '2021-08-19'),
(43, 4801668602027, 'Datu Puti Vinegar 200mL', 'Datu Puti', 116, 9, 10, 2, '2020-11-28', '2020-11-30'),
(44, 4801668602034, 'Datu Puti Soy Sauce 200mL', 'Datu Puti', 116, 9, 10, 2, '2020-11-28', '2020-11-30'),
(45, 4801668603659, 'Oysterrific Oyster Sauce 30g', 'Datu Puti', 116, 35, 40, 0, '2020-11-09', '2020-11-24'),
(46, 4801668606865, 'Mafran All-Purpose Dressing  7.05oz', 'Mafran', 116, 12, 14, 2, '2020-11-28', '2020-11-30'),
(47, 4801958341100, 'Ajinomoto Seasoning 18 x 11g', 'Ajinomoto', 116, 20, 18, 0, '2020-12-08', '2020-12-14'),
(48, 4801958349106, 'Aji-Ginisa 7g x 16', 'Ajinomoto', 116, 28, 30, 0, '2020-12-05', '2020-11-30'),
(49, 4801981118502, 'Coca Cola 294mL', 'The CocaCola Company', 116, 10, 12, 0, '2020-11-13', '2020-11-10'),
(50, 4804888589505, 'Hany Milk Chocolate', 'Annie Candy Manufacturing', 116, 30, 32, 28, '2020-12-05', '2021-03-14'),
(51, 4804888589987, 'Ube Purple Yam Candy 145g', 'Annie Candy Manufacturing', 115, 22, 24, 0, '2020-12-05', '2021-03-12'),
(52, 4806014000137, 'Jolly Sweet Cream Corn 425g ', 'Jolly', 116, 46, 50, 0, '2020-11-28', '2020-11-30'),
(53, 4806014000397, 'Jolly Cream of Mushroom 298g', 'Jolly', 116, 72, 80, 0, '2020-11-28', '2020-11-30'),
(54, 4806014000724, 'Dona Elena Extra Virgin Olive Oil 250mL', 'Dona Elena', 116, 100, 102, 3, '2020-11-28', '2020-11-30'),
(55, 4806504710119, 'Mega Sardines in Tomato Sauce 155g', 'Mega', 116, 18, 21, 1, '2020-11-28', '2020-11-30'),
(56, 4806504710126, 'Mega Sardines in Tomato Sauce with Chili Added 155g', 'Mega', 116, 28, 31, 3, '2020-11-28', '2020-11-30'),
(57, 4806507621863, 'Burst Assorted Fruit Flavor Chewy Candy', 'Guangdong Xiaomimi Foodstuff Corporation', 116, 22, 24, 0, '2020-06-19', '2022-06-19'),
(58, 4806511013166, 'Yaahoo Marie Jumbo 25g', 'W.L Foods', 116, 1, 2, 0, '2020-11-17', '2020-11-18'),
(59, 4806511111121, 'Topsee Milk Chocolate 18g', 'Delicatesse Food Corporation', 117, 32, 40, 0, '2020-12-05', '2021-08-26'),
(60, 4806521791634, 'Super Bawang Garlic Flavor 20 x 18g', 'W.L. Foods', 116, 18, 20, 0, '2020-11-28', '2020-11-29'),
(61, 4806521796202, 'Kids Choice Teeth 100g', 'W.L. Foods', 116, 15, 22, 0, '2020-12-05', '2020-11-29'),
(62, 4806521796233, 'Kids Choice DIY Burger', 'W.L. Foods', 119, 15, 17, 7, '2020-12-05', '2020-11-30'),
(63, 4806521796240, 'Kids Choice Worm 100g', 'W.L. Foods', 118, 15, 22, 0, '2020-12-05', '2020-11-29'),
(64, 4806525660561, 'Peanut Brittle Candy 150g', 'Rackey', 132, 27, 30, 4, '2020-12-05', '2020-11-30'),
(65, 4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 116, 10, 15, 9, '2020-12-05', '2020-12-03'),
(66, 4807770270024, 'Lucky Me Chicken na Chicken 55g', 'Lucky Me', 116, 8, 10, 1, '2020-11-28', '2020-11-30'),
(67, 4807770272097, 'Lucky Me Spicy Beef Labuyo 50g', 'Lucky Me', 116, 8, 10, 1, '2020-11-28', '2020-11-30'),
(68, 4807770273674, 'Lucky Me Pansit Canton Kalamansi Flavor 80g', 'Lucky Me', 116, 12, 14, 1, '2020-11-28', '2020-11-30'),
(69, 4807770273681, 'Lucky Me Pansit Canton Extra Hot Chili Flavor 80g', 'Lucky Me', 116, 12, 14, 1, '2020-11-28', '2020-11-30'),
(70, 4807770273698, 'Lucky Me Pansit Canton Chili-Mansi 80g', 'Lucky Me', 116, 12, 14, 1, '2020-11-28', '2020-11-30'),
(71, 4807770273711, 'Lucky Me Pansit Canton Sweet & Spicy 80g', 'Lucky Me', 116, 12, 14, 1, '2020-11-28', '2020-11-30'),
(72, 4808887011852, 'Star Corned Beef 150g', 'Star', 116, 28, 31, 1, '2020-11-28', '2020-11-30'),
(73, 4809010686011, 'Lemon Square Cheese Cake', 'Big E Food Corporation', 116, 60, 70, 0, '2020-10-30', '2021-10-30'),
(74, 4809011293229, 'Lumpia Shanghai Cheese Flavor 20 x 30g', 'IFP Manufacturing Corp.', 116, 17, 20, 0, '2020-11-28', '2020-11-30'),
(75, 4902430426464, 'Downy Expert AntiBac', 'Procter & Gamble Philippines INC.', 116, 75, 85, 0, '2020-07-12', '2021-07-12'),
(76, 4902430495141, 'Safeguard Floral Pink with Aloe 130g', 'Safeguard', 116, 45, 41, 0, '2020-12-08', '2020-12-08'),
(77, 4902430583169, 'Ariel Sunrise Fresh', 'Procter & Gamble Philippines INC.', 116, 60, 70, 0, '2020-07-12', '2020-07-12'),
(78, 8850006493014, 'Palmolive Sachet Intensive Moisture Shampoo 6 x 15ml', 'Palmolive', 116, 32, 31, 0, '2020-12-08', '2020-12-08'),
(79, 8851717904967, 'Delight 100ml', 'Dutch Mill Corporation', 116, 55, 60, 0, '2020-11-16', '2021-11-16'),
(80, 8935001720126, 'Mentos Tropical Mix', 'Perfetti Van Melle', 116, 35, 50, 0, '2020-07-08', '2022-07-08'),
(81, 8935001721697, 'Mentos Fruit Rainbow 135g', 'Perfetti van Melle', 116, 40, 50, 14, '2020-12-05', '2020-11-30'),
(82, 8992741942959, 'Yupi Strawberry Kiss', 'Yupi', 116, 100, 120, 1, '2020-11-27', '2020-11-28'),
(83, 8992741942973, 'Yupi Sour Iced Cola', 'Yupi', 116, 100, 120, 1, '2020-11-27', '2020-11-28'),
(84, 8993175537124, 'Richeese Cheese Wafer', 'Enerlife Philippines INC.', 116, 88, 98, 0, '2020-07-23', '2021-07-23'),
(85, 8993175559890, 'Richoco Chocolate Wafer', 'Enerlife Philippines INC.', 116, 88, 98, 0, '2020-07-26', '2021-07-26');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `datainventory`
--
ALTER TABLE `datainventory`
  ADD PRIMARY KEY (`prodNo`),
  ADD UNIQUE KEY `prodId` (`prodId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `datainventory`
--
ALTER TABLE `datainventory`
  MODIFY `prodId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=86;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
