create or alter procedure listarClientes
as
begin
	select Cl.idCliente, Cl.nombreRepresentante, Cl.dni, Cl.estado, Cl.correo, cl.telefono, cl.direccion, C.nombre as Ciudad
	from Cliente Cl inner join Ciudad C on C.idCiudad = Cl.idCiudad where Cl.estado = 1
end;


select * from Cliente




create or alter procedure agregarCliente
@nombreRepresentante varchar(15),
@dni char(9),
@estado bit,
@correo varchar(50),
@telefono char(9),
@direccion varchar(50),
@ciudad varchar(50)
as
begin

	insert into Cliente (nombreRepresentante, dni, estado, correo, telefono, direccion, idCiudad)
	values (@nombreRepresentante, @dni, @estado, @correo, @telefono, @direccion, (select top 1 idCiudad  from Ciudad where nombre = @ciudad))
end


create or alter procedure deshabilitarCliente
@idCliente int
as
begin
	update Cliente set estado = 0 where idCliente = @idCliente
end

create or alter procedure actualizarCliente
@idCliente int,
@nombreRepresentante varchar(15),
@dni char(9),
@estado bit,
@correo varchar(50),
@telefono char(9),
@direccion varchar(50),
@ciudad varchar(50)
as
begin
	update Cliente set nombreRepresentante = @nombreRepresentante, dni = @dni,
	estado = @estado, correo = @correo, telefono = @telefono, direccion = @direccion,
	idCiudad = (select top 1 idCiudad  from Ciudad where nombre = @ciudad)
	where idCliente = @idCliente
end


create or alter procedure buscarCliente
@dni varchar(8)
as
begin
	select Cl.idCliente, Cl.nombreRepresentante, Cl.dni, Cl.estado, Cl.correo, cl.telefono, cl.direccion, C.nombre as Ciudad
	from Cliente Cl inner join Ciudad C on C.idCiudad = Cl.idCiudad where Cl.dni = @dni
end;


create or alter procedure listarCiudades
as
begin
	select * from Ciudad
end


create or alter procedure listarFormaPagos
as
begin
	select * from FormaPago where estado = 1
end


create or alter procedure agregarPago
@tipo varchar(50),
@estado bit
as
begin
	insert into FormaPago (tipo, estado) values (@tipo, @estado)
end

create or alter procedure actualizarPago
@idPago int,
@tipo varchar(60),
@estado bit
as
begin
	update FormaPago set tipo = @tipo, estado = @estado where idFormaPago = @idPago
end

create or alter procedure deshabilitarPago
@idPago int
as
begin
	update FormaPago set estado = 0 where idFormaPago = @idPago
end

select * from Servicio


create or alter procedure listarServicios
as
begin
	select * from Servicio where estado = 1
end


create or alter procedure agregarServicio
@nombre varchar(50),
@precio float,
@estado bit
as
begin
	insert into Servicio (estado, nombre, precio) 
	values (@estado, @nombre, @precio)
end

create or alter procedure actualizarServicio
@idServicio int,
@nombre varchar(50),
@precio float,
@estado bit
as
begin
	update Servicio set estado = @estado, nombre = @nombre, precio = @precio where idServicio = @idServicio
end


create or alter procedure deshabilitarServicio
@idServicio int
as
begin
	update Servicio set estado = 0 where idServicio = @idServicio
end

create or alter procedure listarTipoRecurso
as
begin
	select * from TipoRecurso where estado = 1
end

create or alter procedure listarRecurso
as
begin
	select * from Recurso where estado = 1
end

create or alter Procedure listarRecursoTipo
@idTipo int
as
begin
	select * from Recurso where idTipoRecurso = @idTipo and estado = 1
end


select * from TipoRecurso

--- CARGO
create or alter procedure listarCargo
as
begin
	Select * from cargo where estado = 1
end

-----
create or alter procedure agregarCargo
@cargo varchar(20),
@desc varchar(50),
@estado bit
as
begin
	insert into Cargo(cargo, descripcion, estado) values
	(@cargo, @desc, @estado)
end

----

create or alter procedure actualizarCargo
@idCargo int,
@cargo varchar(20),
@desc varchar(50),
@estado bit
as
begin
	update Cargo set
	cargo = @cargo,
	descripcion = @desc,
	estado = @estado
	where idCargo = @idCargo
end

---

create PROCEDURE deshabilitarCargo
@idCargo int
as
begin
	update Cargo set
	estado = 0
	where idCargo = @idCargo
end

-- PROFESION

create or alter procedure listarProfesion
as
begin
	Select * from Profesion where estado = 1
end

-----

create or alter procedure agregarProfesion
@titulo varchar(20),
@estado bit
as
begin
	insert into Profesion(titulo, estado) values
	(@titulo, @estado)
end

----

create or alter procedure actualizarProfesion
@idProfesion int,
@titulo varchar(20),
@estado bit
as
begin
	update Profesion set
	titulo = @titulo,
	estado = @estado
	where idProfesion = @idProfesion
end

---

create or alter PROCEDURE deshabilitarProfesion
@idProfesion int
as
begin
	update Profesion set
	estado = 0
	where idProfesion = @idProfesion
end

select * from profesion

exec deshabilitarProfesion 9
-- DEPARTAMENTO

create or alter procedure listarDepartamento
as
begin
	Select * from Departamento where estado = 1
end

-----

create or alter procedure agregarDepartamento
@nombre varchar(20),
@descripcion varchar(50),
@estado bit
as
begin
	insert into Departamento(nombre, descripcion, estado) values
	(@nombre,@descripcion, @estado)
end

----

create or alter procedure actualizarDepartamento
@idDepartamento int,
@nombre varchar(20),
@descripcion varchar(50),
@estado bit
as
begin
	update Departamento set
	nombre = @nombre,
	descripcion = @descripcion,
	estado = @estado
	where idDepartamento = @idDepartamento
end

---

create or alter procedure deshabilitarDepartamento
@idDepartamento int
as
begin
	update Departamento set
	estado = 0
	where idDepartamento = @idDepartamento
end

--PERSONAL

create or alter procedure listarPersonal
as
begin
	Select P.idPersonal, P.nombre, P.apellido_parterno, P.apellido_materno, c.cargo,pr.titulo,  d.nombre as departamento, p.sueldo, p.estado from Personal p
	inner join Cargo c on c.idCargo = p.idCargo
	inner join Profesion pr on pr.idProfesion = p.idProfesion
	inner join Departamento d on d.idDepartamento = p.idDepartamento
	where P.estado = 1
end

exec listar
-----
Select * from Personal
create or alter procedure agregarPersonal
    @idCargo int,
	@idProf int,
	@idDep int,
    @nombre varchar(15),
    @parterno varchar(15),
    @materno varchar(15),
	@sueldo float,
    @estado bit
as
begin
	insert into Personal(idCargo, idProfesion, idDepartamento, nombre, apellido_parterno, apellido_materno, sueldo, estado) values
	(@idCargo, @idProf, @idDep, @nombre, @parterno, @materno, @sueldo, @estado)
end

----

create or alter procedure actualizarPersonal
	@idPersonal int,
    @idCargo int,
	@idProf int,
	@idDep int,
    @nombre varchar(15),
    @parterno varchar(15),
    @materno varchar(15),
	@sueldo float,
    @estado bit
as
begin
	update Personal set
	idCargo = @idCargo,
	idProfesion = @idProf,
	idDepartamento = @idDep,
	nombre = @nombre,
	apellido_parterno = @parterno,
	apellido_materno = @materno,
	sueldo =@sueldo,
	estado = @estado
	where idPersonal = @idPersonal
end

---

create or alter procedure deshabilitarPersonal
@idPersonal int
as
begin
	update Personal set
	estado = 0
	where idPersonal = @idPersonal
end

-- REALIZAR PAGO

create or alter procedure listarPagoServicio
as
begin
	Select ps.idPago_Servicio, v.idVenta, c.nombreRepresentante, c.dni, c.correo, fp.tipo, SUM(dv.cantidad * dv.precio) AS total, ps.fecha, ps.estado  from PagoServicio ps
	inner join Venta v on v.idVenta = ps.idVenta
	inner join Cliente c on c.idCliente = v.idCliente
	inner join FormaPago fp on fp.idFormaPago = ps.idFormaPago
	INNER JOIN DetalleVenta dv ON dv.idVenta = v.idVenta
	where ps.estado = 1
	GROUP BY ps.idPago_Servicio, c.nombreRepresentante, c.dni, c.correo, v.idVenta, fp.tipo, ps.fecha,  ps.estado
end

-----

create or alter procedure agregarPagoServicio
   @idVenta int,
   @fecha datetime,
   @idFormaPago int,
   @estado bit
as
begin
	insert into PagoServicio(idVenta, fecha, idFormaPago, estado) values
	(@idVenta, @fecha, @idFormaPago, @estado)
end
select * from PagoServicio
---

create or alter procedure deshabilitarPagoServicio
@idPagoServicio int
as
begin
	update PagoServicio set
	estado = 0
	where idPagoServicio = @idPagoServicio
end

---

create or alter procedure listarVentaCliente
@idCliente int
as
begin
	Select * from Venta
	where idCliente = @idCliente AND estado = 1;
end;

SELECT * FROM FormaPago


exec listarClientes