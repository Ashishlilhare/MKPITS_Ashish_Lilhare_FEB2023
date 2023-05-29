/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [NationID]
      ,[NationaName]
  FROM [Project2].[dbo].[TableNation]

  select s.stateID,s.StateName from tableState s inner join 
  tableNation n on s.NationID=n.NationID where n.NationaName ='indian'

  select s.stateID,s.StateName from tableState s inner join tableNation n
  on s.NationID=n.NationID where n.NationaName ='indian' 

  select c.CityName,c.cityID from tablecity c inner join 
  tableState s on c.stateID=s.stateID where s.statename='Punjab'