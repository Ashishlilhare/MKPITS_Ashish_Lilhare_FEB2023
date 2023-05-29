create database Project2
use Project2 

create table TableNation(NationID int Primary Key, NationaName varchar(500)) 

create table TableState(StateID int Primary key, NationID int, 
constraint a1 foreign key (NationID) references TableNation(NationID),StateName varchar(500))

create table TableCity(CityID int Primary key, StateID int,
constraint a2 foreign key(StateID) references TableState(StateID),CityName varchar(500))

create table TableCourseRegDetail(CourseRegID int Primary key identity, CategoryID int, 
FullName Varchar (1500),  GenderInd int)

Create table TableRegAddress(RegAddressID int primary key identity, CourseRegID int,
constraint a3 foreign key (CourseRegID) references TableCourseRegDetail(CourseRegID),
NationID int,
constraint a4 foreign key (NationID) references TableNation(NationID),
StateID int,
constraint a5 foreign key (StateID) references TableState(StateID),
CityID int,
constraint a6 foreign key (CityID) references TableCity(CityID))

create table TableFeeDetail( FeeID int primary key identity, CourseRegID int,
constraint a7 foreign key (CourseRegID) references TableCourseRegDetail(CourseRegID),
TotalAmount decimal(10,2), MinPer Decimal (10,2),PaidAmount Decimal (10,2),
BalAmount Decimal (10,2),Paidate Datetime) 

insert into TableNation values	(1,'Indian'),
								(2,'United-Nation'),
								(3,'Nepal'),
								(4,'Srilanka')

insert into TableState values	(101,1,'Andhra Pradesh'),
								(102,2,'Punjab'),
								(103,2,'California'),
								(104,2,'Florida'),
								(105,3,'Koshi'),
								(106,3,'Bagmati'),
								(107,4,'Colombo'),
								(108,4,'Ratnapura')
insert into TableCity values	(1001,101,'Visakhapatnam')
insert into TableCity values	(1002,101,'Vijayawada'),
								(1003,101,'Guntur'),
								(1004,102,'Amritsar'),
								(1005,102,'Jalandhar'),
								(1006,102,'Chandigarh'),
								(1007,103,'Los Angeles'),
								(1008,103,'San Jose'),
								(1009,103,'San Diego'),
								(1010,104,'Jacksonville'),
								(1011,104,'Miami'),
								(1012,104,'Tampa'),
								(1013,105,'damak'),
								(1014,105,'Dharan'),
								(1015,105,'Biratnagar'),
								(1016,106,'Banepa'),
								(1017,106,'Bharatpur'),
								(1018,106,'Hetauda'),
								(1019,107,'Grandpass'),
								(1020,107,'Borella'),
								(1021,107,'Pettah'),
								(1022,108,'Balangoda'),
								(1023,108,'Kolonna')

insert into TableCourseRegDetail values (4,1,'mk',1),
										(5,2,'mk2',2),
										(6,1,'ravi',1),
										(7,1,'anand',1),
										(8,1,'gaurav',1),
										(9,1,'Pranjali',2),
										(10,1,'mk3',1),
										(11,1,'mk4',1),
										(12,1,'mk4',1),
										(13,1,'mk6',1),
										(14,2,'dhananjay',1),
										(15,1,'m khan',1),
										(16,2,'ananya',2)

insert into TableRegAddress values	(1,4,4,102,1003),
									(2,6,4,104,1009),
									(3,6,4,102,1003),
									(4,4,4,104,1012),
									(5,8,2,104,1009),
									(6,8,2,104,1009),
									(7,9,2,103,1009),
									(8,9,2,103,1007)
insert into TableRegAddress values	(9,12,1,102,1006)
insert into TableRegAddress values	(10,13,1,101,1001),
									(11,14,4,107,1021),
									(12,15,2,104,1012),
									(13,16,1,101,1002)


insert into TableFeeDetail values	(1,4,100,0,500,500,'2023-04-10 00:00:00:001')
insert into TableFeeDetail values	(14,4,1000,0,500,500,'2023-04-04 00:00:00:001'),
									(2,4,3000,0,20,2980,'2023-04-04 00:00:00:000'),
									(3,4,1000,0,200,800,'2023-04-10 00:00:00:000'),
									(4,4,1000,0,500,500,'2023-04-10 00:00:00:000'),
									(5,4,1000,0,500,500,'2023-04-10 00:00:00:000'),
									(6,4,1000,0,500,500,'2023-04-10 00:00:00:000'),
									(7,4,1000,0,500,500,'2023-04-10 00:00:00:000'),
									(8,4,1000,0,500,500,'2023-04-10 00:00:00:000'),
									(9,12,1000,0,600,400,'2023-04-10 00:00:00:000'),
									(10,13,1000,500,600,400,'2023-04-10 00:00:00:000'),
									(11,14,3000,2400,2400,600,'2023-04-10 00:00:00:000'),
									(12,15,1000,500,500,500,'2023-04-10  00:00:00:000'),
									(13,16,3000,2400,2500,500,'2023-04-10 00:00:00:000')

