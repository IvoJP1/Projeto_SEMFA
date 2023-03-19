CREATE DATABASE  IF NOT EXISTS `semfa_bd` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `semfa_bd`;
-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: semfa_bd
-- ------------------------------------------------------
-- Server version	5.7.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cadastros`
--

DROP TABLE IF EXISTS `cadastros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cadastros` (
  `id_funcionario` int(11) NOT NULL AUTO_INCREMENT,
  `nome_funcionario` varchar(70) DEFAULT NULL,
  `cpf_funcionario` int(11) DEFAULT NULL,
  `senha_funcionario` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_funcionario`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadastros`
--

LOCK TABLES `cadastros` WRITE;
/*!40000 ALTER TABLE `cadastros` DISABLE KEYS */;
INSERT INTO `cadastros` VALUES (1,'Ricardão',234234234,'123');
/*!40000 ALTER TABLE `cadastros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login_gerente`
--

DROP TABLE IF EXISTS `login_gerente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login_gerente` (
  `id_gerente` int(11) NOT NULL AUTO_INCREMENT,
  `nome_gerente` varchar(70) DEFAULT NULL,
  `cpf_gerente` int(11) DEFAULT NULL,
  `senha_gerente` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_gerente`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login_gerente`
--

LOCK TABLES `login_gerente` WRITE;
/*!40000 ALTER TABLE `login_gerente` DISABLE KEYS */;
INSERT INTO `login_gerente` VALUES (1,'MARCELÃO',234543,'1234');
/*!40000 ALTER TABLE `login_gerente` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-02 11:34:04
