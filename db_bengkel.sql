-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 27 Bulan Mei 2022 pada 09.15
-- Versi server: 10.4.19-MariaDB
-- Versi PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_bengkel`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `montir`
--

CREATE TABLE `montir` (
  `kodeMontir` varchar(10) NOT NULL,
  `namaMontir` varchar(20) NOT NULL,
  `alamatMontir` varchar(30) NOT NULL,
  `noHpMontir` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `montir`
--

INSERT INTO `montir` (`kodeMontir`, `namaMontir`, `alamatMontir`, `noHpMontir`) VALUES
('MK-01', 'Sukadi', 'Jl. M. Said No.30', '082255114466'),
('MK-02', 'Riyadi', 'Jl. Teuku Umar No.07', '085215636499'),
('MK-03', 'Dayat', 'Jl. Siradj Salman No. 08', '082551632545'),
('MK-04', 'Jaja', 'Jl. Juanda No. 99', '082564269975');

-- --------------------------------------------------------

--
-- Struktur dari tabel `service`
--

CREATE TABLE `service` (
  `kodeJasa` varchar(10) NOT NULL,
  `jenisJasa` enum('Ringan','Berat','Klaim') NOT NULL,
  `hargaJasa` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `service`
--

INSERT INTO `service` (`kodeJasa`, `jenisJasa`, `hargaJasa`) VALUES
('JS-01', 'Ringan', 50000),
('JS-02', 'Berat', 100000),
('JS-03', 'Klaim', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `sparepart`
--

CREATE TABLE `sparepart` (
  `kodePart` varchar(10) NOT NULL,
  `namaPart` varchar(30) NOT NULL,
  `hargaPart` float NOT NULL,
  `stokPart` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `sparepart`
--

INSERT INTO `sparepart` (`kodePart`, `namaPart`, `hargaPart`, `stokPart`) VALUES
('SP-01', 'Kampas Rem', 53000, 12),
('SP-02', 'Kabel Speedometer', 32500, 10),
('SP-03', 'Ban Dalam', 35000, 10),
('SP-04', 'Ban Luar', 201500, 7),
('SP-05', 'Lampu Depan Set', 302000, 5),
('SP-06', 'Lampu Belakang Set', 198000, 5),
('SP-07', 'Aki', 285000, 6),
('SP-08', 'Busi', 15000, 20);

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `kodeTransaksi` varchar(10) NOT NULL,
  `tglTransaksi` date NOT NULL,
  `jamTransaksi` time NOT NULL,
  `userKode` varchar(10) NOT NULL,
  `namaPelanggan` varchar(20) NOT NULL,
  `kendaraanPelanggan` varchar(30) NOT NULL,
  `nopolPelanggan` varchar(10) NOT NULL,
  `montirKode` varchar(10) NOT NULL,
  `jasaKode` varchar(10) NOT NULL,
  `partKode` varchar(10) NOT NULL,
  `jumlahJual` int(3) NOT NULL,
  `totalJual` float NOT NULL,
  `bayar` float NOT NULL,
  `kembali` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`kodeTransaksi`, `tglTransaksi`, `jamTransaksi`, `userKode`, `namaPelanggan`, `kendaraanPelanggan`, `nopolPelanggan`, `montirKode`, `jasaKode`, `partKode`, `jumlahJual`, `totalJual`, `bayar`, `kembali`) VALUES
('TS-001', '2022-05-16', '08:26:59', 'admin1', 'Bowo', 'Honda Beat', 'KT 3007 NN', 'MK-01', 'JS-01', 'SP-01', 1, 103000, 110000, 7000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `kodeUser` varchar(6) NOT NULL,
  `namaUser` varchar(20) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`kodeUser`, `namaUser`, `password`) VALUES
('admin1', 'diah', '123456'),
('admin2', 'ws', '112233');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `montir`
--
ALTER TABLE `montir`
  ADD PRIMARY KEY (`kodeMontir`);

--
-- Indeks untuk tabel `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`kodeJasa`);

--
-- Indeks untuk tabel `sparepart`
--
ALTER TABLE `sparepart`
  ADD PRIMARY KEY (`kodePart`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`kodeTransaksi`),
  ADD KEY `userKode` (`userKode`),
  ADD KEY `montirKode` (`montirKode`),
  ADD KEY `jasaKode` (`jasaKode`),
  ADD KEY `partKode` (`partKode`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`kodeUser`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`montirKode`) REFERENCES `montir` (`kodeMontir`),
  ADD CONSTRAINT `transaksi_ibfk_2` FOREIGN KEY (`partKode`) REFERENCES `sparepart` (`kodePart`),
  ADD CONSTRAINT `transaksi_ibfk_3` FOREIGN KEY (`jasaKode`) REFERENCES `service` (`kodeJasa`),
  ADD CONSTRAINT `transaksi_ibfk_4` FOREIGN KEY (`userKode`) REFERENCES `user` (`kodeUser`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
