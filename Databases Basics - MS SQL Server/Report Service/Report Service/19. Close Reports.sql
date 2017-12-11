CREATE TRIGGER tr_ChangeStatus 
ON Status AFTER UPDATE
AS
BEGIN
	UPDATE Reports
	SET StatusId = 3
	WHERE Id IN (SELECT Id FROM inserted)
END

UPDATE Reports
SET
CloseDate = '12/10/2017'
WHERE Id = 3;
