create database College_DB;
use College_DB;
create table stud(rno int,attendance int, name varchar(20),city varchar(20),)
insert into stud values(1,44,'amit','nagpur')
insert into stud values(2,46,'amrutesh','jalgaon')
insert into stud values(3,47,'akash','bhandara')
insert into stud values(4,44,'bhavesh','ramtek')
insert into stud values(5,32,'nigam','gondia')
insert into stud values(6,31,'rakesh','amravti')
insert into stud values(7,23,'rajnish','tumsar')
insert into stud values(8,50,'dipesh','nagpur')
insert into stud values(9,45,'nikhil','amravti')
insert into stud values(10,02,'shubham','nagpur')
select * from stud  

select name,rno,attendance from stud
order by rno desc

select * from stud 
order by city


select name, attendance, city from stud 
order by attendance desc,name asc

SELECT TOP 5
	name, 
    rno 
FROM
    stud
ORDER BY 
    name asc;


	--SELECT DISTINCT clause
	-- it is use for removing duplicates name
select distinct city from stud

select * from stud where rno>4
select * from stud where city ='nagpur'

select * from stud where name='dipesh'
select * from stud where attendance=44 and city='nagpur'
select * from stud where rno=4 or name= 'dipesh'

select * from stud

select * from stud where rno in (1,2,3,4,5)


