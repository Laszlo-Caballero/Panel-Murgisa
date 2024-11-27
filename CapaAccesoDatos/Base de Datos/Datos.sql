insert into Ciudad (nombre) values
('El Porvenir'),
('Florencia De Mora'),
('Huanchaco'),
('La Esperanza'),
('Laredo'),
('Moche'),
('Poroto'),
('Salaverry'),
('Simbal'),
('Trujillo'),
('Victor Larco Herrera')

insert into Servicio (nombre, precio, estado)
values ('Alquiler de maquinaria', 1000, 1),
('Edificaciones', 2000, 1),
('Muro de Conteción', 2000, 1),
('Demoliciones', 2000, 1)


INSERT INTO Proveedor (razSocial, ruc, estado)
VALUES 
('Proveedor A', '12345678901', 1),
('Proveedor B', '98765432109', 1),
('Proveedor C', '45678912345', 1);

-- Insertar datos en la tabla Condicion
INSERT INTO Condicion (condicion, estado)
VALUES 
('Nuevo', 1),
('Usado', 1),
('En Reparación', 1);

-- Insertar datos en la tabla Disponibilidad
INSERT INTO Disponibilidad (disponibilidad, estado)
VALUES 
('Disponible', 1),
('No Disponible', 1),
('Reservado', 1);

-- Insertar datos en la tabla TipoRecurso
INSERT INTO TipoRecurso (tipo, estado)
VALUES 
('Maquinaria Pesada', 1),
('Herramienta', 1),
('Material de Construcción', 1);

-- Insertar datos en la tabla Recurso
INSERT INTO Recurso (idTipoRecurso, idDisponibilidad, idCondicion, idProveedor, nombre, estado, precio)
VALUES 
-- Maquinaria Pesada
(1, 1, 1, 1, 'Excavadora', 1, 250000.00),
(1, 2, 2, 2, 'Bulldozer', 1, 300000.00),
(1, 1, 1, 3, 'Grúa Torre', 1, 500000.00),

-- Herramienta
(2, 1, 1, 1, 'Martillo', 1, 50.00),
(2, 1, 1, 2, 'Taladro', 1, 150.00),
(2, 2, 2, 3, 'Sierra Eléctrica', 1, 250.00),

-- Material de Construcción
(3, 1, 1, 1, 'Cemento', 1, 10.00),
(3, 1, 1, 2, 'Ladrillos', 1, 0.50),
(3, 1, 1, 3, 'Vigas de Acero', 1, 150.00);