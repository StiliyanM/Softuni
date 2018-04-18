SELECT TOP 3
		m.FirstName + ' ' + m.LastName AS [Full Name],
		COUNT(*) AS [Jobs]
FROM Mechanics m
JOIN Jobs j ON j.MechanicId = m.MechanicId
WHERE NOT j.Status = 'Finished' 
GROUP BY m.MechanicId, m.FirstName + ' ' + m.LastName
HAVING COUNT(*) > 1
ORDER BY COUNT(*) DESC, m.MechanicId
