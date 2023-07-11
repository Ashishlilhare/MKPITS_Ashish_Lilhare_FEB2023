create table employee (id int identity primary key, name varchar(50), city varchar(50), 
address varchar(50))


create procedure AddEmp    
(    
   @Name varchar (50),    
   @City varchar (50),    
   @Address varchar (50)    
)    
as    
begin    
   Insert into Employee values(@Name,@City,@Address)    
End   