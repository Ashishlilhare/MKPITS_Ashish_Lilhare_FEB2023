/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Product_Category_ID]
      ,[Product_Type_Name]
      ,[Product_GST_ID]
  FROM [FendhalDb].[dbo].[TableProductCategory]

  select product_type_name from TableProductCategory