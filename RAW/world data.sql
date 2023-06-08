/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [city]
      ,[city_ascii]
      ,[lat]
      ,[lng]
      ,[country]
      ,[iso2]
      ,[iso3]
      ,[admin_name]
      ,[capital]
      ,[population]
      ,[id]
  FROM [country_data].[dbo].[Sheet1$]

  select city_ascii 
  from Sheet1$ 
  where admin_name=delhi

  SELECT city_ascii
FROM Sheet1$
WHERE admin_name = 'Delhi';

Select country 
from sheet1$
select * from sheet1$
select country from sheet1$ where city='Tokyo'

select country from sheet1$