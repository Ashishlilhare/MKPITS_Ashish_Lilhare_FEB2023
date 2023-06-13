create database trustDB
Use trustDB
---!table Item_master!----
create table item_master(sr_no int Identity,item_id int primary key ,item_name varchar(50) not null, category varchar(50) not null, 
rate int , balance_quantity int not null)
insert into item_master values(12,'mobiles','electronics',15000,12)


---!table Department_master!----
create table Department_mast(sr_no int Identity,Department_id int primary key , Department_name varchar not null)


---!table Vendor_master!----

create table Vendor_mast(sr_no int Identity, Vendor_id int primary key  ,Vendor_name varchar(50) not null)

---!table Transaction!----

create table Transaction_details(sr_no int Identity, Transaction_id int primary key , item_id int,
constraint a1 foreign key (item_id)  references item_master(item_id),
transaction_date datetime not null, Department_id int null,
constraint a2 foreign key (Department_id) references Department_mast(Department_id),
Vendor_id int null, 
constraint a3 foreign key (Vendor_id) references Vendor_mast(Vendor_id),Quantity int not null)


