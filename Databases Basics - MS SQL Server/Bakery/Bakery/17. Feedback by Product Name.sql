CREATE FUNCTION udf_GetRating (@Name NVARCHAR(25))
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @Rating DECIMAL(6,2)
	SET @Rating = (SELECT AVG(Rate) FROM Products p
			JOIN Feedbacks f ON f.ProductId = p.Id
			GROUP BY p.Name
			HAVING p.Name = @Name)

	DECLARE @RatingWord VARCHAR(10);
	SET @RatingWord =
	CASE 
		WHEN @Rating IS NULL THEN 'No rating'
		WHEN @Rating BETWEEN 0 AND 5 THEN 'Bad'
		WHEN @Rating BETWEEN 5 AND 8 THEN 'Average'
	ELSE 'Good'
	END

	RETURN @RatingWord
END
GO

SELECT TOP 5 Id, Name, dbo.udf_GetRating(Name)
  FROM Products
 ORDER BY Id

