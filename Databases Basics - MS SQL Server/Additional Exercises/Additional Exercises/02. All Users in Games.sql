SELECT g.Name AS Game,
		gt.Name AS [Game Type],
		u.Username,
		ug.Level,
		ug.Cash,
		c.Name AS Character
FROM Games g
JOIN UsersGames ug ON ug.GameId = g.Id
JOIN Users u ON u.Id = ug.UserId
JOIN GameTypes gt ON gt.Id = g.GameTypeId
JOIN Characters c ON c.Id = CharacterId
ORDER BY Level DESC, Username,Game