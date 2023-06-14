create database trustDB

drop table item_master
Use trustDB1
---!table Item_master!----
create table item_master(item_id int primary key identity ,item_name varchar(50) not null, category varchar(50) not null, 
rate int , balance_quantity int not null)
insert into item_master values('mobile','electronics',15000,12)
insert into item_master values('ram','computers',10000,10)
insert into item_master values('mouse','computers',150,10)


drop table department_mast
---!table Department_master!----
create table Department_mast(Department_id int primary key identity , Department_name varchar(50) not null)
insert into Department_mast values('sales')
insert into Department_mast values('accounting')





---!table Vendor_master!----

create table Vendor_mast( Vendor_id int primary key identity  ,Vendor_name varchar(50) not null)
insert into vendor_mast values('mkpits')
insert into vendor_mast values('shrishivam')


---!table Transaction!----

create table Transaction_details( Transaction_id int primary key identity , item_id int,
constraint a1 foreign key (item_id)  references item_master(item_id),
transaction_date datetime not null, 
Department_id int null,
constraint a2 foreign key (Department_id) references Department_mast(Department_id),
Vendor_id int null, 
constraint a3 foreign key (Vendor_id) references Vendor_mast(Vendor_id),
Quantity int not null)



