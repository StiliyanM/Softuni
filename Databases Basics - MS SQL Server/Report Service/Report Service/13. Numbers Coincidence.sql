SELECT  DISTINCT Username FROM Users u
JOIN Reports r ON r.UserId = u.Id
WHERE ISNUMERIC(LEFT(u.Username,1)) = 1 AND CAST(LEFT(u.Username,1) AS INT) = r.CategoryId
OR ISNUMERIC(RIGHT(u.Username,1)) = 1 AND CAST(RIGHT(u.Username,1) AS INT) = r.CategoryId
ORDER BY Username