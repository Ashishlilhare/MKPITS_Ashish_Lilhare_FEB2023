create database pro_DB;
use pro_DB;

create table orderdeal1(order_no int primary key,oderdate varchar(20),cust_id int);
create table order_info(order_no int,prod_id int,rate int,qntity int, constraint a1 
foreign key(order_no) references orderdeal1(order_no));

insert into orderdeal1 values(1,'1-10-2023',211)
insert into order_info values(1,111,500,5)
insert into order_info values(1,121,250,4)
insert into order_info values(1,114,300,6)

insert into orderdeal1 values(2,'3-10-2023',311)
insert into order_info values(2,211,500,6)
insert into order_info values(2,221,250,2)
insert into order_info values(2,214,300,1)

insert into orderdeal1 values(3,'5-10-2023',411)
insert into order_info values(3,311,700,5)
insert into order_info values(3,321,650,4)
insert into order_info values(3,314,300,6)

insert into orderdeal1 values(4,'7-10-2023',411)
insert into order_info values(4,411,700,5)
insert into order_info values(4,321,650,4)
insert into order_info values(4,314,300,6)

select * from orderdeal1
select * from order_info 


