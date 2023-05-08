create database bike_store
use bike_store
create table store(store_id int primary key,store_name varchar(20),phone int,email varchar(20),street varchar(20),city varchar(20),zip_code int )
create table categories(category_id int primary key,category_name varchar(20))
create table brand(brand_id int primary key, brand_name varchar(20))
create table products(product_id int primary key,product_name varchar(20),category_id int, 
constraint a1 foreign key(category_id) references categories(category_id),model_year int, list_price int)

create table stocks(store_id int primary key, product_id int,
constraint a2 foreign key(product_id) references products(product_id), quantity int)

create table customers(customer_id int primary key,first_name varchar(20),last_name varchar(20),
phone int,email varchar(20),street varchar(20), city varchar(20),state varchar(20),
zip_code varchar(20))

create table staffs(staff_id int primary key,first_name varchar(20),last_name varchar(20),
email varchar(20),phone int, active varchar(20), store_id int,
constraint a3 foreign key (store_id) references stocks(store_id),
manager_id varchar(20))

create table orders(order_id int primary key, customer_id int, 
constraint a4 foreign key(customer_id) references customers (customer_id),
order_status varchar(20),order_date date,required_date date, shipped_date date, 
store_id int,
constraint a5 foreign key(store_id) references store(store_id),
staff_id int,
constraint a6 foreign key (staff_id) references staffs(staff_id))

create table order_items(order_id int primary key, item_id int,product_id int,quantity int,list_price int, discount int)
