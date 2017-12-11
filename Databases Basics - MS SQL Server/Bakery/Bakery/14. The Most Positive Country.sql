SELECT TOP 1 WITH TIES
		c.Name AS CountryName,
		AVG(f.Rate) AS FeedbackRate
FROM Countries c
JOIN Customers cu ON cu.CountryId = c.Id
JOIN Feedbacks f ON f.CustomerId = cu.Id
GROUP BY c.Name 
ORDER BY FeedbackRate DESC
