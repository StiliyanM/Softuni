SELECT  TOP 1 WITH TIES
		m.Name AS [Model Name],
		COUNT(*) AS [Times Serviced],
		(SELECT ISNULL(SUM(p.Price * op.Quantity),0)
			FROM Jobs j
			JOIN Orders o ON o.JobId = j.JobId
			JOIN OrderParts op ON op.OrderId = o.OrderId
			JOIN Parts p ON p.PartId = op.PartId
			WHERE j.ModelId = m.ModelId) AS [Parts Total]
			FROM Models m
JOIN Jobs j ON j.ModelId = m.ModelId
GROUP BY m.ModelId,m.Name
ORDER BY [Times Serviced] DESC

