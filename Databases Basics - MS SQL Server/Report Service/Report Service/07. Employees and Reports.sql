SELECT e.FirstName,
		e.LastName,
		r.Description,
		FORMAT(OpenDate,'yyyy-MM-dd')
FROM Employees e
JOIN Reports r ON r.EmployeeId = e.Id
GROUP BY r.EmployeeId, e.FirstName,e.LastName,r.Description,OpenDate, r.id
ORDER BY EmployeeId, OpenDate, r.Id