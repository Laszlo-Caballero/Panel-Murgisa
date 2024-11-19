create or alter procedure listarClientes
as
begin
	select Cl.idCliente, Cl.nombreRepresentante, Cl.dni, Cl.estado, Cl.correo, cl.telefono, cl.direccion, C.nombre as Ciudad
	from Cliente Cl inner join Ciudad C on C.idCiudad = Cl.idCiudad where Cl.estado = 1
end;


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
@idCliente int
as
begin
	select Cl.idCliente, Cl.nombreRepresentante, Cl.dni, Cl.estado, Cl.correo, cl.telefono, cl.direccion, C.nombre as Ciudad
	from Cliente Cl inner join Ciudad C on C.idCiudad = Cl.idCiudad where Cl.idCliente = @idCliente
end;