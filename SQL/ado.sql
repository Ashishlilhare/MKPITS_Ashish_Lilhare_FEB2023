/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [LogID]
      ,[EmpID]
      ,[Operation]
      ,[UpdatedDate]
  FROM [practice].[dbo].[EmpLog]
  Create table login(username varchar(20),password varchar (20))