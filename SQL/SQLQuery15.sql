/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductID]
      ,[ProductTypeID]
      ,[ProductName]
      ,[Product_price]
  FROM [FendhalDb].[dbo].[TableProduct]
  select p.productName from TableProduct p inner join TableProductCategory t on  p.ProductTypeID = t.Product_Category_ID   where t.Product_Type_Name = @product_type_name