create database sample_country
use sample_country;
 create table country(country_id int primary key,country_name varchar(20)) 
 
 create table state(state_id int primary key,state_name varchar(20), country_id int,
 constraint c1 foreign key(country_id) references country(country_id))

 insert into country values(1, 'India')
 insert into country values(2, 'usa')
 insert into country values(3, 'canada')
 insert into country values(4, 'brazil')

 insert into state values(1, 'maharashtra',1)
 insert into state values(2, 'telengana',1)
 insert into state values(3, 'los angeles',2)
 insert into state values(4, 'new york',2)
 insert into state values(5, 'Ontario',3)
 insert into state values(6, 'Quebec',3)
 insert into state values(7, 'Rio de Janeiro',4)
 insert into state values(8, 'Piaui',4)


 create table city(city_id int primary key, city_name varchar(20),state_id int,
 constraint c2 foreign key(state_id) references state(state_id))

 insert into city values (1,'nagpur',1)
 insert into city values (2,'pune',1)
 insert into city values (3,'hyderabad',2)
 insert into city values (4,'nizamabad',2)
 insert into city values (5,'santa monica',3)
 insert into city values (6,'El monte',3)
 insert into city values (7,'brooklyn',4)
 insert into city values (8,'manhattan',4)
 insert into city values (9,'Ontario',5)
 insert into city values (10,'hamilton',5)
 insert into city values (11,'Montreal',6)
 insert into city values (12,'Sherbrooke',6)
 insert into city values (13,'São Gonçalo',7)
 insert into city values (14,'Volta Redonda',7)
 insert into city values (15,'Teresina',8)
 insert into city values (16,'Parnaíba',8)

 
 select c1.country_id,c1.country_name,c2.state_name 
 from country c1 inner join state c2 on c1.country_id=c2.country_id 
 where c1.country_name ='usa'

 select c2.state_name 
 from country c1 inner join state c2 on c1.country_id=c2.country_id 
 where c1.country_name ='usa'

 select city.city_name from city inner join state c2 on city.state_id=c2.state_id
 where c2.state_name='maharashtra'

 select * from state

 select state_name from state where country_id=1
 select country_id from  country where country_name='india'

 select state_id from state
 where state_name='Rio de Janeiro'
 select state_name from state where state_id=8

	select state_id,state_name 
	from state
	where state_id in 
	(select state_id from state where state='maharashtra')
