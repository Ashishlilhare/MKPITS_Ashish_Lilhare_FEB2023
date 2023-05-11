create table employee (empid int primary key, empname varchar(20))

CREATE TABLE EmpLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL	
)

create trigger empt
on employee
for insert
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'insert',GETDATE() from inserted;

insert into employee values(11,'amit')
select * from employee
select * from emplog


insert into employee values(14,'amita')
select * from employee
select * from emplog

insert into employee values(01,'amruta')

delete employee where empname ='amruta'
select * from employee
select * from emplog


create trigger empto
on employee
for delete
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'delete',GETDATE() from deleted;

drop trigger empto

create trigger emptos
on employee
for delete
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'delete',GETDATE() from deleted;


insert into employee values(15,'amitabh')
insert into employee values(5,'samar')
insert into employee values(7,'samir')
select * from employee
select * from emplog

delete employee where empname ='samar'
select * from employee
select * from emplog

create trigger empu
on employee
for update
as insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'updated',GETDATE() from deleted;

select * from employee
update employee set empname='amitabh' where empid=11

create trigger empuu
on employee
for update
as insert into emplog(EmpID,Operation,UpdatedDate)
select empid,'updated',GETDATE() from deleted;

select * from employee
update employee set empname='amitabh' where empid=11

select * from employee
select * from emplog