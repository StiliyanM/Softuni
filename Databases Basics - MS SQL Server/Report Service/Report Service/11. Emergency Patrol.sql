SELECT r.OpenDate,
		r.Description,
		u.Email AS [Reporter Email]
FROM Reports r
JOIN Categories c ON c.Id = r.CategoryId
JOIN Departments d ON d.Id = c.DepartmentId
JOIN Users u ON u.Id = r.UserId
WHERE CloseDate IS NULL 
AND LEN(Description) > 20 AND Description LIKE '%str%'
AND d.Id IN (1,4,5)
ORDER BY OpenDate,[Reporter Email], r.Id


SELECT * FROM Reports