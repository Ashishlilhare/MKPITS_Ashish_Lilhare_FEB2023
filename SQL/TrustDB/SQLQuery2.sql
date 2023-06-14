/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [item_id]
      ,[item_name]
      ,[category]
      ,[rate]
      ,[balance_quantity]
  FROM [trustDB].[dbo].[item_master]

  truncate table item_master