SELECT TOP 15
		i.Name,
		Description,
		c.Name AS CountryName
FROM Ingredients i
JOIN Countries c ON c.Id = i.OriginCountryId
WHERE c.Name IN ('Bulgaria','Greece')
ORDER BY i.Name, CountryName