SELECT EOMONTH ( dateadd( month, -1, getdate() ) ) AS Result; 
SELECT cast('1-' + cast (month (dateadd( month, -1, getdate() )) as varchar(2)) + '-' + cast (year (dateadd( month, -1, getdate() )) as varchar(4)) as date)