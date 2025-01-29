create procedure Validare
@serie_ticket varchar(50)
as
begin

update dbo.stoc_bilete_cumparate
set validare = 1
where serie_ticket = @serie_ticket;

end;
go

