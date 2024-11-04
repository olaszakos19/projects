-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Szerver verzió:               10.5.8-MariaDB - mariadb.org binary distribution
-- Szerver OS:                   Win64
-- HeidiSQL Verzió:              11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Adatbázis struktúra mentése a project_manager.
DROP DATABASE IF EXISTS `project_manager`;
CREATE DATABASE IF NOT EXISTS `project_manager` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `project_manager`;

-- Struktúra mentése tábla project_manager. admins
DROP TABLE IF EXISTS `admins`;
CREATE TABLE IF NOT EXISTS `admins` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `nev` text DEFAULT NULL,
  `jelszo` text DEFAULT NULL,
  `felhNev` text DEFAULT NULL,
  `bejelentkezve` int(1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;




-- Struktúra mentése tábla project_manager. boss
DROP TABLE IF EXISTS `boss`;
CREATE TABLE IF NOT EXISTS `boss` (
  `ID` int(11) NOT NULL,
  `felhNev` text DEFAULT NULL,
  `jelszo` text DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tábla adatainak mentése project_manager.boss: ~0 rows (hozzávetőleg)
/*!40000 ALTER TABLE `boss` DISABLE KEYS */;
INSERT INTO `boss` (`ID`, `felhNev`, `jelszo`) VALUES
	(1, 'mester', 'i2yBMU+FxDo=');
/*!40000 ALTER TABLE `boss` ENABLE KEYS */;

-- Struktúra mentése tábla project_manager. guide
DROP TABLE IF EXISTS `guide`;
CREATE TABLE IF NOT EXISTS `guide` (
  `sorszam` int(11) NOT NULL AUTO_INCREMENT,
  `cim` varchar(50) DEFAULT NULL,
  `konyv` varchar(10000) DEFAULT NULL,
  PRIMARY KEY (`sorszam`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése project_manager.guide: ~15 rows (hozzávetőleg)
/*!40000 ALTER TABLE `guide` DISABLE KEYS */;
INSERT INTO `guide` (`sorszam`, `cim`, `konyv`) VALUES
	(1, 'Új alkalmazott felvétele', 'Töltse ki az adatokat, és ha mindent rendben talált<br>nyomja meg az "Alkalmazott felvétele" gombot.'),
	(2, 'Alkalmazott adatainak módosítása', 'Válaszon ki egy alkalmazottat, majd szerkessze át az adatokat úgy, hogy<br>az megfeleljen az igényeinek. Ha végzett, nyomja meg a Mentés gombot.'),
	(3, 'Alkalmazott törlése', 'Válasszon ki egyet az alkalmazottak közül.<br>Ha megtalálta a keresett alkalmazottat, és átnézte az adatait:<br>Nyomja meg a Törlés gombot.'),
	(4, 'Új admin felvétele', 'Töltse ki az adatokat, és ha mindent rendben talált<br>kattintson a felvétel ikonra.'),
	(5, 'Admin adatainak módosítása', 'Válasszon ki egy admin-t majd ha beírta a kívánt adatokat,<br>kattintson a "Mentés" gombra.'),
	(6, 'Admin törlése', 'Válasszon ki egy admin-t majd kattintson a "Törlés" gombra.'),
	(7, 'Jelenlegi feladatok', 'Ezen a felületen láthatja a jelenlegi feladatokat kilistázva.<br>A szűrőket jobb oldalt tudja állítani.'),
	(8, 'Feladatok módosítása', 'Válasszon egyet a feladatok közül.<br>Írja át a kívánt adatokat. Lehetősége van a feladatot más alkalmazottra bízni.<br>Figyelem! Az órában megadott határidőknél maguktól értetődik, hogy az adott napra vonatkoznak.'),
	(9, 'Feladat törlése', 'Válasszon ki egY feladatot, majd<br>kattintson a "Törlés" gombra.'),
	(10, 'Profilom felület', 'Itt tudja saját alapadatait módosítani.<br>Ha mindent kitöltött, kattintson a "Mentés" gombra.'),
	(11, 'Munkatársak felület', 'Itt tekintheti meg a jelenlegi összes munkatársat.<br>Figyelem! A CEO típusú munkatársaknak nincs láthatóvá téve a bejelentkezési állapotuk.'),
	(12, 'Üzenet írása', 'Válassza ki a felhasználó típusát (admin, alkalmazott).<br>Ezek után nevezze meg a címzettet és írja meg az üzenetet.<br>Ha mindennel kész. nyomja meg az "Üzenet küldése" gombot. '),
	(13, 'Üzeneteim', 'Itt tudja megtekinteni a beérkező üzeneteit.<br>Az üzenet lista melletti mezőkkel tud szűrni.<br>Ha már nem kell egy üzenet, válassza azt kis és kattintson a Szemetes ikonra.'),
	(14, 'Súgó', 'Itt van most.'),
	(15, 'Kilépés', 'Kattintson a "Kilépés" gombra amennyiben ki akar jelentkezni a rendszerből.');
/*!40000 ALTER TABLE `guide` ENABLE KEYS */;

-- Struktúra mentése tábla project_manager. messages
DROP TABLE IF EXISTS `messages`;
CREATE TABLE IF NOT EXISTS `messages` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `felado` text DEFAULT NULL,
  `cimzett` text DEFAULT NULL,
  `cim` text DEFAULT NULL,
  `leiras` text DEFAULT NULL,
  `kuldesDatuma` varchar(50) DEFAULT NULL,
  `megtekintett` int(1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;


-- Struktúra mentése tábla project_manager. tasks
DROP TABLE IF EXISTS `tasks`;
CREATE TABLE IF NOT EXISTS `tasks` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `megnevezes` text DEFAULT NULL,
  `tipus` text DEFAULT NULL,
  `hatarido` varchar(50) DEFAULT NULL,
  `leiras` text DEFAULT NULL,
  `surgos` int(1) DEFAULT NULL,
  `allapot` int(1) DEFAULT NULL,
  `adminID` int(11) DEFAULT NULL,
  `workerID` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `adminID` (`adminID`,`workerID`),
  KEY `workerID` (`workerID`),
  CONSTRAINT `tasks_ibfk_1` FOREIGN KEY (`adminID`) REFERENCES `admins` (`ID`),
  CONSTRAINT `tasks_ibfk_2` FOREIGN KEY (`workerID`) REFERENCES `workers` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

-- Tábla adatainak mentése project_manager.tasks: ~0 rows (hozzávetőleg)
/*!40000 ALTER TABLE `tasks` DISABLE KEYS */;
/*!40000 ALTER TABLE `tasks` ENABLE KEYS */;

-- Struktúra mentése tábla project_manager. workers
DROP TABLE IF EXISTS `workers`;
CREATE TABLE IF NOT EXISTS `workers` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `nev` text DEFAULT NULL,
  `jelszo` varchar(50) DEFAULT NULL,
  `szakkepesitese` mediumtext DEFAULT NULL,
  `kep` text DEFAULT NULL,
  `felhNev` varchar(50) DEFAULT NULL,
  `nem` char(50) DEFAULT NULL,
  `bejelentkezve` int(1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;



/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
