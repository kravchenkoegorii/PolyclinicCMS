CREATE DATABASE  IF NOT EXISTS `polyclinicdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `polyclinicdb`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: polyclinicdb
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `administrators`
--

DROP TABLE IF EXISTS `administrators`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrators` (
  `id` int NOT NULL AUTO_INCREMENT,
  `email` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrators`
--

LOCK TABLES `administrators` WRITE;
/*!40000 ALTER TABLE `administrators` DISABLE KEYS */;
INSERT INTO `administrators` VALUES (1,'admin@admin.com','admin');
/*!40000 ALTER TABLE `administrators` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointments`
--

DROP TABLE IF EXISTS `appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointments` (
  `id` int NOT NULL AUTO_INCREMENT,
  `date` datetime NOT NULL,
  `doctorname` varchar(45) NOT NULL,
  `doctorsurname` varchar(45) NOT NULL,
  `patientname` varchar(45) NOT NULL,
  `patientsurname` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `doctroid` FOREIGN KEY (`id`) REFERENCES `doctors` (`id`),
  CONSTRAINT `patientid` FOREIGN KEY (`id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointments`
--

LOCK TABLES `appointments` WRITE;
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
INSERT INTO `appointments` VALUES (5,'2023-03-30 07:00:00','Єгор','Кравченко','Богдан','Палєй'),(6,'2023-03-30 08:00:00','Ігор','Овсяніков','Богдан','Палєй');
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctors`
--

DROP TABLE IF EXISTS `doctors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctors` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `surname` varchar(45) DEFAULT NULL,
  `patronymic` varchar(45) DEFAULT NULL,
  `birthdate` datetime DEFAULT NULL,
  `adress` varchar(45) DEFAULT NULL,
  `passportcode` varchar(45) DEFAULT NULL,
  `phonenumber` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `specialization` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctors`
--

LOCK TABLES `doctors` WRITE;
/*!40000 ALTER TABLE `doctors` DISABLE KEYS */;
INSERT INTO `doctors` VALUES (1,'Єгор','Кравченко','Дмитрович','2002-09-20 00:00:00','Я не знаю','123456789','+380967902973','egor@egor.com','Egorius','egor123'),(2,'Ігор','Овсяников','Володимирович','2007-01-20 00:00:00','Я не знаю','123456789','+380670000000','igor@igor.com','Igorius','igor123'),(4,'Хтось','Хтось','Хтось','1997-01-20 00:00:00','Я не зна','123456789','+380990000001','someone@someone.com','Igorius','someone');
/*!40000 ALTER TABLE `doctors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patients` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `surname` varchar(45) DEFAULT NULL,
  `patronymic` varchar(45) DEFAULT NULL,
  `birthdate` datetime DEFAULT NULL,
  `adress` varchar(45) DEFAULT NULL,
  `passportcode` varchar(45) DEFAULT NULL,
  `phonenumber` varchar(45) DEFAULT NULL,
  `doctorname` varchar(45) DEFAULT NULL,
  `doctorsurname` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `doctorid_idx` (`doctorname`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES (6,'Богдан','Палєй','Євгенович','2004-03-17 00:00:00','Я не зна','123456789','+380960000001','Єгор','Кравченко'),(7,'Пашок','Карнишок','Черепашок','2000-10-10 00:00:00','Фантазия','123456789','+380000000000','Ігор','Овсяников'),(8,'Дашок','Хуй','Пасашок','2000-10-10 00:00:00','Воронцова','123456789','+380000000000','Ігор','Овсяников');
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specializations`
--

DROP TABLE IF EXISTS `specializations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `specializations` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specializations`
--

LOCK TABLES `specializations` WRITE;
/*!40000 ALTER TABLE `specializations` DISABLE KEYS */;
INSERT INTO `specializations` VALUES (5,'Egorius'),(6,'Igorius');
/*!40000 ALTER TABLE `specializations` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-31 12:07:12
