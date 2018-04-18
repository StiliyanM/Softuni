SELECT f.ProductId,
		CONCAT(c.FirstName, ' ',c.LastName) AS CustomerName,
		ISNULL(f.Description,'') AS FeedbackDescription
FROM Feedbacks f
JOIN Customers c ON c.Id = f.CustomerId
WHERE c.Id IN (SELECT CustomerId FROM Feedbacks
				GROUP BY CustomerId
				HAVING COUNT(*) > 2)
ORDER BY f.ProductId,CustomerName,f.Id



