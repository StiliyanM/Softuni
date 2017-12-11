SELECT CONCAT(e.FirstName,' ',e.LastName) AS Name
		,ISNULL(COUNT(DISTINCT r.UserId),0) AS [Users Number]
FROM Employees e
LEFT JOIN Reports r ON r.EmployeeId = e.Id
GROUP BY e.Id, CONCAT(e.FirstName,' ',e.LastName)
ORDER BY [Users Number] DESC, Name

