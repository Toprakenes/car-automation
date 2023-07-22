-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 16 Tem 2023, 15:35:43
-- Sunucu sürümü: 8.0.31
-- PHP Sürümü: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `motorum_sende`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `id` int NOT NULL AUTO_INCREMENT,
  `admin_adi` varchar(35) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `sifre` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `admin`
--

INSERT INTO `admin` (`id`, `admin_adi`, `sifre`) VALUES
(1, 'admin', '123');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanici`
--

DROP TABLE IF EXISTS `kullanici`;
CREATE TABLE IF NOT EXISTS `kullanici` (
  `id` int NOT NULL AUTO_INCREMENT,
  `kullanici_adi` varchar(35) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `e_mail` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `sifre` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `kullanici`
--

INSERT INTO `kullanici` (`id`, `kullanici_adi`, `e_mail`, `sifre`) VALUES
(2, 'Enes', 'enes@gmail.com', '123'),
(3, 'semih', 'semih57@gmail.com', '123'),
(4, 'enest', 'tt@gmail.com', 'deneme0'),
(5, 'semih enes', 'deneme@gmail.com', '-proje1');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `motor`
--

DROP TABLE IF EXISTS `motor`;
CREATE TABLE IF NOT EXISTS `motor` (
  `id` int NOT NULL AUTO_INCREMENT,
  `model` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `aciklama` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `fiyat` int NOT NULL,
  `aralik` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci NOT NULL,
  `resim_id` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `motor`
--

INSERT INTO `motor` (`id`, `model`, `aciklama`, `fiyat`, `aralik`, `resim_id`) VALUES
(9, 'Kymco X-Town 125i', 'Ürün Tipi:Scooter\r\nSilindir Hacmi:125 cc\r\nAzami Tork:11.30 nm\r\nVites Tipi:Otomatik', 299, 'Günlük', 'm_1'),
(10, 'Apachi XRS 125', 'Ürün Tipi:Scooter \r\nSilindir Hacmi:125 cc \r\nBeygir Gücü:08.45 bg\r\nVites Tipi:Otomatik', 339, 'Günlük', 'm_2'),
(11, 'Yamaha MT-25', 'Ürün Tipi:Naked\r\nSilindir Hacmi:250 cc \r\nBeygir Gücü:36 bg \r\nVites Tipi:Otomatik', 499, 'Günlük', '3'),
(12, 'Bajaj Dominar 400', 'Ürün Tipi:Naked \r\nSilindir Hacmi:375 cc \r\nBeygir Gücü:35 bg \r\nVites Tipi:Otomatik', 549, 'Günlük', '11'),
(13, 'Yamaha YZF-R6 ', 'ÜrünTipi:Racing\r\nSilindir Hacmi:599 cc \r\nBeygir Gücü124 bg \r\nVites Tipi:Manuel', 599, 'Günlük', '5'),
(14, 'Triumph Tiger 900 Rally ', 'Ürün Tipi:Adventure\r\nSilindir Hacmi:888 cc \r\nBeygir Gücü:95.02 bg \r\nVites Tipi:Manuel\r\n\r\n', 799, 'Günlük', '6'),
(15, 'Triumph Daytona 675R', 'ÜrünTipi:Sport\r\nSilindir Hacmi:675 cc \r\nBeygir Gücü:128 bg \r\nVites Tipi:Manuel', 699, 'Günlük', '7'),
(16, 'CFMOTO SD 650-S', 'ÜrünTipi:Touring Silindir Hacmi:650 cc Beygir Gücü:60.03 bg Vites Tipi:Manuel', 649, 'Günlük', '8'),
(17, 'Hyosung ST7', 'Ürün Tipi:Chopper Silindir Hacmi:679 cc Beygir Gücü:62.05 bg Vites Tipi:Manuel', 649, 'Günlük', '9'),
(18, 'Honda Hornet 750', 'Ürün Tipi:Naked Silindir Hacmi:755 cc Beygir Gücü:92 bg Vites Tipi:Manuel', 749, 'Günlük', '10'),
(19, 'Aprilia RSV4 RR 1000 ', 'Ürün Tipi:Racing Silindir Hacmi:999.6 cc Beygir Gücü:201bg Vites Tipi:Manuel', 999, 'Günlük', '4'),
(22, 'Suzuki GSX-R1000R  ', 'ürün tipi sport', 1110, 'Günlük', '12');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `rezervasyon`
--

DROP TABLE IF EXISTS `rezervasyon`;
CREATE TABLE IF NOT EXISTS `rezervasyon` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ad` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `soyad` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `adres` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `tel` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `motor_id` int DEFAULT NULL,
  `hesap_id` int DEFAULT NULL,
  `iletisim` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `rezervasyon`
--

INSERT INTO `rezervasyon` (`id`, `ad`, `soyad`, `adres`, `tel`, `motor_id`, `hesap_id`, `iletisim`) VALUES
(7, 'Enes', 'TOPRAK', 'sinop', '5554443322', 1, 2, 0),
(11, 'Enes', 'Toprak', 'Ankara Sincan', '0555000000', 11, 3, 1),
(12, 'Enes', 'toprak', 'Ankara Sincan', '0555000000', 13, 3, 0),
(13, 'enes', 'toprak', 'ankara sincan', '0555000000', 16, 5, 0),
(14, 'Semih', 'Toprak', 'Sinop', '0541921145', 19, 5, 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
