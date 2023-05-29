/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Product_Category_ID]
      ,[Product_Type_Name]
      ,[Product_GST_ID]
  FROM [FendhalDb].[dbo].[TableProductCategory]

  /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Product_GST_ID]
      ,[Gst_Detail_Name]
      ,[CGST]
      ,[SGST]
      ,[IGST]
  FROM [FendhalDb].[dbo].[TableProductGSTDetails]


    select a.cgst,a.sgst,a.igst from tableproductGSTDetails a inner join TableProductCategory b on a.product_gst_id=b.product_gst_id where b.product_type_name='AC and frindge'
