SELECT p.Name AS ProductName,
		AVG(Rate) AS ProductAverageRate,
		d.Name AS DistributorName,
		c.Name AS DistributorCountry
FROM Products p
JOIN ProductsIngredients pi ON pi.ProductId = p.Id
JOIN Ingredients i ON i.Id = pi.IngredientId
JOIN Distributors d ON d.Id = i.DistributorId
JOIN Feedbacks f ON f.ProductId = p.Id
JOIN Countries c ON c.Id = d.CountryId
GROUP BY d.Name,p.Name,c.Name