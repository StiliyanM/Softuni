CREATE PROC usp_AssignEmployeeToReport(@employeeId INT, @reportId INT)
AS
BEGIN

	DECLARE @EmployeeDepartmentId INT
	SET @EmployeeDepartmentId = (SELECT DepartmentId FROM Employees WHERE Id = @employeeId)
	
	IF(@EmployeeDepartmentId IS NULL)
	BEGIN
			RAISERROR('Employee doesn''t belong to the appropriate department!',16,1);
		RETURN;
	END

	DECLARE @CategoryId INT
	SET @CategoryId = (SELECT DISTINCT CategoryId FROM Reports WHERE Id = @reportId)

		IF(@CategoryId IS NULL)
	BEGIN
			RAISERROR('Employee doesn''t belong to the appropriate department!',16,1);
		RETURN;
	END

	DECLARE @CategoryDepartmentId INT
	SET @CategoryDepartmentId = (SELECT DISTINCT DepartmentId FROM Reports r
								JOIN Categories c ON c.Id = r.CategoryId
								WHERE EmployeeId = @employeeId
								AND CategoryId = @CategoryId)

			IF(@CategoryDepartmentId IS NULL)
	BEGIN
			RAISERROR('Employee doesn''t belong to the appropriate department!',16,1);
		RETURN;
	END
BEGIN TRAN
	UPDATE Reports
	SET EmployeeId = @employeeId
	WHERE Id = @reportId

	IF(@EmployeeDepartmentId <> @CategoryDepartmentId)
	BEGIN
		RAISERROR('Employee doesn''t belong to the appropriate department!',16,1);
		ROLLBACK;
		RETURN;
	END
	COMMIT
END
GO
EXEC usp_AssignEmployeeToReport -5, 42;

SELECT * FROM Reports

SELECT DISTINCT DepartmentId FROM Reports r
JOIN Categories c ON c.Id = r.CategoryId
WHERE EmployeeId = 17
AND CategoryId = 2