SELECT ISNULL(SUM(p.Price * op.Quantity),0) AS [Parts Total]
FROM Parts p
JOIN OrderParts op ON op.PartId = p.PartId
JOIN Orders o ON o.OrderId = op.OrderId
WHERE o.IssueDate > DATEADD(WEEK,-3,'04-24-2017')
