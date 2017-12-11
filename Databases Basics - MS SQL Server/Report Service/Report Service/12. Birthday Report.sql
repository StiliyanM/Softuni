SELECT c.Name AS [Category Name] 
FROM Reports r
JOIN Users u ON u.Id = r.UserId
JOIN Categories c ON c.Id = r.CategoryId
WHERE DATEPART(DAYOFYEAR,u.BirthDate) = DATEPART(DAYOFYEAR,r.OpenDate)
ORDER BY [Category Name]

