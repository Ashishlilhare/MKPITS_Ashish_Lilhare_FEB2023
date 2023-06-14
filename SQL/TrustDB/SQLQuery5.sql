/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Transaction_id]
      ,[item_id]
      ,[transaction_date]
      ,[Department_id]
      ,[Vendor_id]
      ,[Quantity]
  FROM [trustdb1].[dbo].[Transaction_details]

  select * from item_master