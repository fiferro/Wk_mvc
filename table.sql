CREATE TABLE `filipe`.`category` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(60) NULL,
  PRIMARY KEY (`Id`));


CREATE TABLE `filipe`.`product` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Amount` DECIMAL(18,2) NULL,
  `CategoryId` INT NULL,
  `Description` VARCHAR(60) NULL,
  `Price1` DECIMAL(18,2) NULL,
  PRIMARY KEY (`Id`));
