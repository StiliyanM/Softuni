SELECT c.Name AS CountryName,
		d.Name AS DisributorName
FROM Countries c 
JOIN Distributors d ON d.CountryId = c.Id
JOIN Ingredients i ON i.DistributorId = d.Id
GROUP BY c.Name


SELECT c.Name AS CountryName,
		d.Name AS DisributorName,
		COUNT(*) AS CountOfIngredients
FROM Countries c 
JOIN Distributors d ON d.CountryId = c.Id
JOIN Ingredients i ON i.DistributorId = d.Id
GROUP BY c.Name, d.Name
ORDER BY CountryName