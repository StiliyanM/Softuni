SELECT c.FirstName + ' ' + c.LastName AS [Client],
		DATEDIFF(DAY,j.IssueDate,'04/24/2017') AS [Days Going],
		j.Status
FROM Clients c
JOIN Jobs j ON j.ClientId = c.ClientId
WHERE NOT j.Status = 'Finished'
ORDER BY [Days Going] DESC, c.ClientId