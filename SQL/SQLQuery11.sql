/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductID]
      ,[ProductTypeID]
      ,[ProductName]
      ,[Product_price]
  FROM [FendhalDb].[dbo].[TableProduct]

  select Product_price from TableProduct where ProductName='Apple'