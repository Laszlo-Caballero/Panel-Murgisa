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
('Muro de Conteci�n', 2000, 1),
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
('En Reparaci�n', 1);

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
('Material de Construcci�n', 1);

-- Insertar datos en la tabla Recurso
INSERT INTO Recurso (idTipoRecurso, idDisponibilidad, idCondicion, idProveedor, nombre, estado, precio)
VALUES 
-- Maquinaria Pesada
(1, 1, 1, 1, 'Excavadora', 1, 250000.00),
(1, 2, 2, 2, 'Bulldozer', 1, 300000.00),
(1, 1, 1, 3, 'Gr�a Torre', 1, 500000.00),

-- Herramienta
(2, 1, 1, 1, 'Martillo', 1, 50.00),
(2, 1, 1, 2, 'Taladro', 1, 150.00),
(2, 2, 2, 3, 'Sierra El�ctrica', 1, 250.00),

-- Material de Construcci�n
(3, 1, 1, 1, 'Cemento', 1, 10.00),
(3, 1, 1, 2, 'Ladrillos', 1, 0.50),
(3, 1, 1, 3, 'Vigas de Acero', 1, 150.00);

-- AGREGADO

INSERT INTO Cargo (cargo, descripcion, estado) VALUES
('Gerente', 'Supervisa las operaciones generales', 1),
('Analista', 'Realiza an�lisis de datos', 1),
('T�cnico', 'Encargado del mantenimiento t�cnico', 1),
('Asistente', 'Apoya en tareas administrativas', 1);

INSERT INTO Profesion (titulo, estado) VALUES
('Ingeniero', 1),
('Contador', 1),
('Administrador', 1),
('Tecnico Informatico', 1);

select* from Profesion

INSERT INTO Departamento (nombre, descripcion, estado) VALUES
('Recursos Humanos', 'Gesti�n del personal', 1),
('Finanzas', 'Manejo de ingresos y gastos', 1),
('Tecnologia', 'Soporte t�cnico y desarrollo', 1),
('Produccion', 'Supervisi�n de procesos productivos', 1);

INSERT INTO Personal (idCargo, idProfesion, idDepartamento, nombre, apellido_parterno, apellido_materno, sueldo, estado) VALUES
(1, 5, 1, 'Juan', 'P�rez', 'Garc�a', 3500.50, 1),
(2, 6, 2, 'Ana', 'L�pez', 'Mart�nez', 2800.75, 1),
(3, 7, 3, 'Carlos', 'Hern�ndez', 'S�nchez', 3000.00, 1),
(4, 8, 4, 'Mar�a', 'Rodr�guez', 'Fern�ndez', 2500.25, 1);


INSERT INTO Cliente (nombreRepresentante, dni, estado, correo, telefono, direccion, idCiudad)
VALUES
('Juan', '123456789', 1, 'juan.perez@gmail.com', '987654321', 'Av. Principal 123', 1),
('Maria', '987654321', 1, 'maria.lopez@yahoo.com', '912345678', 'Calle Secundaria 45', 2),
('Carlos', '654321987', 1, 'carlos.ramos@hotmail.com', '945612378', 'Jr. Los Olivos 567', 3),
('Ana', '321654987', 1, 'ana.garcia@gmail.com', '956783421', 'Av. Los Laureles 89', 1),
('Luis', '159753456', 0, 'luis.torres@example.com', '923456789', 'Calle Los Jazmines 234', 2)