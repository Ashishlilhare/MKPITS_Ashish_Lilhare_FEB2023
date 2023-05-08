create database sample_class
use sample_class

create table course(course_id int primary key, course_name varchar(20))

create table data(rollno int primary key, name varchar(20), course_id int,
constraint s1 foreign key(course_id) references course(course_id))

insert into course values(1,'dotnet')
insert into course values(2,'java')
insert into course values(3,'python')

insert into data values(1,'ashish',1)
insert into data values(2,'jayesh',1)
insert into data values(3,'achal',2)
insert into data values(4,'amruta',2)
insert into data values(5,'sam',3)
insert into data values(6,'vijay',3)

select name from data where rollno =2
select course_name from course where course_id=2

select * from course



