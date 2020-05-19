-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2020 at 10:55 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perhutangan`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_hutang`
--

CREATE TABLE `tb_hutang` (
  `id` int(5) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `jumlah` varchar(50) NOT NULL,
  `jatuh_tempo` date NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_hutang`
--

INSERT INTO `tb_hutang` (`id`, `nama`, `alamat`, `jumlah`, `jatuh_tempo`, `status`) VALUES
(1, 'Noor Amin', 'Tabriz, Iran', 'Rp. 600000,-', '2019-07-17', 'Belum Lunas'),
(2, 'Viktor Bogdanov', 'Vladivostok, USSR', 'Rp. 600000,-', '2021-02-13', 'Belum Lunas'),
(3, 'Chechev Gorbachev', 'Moscow, USSR', 'Rp. 700000,-', '2021-04-23', 'Belum Lunas'),
(4, 'Jamet Mustaine', 'Prague, Czechia', 'Rp. 70000,-', '2029-07-19', 'Belum Lunas'),
(6, 'Yuri Bujangchenkov', 'Volgograd, USSR', 'Rp. 666000,-', '2023-07-20', 'Belum Lunas'),
(7, 'Sujarwo von Hessen', 'Vilnius, Lithuania', 'Rp. 777000,-', '2023-08-26', 'Belum Lunas');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_hutang`
--
ALTER TABLE `tb_hutang`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_hutang`
--
ALTER TABLE `tb_hutang`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
