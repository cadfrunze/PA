USE [spectacol]
GO
/****** Object:  StoredProcedure [dbo].[NewUser]    Script Date: 02-Jan-25 1:33:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[NewUser]
-- evidenta_clienti
@nume varchar(50),
@prenume varchar(50),
@cnp varchar(50),
@email varchar(50),
@telefon varchar(15),
-- stoc bilete
@tip_ticket varchar(50),
@serie_ticket varchar(50)

as
	begin
		begin transaction
			begin try
			-- inserare evidenta_clienti
			insert into dbo.evidenta_clienti (nume, prenume, cnp, email, telefon)
			values(@nume, @prenume, @cnp, @email, @telefon);

			update dbo.stoc_bilete
			set cantitate = cantitate - 1
			where tip_ticket = @tip_ticket;

			-- stoc_bilete_cumparate
			insert into dbo.stoc_bilete_cumparate (tip_ticket, serie_ticket, validare, data_achizitie)
			values(@tip_ticket, @serie_ticket, 0, GETDATE());
			commit transaction;
			end try
			begin catch
			rollback transaction;
			print error_message();
			end catch
		end;
go
