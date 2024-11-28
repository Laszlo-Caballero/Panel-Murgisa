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
@dni varchar(9)
as
begin
	select Cl.idCliente, Cl.nombreRepresentante, Cl.dni, Cl.estado, Cl.correo, cl.telefono, cl.direccion, C.nombre as Ciudad
	from Cliente Cl inner join Ciudad C on C.idCiudad = Cl.idCiudad where Cl.dni = @dni
end;

execute buscarCliente '123456789'

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
	select * from Recurso where estado = 1 and idDisponibilidad = 1
end

create or alter Procedure listarRecursoTipo
@idTipo int
as
begin
	select * from Recurso where idTipoRecurso = @idTipo and estado = 1 and idDisponibilidad = 1
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

alter table PagoServicio add estado bit

-- REALIZAR PAGO

create or alter procedure listarPagoServicio
as
begin
	Select ps.idPago_Servicio,ps.idFormaPago, v.idVenta, c.nombreRepresentante, c.dni, c.correo, fp.tipo, ps.fecha, ps.estado    
	from PagoServicio ps
	inner join Venta v on v.idVenta = ps.idVenta
	inner join Cliente c on c.idCliente = v.idCliente
	inner join FormaPago fp on fp.idFormaPago = ps.idFormaPago
	where ps.estado = 1
end

select * from PagoServicio

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
	where idPago_Servicio = @idPagoServicio
end


create or alter procedure buscarPagos
@dni varchar(9)
as
begin
	Select ps.idPago_Servicio,ps.idFormaPago, v.idVenta, c.nombreRepresentante, c.dni, c.correo, fp.tipo, ps.fecha, ps.estado    
	from PagoServicio ps
	inner join Venta v on v.idVenta = ps.idVenta
	inner join Cliente c on c.idCliente = v.idCliente
	inner join FormaPago fp on fp.idFormaPago = ps.idFormaPago
	where ps.estado = 1 and C.dni = @dni
end

execute buscarPagos '654321987'
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
select * from TipoRecurso

select * from Venta

alter table venta add estado bit

--venta
create or alter procedure agregarVenta
@idServicio int,
@idCliente int,
@fechaInicio datetime,
@fechaFin datetime,
@fechaVenta date,
@estado bit
as
begin
	insert into venta (idServicio, idCliente, fechaInicioServicio, fechaFFinServicio, fechaVenta, estado)
	values (
end


create or alter procedure [dbo].[listarHorarioActivo]

as
begin
	SELECT 
		idHorario,
		CONVERT(VARCHAR, horaInicio, 108) + ' - ' + CONVERT(VARCHAR, horaFin, 108) AS horario
	FROM 
		Horario
	WHERE 
		estado = 1;
end;


create or alter procedure [dbo].[mantenimientoPlanificacion_buscarXId]
    @IdPlanificacion INT
AS
BEGIN
    SELECT 
        idPlanificacion, 
        idRecurso, 
        idPersonal, 
        idHorario, 
        fecha_Mantenimineo AS FechaMantenimiento, 
        prioridad
    FROM dbo.PlanificacionMantenimiento
    WHERE idPlanificacion = @IdPlanificacion
END



create or alter   procedure [dbo].[listarMantenimientoPlanificacion]
    @IdPlanificacion INT = NULL,
    @FechaMantenimiento DATETIME = NULL
as
begin
    select
        mp.idPlanificacion,
        mp.prioridad,
        r.nombre AS RecursoNombre,
        r.precio AS RecursoPrecio,
        p.nombre AS PersonalNombre,
        p.apellido_parterno AS PersonalApellidoPaterno,
        p.apellido_materno AS PersonalApellidoMaterno,
        mp.fecha_Mantenimineo,
        h.horaInicio,
        h.horafin
    from dbo.PlanificacionMantenimiento mp
    inner join dbo.Recurso r on mp.idRecurso = r.idRecurso
    inner join dbo.Personal p on mp.idPersonal = p.idPersonal
    inner join dbo.Horario h on mp.idHorario = h.idHorario
    where
        (@IdPlanificacion IS NULL OR mp.idPlanificacion = @IdPlanificacion)
        and (@FechaMantenimiento IS NULL OR cast(mp.fecha_Mantenimineo as date) = cast(@FechaMantenimiento as date))
    order by mp.idPlanificacion;
end

create or alter procedure listarDetalleVenta
@idVenta int
as
begin
	select V.idDetalleVenta, R.idRecurso,
	T.tipo, D.disponibilidad, C.condicion, P.razSocial,
	R.nombre, V.precio, V.estado
	from DetalleVenta V
	inner join Recurso R on R.idRecurso = V.idRecurso
	inner join TipoRecurso T on T.idTipoRecurso = R.idTipoRecurso
	inner join Proveedor P on P.idProveedor = R.idProveedor
	inner join Disponibilidad D on R.idDisponibilidad = D.idDisponibilidad
	inner join Condicion C on R.idCondicion = C.idCondicion
	where V.idVenta = @idVenta
end

create or alter procedure listarAsignacionPersonal
@idVenta int
as
begin
	select A.idAsignacionPersonal,A.idPersonal, P.nombre, P.apellido_parterno,
	P.apellido_materno, C.descripcion, A.costo, A.estado
	from AsignacionPersonal A 
	inner join Personal P on P.idPersonal = A.idPersonal
	inner join Cargo C on P.idCargo = C.idCargo
	where A.idVenta = @idVenta
end


create or alter procedure deshabilitarVenta
@idVenta int
as
begin
	update Venta set estado = 0 where idVenta = @idVenta
end

create or alter procedure habilitarRecurso
@idRecurso int,
@idVenta int
as
begin
	update Recurso set idDisponibilidad = 1 where idRecurso = @idRecurso
	update DetalleVenta set estado = 0 where idVenta = @idVenta and idRecurso = @idRecurso
end


create or alter procedure deshabilitarPersonal
@idVenta int,
@idPersonal int
as
begin
	update AsignacionPersonal set estado = 0 where idVenta = @idVenta and idPersonal = @idPersonal
end


select * from AsignacionPersonal


---venta

select * from Disponibilidad

select * from Personal


select * from Cliente


select * from Servicio
select * from Cliente

select * from Venta


alter table DetalleVenta add estado bit

select* from AsignacionPersonal

select * from DetalleVenta



update DetalleVenta set estado = 1

select * from DetalleVenta

-- LISTAR PEDIDOS MANTENIMIENTO

alter table PedidoMantenimientoCorrectivo add estado bit

create or alter procedure listarPedidoManCor
as
begin
	Select PM.idPedidoMan, pm.idRecurso, R.nombre, PM.fecha, pm.estado from 
	PedidoMantenimientoCorrectivo PM 
	inner join Recurso r on r.idRecurso = PM.idRecurso
	where PM.estado = 1
end

-- AGREGAR PEDIDOS MANTENIMIENTO
Select * from PedidoMantenimientoCorrectivo

create or alter procedure agregarPedidoManCor
@recurso int,
@fecha date,
@estado bit
as
begin
	insert into PedidoMantenimientoCorrectivo (idRecurso, fecha, estado) 
	values (@recurso, @fecha, @estado)
end

-- DESHABILITAR PEDIDOS
create or alter procedure deshabilitarPedidoManCor
@idPedido int
as
begin
	update PedidoMantenimientoCorrectivo set estado = 0 where idPedidoMan = @idPedido 
end

-- ULTIMO PEDIDO
create or alter procedure ultimoPedido
as
begin
	SELECT TOP 1 idPedidoMan
	FROM PedidoMantenimientoCorrectivo
	ORDER BY idPedidoMan DESC;
end

-- AGREGAR DETALLE

alter table DetallePedidoManCorrectivo add estado bit

create or alter procedure agregarDetallePedido
@pedido int,
@tipo int,
@estado bit
as
begin
	insert into DetallePedidoManCorrectivo (idPedido, idTipo, estado) 
	values (@pedido, @tipo, @estado)
end


-- LISTAR RECURSO POR MAQUINARIA

create or alter procedure listarMaquinaria
as
begin
	select * from Recurso where idTipoRecurso = 1
end

-- LISTARMANTENIMIENTO

alter table TipoMantenimiento add estado bit

create or alter procedure listarTipoMan
as
begin
	Select * from TipoMantenimiento where estado = 1
end



--Realiza Pago


	select * from PagoServicio


--Realiza Pago



CREATE OR ALTER PROCEDURE [dbo].[listarMantenimientoPreventivo]
    @idOrdenMantenimiento INT = NULL,
    @fecha DATETIME = NULL
AS
BEGIN
    SELECT * 
    FROM OrdenMantenimientoPreventivo 
    WHERE estado = 1
    AND (@idOrdenMantenimiento IS NULL OR idOrdenMantenimiento = @idOrdenMantenimiento)
    AND (@fecha IS NULL OR CAST(fecha AS DATE) = CAST(@fecha AS DATE))
END

CREATE OR ALTER PROCEDURE [dbo].[agregarOrdenMantenimientoPreventivo]
    @idPlanificacion INT,
    @fecha DATETIME,
    @resultadoEjecucion VARCHAR(255) = NULL,
    @comentarios VARCHAR(255) = NULL,
    @requerimientosEspeciales VARCHAR(255) = NULL,
    @duracionEstimadaHoras FLOAT = NULL,
    @estado BIT = 1 
AS
BEGIN
    INSERT INTO OrdenMantenimientoPreventivo 
    (
        idPlanificacion, 
        fecha, 
        resultadoEjecucion, 
        comentarios, 
        requerimientosEspeciales, 
        duracionEstimadaHoras, 
        estado
    )
    VALUES 
    (
        @idPlanificacion, 
        @fecha, 
        @resultadoEjecucion, 
        @comentarios, 
        @requerimientosEspeciales, 
        @duracionEstimadaHoras, 
        @estado
    );
    SELECT SCOPE_IDENTITY() AS idOrdenMantenimiento;
END

CREATE PROCEDURE mantenimientoPreventivo_buscarXId
    @IdOrden INT
AS
BEGIN
    SELECT 
        *
    FROM 
        OrdenMantenimientoPreventivo
    WHERE
        idOrdenMantenimiento = @IdOrden
END



CREATE OR ALTER PROCEDURE actualizarOrdenMantenimientoPreventivo
    @idOrdenMantenimiento INT,
    @idPlanificacion INT,
    @fecha DATETIME,
    @resultadoEjecucion VARCHAR(MAX),
    @comentarios VARCHAR(MAX),
    @requerimientosEspeciales VARCHAR(MAX),
    @duracionEstimadaHoras FLOAT
AS
BEGIN
    UPDATE OrdenMantenimientoPreventivo
    SET
        idPlanificacion = @idPlanificacion,
        fecha = @fecha,
        ResultadoEjecucion = @resultadoEjecucion,
        Comentarios = @comentarios,
        RequerimientosEspeciales = @requerimientosEspeciales,
        DuracionEstimadaHoras = @duracionEstimadaHoras
    WHERE idOrdenMantenimiento = @idOrdenMantenimiento;
END;
CREATE PROCEDURE deshabilitarOrdenMantenimientoPreventivo
    @idOrdenMantenimiento INT
AS
BEGIN
    UPDATE OrdenMantenimientoPreventivo
    SET Estado = 0
    WHERE idOrdenMantenimiento = @idOrdenMantenimiento;
END;
