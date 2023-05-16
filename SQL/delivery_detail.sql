create database delivery_detail

create table Salesman(salesman_id int primary key,name varchar(20),city varchar(20),commission dec(10,2))

insert into Salesman values(5001,'James hoog','New york',0.15)
insert into Salesman values(5002,'Nail knite','Paris',0.13)
insert into Salesman values(5005,'Pit Alex','Landon',0.11)
insert into Salesman values(5006,'Mc Lyon','Paris',0.14)
insert into Salesman values(5003,'Lauson Hen','San jose',0.12)
insert into Salesman values(5007,'Paul Adam','Rome',0.13)
insert into Salesman values(50077,'Ptyaul Adam','Rome',0.13)



create table Customer(customer_id int primary key, cust_name varchar (20),city varchar (20),
grade int ,salesman_id int,
constraint f1 foreign key (salesman_id) references Salesman(salesman_id))

insert into Customer values(3002,'Nick Rimando','New york',100,5001)
insert into Customer values(3007,'Brad Davis','New york',200,5001)
insert into Customer values(3005,'Graham Zusi','California',200,5002)
insert into Customer values(3008,'Julian Green','London',300,5002)
insert into Customer values(3004,'Fabian Jhonson','Paris',300,5006)
insert into Customer values(3009,'Geoff Cameron','Berlin',100,5003)
insert into Customer values(3003,'Jozy Altidor','Moscow',200,5007)
insert into Customer values(3001,'Brad Guzan','London',500,5005)

create table Orders(ord_no int primary key,purch_amt dec(10,2),
ord_date date,customer_id int,
constraint f2 foreign key (customer_id) references Customer(customer_id),
salesman_id int,
constraint f3 foreign key(salesman_id) references Salesman(salesman_id))

insert into Orders values (70001,150.5,'2012-10-05',3005,5002)
insert into Orders values (70009, 270.65,'2012-09-10',3001,5005)
insert into Orders values (70002,65.26,'2012-10-05',3002,5001)
insert into Orders values (70004 ,110.5,'2012-08-17',3009,5003)
insert into Orders values (70007,948.5,'2012-09-10',3005,5002)
insert into Orders values (70005,2400.6,'2012-07-27',3007,5001)
insert into Orders values (70008,5760,'2012-09-10',3002,5001)
insert into Orders values (70010,1983.43,'2012-10-10',3004, 5006)
insert into Orders values (70003,2480.4,'2012-10-10',3009,5003)
insert into Orders values (70012,250.45,'2012-06-27',3008,5002)
insert into Orders values (70011,75.29,'2012-08-17',3003,5007)
insert into Orders values (70013,3045.6,'2012-04-25',3002,5001)


alter table Salesman alter column commission dec(10,2)
select * from Orders 
select * from Customer
Select * from Salesman

--------------1st query---------

select * 
from Orders 
where salesman_id=(
	select salesman_id 
	from Salesman
	where name='Paul Adam')
				

---------------------2nd query-----------
select *
from Orders
where salesman_id=(
	select salesman_id
	from Salesman
	where city='Landon')

---------------------3rd query-------------
select * 
from Orders
where salesman_id=(
		select salesman_id
		from Orders
		where customer_id=3007)

--------------4rth query---------------------
select * from Orders 
select * from Customer
Select * from Salesman

select *
from Orders
where purch_amt>
	(select AVG(purch_amt)
	from Orders
	where ord_date='2012-10-10')

----------------5th query-----------

select * 
from Orders
where salesman_id IN
	(select salesman_id
	from Salesman
	where city='New york')

--------------------6th-------------------
select commission
from Salesman
where salesman_id=
		(select salesman_id
		from Customer
		where city='Paris')
			

--------------------7th -------------------------

select * from Orders 
select * from Customer
Select * from Salesman

select * 
from Customer
where customer_id=
		(select salesman_id-2001
		from Salesman
		where name='MC Lyon')

----------------8th ---------------------
select grade, COUNT(*)
from Customer
group by grade
having grade>(select AVG(grade)
		from Customer
		where city ='New york')

----------------9th ---------------------
select ord_no, purch_amt, ord_date, salesman_id
from Orders
where salesman_id IN
		(select salesman_id
		from Salesman
		where commission=(
		select max(commission)
		from Salesman))

----------------10th---------------------------
select * from Orders

SELECT b.*, a.cust_name
FROM orders b, customer a
WHERE a.customer_id=b.customer_id
AND b.ord_date='2012-08-17';
 ------------------11th---------------
 SELECT salesman_id,name 
FROM salesman a 
WHERE 1 < 
    (SELECT COUNT(*) 
     FROM customer 
     WHERE salesman_id=a.salesman_id);

 ------------------121th---------------
