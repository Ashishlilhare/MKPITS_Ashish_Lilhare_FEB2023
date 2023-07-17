create table countries (country_Id int primary key identity, countryName varchar(50))

insert into countries values('USA')
insert into countries values('india'),('france')

select * from countries

create table state (state_Id int primary key identity, country_ID int,
Constraint a1 foreign key (country_ID) references countries (country_ID) ,
stateName varchar(50))

insert into state values(1,'california'), (1,'texas')
insert into state values(2,'Maharashtra'), (2,'Himachal Pradesh')
insert into state values(3,'Paris'), (3,'Corsica')

select * from state


