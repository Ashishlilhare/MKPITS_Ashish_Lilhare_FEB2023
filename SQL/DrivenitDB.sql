create database DrivenitDB

use DrivenitDB

create table ItemMaster(ItemID int identity(1,1) primary key NOT NULL,
ItemDescr nvarchar(100) NULL,
BalQty int NULL,
CreatedOn Datetime)

create table Transactions(TransID int identity(1,1) primary key NOT NULL,
ItemID int NOT NULL,
constraint a1 foreign key (ItemID) references ItemMaster(ItemID),
TransType char(1) NOT NULL ,
TransQty int,
TransDate datetime)

insert into table values('mouse',10,'10/6/2023')
insert into table values('keyboard',15,'1/5/2023')
insert into table values('monitor',8,'23/4/2023')
insert into table values('usb',4,'18/6/2023')
insert into table values('cables',20,'1/6/2023')



