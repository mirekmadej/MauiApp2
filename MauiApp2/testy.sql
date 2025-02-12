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

VALUES(1, 'pytanie', 'o1', 'o2', 'o3', 'o4', 'op'),
                (2, 'System operacyjny nie zajmuje się ', 'dostarczaniem mechanizmów do synchronizacji zadań i komunikacji pomiędzy zadaniami. ', 'planowaniem oraz przydziałem czasu procesora poszczególnym zadaniom. ', 'kontrolą i przydziałem pamięci operacyjnej dla uruchomionych zadań. ', 'tworzeniem źródeł aplikacji systemowych.', 'tworzeniem źródeł aplikacji systemowych.'),
                (3, 'Podstawową funkcją serwera FTP jest ', 'monitoring sieci. ', 'synchronizacja czasu. ', 'udostępnianie plików. ', 'zarządzanie kontami poczty. ', 'udostępnianie plików. '),
                (4, 'Do cech pojedynczego konta użytkownika pracującego w systemie Windows Serwer należy ', 'numer telefonu, pod który ma oddzwonić serwer w przypadku nawiązania połączenia telefonicznego przez tego użytkownika. ', 'maksymalna wielkość pojedynczego pliku jaki użytkownik może zapisać na dysku serwera. ', 'maksymalna wielkość pulpitu użytkownika  ', 'maksymalna wielkość profilu użytkownika.', 'numer telefonu, pod który ma oddzwonić serwer w przypadku nawiązania połączenia telefonicznego przez tego użytkownika. '),
                (5, 'Który z protokołów jest protokołem synchronizacji czasu? ', 'FTP ', 'NTP ', 'HTTP ', 'NNTP', 'NTP '),
                (6, 'Litera S w protokole FTPS oznacza zabezpieczanie przesyłanych danych poprzez ', 'logowanie. ', 'autoryzację. ', 'szyfrowanie. ', 'uwierzytelnianie. ', 'szyfrowanie. '),
                (7, 'Który z protokołów jest protoko?em wykorzystywanym do zarz?dzania urz?dzeniami sieciowymi? ', 'SMTP ', 'SNMP ', 'SFTP ', 'DNS ', 'SNMP '),
                (8, 'Translacj? nazw domenowych na adresy sieciowe zajmuje się usługa ', 'DNS ', 'DHCP ', 'SMTP ', 'SNMP', 'DNS '),
                (9, 'Który z protokołów jest szyfrowanym protokołem terminalowym? ', 'SSH ', 'TFTP ', 'telnet ', 'POP3', 'SSH '),
                (10, 'Który protokó?ł obsługuje rozproszone wysyłanie i pobieranie plików? ', 'FTP ', 'Radius ', 'HTTPS ', 'BitTorrent', 'BitTorrent'),"
                (11, ' AES (ang. Advanced Encryption Standard) ', 'jest poprzednikiem DES (ang. Data Encryption Standard). ', 'nie może być wykorzystany przy szyfrowaniu plików. ', 'wykorzystuje symetryczny algorytm szyfrujący. ', 'nie może być zaimplementowany sprzętowo.', 'wykorzystuje symetryczny algorytm szyfruj?cy. ');
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
