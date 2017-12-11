SELECT m.ModelId, m.Name,
		CONVERT(varchar,AVG(DATEDIFF(DAY,j.IssueDate,j.FinishDate))) + ' days' AS [Average Service Time]
FROM Models m
JOIN Jobs j ON j.ModelId = m.ModelId
GROUP BY m.ModelId,m.Name
ORDER BY AVG(DATEDIFF(DAY,j.IssueDate,j.FinishDate))