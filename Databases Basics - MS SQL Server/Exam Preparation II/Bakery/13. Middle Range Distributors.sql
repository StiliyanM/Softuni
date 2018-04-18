SELECT d.Name AS DistributorName,
		i.Name AS IngredientName,
		p.Name AS ProductName,
		AVG(f.Rate) AS AverageRate
FROM Distributors d
JOIN Ingredients i ON i.DistributorId = d.Id
JOIN ProductsIngredients [pi] ON pi.IngredientId = i.Id
JOIN Products p ON p.Id = pi.ProductId
JOIN Feedbacks f ON f.ProductId = p.Id
GROUP BY d.Name,i.Name,p.Name,pi.ProductId
HAVING pi.ProductId IN (SELECT Id FROM Products)
AND AVG(f.Rate) BETWEEN 5 AND 8
ORDER BY DistributorName,IngredientName,ProductName
