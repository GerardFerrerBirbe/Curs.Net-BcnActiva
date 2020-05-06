CREATE DATABASE  IF NOT EXISTS `cul_ampolla` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `cul_ampolla`;
-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: cul_ampolla
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `client` (
  `idClient` int(11) NOT NULL,
  `nom` varchar(45) DEFAULT NULL,
  `carrer` varchar(45) DEFAULT NULL,
  `num` int(11) DEFAULT NULL,
  `pis` int(11) DEFAULT NULL,
  `porta` int(11) DEFAULT NULL,
  `ciutat` varchar(30) DEFAULT NULL,
  `codiPostal` varchar(5) DEFAULT NULL,
  `pais` varchar(30) DEFAULT NULL,
  `telefon` varchar(10) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `dataRegistre` datetime DEFAULT NULL,
  PRIMARY KEY (`idClient`),
  UNIQUE KEY `idClient_UNIQUE` (`idClient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Gerard Ferrer Birbe','Carrer Granollers',127,3,1,'Cardedeu','08440','Espanya','657519609','gferrerbirbe@gmail.com','2020-03-14 00:00:00'),(2,'Felip','Carrer Barcelona',128,4,2,'Tarragona','43005','Espanya','655555555','felip@gmail.com','2020-03-14 00:00:00');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `marca` (
  `idMarca` int(11) NOT NULL,
  `nomMarca` varchar(45) NOT NULL,
  `idProveidor` int(11) NOT NULL,
  PRIMARY KEY (`idMarca`),
  UNIQUE KEY `idmarca_UNIQUE` (`idMarca`),
  KEY `fk_Marca_Proveidor1_idx` (`idProveidor`),
  CONSTRAINT `fk_Marca_Proveidor1` FOREIGN KEY (`idProveidor`) REFERENCES `proveidor` (`idProveidor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` VALUES (1,'Rayban',1),(2,'Oakley',1),(3,'Ferrer',2),(4,'Arnette',3);
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveidor`
--

DROP TABLE IF EXISTS `proveidor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `proveidor` (
  `idProveidor` int(11) NOT NULL,
  `nom` varchar(45) NOT NULL,
  `carrer` varchar(45) DEFAULT NULL,
  `num` int(11) DEFAULT NULL,
  `pis` int(11) DEFAULT NULL,
  `porta` int(11) DEFAULT NULL,
  `ciutat` varchar(30) DEFAULT NULL,
  `codiPostal` varchar(5) DEFAULT NULL,
  `pais` varchar(30) DEFAULT NULL,
  `telefon` varchar(10) DEFAULT NULL,
  `fax` varchar(10) DEFAULT NULL,
  `nif` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`idProveidor`),
  UNIQUE KEY `idProveidor_UNIQUE` (`idProveidor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveidor`
--

LOCK TABLES `proveidor` WRITE;
/*!40000 ALTER TABLE `proveidor` DISABLE KEYS */;
INSERT INTO `proveidor` VALUES (1,'Optiques Joan','Carrer Mataró',129,3,2,'Barcelona','08025','Espanya','651525252','',NULL),(2,'Multioptiques','Avinguda Diagonal',500,4,3,'Barcelona','08024','Espanya','666666666',NULL,NULL),(3,'Optiques Felip','Carrer Granollers',122,2,3,'Cardedeu','08440','Espanya','633333333',NULL,NULL);
/*!40000 ALTER TABLE `proveidor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ulleres`
--

DROP TABLE IF EXISTS `ulleres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ulleres` (
  `idUlleres` int(11) NOT NULL,
  `graduacio` varchar(45) NOT NULL,
  `muntura` varchar(45) NOT NULL,
  `colorMuntura` varchar(45) NOT NULL,
  `colorVidre` varchar(45) NOT NULL,
  `preu` decimal(10,2) DEFAULT NULL,
  `idMarca` int(11) NOT NULL,
  PRIMARY KEY (`idUlleres`),
  UNIQUE KEY `idulleres_UNIQUE` (`idUlleres`),
  KEY `fk_Ulleres_Marca_idx` (`idMarca`),
  CONSTRAINT `fk_Ulleres_Marca` FOREIGN KEY (`idMarca`) REFERENCES `marca` (`idMarca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ulleres`
--

LOCK TABLES `ulleres` WRITE;
/*!40000 ALTER TABLE `ulleres` DISABLE KEYS */;
INSERT INTO `ulleres` VALUES (1,'0.75','flotant','vermell','verd',100.00,1),(2,'0.00','pasta','negre','blanc',120.00,2),(3,'0.25','metàl·lica','verd','verd',200.00,2);
/*!40000 ALTER TABLE `ulleres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendes`
--

DROP TABLE IF EXISTS `vendes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `vendes` (
  `idVendes` int(11) NOT NULL,
  `idEmpleat` int(11) NOT NULL,
  `idUlleres` int(11) NOT NULL,
  `idClient` int(11) NOT NULL,
  PRIMARY KEY (`idVendes`),
  UNIQUE KEY `idVendes_UNIQUE` (`idVendes`),
  KEY `fk_Vendes_Ulleres1_idx` (`idUlleres`),
  KEY `fk_Vendes_Client1_idx` (`idClient`),
  CONSTRAINT `fk_Vendes_Client1` FOREIGN KEY (`idClient`) REFERENCES `client` (`idClient`),
  CONSTRAINT `fk_Vendes_Ulleres1` FOREIGN KEY (`idUlleres`) REFERENCES `ulleres` (`idUlleres`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendes`
--

LOCK TABLES `vendes` WRITE;
/*!40000 ALTER TABLE `vendes` DISABLE KEYS */;
INSERT INTO `vendes` VALUES (1,1,1,1),(2,2,1,1),(3,1,2,2);
/*!40000 ALTER TABLE `vendes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-14 11:59:33
