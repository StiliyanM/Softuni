  SELECT FirstName + ' ' + LastName AS [Mechanic Full Name],
		j.Status AS [Job Status],
		j.IssueDate AS [Job Issue Date]
FROM Mechanics m
JOIN Jobs j ON j.MechanicId = m.MechanicId
ORDER BY m.MechanicId,j.IssueDate,j.JobId