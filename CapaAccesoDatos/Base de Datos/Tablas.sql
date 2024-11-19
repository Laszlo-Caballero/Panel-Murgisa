
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
    tipo varchar(25),
    estado bit,
    primary key(idCargo)
)
-- SQLBook: Code
create table Personal(
    idPersonal int identity(1,1),
    idCargo int,
    nombre varchar(15),
    apellido_parterno varchar(15),
    apellido_materno varchar(15),
    estado bit,
    foreign Key (idCargo) REFERENCES Cargo(idCargo),
    primary key(idPersonal)
)
-- SQLBook: Code
create table Servicio(
    idServicio int identity(1,1),
    descripción varchar(50),
    estado bit,
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
-- SQLBook: Code
create table Maquinaria(
    idMaquinaria int identity(1,1),
    idProveedor int,
    nombre varchar(15),
    stock int,
    precioServicio float,
    estado bit,
    primary key(idMaquinaria),
    foreign key(idProveedor) REFERENCES Proveedor(idProveedor)
)
-- SQLBook: Code
create table Material(
    idMaterial int identity(1,1),
    idProveedor int,
    nombre varchar(15),
    stock int,
    estado bit,
    precioVenta float,
    primary key(idMaterial),
    foreign key(idProveedor) REFERENCES Proveedor(idProveedor),
)
-- SQLBook: Code
create table FormaPago(
    idFormaPago int identity(1,1),
    tipo varchar(25),
    estado bit,
    primary key(idFormaPago)
)
-- SQLBook: Code
create table Repuesto(
    idRepuesto int identity(1,1),
    idProveedor int,
    nombre varchar(15),
    stock int,
    estado bit,
    primary key(idRepuesto),
    foreign key(idProveedor) REFERENCES Proveedor(idProveedor)
)
-- SQLBook: Code
create table Herramienta(
    idHerramienta int identity(1,1),
    idProveedor int,
    nombre varchar(15),
    stock int,
    estado bit,
    primary key(idHerramienta),
    foreign key(idProveedor) REFERENCES Proveedor(idProveedor)
)
-- SQLBook: Code
create table TipoMantenimiento(
    idTipoMantenimiento int identity(1,1),
    tipo varchar(25),
    prioridad char(1),
    primary key(idTipoMantenimiento)
)
-- SQLBook: Code
create table Venta(
    idVenta int identity(1,1),
    idServicio int,
    idCliente int,
    fechaInicioServicio datetime,
    fechaFFinServicio datetime,
    fechaVenta date,
    primary key(idVenta),
    foreign key(idCliente) REFERENCES Cliente(idCliente),
    Foreign Key (idServicio) REFERENCES Servicio(idServicio)
)
-- SQLBook: Code
create table PagoServicio(
   idPago_Servicio int identity(1,1),
   idVenta int,
   fecha datetime,
   idFormaPago int,
   primary key(idPago_Servicio),
   foreign key(idVenta) REFERENCES Venta(idVenta),
   foreign key(idFormaPago) REFERENCES FormaPago(idFormaPago),
)    
-- SQLBook: Code
create table PlanificacionMantenimiento(
    idPlanificacion int identity(1,1),
    idMaquinaria int,
    idPersonal int,
    fecha_Mantenimineo datetime,
    primary key(idPlanificacion),
    Foreign Key (idMaquinaria) REFERENCES Maquinaria(idMaquinaria),
    Foreign Key (idPersonal) REFERENCES Personal(idPersonal)
)
-- SQLBook: Code
create table AsignacionMaquinaria(
    idAsiMaquinaria int identity(1,1),
    idVenta int,
    idMaquinaria int,
    idPersonal int,
    cantidad int,
    primary key (idAsiMaquinaria),
    foreign key(idVenta) REFERENCES Venta(idVenta),
    foreign key(idMaquinaria) REFERENCES Maquinaria(idMaquinaria),
    foreign key(idPersonal) REFERENCES Personal(idPersonal)
)
-- SQLBook: Code
create table OrdenMantenimientoPreventivo(
    idOrdenMantenimiento int identity(1,1),
    idPlanificacion int,
    fecha datetime,
    estado bit,
    primary key(idOrdenMantenimiento),
    Foreign Key (idPlanificacion) REFERENCES PlanificacionMantenimiento(idPlanificacion)
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
-- SQLBook: Code
create table AsignacionMaterial(
    idAsiMaterial int identity(1,1),
    idVenta int,
    idMaterial int,
    cantidad int,
    primary key (idAsiMaterial),
    foreign key(idVenta) REFERENCES Venta(idVenta),
    foreign key(idMaterial) REFERENCES Material(idMaterial),
)
-- SQLBook: Code
create table NotaSalida(
   idNotaSalida int identity(1,1),
   idOrdenServicio int,Fecha date,
   primary key(idNotaSalida),
   foreign key(idOrdenServicio) REFERENCES OrdenServicio(idOrdenServicio)
)   
   
-- SQLBook: Code
create table AsignacionHerramientas(
    idAsignacionHerramientas int identity(1,1),
    idHerramienta int,
    idPlanificacion int,
    cantidad int,
    primary key(idAsignacionHerramientas),
    Foreign Key (idHerramienta) REFERENCES Herramienta(idHerramienta),
    Foreign Key (idPlanificacion) REFERENCES PlanificacionMantenimiento(idPlanificacion)
)
-- SQLBook: Code
create table AsignacionRepuesto(
    idAsignacionRepuesto int identity(1,1),
    idRepuesto int,
    idPlanificacion int,
    cantidad int,
    primary key(idAsignacionRepuesto),
    Foreign Key (idRepuesto) REFERENCES Repuesto(idRepuesto),
    Foreign Key (idPlanificacion) REFERENCES PlanificacionMantenimiento(idPlanificacion)
)
-- SQLBook: Code
create table PedidoMantenimiento(
    idPedidoMan int identity(1,1),
    idMaquinaria int,
    idTipoMantenimiento int,
    fecha date,
    primary key(idPedidoMan),
    foreign key(idMaquinaria) REFERENCES Maquinaria(idMaquinaria),
    foreign key(idTipoMantenimiento) REFERENCES TipoMantenimiento(idTipoMantenimiento)
)
-- SQLBook: Code
create table Diagnostico(
    idDiagnostico int identity(1,1),
    idPedidoMan int,
    descripcion varchar(50),
    fecha date,
    primary key(idDiagnostico),
    foreign key(idPedidoMan) REFERENCES PedidoMantenimiento(idPedidoMan)
)
-- SQLBook: Code
create table OrdenManCor(
    idOrdenManCor int identity(1,1),
    idDiagnostico int,
    estado bit,
    fecha datetime,
    primary key(idOrdenManCor),
    foreign key(idDiagnostico) REFERENCES Diagnostico(idDiagnostico)
)


create table PedidoMaterial(
    idPedidoMaterial int identity(1,1),
    idMaterial int,
    fecha date,
    cantidad int,
    estado bit,
    primary key(idPedidoMaterial),
    foreign key(idMaterial) references Material(idMaterial)
)

create table NotaIngresoMaterial(
    idNotaIngresoMaterial int identity(1,1),
    idPedidoMaterial int,
    fecha datetime,
    primary key(idNotaIngresoMaterial),
    foreign key(idPedidoMaterial) references PedidoMaterial(idPedidoMaterial)
)


create table PedidoMaquinaria(
    idPedidoMaquinaria int identity(1,1),
    idMaquinaria int,
    fecha date,
    cantidad int,
    estado bit,
    primary key(idPedidoMaquinaria),
    foreign key (idMaquinaria) references Maquinaria(idMaquinaria)
)

create table NotaIngresoMaquinaria(
    idNotaIngresoMaquinaria int identity(1,1),
    idPedidoMaquinaria int,
    fecha datetime,
    primary key(idNotaIngresoMaquinaria),
    foreign key(idPedidoMaquinaria) references PedidoMaquinaria(idPedidoMaquinaria)
)