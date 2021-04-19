-- MySQL Script generated by MySQL Workbench
-- dom 18 abr 2021 23:26:06 AST
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema rentcar
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema rentcar
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `rentcar` ;
USE `rentcar` ;

-- -----------------------------------------------------
-- Table `rentcar`.`TipoVehiculos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rentcar`.`TipoVehiculos` (
  `idTipoVehiculos` INT NOT NULL AUTO_INCREMENT,
  `tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idTipoVehiculos`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rentcar`.`Vehiculos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rentcar`.`Vehiculos` (
  `idVehiculos` INT NOT NULL AUTO_INCREMENT,
  `marca` VARCHAR(45) NOT NULL,
  `modelo` VARCHAR(45) NOT NULL,
  `año` VARCHAR(45) NOT NULL,
  `color` VARCHAR(45) NOT NULL,
  `precio` FLOAT NOT NULL,
  `TipoVehiculos_idTipoVehiculos` INT NOT NULL,
  `capacidadcarga` FLOAT NOT NULL,
  `pasajeros` INT NOT NULL,
  `nroseguro` INT NOT NULL,
  `foto` VARCHAR(45) NOT NULL,
  `latitude` DOUBLE NOT NULL,
  `longitude` DOUBLE NOT NULL,
  PRIMARY KEY (`idVehiculos`, `TipoVehiculos_idTipoVehiculos`),
  INDEX `fk_Vehiculos_TipoVehiculos_idx` (`TipoVehiculos_idTipoVehiculos` ASC) VISIBLE,
  CONSTRAINT `fk_Vehiculos_TipoVehiculos`
    FOREIGN KEY (`TipoVehiculos_idTipoVehiculos`)
    REFERENCES `rentcar`.`TipoVehiculos` (`idTipoVehiculos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rentcar`.`Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rentcar`.`Clientes` (
  `idClientes` INT NOT NULL AUTO_INCREMENT,
  `cedula` VARCHAR(45) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NOT NULL,
  `correo` VARCHAR(45) NOT NULL,
  `licencia` VARCHAR(45) NOT NULL,
  `nacionalidad` VARCHAR(45) NOT NULL,
  `tipodesangre` VARCHAR(45) NOT NULL,
  `fotopersona` VARCHAR(45) NOT NULL,
  `fotolicencia` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idClientes`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rentcar`.`Alquileres`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rentcar`.`Alquileres` (
  `idAlquileres` INT NOT NULL AUTO_INCREMENT,
  `Clientes_idClientes` INT NOT NULL,
  `Vehiculos_idVehiculos` INT NOT NULL,
  `Vehiculos_TipoVehiculos_idTipoVehiculos` INT NOT NULL,
  `fecha_inicio` DATE NOT NULL,
  `fecha_fin` DATE NOT NULL,
  `monto` DOUBLE NOT NULL,
  PRIMARY KEY (`idAlquileres`, `Clientes_idClientes`, `Vehiculos_idVehiculos`, `Vehiculos_TipoVehiculos_idTipoVehiculos`),
  INDEX `fk_Alquileres_Clientes1_idx` (`Clientes_idClientes` ASC) VISIBLE,
  INDEX `fk_Alquileres_Vehiculos1_idx` (`Vehiculos_idVehiculos` ASC, `Vehiculos_TipoVehiculos_idTipoVehiculos` ASC) VISIBLE,
  CONSTRAINT `fk_Alquileres_Clientes1`
    FOREIGN KEY (`Clientes_idClientes`)
    REFERENCES `rentcar`.`Clientes` (`idClientes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Alquileres_Vehiculos1`
    FOREIGN KEY (`Vehiculos_idVehiculos` , `Vehiculos_TipoVehiculos_idTipoVehiculos`)
    REFERENCES `rentcar`.`Vehiculos` (`idVehiculos` , `TipoVehiculos_idTipoVehiculos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
