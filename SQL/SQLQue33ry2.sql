/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EMPLOYEE_ID]
      ,[FIRST_NAME]
      ,[LAST_NAME]
      ,[EMAIL]
      ,[PHONE_NUMBER]
      ,[HIRE_DATE]
      ,[JOB_ID]
      ,[SALARY]
      ,[COMMISSION_PCT]
      ,[MANAGER_ID]
      ,[DEPARTMENT_ID]
      ,[F12]
      ,[F13]
      ,[F14]
      ,[F15]
  FROM [bike_store].[dbo].[Sheet1$]
 exec  sp_help sheet1$