-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 12, 2025 at 08:15 AM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `test`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `testy`
--

CREATE TABLE `testy` (
  `id` int(11) NOT NULL,
  `pytanie` varchar(250) NOT NULL,
  `o1` varchar(250) NOT NULL,
  `o2` varchar(250) NOT NULL,
  `o3` varchar(250) NOT NULL,
  `o4` varchar(250) NOT NULL,
  `op` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `testy`
--

INSERT INTO `testy` (`id`, `pytanie`, `o1`, `o2`, `o3`, `o4`, `op`) VALUES
(1, 'pytanie', 'o1', 'o2', 'o3', 'o4', 'op'),
(2, 'System operacyjny nie zajmuje si? ', 'dostarczaniem mechanizmów do synchronizacji zada? i komunikacji pomi?dzy zadaniami. ', 'planowaniem oraz przydzia?em czasu procesora poszczególnym zadaniom. ', 'kontrol? i przydzia?em pami?ci operacyjnej dla uruchomionych zada?. ', 'tworzeniem ?róde? aplikacji systemowych.', 'tworzeniem ?róde? aplikacji systemowych.'),
(3, 'Podstawow? funkcj? serwera FTP jest ', 'monitoring sieci. ', 'synchronizacja czasu. ', 'udost?pnianie plików. ', 'zarz?dzanie kontami poczty. ', 'udost?pnianie plików. '),
(4, 'Do cech pojedynczego konta u?ytkownika pracuj?cego w systemie Windows Serwer nale?y ', 'numer telefonu, pod który ma oddzwoni? serwer w przypadku nawi?zania po??czenia telefonicznego przez tego u?ytkownika. ', 'maksymalna wielko?? pojedynczego pliku jak? u?ytkownik mo?e zapisa? na dysku serwera. ', 'maksymalna wielko?? pulpitu u?ytkownika  ', 'maksymalna wielko?? profilu u?ytkownika.', 'numer telefonu, pod który ma oddzwoni? serwer w przypadku nawi?zania po??czenia telefonicznego przez tego u?ytkownika. '),
(5, 'Który z protoko?ów jest protoko?em synchronizacji czasu? ', 'FTP ', 'NTP ', 'HTTP ', 'NNTP', 'NTP '),
(6, 'Litera S w protokole FTPS oznacza zabezpieczanie przesy?anych danych poprzez ', 'logowanie. ', 'autoryzacj?. ', 'szyfrowanie. ', 'uwierzytelnianie. ', 'szyfrowanie. '),
(7, 'Który z protoko?ów jest protoko?em wykorzystywanym do zarz?dzania urz?dzeniami sieciowymi? ', 'SMTP ', 'SNMP ', 'SFTP ', 'DNS ', 'SNMP '),
(8, 'Translacj? nazw domenowych na adresy sieciowe zajmuje si? us?uga ', 'DNS ', 'DHCP ', 'SMTP ', 'SNMP', 'DNS '),
(9, 'Który z protoko?ów jest szyfrowanym protoko?em terminalowym? ', 'SSH ', 'TFTP ', 'telnet ', 'POP3', 'SSH '),
(10, 'Który protokó? obs?uguje rozproszone wysy?anie i pobieranie plików? ', 'FTP ', 'Radius ', 'HTTPS ', 'BitTorrent', 'BitTorrent'),
(11, ' AES (ang. Advanced Encryption Standard) ', 'jest poprzednikiem DES (ang. Data Encryption Standard). ', 'nie mo?e by? wykorzystany przy szyfrowaniu plików. ', 'wykorzystuje symetryczny algorytm szyfruj?cy. ', 'nie mo?e by? zaimplementowany sprz?towo.', 'wykorzystuje symetryczny algorytm szyfruj?cy. ');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `testy`
--
ALTER TABLE `testy`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `testy`
--
ALTER TABLE `testy`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
