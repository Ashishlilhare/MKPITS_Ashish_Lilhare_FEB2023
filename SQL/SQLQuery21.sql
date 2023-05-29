/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Product_Category_ID]
      ,[Product_Type_Name]
      ,[Product_GST_ID]
  FROM [FendhalDb].[dbo].[TableProductCategory]

  select p.productid, p.ProductName from TableProduct p inner join TableProductCategory t on 
  p.ProductTypeID = t.Product_Category_ID
  where t.Product_Type_Name='Computer';


  select productid, ProductName from TableProduct  inner join TableProductCategory  on 
  ProductTypeID = Product_Category_ID
  where Product_Type_Name='Computer';