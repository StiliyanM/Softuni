SELECT Name as Game,
CASE 
When DATEPART(HOUR,Start) BETWEEN 0 AND 11 THEN 'Morning'
When DATEPART(HOUR,Start) BETWEEN 12 AND 17 THEN 'Afternoon'
When DATEPART(HOUR,Start) BETWEEN 18 AND 23 THEN 'Evening'
END AS [Part of the Day],
CASE
When Duration <=3 THEN 'Extra Short'
When Duration BETWEEN 4 AND 6 THEN 'Short'
When Duration >6 THEN 'Long'
ELSE 'Extra Long'
END as [Duration]
FROM Games
ORDER BY Name,
[Duration],
[Part of the Day]