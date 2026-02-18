-- Creación de la Base de Datos
DROP DATABASE IF EXISTS TallerMecanicoDB;
CREATE DATABASE TallerMecanicoDB CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE TallerMecanicoDB;

-- 1. Tabla CLIENTES
CREATE TABLE Clientes (
    ID_Cliente INT AUTO_INCREMENT PRIMARY KEY,
    RFC VARCHAR(13) NOT NULL UNIQUE,
    Nombre VARCHAR(50) NOT NULL,
    Ap_Paterno VARCHAR(50) NOT NULL,
    Ap_Materno VARCHAR(50),
    Calle VARCHAR(100),
    Numero VARCHAR(20),
    Colonia VARCHAR(50),
    CP VARCHAR(10),
    Ciudad VARCHAR(50),
    Email VARCHAR(100),
    Fecha_Registro DATE DEFAULT (CURRENT_DATE),
    Activo bool default true -- Campo para borrado lógico
);

-- 2. Tabla TELEFONOS_CLIENTES
CREATE TABLE Telefonos_Clientes (
    ID_Telefono INT AUTO_INCREMENT PRIMARY KEY,
    ID_Cliente INT NOT NULL,
    Numero_Telefono VARCHAR(20) NOT NULL,
    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente)
);

-- 3. Tabla MECANICOS
CREATE TABLE Mecanicos (
    ID_Mecanico INT AUTO_INCREMENT PRIMARY KEY,
    No_Empleado VARCHAR(20) NOT NULL UNIQUE,
    RFC VARCHAR(13) NOT NULL UNIQUE,
    Nombre_Completo VARCHAR(150) NOT NULL,
    Telefono VARCHAR(20),
    Salario DECIMAL(10,2),
    Anios_Experiencia INT,
    Activo bool default true -- Borrado lógico
);

-- 4. Tabla ESPECIALIDADES_MECANICOS
CREATE TABLE Especialidades_Mecanicos (
    ID_Espec INT AUTO_INCREMENT PRIMARY KEY,
    ID_Mecanico INT NOT NULL,
    Especialidad VARCHAR(100) NOT NULL,
    FOREIGN KEY (ID_Mecanico) REFERENCES Mecanicos(ID_Mecanico)
);

-- 5. Tabla SERVICIOS
CREATE TABLE Servicios (
    ID_Servicio INT AUTO_INCREMENT PRIMARY KEY,
    Clave_Servicio VARCHAR(20) NOT NULL UNIQUE,
    Nombre_Servicio VARCHAR(100) NOT NULL,
    Descripcion TEXT,
    Costo_Base DECIMAL(10,2) NOT NULL,
    Tiempo_Estimado_Hrs DECIMAL(4,2),
    Activo bool default true -- Borrado lógico
);

-- 6. Tabla REFACCIONES
CREATE TABLE Refacciones (
    ID_Refaccion INT AUTO_INCREMENT PRIMARY KEY,
    Codigo_Refaccion VARCHAR(50) NOT NULL UNIQUE,
    Nombre VARCHAR(100) NOT NULL,
    Marca VARCHAR(50),
    Precio_Unitario DECIMAL(10,2) NOT NULL,
    Stock_Actual INT NOT NULL,
    Stock_Minimo INT NOT NULL,
    Proveedor VARCHAR(100),
    Activo bool default true-- Borrado lógico
);

-- 7. Tabla VEHICULOS
CREATE TABLE Vehiculos (
    ID_Vehiculo INT AUTO_INCREMENT PRIMARY KEY,
    ID_Cliente INT NOT NULL,
    Numero_Serie VARCHAR(50) NOT NULL UNIQUE,
    Placas VARCHAR(20) NOT NULL,
    Marca VARCHAR(50),
    Modelo VARCHAR(50),
    Anio INT,
    Color VARCHAR(30),
    Kilometraje INT,
    Tipo_Vehiculo VARCHAR(30), -- Sedan, SUV, etc.
    Activo bool default true, -- Borrado lógico
    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente)
);
-- Nota: La "Antigüedad" es derivada (Año actual - Año vehículo), se calcula en las consultas, no se guarda.

-- 8. Tabla ORDENES_SERVICIO
CREATE TABLE Ordenes_Servicio (
    Folio_Orden INT AUTO_INCREMENT PRIMARY KEY,
    ID_Vehiculo INT NOT NULL,
    Fecha_Ingreso DATETIME DEFAULT CURRENT_TIMESTAMP,
    Fecha_Estimada_Entrega DATETIME,
    Fecha_Real_Entrega DATETIME,
    Estado VARCHAR(20) DEFAULT 'Abierta', -- Abierta, En Proceso, Finalizada, Cancelada
    Costo_Total DECIMAL(10,2) DEFAULT 0.00,
    Activo bool default true, -- Borrado lógico
    FOREIGN KEY (ID_Vehiculo) REFERENCES Vehiculos(ID_Vehiculo)
);

-- 9. Tabla ASIGNACION_MECANICOS (Intermedia Orden-Mecanico)
CREATE TABLE Asignacion_Mecanicos (
    ID_Asignacion INT AUTO_INCREMENT PRIMARY KEY,
    Folio_Orden INT NOT NULL,
    ID_Mecanico INT NOT NULL,
    FOREIGN KEY (Folio_Orden) REFERENCES Ordenes_Servicio(Folio_Orden),
    FOREIGN KEY (ID_Mecanico) REFERENCES Mecanicos(ID_Mecanico)
);

-- 10. Tabla DETALLE_ORDEN_SERVICIOS (Intermedia Orden-Servicio)
CREATE TABLE Detalle_Orden_Servicios (
    ID_Detalle_Serv INT AUTO_INCREMENT PRIMARY KEY,
    Folio_Orden INT NOT NULL,
    ID_Servicio INT NOT NULL,
    Precio_Aplicado DECIMAL(10,2) NOT NULL, -- Precio al momento de la orden
    FOREIGN KEY (Folio_Orden) REFERENCES Ordenes_Servicio(Folio_Orden),
    FOREIGN KEY (ID_Servicio) REFERENCES Servicios(ID_Servicio)
);

-- 11. Tabla DETALLE_ORDEN_REFACCIONES (Intermedia Orden-Refacción)
CREATE TABLE Detalle_Orden_Refacciones (
    ID_Detalle_Ref INT AUTO_INCREMENT PRIMARY KEY,
    Folio_Orden INT NOT NULL,
    ID_Refaccion INT NOT NULL,
    Cantidad INT NOT NULL,
    Precio_Unitario_Aplicado DECIMAL(10,2) NOT NULL, -- Precio al momento de la orden
    FOREIGN KEY (Folio_Orden) REFERENCES Ordenes_Servicio(Folio_Orden),
    FOREIGN KEY (ID_Refaccion) REFERENCES Refacciones(ID_Refaccion)
);

-- Insertar Clientes (5)
INSERT INTO Clientes (RFC, Nombre, Ap_Paterno, Ap_Materno, Calle, Numero, Colonia, CP, Ciudad, Email) VALUES
('XAXX010101000', 'Juan', 'Perez', 'Lopez', 'Av. Reforma', '123', 'Centro', '06000', 'CDMX', 'juan.perez@mail.com'),
('XAXX020202000', 'Maria', 'Gomez', 'Sanchez', 'Calle Pino', '45', 'Bosques', '05000', 'CDMX', 'maria.gomez@mail.com'),
('XAXX030303000', 'Carlos', 'Ruiz', 'Diaz', 'Av. Insurgentes', '890', 'Del Valle', '03100', 'CDMX', 'carlos.ruiz@mail.com'),
('XAXX040404000', 'Ana', 'Torres', 'Mendez', 'Calle Roble', '12', 'Jardines', '04000', 'Monterrey', 'ana.torres@mail.com'),
('XAXX050505000', 'Luis', 'Hernandez', 'Ortega', 'Av. Vallarta', '555', 'Americana', '44160', 'Guadalajara', 'luis.h@mail.com');

-- Insertar Telefonos (Asociados a clientes)
INSERT INTO Telefonos_Clientes (ID_Cliente, Numero_Telefono) VALUES
(1, '5512345678'), (1, '5587654321'), (2, '5544332211'), (3, '5599887766'), (4, '8112345678'), (5, '3312345678');

-- Insertar Mecanicos (5)
INSERT INTO Mecanicos (No_Empleado, RFC, Nombre_Completo, Telefono, Salario, Anios_Experiencia) VALUES
('EMP001', 'MEC010101AAA', 'Roberto Mecanico', '5511112222', 15000.00, 10),
('EMP002', 'MEC020202BBB', 'Laura Motor', '5533334444', 18000.00, 12),
('EMP003', 'MEC030303CCC', 'Pedro Frenos', '5555556666', 12000.00, 5),
('EMP004', 'MEC040404DDD', 'Sofia Electric', '5577778888', 16000.00, 8),
('EMP005', 'MEC050505EEE', 'Miguel Suspension', '5599990000', 14000.00, 6);

-- Insertar Especialidades
INSERT INTO Especialidades_Mecanicos (ID_Mecanico, Especialidad) VALUES
(1, 'Motor General'), (2, 'Transmisiones'), (3, 'Frenos ABS'), (4, 'Sistema Eléctrico'), (5, 'Suspensión y Dirección');

-- Insertar Servicios (5)
INSERT INTO Servicios (Clave_Servicio, Nombre_Servicio, Descripcion, Costo_Base, Tiempo_Estimado_Hrs) VALUES
('SERV001', 'Afinación Mayor', 'Cambio de bujias, filtros, aceite y lavado de inyectores', 2500.00, 4.0),
('SERV002', 'Cambio de Aceite', 'Aceite sintético y filtro', 800.00, 1.0),
('SERV003', 'Cambio de Balatas', 'Frenos delanteros y traseros', 1200.00, 2.0),
('SERV004', 'Alineación y Balanceo', 'Por computadora', 600.00, 1.5),
('SERV005', 'Escaneo de Computadora', 'Diagnóstico general OBD2', 300.00, 0.5);

-- Insertar Refacciones (15 registros solicitados)
INSERT INTO Refacciones (Codigo_Refaccion, Nombre, Marca, Precio_Unitario, Stock_Actual, Stock_Minimo, Proveedor) VALUES
('REF001', 'Filtro de Aceite', 'Gonher', 150.00, 50, 10, 'Proveedora Automotriz'),
('REF002', 'Bujía Iridio', 'NGK', 120.00, 100, 20, 'Autopartes Express'),
('REF003', 'Aceite Sintético 5W30', 'Mobil 1', 950.00, 30, 5, 'Lubricantes del Norte'),
('REF004', 'Balatas Delanteras', 'Brembo', 850.00, 15, 2, 'Frenos y Mas'),
('REF005', 'Balatas Traseras', 'Brembo', 750.00, 15, 2, 'Frenos y Mas'),
('REF006', 'Filtro de Aire', 'Fram', 200.00, 40, 5, 'Proveedora Automotriz'),
('REF007', 'Amortiguador Delantero', 'Monroe', 1200.00, 8, 2, 'Suspensiones Totales'),
('REF008', 'Amortiguador Trasero', 'Monroe', 1100.00, 8, 2, 'Suspensiones Totales'),
('REF009', 'Batería', 'LTH', 2500.00, 10, 3, 'Acumuladores Nacionales'),
('REF010', 'Banda de Tiempo', 'Gates', 600.00, 12, 2, 'Autopartes Express'),
('REF011', 'Bomba de Agua', 'Trezzo', 800.00, 6, 1, 'Autopartes Express'),
('REF012', 'Disco de Freno', 'Brembo', 900.00, 10, 2, 'Frenos y Mas'),
('REF013', 'Radiador', 'Valeo', 3500.00, 4, 1, 'Enfriamiento Total'),
('REF014', 'Termostato', 'Gates', 300.00, 20, 5, 'Autopartes Express'),
('REF015', 'Sensor de Oxígeno', 'Bosch', 1500.00, 5, 1, 'Sensores y Cables');

-- Insertar Vehiculos (5)
INSERT INTO Vehiculos (ID_Cliente, Numero_Serie, Placas, Marca, Modelo, Anio, Color, Kilometraje, Tipo_Vehiculo) VALUES
(1, 'SERIE12345', 'ABC-123', 'Toyota', 'Corolla', 2018, 'Blanco', 80000, 'Sedan'),
(2, 'SERIE67890', 'DEF-456', 'Honda', 'CR-V', 2020, 'Gris', 45000, 'SUV'),
(3, 'SERIE11223', 'GHI-789', 'Ford', 'Lobo', 2015, 'Rojo', 120000, 'Pickup'),
(4, 'SERIE33445', 'JKL-012', 'Nissan', 'Versa', 2022, 'Azul', 20000, 'Sedan'),
(5, 'SERIE55667', 'MNO-345', 'Mazda', 'CX-5', 2021, 'Negro', 30000, 'SUV');

-- Insertar Ordenes de Servicio (5)
INSERT INTO Ordenes_Servicio (ID_Vehiculo, Fecha_Ingreso, Fecha_Estimada_Entrega, Estado, Costo_Total) VALUES
(1, NOW(), DATE_ADD(NOW(), INTERVAL 1 DAY), 'En Proceso', 0),
(2, DATE_SUB(NOW(), INTERVAL 5 DAY), DATE_SUB(NOW(), INTERVAL 4 DAY), 'Finalizada', 3300.00),
(3, NOW(), DATE_ADD(NOW(), INTERVAL 2 DAY), 'Abierta', 0),
(4, DATE_SUB(NOW(), INTERVAL 10 DAY), DATE_SUB(NOW(), INTERVAL 9 DAY), 'Finalizada', 800.00),
(5, NOW(), DATE_ADD(NOW(), INTERVAL 3 DAY), 'En Proceso', 0);

-- Insertar Detalles (Relacionar mecánicos, servicios y refacciones a las ordenes)
-- Orden 2 (Finalizada - Afinación completa)
INSERT INTO Asignacion_Mecanicos (Folio_Orden, ID_Mecanico) VALUES (2, 1);
INSERT INTO Detalle_Orden_Servicios (Folio_Orden, ID_Servicio, Precio_Aplicado) VALUES (2, 1, 2500.00); -- Afinación
INSERT INTO Detalle_Orden_Refacciones (Folio_Orden, ID_Refaccion, Cantidad, Precio_Unitario_Aplicado) VALUES 
(2, 2, 4, 120.00), -- 4 Bujias
(2, 1, 1, 150.00); -- 1 Filtro

-- Orden 4 (Finalizada - Cambio de Aceite)
INSERT INTO Asignacion_Mecanicos (Folio_Orden, ID_Mecanico) VALUES (4, 2);
INSERT INTO Detalle_Orden_Servicios (Folio_Orden, ID_Servicio, Precio_Aplicado) VALUES (4, 2, 800.00);
