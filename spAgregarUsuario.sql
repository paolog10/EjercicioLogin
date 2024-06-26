USE [BD_Encriptado]
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarUsuario]    Script Date: 28/04/2024 8:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER procedure [dbo].[SP_AgregarUsuario]
	@Usuario varchar(50),
	@Contrasenia varchar(50),
	@Patron varchar(50) /*usar patrón: prgpassword*/
as
	begin
		insert into Usuarios(Usuario, Contrasenia) values (@Usuario,ENCRYPTBYPASSPHRASE(@Patron,@Contrasenia))
	End

go

--exec SP_AgregarUsuario 'rcapello', 'Qwerty154', 'prgpassword'