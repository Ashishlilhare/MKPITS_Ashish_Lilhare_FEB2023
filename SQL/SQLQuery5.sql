/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductID]
      ,[ProductTypeID]
      ,[ProductName]
      ,[Product_price]
  FROM [FendhalDb].[dbo].[TableProduct]

select a.cgst,a.sgst,a.igst from tableproductGSTDetails 
inner join TableProductCategory b
on a.product_gst_id=b.product_gst_id
where b.product_type_name='computers'