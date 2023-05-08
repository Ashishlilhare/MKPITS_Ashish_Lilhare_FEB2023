create database college
 use college
 create table teachers(teacher_id int primary key, age int)
 create table subjects(teacher_id int, subject varchar(20),constraint f1 
 foreign key(teacher_id) references teachers(teacher_id))

 insert into teachers values(1,30)
 insert into subjects values(1,'chemistry')
 insert into subjects values(1,'biology')

 insert into teachers values(2,32)
 insert into subjects values(2,'maths')
 insert into subjects values(2,'account')

 insert into teachers values(3,26)
 insert into subjects values(3,'physics')
 insert into subjects values(3,'economics')

 insert into teachers values(4,27)
 insert into subjects values(4,'English')
 insert into subjects values(4,'spanish')

 select * from teachers
 select * from subjects

 --quenry to join two tables
 SELECT *
FROM teachers
JOIN subjects
ON teachers.teacher_id = subjects.teacher_id;
