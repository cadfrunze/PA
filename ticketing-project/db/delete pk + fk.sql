create procedure delete_all
as
begin
declare @maxim int;
declare @current_id int;

select @maxim = MAX(idevidenta_clienti)
from dbo.evidenta_clienti;

if @maxim is not null
begin
set @current_id = 1;
while @current_id <= @maxim
begin
delete from dbo.stoc_bilete_cumparate where fk_idevidenta_clienti = @current_id;
delete  from dbo.evidenta_clienti where idevidenta_clienti = @current_id;
--print @current_id;

set @current_id = @current_id + 1;
end
end
begin try
alter table dbo.stoc_bilete_cumparate
drop constraint fk_idevidenta_clienti;
end try
begin catch
end catch;
begin try
alter table dbo.stoc_bilete_cumparate
drop constraint fk_idstoc_bilete;
end try
begin catch
end catch

dbcc checkident('evidenta_clienti', reseed, 0);
dbcc checkident('stoc_bilete_cumparate', reseed, 0);

end;
go

exec delete_all;


