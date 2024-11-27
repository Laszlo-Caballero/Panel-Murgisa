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

-- AGREGADO

INSERT INTO Cargo (cargo, descripcion, estado) VALUES
('Gerente', 'Supervisa las operaciones generales', 1),
('Analista', 'Realiza análisis de datos', 1),
('Técnico', 'Encargado del mantenimiento técnico', 1),
('Asistente', 'Apoya en tareas administrativas', 1);

INSERT INTO Profesion (titulo, estado) VALUES
('Ingeniero', 1),
('Contador', 1),
('Administrador', 1),
('Tecnico Informatico', 1);

select* from Profesion

INSERT INTO Departamento (nombre, descripcion, estado) VALUES
('Recursos Humanos', 'Gestión del personal', 1),
('Finanzas', 'Manejo de ingresos y gastos', 1),
('Tecnologia', 'Soporte técnico y desarrollo', 1),
('Produccion', 'Supervisión de procesos productivos', 1);

INSERT INTO Personal (idCargo, idProfesion, idDepartamento, nombre, apellido_parterno, apellido_materno, sueldo, estado) VALUES
(1, 5, 1, 'Juan', 'Pérez', 'García', 3500.50, 1),
(2, 6, 2, 'Ana', 'López', 'Martínez', 2800.75, 1),
(3, 7, 3, 'Carlos', 'Hernández', 'Sánchez', 3000.00, 1),
(4, 8, 4, 'María', 'Rodríguez', 'Fernández', 2500.25, 1);


INSERT INTO Cliente (nombreRepresentante, dni, estado, correo, telefono, direccion, idCiudad)
VALUES
('Juan', '123456789', 1, 'juan.perez@gmail.com', '987654321', 'Av. Principal 123', 1),
('Maria', '987654321', 1, 'maria.lopez@yahoo.com', '912345678', 'Calle Secundaria 45', 2),
('Carlos', '654321987', 1, 'carlos.ramos@hotmail.com', '945612378', 'Jr. Los Olivos 567', 3),
('Ana', '321654987', 1, 'ana.garcia@gmail.com', '956783421', 'Av. Los Laureles 89', 1),
('Luis', '159753456', 0, 'luis.torres@example.com', '923456789', 'Calle Los Jazmines 234', 2)