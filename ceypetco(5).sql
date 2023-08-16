-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 02, 2022 at 05:21 AM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ceypetco`
--

-- --------------------------------------------------------

--
-- Table structure for table `add_product`
--

CREATE TABLE `add_product` (
  `Product_Id` varchar(20) NOT NULL,
  `Product_Name` varchar(50) NOT NULL,
  `Unit_Cost` decimal(10,3) DEFAULT NULL,
  `unit_Price` decimal(10,3) DEFAULT NULL,
  `Liters_or_Qty` decimal(10,3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `add_product`
--

INSERT INTO `add_product` (`Product_Id`, `Product_Name`, `Unit_Cost`, `unit_Price`, `Liters_or_Qty`) VALUES
('P92', 'Petrol 92', '455.900', '470.000', '0.000'),
('P95', 'Petrol 95', '533.500', '550.000', '0.000');

-- --------------------------------------------------------

--
-- Table structure for table `bank_details`
--

CREATE TABLE `bank_details` (
  `Id` int(4) NOT NULL,
  `Today_Date` varchar(10) DEFAULT NULL,
  `Bank_Name` varchar(20) NOT NULL,
  `Dep_Amount` decimal(20,3) NOT NULL,
  `Balance` decimal(20,3) DEFAULT NULL,
  `Decscription` varchar(50) NOT NULL,
  `Deducation` decimal(20,3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bank_details`
--

INSERT INTO `bank_details` (`Id`, `Today_Date`, `Bank_Name`, `Dep_Amount`, `Balance`, `Decscription`, `Deducation`) VALUES
(5, NULL, '', '0.000', '0.000', '', '0.000'),
(6, '2022-08-02', 'HNB', '10000.000', '10000.000', '', '0.000'),
(7, '2022-08-02', '', '0.000', '5500.000', 'ccc1111', '4500.000');

-- --------------------------------------------------------

--
-- Table structure for table `employee_details`
--

CREATE TABLE `employee_details` (
  `Emp_Id` varchar(20) NOT NULL,
  `Emp_Name` varchar(20) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Emp_Address` varchar(40) NOT NULL,
  `Emp_NIC` varchar(12) NOT NULL,
  `Emp_Contact` int(10) NOT NULL,
  `DOB` varchar(10) DEFAULT NULL,
  `Join_Date` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pump`
--

CREATE TABLE `pump` (
  `Pump_Id` varchar(20) NOT NULL,
  `Product_Id` varchar(20) NOT NULL,
  `Last_Reading` decimal(10,3) NOT NULL,
  `unit_Price` decimal(10,3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pump`
--

INSERT INTO `pump` (`Pump_Id`, `Product_Id`, `Last_Reading`, `unit_Price`) VALUES
('D01', 'AD', '0.000', '0.000'),
('D02', 'AD', '0.000', '0.000'),
('D03', 'AD', '0.000', '0.000'),
('P01', 'P92', '10.000', '470.000'),
('P02', 'P92', '0.000', '470.000'),
('P03', 'P92', '0.000', '470.000'),
('SD', 'SD', '0.000', '0.000'),
('SP', 'P95', '8.000', '550.000');

-- --------------------------------------------------------

--
-- Table structure for table `purchase_details`
--

CREATE TABLE `purchase_details` (
  `Product_Id` varchar(20) NOT NULL,
  `Invoice_No` varchar(20) NOT NULL,
  `Unit_Price` decimal(10,2) NOT NULL,
  `Liters_or_Qty` decimal(10,3) NOT NULL,
  `Total_Amount` decimal(25,2) DEFAULT NULL,
  `Arrival_Date` varchar(10) DEFAULT NULL,
  `Payment_Mode` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `purchase_details`
--

INSERT INTO `purchase_details` (`Product_Id`, `Invoice_No`, `Unit_Price`, `Liters_or_Qty`, `Total_Amount`, `Arrival_Date`, `Payment_Mode`) VALUES
('p95', 'ccc1111', '450.00', '10.000', '4500.00', '2022-08-02', 'Bank Pay');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `Today_Date` varchar(10) DEFAULT NULL,
  `Pump_Id` varchar(20) NOT NULL,
  `Product_Id` varchar(20) NOT NULL,
  `Total_Liter_or_Qty` decimal(10,4) NOT NULL,
  `unit_price` decimal(10,3) NOT NULL,
  `Amount` decimal(15,3) NOT NULL,
  `ID` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`Today_Date`, `Pump_Id`, `Product_Id`, `Total_Liter_or_Qty`, `unit_price`, `Amount`, `ID`) VALUES
('2022-08-02', 'SP', 'P95', '8.0000', '550.000', '4400.000', 1);

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `product_Id` varchar(20) NOT NULL,
  `product_Name` varchar(50) NOT NULL,
  `qty_or_Ltr` decimal(10,3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`product_Id`, `product_Name`, `qty_or_Ltr`) VALUES
('', '', '0.000'),
('P92', 'Petrol 92', '0.000'),
('P95', 'Petrol 95', '2.000');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_acc` varchar(20) NOT NULL,
  `passwords` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_acc`, `passwords`) VALUES
('Admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `add_product`
--
ALTER TABLE `add_product`
  ADD PRIMARY KEY (`Product_Id`);

--
-- Indexes for table `bank_details`
--
ALTER TABLE `bank_details`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `employee_details`
--
ALTER TABLE `employee_details`
  ADD PRIMARY KEY (`Emp_Id`),
  ADD UNIQUE KEY `Emp_NIC` (`Emp_NIC`),
  ADD UNIQUE KEY `Emp_Contact` (`Emp_Contact`);

--
-- Indexes for table `pump`
--
ALTER TABLE `pump`
  ADD PRIMARY KEY (`Pump_Id`);

--
-- Indexes for table `purchase_details`
--
ALTER TABLE `purchase_details`
  ADD PRIMARY KEY (`Invoice_No`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`product_Id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_acc`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bank_details`
--
ALTER TABLE `bank_details`
  MODIFY `Id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
