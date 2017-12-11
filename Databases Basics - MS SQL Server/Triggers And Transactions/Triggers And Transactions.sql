CREATE TRIGGER tr_AccountsInsert 
ON Accounts FOR UPDATE
AS
BEGIN
	INSERT INTO Logs(AccountId,OldSum,NewSum) 
	SELECT i.Id,d.Balance,i.Balance
	FROM inserted i
	JOIN deleted d ON d.Id = i.Id
END 
GO
CREATE TABLE NotificationEmails(
	Id INT PRIMARY KEY IDENTITY,
	Recipient INT NOT NULL,
	Subject VARCHAR(100) NOT NULL,
	Body VARCHAR(100) NOT NULL
)
GO
CREATE TRIGGER tr_EmailLogs ON Logs FOR INSERT
AS
BEGIN
INSERT INTO NotificationEmails (Recipient,Subject,Body)
SELECT AccountId,
'Balance change for account: ' + CONVERT(varchar(10), AccountId),
'ON ' + CONVERT(varchar(50),
GETDATE(),121) + '  your balance was changed from ' + CONVERT(varchar(20), OldSum) + ' to ' +CONVERT(varchar(20),NewSum) 
FROM Logs
END
GO 
UPDATE Accounts
SET Balance += 100
WHERE Id = 3
GO
CREATE PROC usp_DepositMoney @AccountId INT, @MoneyAmount DECIMAL(15,4)
AS
BEGIN
	BEGIN TRANSACTION

	--	IF(@MoneyAmount <= 0)
	--BEGIN
	--	RAISERROR('Zero or Negative Amount Specified',16,1)
	--	RETURN
	--END
	UPDATE Accounts
	SET Balance += @MoneyAmount
	WHERE Id = @AccountId

	IF(@@ROWCOUNT <> 1)
	BEGIN 
		RAISERROR('Invalid Account Id',16,2)
		ROLLBACK
		RETURN
	END

	COMMIT
END
GO
EXEC usp_DepositMoney 1,10
GO
CREATE PROC usp_WithdrawMoney @AccountId INT, @MoneyAmount DECIMAL(15,4)
AS
BEGIN
	BEGIN TRANSACTION

	--	IF(@MoneyAmount <= 0)
	--BEGIN
	--	RAISERROR('Zero or Negative Amount Specified',16,1)
	--	RETURN
	--END
	UPDATE Accounts
	SET Balance -= @MoneyAmount
	WHERE Id = @AccountId

	IF(@@ROWCOUNT <> 1)
	BEGIN 
		RAISERROR('Invalid Account Id',16,2)
		ROLLBACK
		RETURN
	END

	COMMIT
END
GO

CREATE PROC usp_TransferMoney @SenderId INT, @RecieverId INT, @MoneyAmount DECIMAL(15,4)
AS
BEGIN
	BEGIN TRANSACTION

	--	IF(@MoneyAmount <= 0)
	--BEGIN
	--	RAISERROR('Zero or Negative Amount Specified',16,1)
	--	RETURN
	--END
	UPDATE Accounts
	SET Balance -= @MoneyAmount
	WHERE Id = @SenderId

	IF(@@ROWCOUNT <> 1)
	BEGIN 
		RAISERROR('Invalid Account Id',16,2)
		ROLLBACK
		RETURN
	END

		UPDATE Accounts
	SET Balance += @MoneyAmount
	WHERE Id = @RecieverId

	IF(@@ROWCOUNT <> 1)
	BEGIN 
		RAISERROR('Invalid Account Id',16,2)
		ROLLBACK
		RETURN
	END

	COMMIT
END
GO

CREATE PROC usp_AssignProject(@emloyeeId INT, @projectID INT)
AS
BEGIN
	INSERT INTO EmployeesProjects VALUES
	(@emloyeeId,@projectID)

	DECLARE @EmployeeProjectCount INT =	(SELECT COUNT(*)
	FROM EmployeesProjects
	WHERE EmployeeID = @emloyeeId)

	IF(@EmployeeProjectCount > 3)
	BEGIN
		RAISERROR('The employee has too many projects!',16,1)
		ROLLBACK
	END
END
GO

CREATE TABLE Deleted_Employees(
	EmployeeId INT PRIMARY KEY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50),
	JobTitle VARCHAR(50) NOT NULL,
	DepartmentID INT NOT NULL,
	Salary MONEY NOT NULL
)
GO
CREATE TRIGGER tr_InsertIntoDeleted 
ON Employees FOR DELETE
AS
BEGIN
	INSERT INTO Deleted_Employees
	SELECT FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary
	FROM deleted
END