use Bancolombia
go
/*
DROP PROCEDURE crearUsuario; 
GO
*/
create proc insertarCliente
	@Cedula varchar(50),
	@Nombre varchar(50),
	@Direccion varchar(50),
	@Ingresos int,
	@Egresos int,
	@Pasivos int,
	@Scoring int

As 
	INSERT INTO Cliente (cedula,nombre,direccion,ingresos,egresos,pasivos,scoring)
	VALUES (@Cedula,@Nombre,@Direccion,@Ingresos,@Egresos,@Pasivos,@Scoring); 
	
go

exec crearUsuario '345','ccc','cl 47 b',1000,500,100,250

use Bancolombia
go
/*
DROP PROCEDURE modificarUsuario; 
GO
*/
create proc modificarCliente
	@IdCliente int,
	@Cedula varchar(50),
	@Nombre varchar(50),
	@Direccion varchar(50),
	@Ingresos int,
	@Egresos int,
	@Pasivos int,
	@Scoring int

As 
	UPDATE Cliente
	SET cedula = @Cedula,nombre = @Nombre,direccion = @Direccion,ingresos = @Ingresos,egresos= @Egresos,pasivos = @Pasivos,scoring = @Scoring
	WHERE id_cliente = @IdCliente
	
go

exec modificarUsuario 1,'234','bbb','cl 45 c',1000,500,100,250

use Bancolombia
go

/*
DROP PROCEDURE eliminarUsuario; 
GO
*/
create proc eliminarUsuario
	@Cedula int
As
DELETE FROM Cliente
WHERE cedula = @Cedula
go

exec eliminarCliente 1

use Bancolombia
go
/*
DROP PROCEDURE consultarUsuario;  
GO
*/  
create proc consultarCliente

	@Cedula varchar(50)
	
As
SELECT id_cliente,cedula,nombre,direccion,ingresos,egresos,pasivos,scoring FROM Cliente
WHERE cedula = @Cedula
go

exec consultarCliente '123'


/*LISTAR TODOS LOS USUARIOS*/

/*
DROP PROCEDURE listarUsuarios;  
GO
*/  
create proc listarClientes
As
SELECT id_cliente,cedula,nombre,direccion,ingresos,egresos,pasivos,scoring FROM Cliente
go

exec listarClientes

use Bancolombia
go
/*
DROP PROCEDURE crearCredito;  
GO
*/  
create proc crearCredito
	@Plazo int,
	@Monto int,
	@TotalInteres int,
	@Anualidad int,
	@Tnm float,
	@Tea float,
	@IdCliente int,
	@TotalMontoIntereses int

As 
	INSERT INTO Credito(plazo,monto,total_interes,anualidad,tnm,tea,id_cliente, total_monto_intereses)
	VALUES (@Plazo,@Monto,@TotalInteres,@Anualidad,@Tnm,@Tea,@IdCliente, @TotalMontoIntereses); 
	
go

exec crearCredito 12,1500,10,15,20,15,10,2,1


DROP PROC consultarProductosPorCliente;
GO
create proc consultarProductosPorCliente
	@Cedula varchar(50)
as
	select cre.id_credito, cre.nombre, cre.monto, cre.plazo, cre.tea , cre.tnm, cre.total_interes, cre.total_monto_intereses
	from Cliente as cli
		inner join Credito as cre
			on cli.id_cliente = cre.id_cliente
	where cli.cedula = @Cedula
go

exec consultarProductosPorCliente '1087986486'



select * from Credito
select * from Cliente