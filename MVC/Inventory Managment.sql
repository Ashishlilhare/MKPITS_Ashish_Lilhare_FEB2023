create database Inventory_managment

use Inventory_managment

Create table Product(id int primary key identity, product_name varchar(50) not null,
product_qnty varchar(5) not null)


Create table Purchase(id int primary key identity, purchase_prod varchar(50) not null,
purchase_qnty varchar(5) not null, purchase_date date not null)

Create table Sale(id int primary key identity, sale_prod varchar(50) not null,
sale_qnty varchar(5) not null, sale_date date not null)

select * from Product
select * from Purchase
select * from Sale

