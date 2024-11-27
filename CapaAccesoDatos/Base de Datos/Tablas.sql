
-- SQLBook: Code
create table Ciudad(
    idCiudad int identity(1,1),
    nombre VARCHAR(50),
    PRIMARY KEY(idCiudad)
);

create table Cliente(
    idCliente int identity(1,1),
    nombreRepresentante varchar(15),
    dni char(9),
    estado bit,
    correo VARCHAR(50),
    telefono char(9),
    direccion VARCHAR(50),
    idCiudad int,
    primary key(idCliente),
    Foreign Key (idCiudad) REFERENCES Ciudad(idCiudad)
)
-- SQLBook: Code
create table Cargo(
    idCargo int identity(1,1),
	cargo varchar(20),
	descripcion varchar(50),
	estado bit,
	primary key (idCargo)
)
create table Profesion(
	idProfesion int identity(1,1),
	titulo varchar(20),
	estado bit,
	primary key (idProfesion)
)

create table Departamento(
	idDepartamento int identity(1,1),
	nombre varchar(20),
	descripcion varchar(50),
	estado bit,
	primary key(idDepartamento)
)

-- SQLBook: Code
create table Personal(
    idPersonal int identity(1,1),
    idCargo int,
	idProfesion int,
	idDepartamento int,
    nombre varchar(15),
    apellido_parterno varchar(15),
    apellido_materno varchar(15),
	sueldo float,
    estado bit,
    foreign Key (idCargo) REFERENCES Cargo(idCargo),
    foreign key (idProfesion) references Profesion(idProfesion),
	foreign key (idDepartamento) references Departamento(idDepartamento),
	primary key(idPersonal)
)
-- SQLBook: Code
create table Servicio(
    idServicio int identity(1,1),
    nombre varchar(50),
    estado bit,
    precio float,
    primary key(idServicio)
)
-- SQLBook: Code
create table Proveedor(
    idProveedor int identity(1,1),
    razSocial varchar(30),
    ruc char(11),
    estado bit,
    primary key(idProveedor)
)

create table Condicion(
	idCondicion int identity(1,1),
	condicion varchar(50),
	estado bit,
	primary key(idCondicion)
)

create table Disponibilidad(
	idDisponibilidad int identity(1,1),
	disponibilidad varchar(50),
	estado bit,
	primary key(idDisponibilidad)
)

create table TipoRecurso(
	idTipoRecurso int identity(1,1),
	tipo varchar(50),
	estado bit,
	primary key(idTipoRecurso)
)

create table Recurso(
	idRecurso int identity(1,1),
	idTipoRecurso int,
	idDisponibilidad int,
	idCondicion int,
	idProveedor int,
	nombre varchar(50),
	estado bit,
	precio float,
	foreign key (idTipoRecurso) references TipoRecurso(idTipoRecurso),
	foreign key (idDisponibilidad) references Disponibilidad(idDisponibilidad),
	foreign key (idCondicion) references Condicion(idCondicion),
	foreign key (idProveedor) references Proveedor(idProveedor),
	primary key(idRecurso)
)

-- SQLBook: Code
create table FormaPago(
    idFormaPago int identity(1,1),
    tipo varchar(25),
    estado bit,
    primary key(idFormaPago)
)
-- SQLBook: Code
create table TipoMantenimiento(
    idTipoMantenimiento int identity(1,1),
    tipo varchar(25),
    primary key(idTipoMantenimiento)
)

create table Horario(
	idHorario int identity(1,1),
	horaInicio datetime,
	horafin datetime,
	estado bit,
	primary key(idHorario)
)

-- SQLBook: Code
create table Venta(
    idVenta int identity(1,1),
    idServicio int,
    idCliente int,
    fechaInicioServicio datetime,
    fechaFFinServicio datetime,
    fechaVenta date,
	estado bit,
	primary key(idVenta),
    foreign key(idCliente) REFERENCES Cliente(idCliente),
    Foreign Key (idServicio) REFERENCES Servicio(idServicio)
)

create table DetalleVenta(
	idDetalleVenta int identity(1,1),
	idVenta int,
	idRecurso int,
	cantidad int,
	precio float,
	primary key (idDetalleVenta),
	foreign key (idVenta) references Venta(idVenta),
	foreign key (idRecurso) references Recurso(idRecurso)
)


-- SQLBook: Code
create table OrdenServicio(
   idOrdenServicio int identity(1,1),
   idVenta int,
   estado bit,
   FechaRegistro date,
   primary key(idOrdenServicio),
   foreign key(idVenta) REFERENCES Venta(idVenta)
)

create table AsignacionPersonal(
	idAsignacionPersonal int identity(1,1),
	idVenta int,
	idPersonal int,
	costo float,
	primary key(idAsignacionPersonal),
	foreign key (idVenta) references Venta(idVenta),
	foreign key (idPersonal) references Personal(idPersonal)
)


-- SQLBook: Code
create table NotaSalida(
   idNotaSalida int identity(1,1),
   idOrdenServicio int,
   Fecha date,
   primary key(idNotaSalida),
   foreign key(idOrdenServicio) REFERENCES OrdenServicio(idOrdenServicio)
)   

create table NotaIngreso(
    idNotaIngreso int identity(1,1),
    idNotaSalida int,
    fecha datetime,
    primary key(idNotaIngreso),
    foreign key(idNotaSalida) references NotaSalida(idNotaSalida)
)
-- SQLBook: Code
create table PagoServicio(
   idPago_Servicio int identity(1,1),
   idVenta int,
   fecha datetime,
   idFormaPago int,
   estado bit,
   primary key(idPago_Servicio),
   foreign key(idVenta) REFERENCES Venta(idVenta),
   foreign key(idFormaPago) REFERENCES FormaPago(idFormaPago),
) 

-- SQLBook: Code
create table PlanificacionMantenimiento(
    idPlanificacion int identity(1,1),
    idRecurso int,
    idPersonal int,
	idHorario int,
    fecha_Mantenimineo datetime,
    prioridad varchar(100),
    primary key(idPlanificacion),
    Foreign Key (idRecurso) REFERENCES Recurso(idRecurso),
    Foreign Key (idPersonal) REFERENCES Personal(idPersonal),
	Foreign key (idHorario) References Horario(idHorario)
)

create table DetallePlanificacionMantinimiento(
	idDetallePlanificacion int identity(1,1),
	idPlanificacion int,
	idTipoMantenimiento int,
	primary key(idDetallePlanificacion),
	foreign key (idPlanificacion) references PlanificacionMantenimiento(idPlanificacion)
)

create table OrdenMantenimientoPreventivo(
    idOrdenMantenimiento int identity(1,1),
    idPlanificacion int,
    fecha datetime,
    estado bit,
    primary key(idOrdenMantenimiento),
    Foreign Key (idPlanificacion) REFERENCES PlanificacionMantenimiento(idPlanificacion)
)

create table PedidoMantenimientoCorrectivo(
    idPedidoMan int identity(1,1),
    idRecurso int,
    fecha date,
    primary key(idPedidoMan),
    foreign key(idRecurso) REFERENCES Recurso(idRecurso)
)

create table DetallePedidoManCorrectivo(
	idDetallePedidoMan int identity(1,1),
	idPedido int,
	idTipo int,
	primary key (idDetallePedidoMan),
	foreign key (idPedido) references PedidoMantenimientoCorrectivo(idPedidoMan),
	foreign key (idTipo) references TipoMantenimiento(idTipoMantenimiento)
)

create table OrdenManCorrectivo(
    idOrdenManCor int identity(1,1),
    idPedido int,
	estado bit,
    fecha datetime,
    primary key(idOrdenManCor),
	foreign key (idPedido) references PedidoMantenimientoCorrectivo(idPedidoMan)
)

create table PedidoReemplazo(
	idPedidoReemplazo int identity(1,1),
	idRecurso int,
	primary key (idPedidoReemplazo),
	foreign key(idRecurso) references Recurso(idRecurso)
)

