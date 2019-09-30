USE [amigos]
GO
/****** Object:  StoredProcedure [dbo].[updateamigo]    Script Date: 27/09/2019 07:22:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[updateamigo]
(
	@idamigo int, 
	@nombre nvarchar(50),
	@fecnac datetime,
	@direccion nvarchar(100),
	@telefono nvarchar(50),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	update amigos
	set nombre = @nombre,
	fecnac = @fecnac,
	direccion = @direccion,
	telefono = @telefono
	where [idamigo] = @idamigo
end try
begin catch
	set @haserror = 1;
end catch
