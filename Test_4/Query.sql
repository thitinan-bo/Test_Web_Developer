


 SELECT dbo.tbl_employee.Name
 , CONVERT(varchar(10),dbo.tbl_TimeTick.timestamp,121) as 'Date'
 
 , MinTime.min_timestamp  as 'TimeIn'
 , MaxTime.max_timestamp  as 'TimeOut'


FROM dbo.tbl_employee
INNER JOIN dbo.tbl_TimeTick ON dbo.tbl_employee.ID = dbo.tbl_TimeTick.employee_ID

 INNER JOIN 
(
	SELECT employee_ID, MIN(timestamp) AS min_timestamp
	FROM dbo.tbl_TimeTick
	GROUP BY employee_ID   
) AS MinTime ON dbo.tbl_TimeTick.employee_ID = MinTime.employee_ID  
 
INNER JOIN 
(
	SELECT employee_ID, MAX(timestamp) AS max_timestamp
	FROM dbo.tbl_TimeTick
	GROUP BY employee_ID   
) AS MaxTime ON dbo.tbl_TimeTick.employee_ID = MaxTime.employee_ID 
 
  
 group by  dbo.tbl_employee.Name, MaxTime.max_timestamp ,MinTime.min_timestamp 
 , CONVERT(varchar(10),dbo.tbl_TimeTick.timestamp,121) 
 ORDER BY dbo.tbl_employee.Name 