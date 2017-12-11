SELECT f.ProductId,
		f.Rate,
		f.Description,
		f.CustomerId,
		c.Age,
		c.Gender
 FROM Feedbacks f
JOIN Customers c ON c.Id = f.CustomerId
WHERE f.Rate < 5
ORDER BY ProductId DESC, Rate