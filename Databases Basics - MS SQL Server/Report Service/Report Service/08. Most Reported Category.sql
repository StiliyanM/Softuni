SELECT c.Name, 
		COUNT(*) AS ReportsNumber
FROM Categories c
RIGHT JOIN Reports r ON r.CategoryId = c.Id
GROUP BY c.Id,c.Name
ORDER BY ReportsNumber DESC, c.Name