CREATE FUNCTION udf_GetReportsCount(@employeeId INT, @statusId INT)
RETURNS INT
AS
BEGIN
	DECLARE @ReportsCount INT;
	SET @ReportsCount = (SELECT COUNT(*) FROM Reports
						WHERE EmployeeId = @employeeId AND StatusId = @statusId)
	RETURN @ReportsCount
END

