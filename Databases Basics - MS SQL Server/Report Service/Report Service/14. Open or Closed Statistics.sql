SELECT CONCAT(FirstName, ' ', LastName) AS [Name]
		CONCAT(SELECT EmployeeId
				FROM Reports 
				WHERE DATEPART(YEAR,OpenDate) = 2016 
				AND CloseDate IS NULL
				AND NOT EmployeeId IS NULL
				AND EmployeeId = Id, '/',
				
				(SELECT EmployeeId
					FROM Reports
					WHERE DATEPART(YEAR,CloseDate) = 2016
					AND NOT EmployeeId IS NULL
					AND EmployeeId = Id))
FROM Employees

-- Open Reports 



--CLosed Reports


