DELETE FROM Products WHERE Id = 7
GO
CREATE TRIGGER tr_DeleteProduct
ON Products INSTEAD OF DELETE
AS
BEGIN
	DECLARE @ProductId INT
	SET @ProductId = (SELECT Id FROM deleted)
	DELETE FROM ProductsIngredients
	WHERE ProductId = @ProductId

	DELETE FROM Feedbacks
	WHERE ProductId = @ProductId

	DELETE FROM Products
	WHERE Id = @ProductId
END
GO