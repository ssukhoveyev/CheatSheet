DECLARE @date DATETIME = '12/1/2011';  
SELECT EOMONTH ( @date ) AS Result; 

--Дата минус месяц
select dateadd( month, -1, getdate() )

--Предыдущий месяц
select month (dateadd( month, -1, getdate() ))

--Предыдущий год
select year(dateadd( YEAR, -1, getdate() ))