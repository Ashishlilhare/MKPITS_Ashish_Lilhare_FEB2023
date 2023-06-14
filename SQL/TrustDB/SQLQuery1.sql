/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [sr_no]
      ,[Vendor_id]
      ,[Vendor_name]
  FROM [trustDB].[dbo].[Vendor_mast]
alter table vendor_mast drop column sr_no

select * from vendor_mast
select * from department_mast

alter table department_mast drop column sr_no

select * from item_master
alter table item_master drop column sr_no


select * from Transaction_details
alter table transaction_details drop column sr_no



