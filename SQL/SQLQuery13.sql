/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Product_Category_ID]
      ,[Product_Type_Name]
      ,[Product_GST_ID]
  FROM [FendhalDb].[dbo].[TableProductCategory]

  select p.productname from TableProduct p inner join TableProductCategory t on p.Product_Category_ID=t.Product_Category_ID where 
  t.Product_type_name ='computer'