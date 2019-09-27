create database agenda
go
use agenda
go

create table amigos(
idamigo int primary key identity(1,1),
nombre nvarchar(50) not null,
fecnac datetime,
direccion nvarchar(100),
telefono nvarchar(50));
go

insert into amigos
values
('JVelarde','04/13/1982','San Antonio 101-19','4491091867')
go

create procedure getamigos
as
select * from amigos
go

create procedure addamigo
(
	@nombre nvarchar(50),
	@fecnac datetime,
	@direccion nvarchar(100),
	@telefono nvarchar(50),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	insert into amigos
	values
	(@nombre,@fecnac,@direccion,@telefono)
end try
begin catch
	set @haserror = 1;
end catch
go

create procedure deleteamigo
(
	@idamigo int,
	@haserror bit out
)
as
set @haserror = 1
begin try
if exists(select top 1 1 from amigos where idamigo = @idamigo)
begin
	set @haserror = 0
	delete amigos where idamigo = @idamigo
end
end try
begin catch
	set @haserror = 1;
end catch
go

create procedure updateamigo
(
	@idamigo int,
	@nombre nvarchar(50),
	@fecnac datetime,
	@direccion nvarchar(100),
	@telefono nvarchar(50),
	@haserror bit out
)
as
set @haserror = 1
begin try
if exists(select top 1 1 from amigos where idamigo = @idamigo)
begin
	set @haserror = 0
	update amigos
	set nombre = @nombre, fecnac = @fecnac, direccion = @direccion, telefono = @telefono
	where idamigo = @idamigo
end
end try
begin catch
	set @haserror = 1;
end catch
go
