CREATE PROCEDURE NewUser
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
			begin try
			alter table dbo.stoc_bilete_cumparate
			add constraint fk_idevidenta_clienti
			foreign key (fk_idevidenta_clienti)
			references dbo.evidenta_clienti(idevidenta_clienti);
			end try
			begin catch
			end catch
			begin try
			alter table dbo.stoc_bilete_cumparate
			add constraint fk_idstoc_bilete
			foreign key (fk_idstoc_bilete)
			references dbo.stoc_bilete(idstoc_bilete);
			end try
			begin catch
			print error_message();
			end catch
	
			begin try
			begin transaction
			declare @idevidenta_clienti int;
			
			-- inserare evidenta_clienti
			insert into dbo.evidenta_clienti (nume, prenume, cnp, email, telefon)
			values(@nume, @prenume, @cnp, @email, @telefon);
			set @idevidenta_clienti = SCOPE_IDENTITY();
			--commit transaction;
			--print @idevidenta_clienti;
			

			
			declare @id_stoc int;
			update dbo.stoc_bilete
			set cantitate = cantitate - 1
			where tip_ticket = @tip_ticket;
			--print @tip_ticket;

			select  @id_stoc = idstoc_bilete
			from dbo.stoc_bilete
			where @tip_ticket = tip_ticket;
			--commit transaction;
			--print @id_stoc;
			
			if @id_stoc is null
			begin
			print @id_stoc;
			update dbo.stoc_bilete
			set cantitate = cantitate - 1
			where tip_ticket = @tip_ticket;
			--print @tip_ticket;

			select  @id_stoc = idstoc_bilete
			from dbo.stoc_bilete
			where @tip_ticket = tip_ticket;
			rollback transaction;
			return;
			end;
			

			-- stoc_bilete_cumparate
			insert into dbo.stoc_bilete_cumparate (tip_ticket, serie_ticket, validare, data_achizitie, fk_idevidenta_clienti, fk_idstoc_bilete)
			values(@tip_ticket, @serie_ticket, 0, GETDATE(), @idevidenta_clienti, @id_stoc);
			commit transaction;
			end try
			begin catch
			print error_message();
			rollback transaction;
			
			end catch
		end;
go

exec NewUser
@nume = 'test', 
@prenume = 'test', 
@cnp = '1234567890123', 
@email = 'test.test@email.com', 
@telefon = 'test', 
@tip_ticket = 'premium', 
@serie_ticket = 'ABC123';
