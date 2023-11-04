-- MySQL dump 10.16  Distrib 10.1.48-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: fdb1028.awardspace.net    Database: 4301628_stepushenkov63334
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `MyGuests`
--

DROP TABLE IF EXISTS `MyGuests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `MyGuests` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `firstname` char(50) NOT NULL,
  `lastname` char(50) NOT NULL,
  `city` char(50) NOT NULL,
  `street` char(50) NOT NULL,
  `streetnumber` int unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `MyGuests`
--

LOCK TABLES `MyGuests` WRITE;
/*!40000 ALTER TABLE `MyGuests` DISABLE KEYS */;
INSERT INTO `MyGuests` VALUES (5,'John','Doe','London','Main St',10),(6,'Jane','Smith','New York','Broadway',20),(8,'Michael','Johnson','Los Angeles','Sunset Blvd',30),(9,'Emily','Williams','Paris','Rue de Rivoli',40),(10,'Daniel','Brown','Berlin','Unter den Linden',50),(11,'Sophia','Davis','Tokyo','Ginza',60),(12,'Peter','Fawler','Oxford','Teechuba Rd',12),(13,'Viliam','st','rt','t6',34);
/*!40000 ALTER TABLE `MyGuests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `plan`
--

DROP TABLE IF EXISTS `plan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `plan` (
  `id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `position` varchar(50) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `plan`
--

LOCK TABLES `plan` WRITE;
/*!40000 ALTER TABLE `plan` DISABLE KEYS */;
/*!40000 ALTER TABLE `plan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transactions2`
--

DROP TABLE IF EXISTS `transactions2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transactions2` (
  `id` int NOT NULL AUTO_INCREMENT,
  `order_id` int NOT NULL,
  `amount` decimal(9,2) NOT NULL,
  `response_code` int NOT NULL,
  `response_desc` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `order_id` (`order_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transactions2`
--

LOCK TABLES `transactions2` WRITE;
/*!40000 ALTER TABLE `transactions2` DISABLE KEYS */;
INSERT INTO `transactions2` VALUES (1,12345,99.99,200,'Success'),(2,54321,49.99,404,'Not Found'),(3,67890,199.99,200,'Success'),(4,24680,79.99,500,'Internal Server Error'),(6,54432,49.99,404,'Not Found');
/*!40000 ALTER TABLE `transactions2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vacationplan`
--

DROP TABLE IF EXISTS `vacationplan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vacationplan` (
  `id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `position` varchar(50) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vacationplan`
--

LOCK TABLES `vacationplan` WRITE;
/*!40000 ALTER TABLE `vacationplan` DISABLE KEYS */;
INSERT INTO `vacationplan` VALUES (3,'Vova','Kurpatov','Architektor','2023-05-19','2023-05-21'),(4,'Viliamin','Stepushenkov','Programista','2023-05-20','2023-06-07'),(5,'Kseniia','Lieszkiewicz','Kierownik','2023-05-28','2023-07-02'),(6,'Vadym','Vajuta','Programista','2023-05-28','2023-07-02');
/*!40000 ALTER TABLE `vacationplan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database '4301628_stepushenkov63334'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-04 13:53:24
