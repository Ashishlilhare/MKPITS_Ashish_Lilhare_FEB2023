select *from orders1
CREATE PROCEDURE prodS1

as 
begin
select * from orders1
end;

exec prodS1

--Modifying a stored procedure
ALTER PROCEDURE prodname
As 
begin
select prodname, quantity from orders1
order by quantity 
end;

exec prodname


create proc prod4(@minquantity as decimal)
as
begin
select * from orders1
where quantity > @minquantity
order by quantity
end;

exec prod4 2
exec prod4 2

