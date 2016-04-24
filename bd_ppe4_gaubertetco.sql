-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Ven 22 Avril 2016 à 08:52
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `bd_ppe4_gaubertetco`
--

-- --------------------------------------------------------

--
-- Structure de la table `annee`
--

CREATE TABLE IF NOT EXISTS `annee` (
  `NUM_ANNEE` bigint(20) NOT NULL,
  PRIMARY KEY (`NUM_ANNEE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `camping`
--

CREATE TABLE IF NOT EXISTS `camping` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `chambrehotes`
--

CREATE TABLE IF NOT EXISTS `chambrehotes` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `NB_CHAMBRES` int(11) DEFAULT NULL,
  `CUISINECOMMUNE` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `contre_visite`
--

CREATE TABLE IF NOT EXISTS `contre_visite` (
  `ID_VISITE` int(11) NOT NULL,
  `ID_CONTREVISITE` int(11) NOT NULL,
  `ID_INSPECTEUR` int(11) DEFAULT NULL,
  `DATE_CONTREVISITE` date DEFAULT NULL,
  `HEURE` time DEFAULT NULL,
  `NBETOILESMOINS` int(11) DEFAULT NULL,
  `COMMENTAIRE` text,
  PRIMARY KEY (`ID_VISITE`,`ID_CONTREVISITE`),
  KEY `I_FK_CONTRE_VISITE_INSPECTEUR` (`ID_INSPECTEUR`),
  KEY `I_FK_CONTRE_VISITE_VISITE` (`ID_VISITE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `departement`
--

CREATE TABLE IF NOT EXISTS `departement` (
  `id_departement` int(11) NOT NULL,
  `code_departement` int(11) NOT NULL,
  `nom_departement` char(32) DEFAULT NULL,
  PRIMARY KEY (`code_departement`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `dpts`
--

CREATE TABLE IF NOT EXISTS `dpts` (
  `id_departement` int(11) NOT NULL AUTO_INCREMENT,
  `code_departement` varchar(3) CHARACTER SET utf8 DEFAULT NULL,
  `nom_departement` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `nom_uppercase_departement` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `slug_departement` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `nom_soudex_departement` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_departement`),
  KEY `slug_departement` (`slug_departement`),
  KEY `code_departement` (`code_departement`),
  KEY `nom_soudex_departement` (`nom_soudex_departement`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=102 ;

--
-- Contenu de la table `dpts`
--

INSERT INTO `dpts` (`id_departement`, `code_departement`, `nom_departement`, `nom_uppercase_departement`, `slug_departement`, `nom_soudex_departement`) VALUES
(1, '01', 'Ain', 'AIN', 'ain', 'A500'),
(2, '02', 'Aisne', 'AISNE', 'aisne', 'A250'),
(3, '03', 'Allier', 'ALLIER', 'allier', 'A460'),
(4, '04', 'Alpes-de-Haute-Provence', 'ALPES-DE-HAUTE-PROVENCE', 'alpes-de-haute-provence', 'A412316152'),
(5, '05', 'Hautes-Alpes', 'HAUTES-ALPES', 'hautes-alpes', 'H32412'),
(6, '06', 'Alpes-Maritimes', 'ALPES-MARITIMES', 'alpes-maritimes', 'A41256352'),
(7, '07', 'Ardèche', 'ARDÈCHE', 'ardeche', 'A632'),
(8, '08', 'Ardennes', 'ARDENNES', 'ardennes', 'A6352'),
(9, '09', 'Ariège', 'ARIÈGE', 'ariege', 'A620'),
(10, '10', 'Aube', 'AUBE', 'aube', 'A100'),
(11, '11', 'Aude', 'AUDE', 'aude', 'A300'),
(12, '12', 'Aveyron', 'AVEYRON', 'aveyron', 'A165'),
(13, '13', 'Bouches-du-Rhône', 'BOUCHES-DU-RHÔNE', 'bouches-du-rhone', 'B2365'),
(14, '14', 'Calvados', 'CALVADOS', 'calvados', 'C4132'),
(15, '15', 'Cantal', 'CANTAL', 'cantal', 'C534'),
(16, '16', 'Charente', 'CHARENTE', 'charente', 'C653'),
(17, '17', 'Charente-Maritime', 'CHARENTE-MARITIME', 'charente-maritime', 'C6535635'),
(18, '18', 'Cher', 'CHER', 'cher', 'C600'),
(19, '19', 'Corrèze', 'CORRÈZE', 'correze', 'C620'),
(20, '2a', 'Corse-du-sud', 'CORSE-DU-SUD', 'corse-du-sud', 'C62323'),
(21, '2b', 'Haute-corse', 'HAUTE-CORSE', 'haute-corse', 'H3262'),
(22, '21', 'Côte-d''or', 'CÔTE-D''OR', 'cote-dor', 'C360'),
(23, '22', 'Côtes-d''armor', 'CÔTES-D''ARMOR', 'cotes-darmor', 'C323656'),
(24, '23', 'Creuse', 'CREUSE', 'creuse', 'C620'),
(25, '24', 'Dordogne', 'DORDOGNE', 'dordogne', 'D6325'),
(26, '25', 'Doubs', 'DOUBS', 'doubs', 'D120'),
(27, '26', 'Drôme', 'DRÔME', 'drome', 'D650'),
(28, '27', 'Eure', 'EURE', 'eure', 'E600'),
(29, '28', 'Eure-et-Loir', 'EURE-ET-LOIR', 'eure-et-loir', 'E6346'),
(30, '29', 'Finistère', 'FINISTÈRE', 'finistere', 'F5236'),
(31, '30', 'Gard', 'GARD', 'gard', 'G630'),
(32, '31', 'Haute-Garonne', 'HAUTE-GARONNE', 'haute-garonne', 'H3265'),
(33, '32', 'Gers', 'GERS', 'gers', 'G620'),
(34, '33', 'Gironde', 'GIRONDE', 'gironde', 'G653'),
(35, '34', 'Hérault', 'HÉRAULT', 'herault', 'H643'),
(36, '35', 'Ile-et-Vilaine', 'ILE-ET-VILAINE', 'ile-et-vilaine', 'I43145'),
(37, '36', 'Indre', 'INDRE', 'indre', 'I536'),
(38, '37', 'Indre-et-Loire', 'INDRE-ET-LOIRE', 'indre-et-loire', 'I536346'),
(39, '38', 'Isère', 'ISÈRE', 'isere', 'I260'),
(40, '39', 'Jura', 'JURA', 'jura', 'J600'),
(41, '40', 'Landes', 'LANDES', 'landes', 'L532'),
(42, '41', 'Loir-et-Cher', 'LOIR-ET-CHER', 'loir-et-cher', 'L6326'),
(43, '42', 'Loire', 'LOIRE', 'loire', 'L600'),
(44, '43', 'Haute-Loire', 'HAUTE-LOIRE', 'haute-loire', 'H346'),
(45, '44', 'Loire-Atlantique', 'LOIRE-ATLANTIQUE', 'loire-atlantique', 'L634532'),
(46, '45', 'Loiret', 'LOIRET', 'loiret', 'L630'),
(47, '46', 'Lot', 'LOT', 'lot', 'L300'),
(48, '47', 'Lot-et-Garonne', 'LOT-ET-GARONNE', 'lot-et-garonne', 'L3265'),
(49, '48', 'Lozère', 'LOZÈRE', 'lozere', 'L260'),
(50, '49', 'Maine-et-Loire', 'MAINE-ET-LOIRE', 'maine-et-loire', 'M346'),
(51, '50', 'Manche', 'MANCHE', 'manche', 'M200'),
(52, '51', 'Marne', 'MARNE', 'marne', 'M650'),
(53, '52', 'Haute-Marne', 'HAUTE-MARNE', 'haute-marne', 'H3565'),
(54, '53', 'Mayenne', 'MAYENNE', 'mayenne', 'M000'),
(55, '54', 'Meurthe-et-Moselle', 'MEURTHE-ET-MOSELLE', 'meurthe-et-moselle', 'M63524'),
(56, '55', 'Meuse', 'MEUSE', 'meuse', 'M200'),
(57, '56', 'Morbihan', 'MORBIHAN', 'morbihan', 'M615'),
(58, '57', 'Moselle', 'MOSELLE', 'moselle', 'M240'),
(59, '58', 'Nièvre', 'NIÈVRE', 'nievre', 'N160'),
(60, '59', 'Nord', 'NORD', 'nord', 'N630'),
(61, '60', 'Oise', 'OISE', 'oise', 'O200'),
(62, '61', 'Orne', 'ORNE', 'orne', 'O650'),
(63, '62', 'Pas-de-Calais', 'PAS-DE-CALAIS', 'pas-de-calais', 'P23242'),
(64, '63', 'Puy-de-Dôme', 'PUY-DE-DÔME', 'puy-de-dome', 'P350'),
(65, '64', 'Pyrénées-Atlantiques', 'PYRÉNÉES-ATLANTIQUES', 'pyrenees-atlantiques', 'P65234532'),
(66, '65', 'Hautes-Pyrénées', 'HAUTES-PYRÉNÉES', 'hautes-pyrenees', 'H321652'),
(67, '66', 'Pyrénées-Orientales', 'PYRÉNÉES-ORIENTALES', 'pyrenees-orientales', 'P65265342'),
(68, '67', 'Bas-Rhin', 'BAS-RHIN', 'bas-rhin', 'B265'),
(69, '68', 'Haut-Rhin', 'HAUT-RHIN', 'haut-rhin', 'H365'),
(70, '69', 'Rhône', 'RHÔNE', 'rhone', 'R500'),
(71, '70', 'Haute-Saône', 'HAUTE-SAÔNE', 'haute-saone', 'H325'),
(72, '71', 'Saône-et-Loire', 'SAÔNE-ET-LOIRE', 'saone-et-loire', 'S5346'),
(73, '72', 'Sarthe', 'SARTHE', 'sarthe', 'S630'),
(74, '73', 'Savoie', 'SAVOIE', 'savoie', 'S100'),
(75, '74', 'Haute-Savoie', 'HAUTE-SAVOIE', 'haute-savoie', 'H321'),
(76, '75', 'Paris', 'PARIS', 'paris', 'P620'),
(77, '76', 'Seine-Maritime', 'SEINE-MARITIME', 'seine-maritime', 'S5635'),
(78, '77', 'Seine-et-Marne', 'SEINE-ET-MARNE', 'seine-et-marne', 'S53565'),
(79, '78', 'Yvelines', 'YVELINES', 'yvelines', 'Y1452'),
(80, '79', 'Deux-Sèvres', 'DEUX-SÈVRES', 'deux-sevres', 'D2162'),
(81, '80', 'Somme', 'SOMME', 'somme', 'S500'),
(82, '81', 'Tarn', 'TARN', 'tarn', 'T650'),
(83, '82', 'Tarn-et-Garonne', 'TARN-ET-GARONNE', 'tarn-et-garonne', 'T653265'),
(84, '83', 'Var', 'VAR', 'var', 'V600'),
(85, '84', 'Vaucluse', 'VAUCLUSE', 'vaucluse', 'V242'),
(86, '85', 'Vendée', 'VENDÉE', 'vendee', 'V530'),
(87, '86', 'Vienne', 'VIENNE', 'vienne', 'V500'),
(88, '87', 'Haute-Vienne', 'HAUTE-VIENNE', 'haute-vienne', 'H315'),
(89, '88', 'Vosges', 'VOSGES', 'vosges', 'V200'),
(90, '89', 'Yonne', 'YONNE', 'yonne', 'Y500'),
(91, '90', 'Territoire de Belfort', 'TERRITOIRE DE BELFORT', 'territoire-de-belfort', 'T636314163'),
(92, '91', 'Essonne', 'ESSONNE', 'essonne', 'E250'),
(93, '92', 'Hauts-de-Seine', 'HAUTS-DE-SEINE', 'hauts-de-seine', 'H32325'),
(94, '93', 'Seine-Saint-Denis', 'SEINE-SAINT-DENIS', 'seine-saint-denis', 'S525352'),
(95, '94', 'Val-de-Marne', 'VAL-DE-MARNE', 'val-de-marne', 'V43565'),
(96, '95', 'Val-d''oise', 'VAL-D''OISE', 'val-doise', 'V432'),
(97, '976', 'Mayotte', 'MAYOTTE', 'mayotte', 'M300'),
(98, '971', 'Guadeloupe', 'GUADELOUPE', 'guadeloupe', 'G341'),
(99, '973', 'Guyane', 'GUYANE', 'guyane', 'G500'),
(100, '972', 'Martinique', 'MARTINIQUE', 'martinique', 'M6352'),
(101, '974', 'Réunion', 'RÉUNION', 'reunion', 'R500');

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

CREATE TABLE IF NOT EXISTS `equipement` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `ID_EQUIPEMENT` int(11) NOT NULL,
  `LIBELLE_EQUIPEMENT` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`,`ID_EQUIPEMENT`),
  KEY `I_FK_EQUIPEMENT_CAMPING` (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `gerant`
--

CREATE TABLE IF NOT EXISTS `gerant` (
  `ID_GERANT` int(11) NOT NULL,
  `NOM_GERANT` char(32) DEFAULT NULL,
  `TELEPHONE` int(11) DEFAULT NULL,
  `MAIL` char(32) DEFAULT NULL,
  `ADRESSE_GERANT` char(32) DEFAULT NULL,
  `CODEPOSTAL_GERANT` bigint(20) DEFAULT NULL,
  `VILLE_GERANT` char(32) DEFAULT NULL,
  `MOTDEPASSE` text,
  PRIMARY KEY (`ID_GERANT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `gerer`
--

CREATE TABLE IF NOT EXISTS `gerer` (
  `ID_GERANT` int(11) NOT NULL,
  `ID_HEBERGEMENT` int(11) NOT NULL,
  PRIMARY KEY (`ID_GERANT`,`ID_HEBERGEMENT`),
  KEY `I_FK_GERER_GERANT` (`ID_GERANT`),
  KEY `I_FK_GERER_HEBERGEMENT` (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `hebergement`
--

CREATE TABLE IF NOT EXISTS `hebergement` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `ID_SPECIALITE` int(11) NOT NULL,
  `ADRESSE` char(32) DEFAULT NULL,
  `CODE_POSTAL` bigint(20) DEFAULT NULL,
  `VILLE` char(32) DEFAULT NULL,
  `TEL` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`),
  KEY `I_FK_HEBERGEMENT_SPECIALITE` (`ID_SPECIALITE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `historiqueetoiles`
--

CREATE TABLE IF NOT EXISTS `historiqueetoiles` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `NUM_ANNEE` bigint(20) NOT NULL,
  `NBETOILES` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`,`NUM_ANNEE`),
  KEY `I_FK_HISTORIQUEETOILES_HEBERGEMENT` (`ID_HEBERGEMENT`),
  KEY `I_FK_HISTORIQUEETOILES_ANNEE` (`NUM_ANNEE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `hotel`
--

CREATE TABLE IF NOT EXISTS `hotel` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `inspecteur`
--

CREATE TABLE IF NOT EXISTS `inspecteur` (
  `ID_INSPECTEUR` int(11) NOT NULL,
  `ID_SPECIALITE` int(11) NOT NULL,
  `NOM` char(32) DEFAULT NULL,
  `PRENOM` char(32) DEFAULT NULL,
  `ADRESSE` char(32) DEFAULT NULL,
  `CODE_POSTAL` bigint(20) DEFAULT NULL,
  `TEL` bigint(20) DEFAULT NULL,
  `MOTDEPASSE` text,
  PRIMARY KEY (`ID_INSPECTEUR`),
  KEY `I_FK_INSPECTEUR_SPECIALITE` (`ID_SPECIALITE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `inspecteur`
--

INSERT INTO `inspecteur` (`ID_INSPECTEUR`, `ID_SPECIALITE`, `NOM`, `PRENOM`, `ADRESSE`, `CODE_POSTAL`, `TEL`, `MOTDEPASSE`) VALUES
(111111, 1, 'JAMAIN', 'JORDAN', NULL, NULL, NULL, 'jordanjamain');

-- --------------------------------------------------------

--
-- Structure de la table `restaurant`
--

CREATE TABLE IF NOT EXISTS `restaurant` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `ID_CHEF` int(11) NOT NULL,
  `ID_CUISINE` int(11) NOT NULL,
  `NOM_CHEF` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`,`ID_CHEF`),
  KEY `I_FK_RESTAURANT_HOTEL` (`ID_HEBERGEMENT`),
  KEY `I_FK_RESTAURANT_TYPECUISINE` (`ID_CUISINE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `semaine`
--

CREATE TABLE IF NOT EXISTS `semaine` (
  `NUM_ANNEE` bigint(20) NOT NULL,
  `NUM_SEMAINE` int(11) NOT NULL,
  `DATE_DEBUT` date DEFAULT NULL,
  `DATE_FIN` date DEFAULT NULL,
  PRIMARY KEY (`NUM_ANNEE`,`NUM_SEMAINE`),
  KEY `I_FK_SEMAINE_ANNEE` (`NUM_ANNEE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `se_trouver`
--

CREATE TABLE IF NOT EXISTS `se_trouver` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `NUM_DEPARTEMENT` int(11) NOT NULL,
  `code_departement` varchar(3) NOT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`,`NUM_DEPARTEMENT`),
  KEY `I_FK_SE_TROUVER_HEBERGEMENT` (`ID_HEBERGEMENT`),
  KEY `I_FK_SE_TROUVER_DEPARTEMENT` (`NUM_DEPARTEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `se_voit_attribuer`
--

CREATE TABLE IF NOT EXISTS `se_voit_attribuer` (
  `NUM_ANNEE` bigint(20) NOT NULL,
  `NUM_SEMAINE` int(11) NOT NULL,
  `ID_INSPECTEUR` int(11) NOT NULL,
  `NUM_DEPARTEMENT` int(11) NOT NULL,
  PRIMARY KEY (`NUM_ANNEE`,`NUM_SEMAINE`,`ID_INSPECTEUR`),
  KEY `I_FK_SE_VOIT_ATTRIBUER_DEPARTEMENT` (`NUM_DEPARTEMENT`),
  KEY `I_FK_SE_VOIT_ATTRIBUER_SEMAINE` (`NUM_ANNEE`,`NUM_SEMAINE`),
  KEY `I_FK_SE_VOIT_ATTRIBUER_INSPECTEUR` (`ID_INSPECTEUR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `specialite`
--

CREATE TABLE IF NOT EXISTS `specialite` (
  `ID_SPECIALITE` int(11) NOT NULL,
  `LIBELLE_SPECIALITE` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_SPECIALITE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `specialite`
--

INSERT INTO `specialite` (`ID_SPECIALITE`, `LIBELLE_SPECIALITE`) VALUES
(1, 'Hotel');

-- --------------------------------------------------------

--
-- Structure de la table `typecuisine`
--

CREATE TABLE IF NOT EXISTS `typecuisine` (
  `ID_CUISINE` int(11) NOT NULL,
  `LIBELLE_CUISINE` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_CUISINE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `visite`
--

CREATE TABLE IF NOT EXISTS `visite` (
  `ID_VISITE` int(11) NOT NULL,
  `ID_INSPECTEUR` int(11) DEFAULT NULL,
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `DATE_VISITE` date DEFAULT NULL,
  `HEURE` time DEFAULT NULL,
  `NBETOILESPLUS` int(11) DEFAULT NULL,
  `COMMENTAIRE` text,
  PRIMARY KEY (`ID_VISITE`),
  KEY `I_FK_VISITE_INSPECTEUR` (`ID_INSPECTEUR`),
  KEY `I_FK_VISITE_HEBERGEMENT` (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `camping`
--
ALTER TABLE `camping`
  ADD CONSTRAINT `camping_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `chambrehotes`
--
ALTER TABLE `chambrehotes`
  ADD CONSTRAINT `chambrehotes_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `contre_visite`
--
ALTER TABLE `contre_visite`
  ADD CONSTRAINT `contre_visite_ibfk_2` FOREIGN KEY (`ID_VISITE`) REFERENCES `visite` (`ID_VISITE`),
  ADD CONSTRAINT `contre_visite_ibfk_1` FOREIGN KEY (`ID_INSPECTEUR`) REFERENCES `inspecteur` (`ID_INSPECTEUR`);

--
-- Contraintes pour la table `equipement`
--
ALTER TABLE `equipement`
  ADD CONSTRAINT `equipement_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `camping` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `gerer`
--
ALTER TABLE `gerer`
  ADD CONSTRAINT `gerer_ibfk_2` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`),
  ADD CONSTRAINT `gerer_ibfk_1` FOREIGN KEY (`ID_GERANT`) REFERENCES `gerant` (`ID_GERANT`);

--
-- Contraintes pour la table `hebergement`
--
ALTER TABLE `hebergement`
  ADD CONSTRAINT `hebergement_ibfk_1` FOREIGN KEY (`ID_SPECIALITE`) REFERENCES `specialite` (`ID_SPECIALITE`);

--
-- Contraintes pour la table `historiqueetoiles`
--
ALTER TABLE `historiqueetoiles`
  ADD CONSTRAINT `historiqueetoiles_ibfk_2` FOREIGN KEY (`NUM_ANNEE`) REFERENCES `annee` (`NUM_ANNEE`),
  ADD CONSTRAINT `historiqueetoiles_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `hotel`
--
ALTER TABLE `hotel`
  ADD CONSTRAINT `hotel_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `inspecteur`
--
ALTER TABLE `inspecteur`
  ADD CONSTRAINT `inspecteur_ibfk_1` FOREIGN KEY (`ID_SPECIALITE`) REFERENCES `specialite` (`ID_SPECIALITE`);

--
-- Contraintes pour la table `restaurant`
--
ALTER TABLE `restaurant`
  ADD CONSTRAINT `restaurant_ibfk_2` FOREIGN KEY (`ID_CUISINE`) REFERENCES `typecuisine` (`ID_CUISINE`),
  ADD CONSTRAINT `restaurant_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hotel` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `semaine`
--
ALTER TABLE `semaine`
  ADD CONSTRAINT `semaine_ibfk_1` FOREIGN KEY (`NUM_ANNEE`) REFERENCES `annee` (`NUM_ANNEE`);

--
-- Contraintes pour la table `se_trouver`
--
ALTER TABLE `se_trouver`
  ADD CONSTRAINT `se_trouver_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`),
  ADD CONSTRAINT `se_trouver_ibfk_2` FOREIGN KEY (`NUM_DEPARTEMENT`) REFERENCES `departement` (`code_departement`);

--
-- Contraintes pour la table `se_voit_attribuer`
--
ALTER TABLE `se_voit_attribuer`
  ADD CONSTRAINT `se_voit_attribuer_ibfk_3` FOREIGN KEY (`ID_INSPECTEUR`) REFERENCES `inspecteur` (`ID_INSPECTEUR`),
  ADD CONSTRAINT `se_voit_attribuer_ibfk_1` FOREIGN KEY (`NUM_DEPARTEMENT`) REFERENCES `departement` (`code_departement`),
  ADD CONSTRAINT `se_voit_attribuer_ibfk_2` FOREIGN KEY (`NUM_ANNEE`, `NUM_SEMAINE`) REFERENCES `semaine` (`NUM_ANNEE`, `NUM_SEMAINE`);

--
-- Contraintes pour la table `visite`
--
ALTER TABLE `visite`
  ADD CONSTRAINT `visite_ibfk_2` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`),
  ADD CONSTRAINT `visite_ibfk_1` FOREIGN KEY (`ID_INSPECTEUR`) REFERENCES `inspecteur` (`ID_INSPECTEUR`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
