create database sample_custdetail
use sample_custdetail

create table  custdetail(custid	int primary key,custname varchar(20),state varchar(20),city varchar(20))

insert into custdetail values(1, 'samir','maharashtra','nagpur')
insert into custdetail values(2, 'rakesh','maharashtra','nagpur')
insert into custdetail values(3, 'harshit','maharashtra','nagpur')
insert into custdetail values(4, 'adil','mp','riva')
insert into custdetail values(5, 'shreyash','up','lucknow')
insert into custdetail values(6, 'sanu','up','varanasi')
insert into custdetail values(7, 'ramesh','mp','riva')
insert into custdetail values(8, 'ganesh','rajasthan','jaiselmer')
insert into custdetail values(9, 'krishna','rajasthan','jaiselmer')

exec sp_help custdetail

create table orders (orderid int , custid int,
constraint a1 foreign key(custid) references custdetail(custid),
orderdate date,
productname varchar(20),qty int)

insert into orders values(1,1,'2022-2-2','mouse',5)
insert into orders values(1,1,'2022-2-2','keyboard',5)
insert into orders values(2,2,'2022-2-2','desktop',5)
insert into orders values(2,2,'2022-2-2','ram',5)
insert into orders values(3,3,'2022-2-2','laptop',5)
insert into orders values(4,3,'2022-1-2','mouse',5)
insert into orders values(5,4,'2022-2-2','mouse',5)
insert into orders values(6,4,'2022-2-2','ram',5)
insert into orders values(7,6,'2022-2-2','desktop',5)
insert into orders values(7,5,'2022-2-2','ram',5)

select * from orders

select * from custdetail
select custname from custdetail where city='nagpur'

select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from custdetail where city='nagpur')

select orderid,custid, orderdate,productname,qty
from orders
where custid in
(select custname from custdetail where city='up')