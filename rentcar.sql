CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `Sangre` (
    `idSangre` int NOT NULL AUTO_INCREMENT,
    `Sangre` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`idSangre`)
);

CREATE TABLE `TipoVehiculos` (
    `idTipoVehiculos` int NOT NULL AUTO_INCREMENT,
    `tipo` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`idTipoVehiculos`)
);

CREATE TABLE `Clientes` (
    `idClientes` int NOT NULL AUTO_INCREMENT,
    `cedula` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `nombre` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `apellido` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `correo` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `licencia` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `Sangre_idSangre` int NOT NULL,
    `nacionalidad` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `status` tinyint NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`idClientes`),
    CONSTRAINT `fk_Clientes_Sangre1` FOREIGN KEY (`Sangre_idSangre`) REFERENCES `Sangre` (`idSangre`) ON DELETE RESTRICT
);

CREATE TABLE `Vehiculos` (
    `idVehiculos` int NOT NULL AUTO_INCREMENT,
    `TipoVehiculos_idTipoVehiculos` int NOT NULL,
    `marca` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `modelo` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `año` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `color` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `precio` float NOT NULL,
    `capacidadcarga` float NOT NULL,
    `pasajeros` int NOT NULL,
    `nroseguro` int NOT NULL,
    `latitude` double NOT NULL,
    `longitude` double NOT NULL,
    `disponible` tinyint NOT NULL DEFAULT '1',
    `status` tinyint NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`idVehiculos`),
    CONSTRAINT `fk_Vehiculos_TipoVehiculos1` FOREIGN KEY (`TipoVehiculos_idTipoVehiculos`) REFERENCES `TipoVehiculos` (`idTipoVehiculos`) ON DELETE RESTRICT
);

CREATE TABLE `Alquileres` (
    `idAlquileres` int NOT NULL AUTO_INCREMENT,
    `Clientes_idClientes` int NOT NULL,
    `Vehiculos_idVehiculos` int NOT NULL,
    `fecha_inicio` date NOT NULL,
    `fecha_fin` date NOT NULL,
    `monto` double NOT NULL,
    `pagado` tinyint NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`idAlquileres`, `Clientes_idClientes`),
    CONSTRAINT `fk_Alquileres_Clientes1` FOREIGN KEY (`Clientes_idClientes`) REFERENCES `Clientes` (`idClientes`) ON DELETE RESTRICT,
    CONSTRAINT `fk_Alquileres_Vehiculos1` FOREIGN KEY (`Vehiculos_idVehiculos`) REFERENCES `Vehiculos` (`idVehiculos`) ON DELETE RESTRICT
);

CREATE INDEX `fk_Alquileres_Clientes1_idx` ON `Alquileres` (`Clientes_idClientes`);

CREATE INDEX `fk_Alquileres_Vehiculos1_idx` ON `Alquileres` (`Vehiculos_idVehiculos`);

CREATE INDEX `fk_Clientes_Sangre1_idx` ON `Clientes` (`Sangre_idSangre`);

CREATE INDEX `fk_Vehiculos_TipoVehiculos1_idx` ON `Vehiculos` (`TipoVehiculos_idTipoVehiculos`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210424221421_database_builded', '3.1.12');

INSERT INTO `Sangre` (`idSangre`, `Sangre`)
VALUES (1, 'O+');
INSERT INTO `Sangre` (`idSangre`, `Sangre`)
VALUES (2, 'O-');
INSERT INTO `Sangre` (`idSangre`, `Sangre`)
VALUES (3, 'A+');
INSERT INTO `Sangre` (`idSangre`, `Sangre`)
VALUES (4, 'A-');
INSERT INTO `Sangre` (`idSangre`, `Sangre`)
VALUES (5, 'B+');
INSERT INTO `Sangre` (`idSangre`, `Sangre`)
VALUES (6, 'B-');
INSERT INTO `Sangre` (`idSangre`, `Sangre`)
VALUES (7, 'AB+');
INSERT INTO `Sangre` (`idSangre`, `Sangre`)
VALUES (8, 'AB-');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210424223129_Seeds_Sangre', '3.1.12');

INSERT INTO `TipoVehiculos` (`idTipoVehiculos`, `tipo`)
VALUES (1, 'Carro');
INSERT INTO `TipoVehiculos` (`idTipoVehiculos`, `tipo`)
VALUES (2, 'Camioneta');
INSERT INTO `TipoVehiculos` (`idTipoVehiculos`, `tipo`)
VALUES (3, 'Jeep');
INSERT INTO `TipoVehiculos` (`idTipoVehiculos`, `tipo`)
VALUES (4, 'De lujo');
INSERT INTO `TipoVehiculos` (`idTipoVehiculos`, `tipo`)
VALUES (5, 'Nave espacial');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210424223903_Seeds_tipovehiculos', '3.1.12');
