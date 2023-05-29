create Database FendhalDb
use FendhalDb
--*creating table TableProductGSTDetails*--
create table TableProductGSTDetails (Product_GST_ID int primary key,Gst_Detail_Name varchar(500),CGST Decimal(10,2),SGST Decimal(10,2),IGST Decimal(10,2))

--*creating table TableProductCategory*--

create table TableProductCategory (Product_Category_ID int primary key, Product_Type_Name varchar (500),Product_GST_ID int,
constraint f1 foreign key (Product_GST_ID) references TableProductGSTDetails(Product_GST_ID))

--*creating table TableProduct*--
create table TableProduct(ProductID int primary key, ProductTypeID int,
constraint f2 foreign key (ProductTypeID) references TableProductCategory(Product_Category_ID),
ProductName varchar (500))

--*creating table TableInvoiceDetails*--
Create table TableInvoiceDetails(Invoice_Detail_ID int primary key, Customer_Name varchar(500), Customer_Contact varchar(15),Product_Category_ID int, 
constraint f3 foreign key (Product_Category_ID) references TableProductCategory(Product_Category_ID),
Product_ID int,
constraint f4 foreign key (Product_ID) references TableProduct(ProductID),
Residential_type_ID int, Invoice_Date datetime, Quantity Decimal(10,2),
price Decimal(10,2), CGST Decimal(10,2),SGST Decimal(10,2),IGST Decimal(10,2),
CGST_Value Decimal(10,2), SGST_Value Decimal(10,2),IGST_Value Decimal(10,2),
Total_Amount Decimal(10,2))

insert into TableProductGSTDetails values	(601,'AC and Fridge',14,14,14),
											(602,'Computers',9,9,9),
											(603,'Printers',9,9,9),
											(604,'Mobiles',6,6,6)

insert into TableProductCategory values		(1001,'Computer',602),
											(1002,'Mobiles',604),
											(1003,'Printers',603),
											(1004,'AC and Frindge',601)
insert into TableProduct values				(210,1002,'Apple'),
											(211,1002,'Lenove'),
											(212,1003,'Samsung'),
											(213,1004,'IFB'),
											(214,1004,'LG'),
											(215,1001,'Sony')

insert into TableInvoiceDetails values		(1,'Rahul','9185783214',1002,210,3001,'2023-04-04 00:00:00:000',1,50000,6,6,12,3000,3000,6000,56000),
											(12,'Nikita','7841824986',1001,211,3002,'2023-04-08 00:00:00:000',1,65000,9,9,18,11700,5850,5850,76700),
											(13,'Gopal','1234567890',1001,215,3003,'2023-04-12 00:00:00:000',1,60000,9,9,18,5400,5400,10800,70800),
											(14,'Anand','7387872895',1002,210,3004,'2023-04-14 00:00:00:000',1,40000,6,6,6,2400,2400,2400,42400)

select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct
select * from TableInvoiceDetails

ALTER TABLE TableProduct
ADD Product_price int;

UPDATE TableProduct
SET Product_price = 40000 where ProductName=Apple

UPDATE TableProduct
SET Product_price = 300000
WHERE ProductID=211;

UPDATE TableProduct
SET Product_price = 500000
WHERE ProductID=212;

UPDATE TableProduct
SET Product_price = 600000
WHERE ProductID=213;

UPDATE TableProduct
SET Product_price = 700000
WHERE ProductID=214;

UPDATE TableProduct
SET Product_price = 24000
WHERE ProductID=215;


Create table TableInvoiceDetails1(Invoice_Detail_ID int primary key identity, Customer_Name varchar(500), Customer_Contact varchar(15),Product_Category_ID int, 
constraint f5 foreign key (Product_Category_ID) references TableProductCategory(Product_Category_ID),
Product_ID int,
constraint f6 foreign key (Product_ID) references TableProduct(ProductID),
Residential_type_ID int, Invoice_Date datetime, Quantity Decimal(10,2),
price Decimal(10,2), CGST Decimal(10,2),SGST Decimal(10,2),IGST Decimal(10,2),
CGST_Value Decimal(10,2), SGST_Value Decimal(10,2),IGST_Value Decimal(10,2),
Total_Amount Decimal(10,2))

insert into TableInvoiceDetails1 values		(1,'Rahul','9185783214',1002,210,3001,'2023-04-04 00:00:00:000',1,50000,6,6,12,3000,3000,6000,56000),
											(12,'Nikita','7841824986',1001,211,3002,'2023-04-08 00:00:00:000',1,65000,9,9,18,11700,5850,5850,76700),
											(13,'Gopal','1234567890',1001,215,3003,'2023-04-12 00:00:00:000',1,60000,9,9,18,5400,5400,10800,70800),
											(14,'Anand','7387872895',1002,210,3004,'2023-04-14 00:00:00:000',1,40000,6,6,6,2400,2400,2400,42400)
