-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 17, 2020 at 02:25 PM
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
  `prodDOA` date NOT NULL,
  `prodEXPD` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `datainventory`
--

INSERT INTO `datainventory` (`prodNo`, `prodItem`, `prodBrand`, `prodQty`, `prodSRP`, `prodRP`, `prodDOA`, `prodEXPD`) VALUES
(48025522, 'Magic Sarap 8g', 'Maggi', 10, 37, 48, '2020-11-17', '2020-11-29'),
(750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 100, 50, 60, '2020-11-17', '2021-03-23'),
(4800016022180, 'Great Taste White Crema', 'Universal Robina', 20, 102, 110, '2020-11-17', '2020-11-22'),
(4800016043093, 'Nips White Chocolate', 'Jack n Jill', 15, 24, 26, '2020-11-17', '2021-09-18'),
(4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 100, 35, 50, '2020-11-17', '2021-02-28'),
(4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 20, 12, 13, '2020-11-17', '2021-02-05'),
(4800016644801, 'Piattos Cheese', 'Jack n Jill', 0, 12, 13, '2020-09-12', '2021-03-12'),
(4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', 0, 12, 13, '2020-02-07', '2020-09-07'),
(4800092113338, 'Rebisco Crackers', 'Republic Biscuit Corporation', 0, 50, 60, '2020-07-12', '2021-07-12'),
(4800103341835, 'Chubby Choco Chewy Candy', 'SPI Corporation', 0, 20, 22, '2020-03-17', '2021-03-17'),
(4800103343563, 'Vita Cubes Singles', 'SPI Corporation', 0, 20, 22, '2020-02-01', '2021-02-01'),
(4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 0, 7, 8, '2020-02-23', '2021-02-03'),
(4800361413480, 'Milo Twin Pack', 'Nestle Philippines INC.', 0, 83, 90, '2020-04-30', '2021-04-30'),
(4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 0, 102, 110, '2020-07-31', '2021-07-31'),
(4800818808760, 'Yakee! Super Asim Gumball', 'Columbia Intl Food Product INC.', 0, 25, 28, '2020-07-27', '2021-07-25'),
(4800818808906, 'Potchi Strawberyy Cream', 'Columbia Intl Food Productions INC.', 0, 35, 50, '2020-08-19', '2021-08-19'),
(4801668603659, 'Oysterrific Oyster Sauce 30g', 'Datu Puti', 0, 35, 40, '2020-11-09', '2020-11-24'),
(4801981118502, 'CocaCola 294mL', 'The CocaCola Company', 0, 10, 12, '2020-11-13', '2020-11-10'),
(4804888589505, 'Hany Milk Chocolate', 'Annie Candy Manufacturing', 0, 30, 32, '2020-08-14', '2021-03-14'),
(4804888589987, 'Ube Purple Yam Candy', 'Annie Candy Manufacturing', 0, 22, 24, '2020-09-12', '2021-03-12'),
(4806507621863, 'Burst Assorted Fruit Flavor Chewy Candy', 'Guangdong Xiaomimi Foodstuff Corporation', 0, 22, 24, '2020-06-19', '2022-06-19'),
(4806511013166, 'Yaahoo Marie Jumbo 25g', 'W.L Foods', 1, 1, 2, '2020-11-17', '2020-11-18'),
(4806511111121, 'Topsee Milk Chocolate', 'Delicatesse Food Corporation', 0, 22, 24, '2020-08-26', '2021-08-26'),
(4806534030164, 'MySip Juice Drink Lycee 255mL', 'MSP Golden Dragon Manufacturing', 0, 10, 15, '2020-11-13', '2020-12-03'),
(4809010686011, 'Lemon Square Cheese Cake', 'Big E Food Corporation', 0, 60, 70, '2020-10-30', '2021-10-30'),
(4902430426464, 'Downy Expert AntiBac', 'Procter & Gamble Philippines INC.', 0, 75, 85, '2020-07-12', '2021-07-12'),
(4902430583169, 'Ariel Sunrise Fresh', 'Procter & Gamble Philippines INC.', 0, 60, 70, '2020-07-12', '2020-07-12'),
(8851717904967, 'Delight 100ml', 'Dutch Mill Corporation', 0, 55, 60, '2020-11-16', '2021-11-16'),
(8935001720126, 'Mentos Tropical Mix', 'Perfetti Van Melle', 0, 35, 50, '2020-07-08', '2022-07-08'),
(8993175537124, 'Richeese Cheese Wafer', 'Enerlife Philippines INC.', 0, 88, 98, '2020-07-23', '2021-07-23'),
(8993175559890, 'Richoco Chocolate Wafer', 'Enerlife Philippines INC.', 0, 88, 98, '2020-07-26', '2021-07-26');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `datainventory`
--
ALTER TABLE `datainventory`
  ADD PRIMARY KEY (`prodNo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
