CREATE PROC usp_GetEmployeesSalaryAbove35000 
AS
BEGIN
	SELECT FirstName, LastName
	FROM Employees
	WHERE Salary > 35000
END

GO

CREATE PROC usp_GetEmployeesSalaryAboveNumber @Number DECIMAL(18,4) 
AS
BEGIN
	SELECT FirstName, LastName
	FROM Employees
	WHERE Salary >= @Number
END
GO

CREATE PROC usp_GetTownsStartingWith @String VARCHAR(50)
AS
BEGIN
	SELECT Name AS Town
	FROM Towns
	WHERE LEFT(Name,LEN(@String)) = @String
END
GO
CREATE PROC usp_GetEmployeesFromTown @TownName VARCHAR(50)
AS
BEGIN
	SELECT FirstName,LastName
	FROM Employees AS e
	JOIN Addresses AS a ON a.AddressID = e.AddressID
	JOIN Towns AS t ON t.TownID = a.TownID
	WHERE t.Name = @TownName
END
GO

CREATE FUNCTION dbo.ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @salaryLevel VARCHAR(10)
IF (@salary < 30000)
SET @salaryLevel = 'Low'

ELSE IF(@salary >= 30000 AND @salary <= 50000)
SET @salaryLevel = 'Average'

ELSE SET @salaryLevel = 'High'

RETURN @salaryLevel
END
GO
CREATE PROC usp_EmployeesBySalaryLevel @SalaryLevel VARCHAR(10)
AS
BEGIN
	SELECT FirstName,LastName
	FROM Employees
	WHERE dbo.ufn_GetSalaryLevel(Salary) = @SalaryLevel
END
GO
CREATE PROC usp_GetHoldersFullName 
AS
BEGIN
	SELECT FirstName + ' ' + LastName AS [Full Name]
	FROM AccountHolders
END
GO

CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan(@value MONEY)
 AS
 BEGIN 
 SELECT ah.FirstName, ah.LastName FROM AccountHolders AS ah
 LEFT JOIN Accounts AS a ON a.AccountHolderId = ah.Id
 GROUP BY ah.FirstName, ah.LastName
 HAVING SUM(a.Balance) > @value
 END
 GO

CREATE FUNCTION ufn_CalculateFutureValue (@I MONEY, @R FLOAT, @T INT)
RETURNS DECIMAL(15,4)
AS
BEGIN
	DECLARE @FutureValue DECIMAL(15,4) = @I * POWER(1 + @R,@T);
	RETURN @FutureValue
END
GO

SELECT dbo.ufn_CalculateFutureValue(1000, 0.10, 5)


GO
CREATE PROC usp_DeleteEmployeesFromDepartment @DepartmentId INT
AS
BEGIN
	DELETE FROM Employees
	WHERE DepartmentId = @DepartmentId

	DELETE FROM Departments
	WHERE DepartmentId = @DepartmentId
END
GO
CREATE FUNCTION ufn_IsWordComprised (@SetOfLetters VARCHAR(50), @Word VARCHAR(50))
RETURNS BIT
AS
BEGIN
	DECLARE @IsComprised BIT = 0;

	DECLARE @SetOfLettersTest VARCHAR(50) = @SetOfLetters;
	DECLARE @WordTest VARCHAR(50) = @Word;

	DECLARE @LettersInWordTest INT = LEN(@WordTest);
	DECLARE @CountEqualLetters INT = 0;
	DECLARE @Count INT = 1;

	WHILE(@CountEqualLetters <> @LettersInWordTest)
	BEGIN
		DECLARE @Letter VARCHAR(50) = '%' + SUBSTRING(@WordTest,@Count,1) + '%';
		IF(@SetOfLettersTest LIKE @Letter)
		BEGIN
			SET @CountEqualLetters += 1;
			SET @Count += 1;
		END
		ELSE BREAK
	END

	IF(@LettersInWordTest = @CountEqualLetters)
	BEGIN
		SET @IsComprised = 1;
	END
	
	RETURN @IsComprised;
END
GO
USE Bank
GO
SELECT * FROM AccountHolders

GO
CREATE PROC usp_CalculateFutureValueForAccount @AccountId INT, @InterestRate FLOAT
AS
BEGIN
	SELECT a.Id AS AccountId,
			ah.FirstName AS [First Name],
			ah.LastName AS [Last Name],
			a.Balance AS [Current Balance],
			dbo.ufn_CalculateFutureValue(a.Balance,@InterestRate,5) AS [Balance in 5 years]
	FROM AccountHolders AS ah
	JOIN Accounts AS a ON a.AccountHolderId = ah.Id
	WHERE a.Id = @AccountId
END
GO

EXEC usp_CalculateFutureValueForAccount 1,0.1