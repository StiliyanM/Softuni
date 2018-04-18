SELECT p.PartId,
		SUM(pn.Quantity) AS [Required],
		SUM(p.StockQty) AS [In Stock]
FROM Parts p
JOIN OrderParts op ON op.PartId = p.PartId
JOIN Orders as o ON o.OrderId = op.OrderId
JOIN Jobs j ON j.JobId = o.JobId
JOIN PartsNeeded pn ON pn.JobId = j.JobId AND pn.PartId = p.PartId
WHERE j.Status <> 'Finished'
GROUP BY p.PartId
