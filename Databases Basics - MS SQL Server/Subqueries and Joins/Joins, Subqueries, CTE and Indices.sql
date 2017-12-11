USE SoftUni

SELECT TOP 5
 e.EmployeeID,e.JobTitle,e.AddressID, a.AddressText
FROM Employees AS e
JOIN Addresses AS a ON a.AddressID = e.AddressID
ORDER BY AddressID

SELECT TOP 50
	  e.FirstName,e.LastName, 
	  t.Name AS Town,
	  a.AddressText
FROM Employees AS e
JOIN Addresses AS a ON a.AddressID = e.AddressID
JOIN Towns AS t ON t.TownID = a.TownID
ORDER BY e.FirstName,e.LastName

SELECT e.EmployeeID,
		e.FirstName, 
		e.LastName, 
		d.Name AS DepartmentName
FROM Employees AS e
JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'
ORDER BY EmployeeID

SELECT TOP 5
		e.EmployeeID,
		e.FirstName, 
		e.Salary, 
		d.Name AS DepartmentName
FROM Employees AS e
JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE e.Salary > 15000
ORDER BY d.DepartmentID

SELECT TOP 3
	e.EmployeeID, e.FirstName
FROM Employees AS e
LEFT JOIN EmployeesProjects ep ON ep.EmployeeID = e.EmployeeID
WHERE ep.EmployeeID IS NULL
ORDER BY e.EmployeeID

SELECT 	e.FirstName, 
		e.LastName, 
		e.HireDate,
		d.Name AS DeptName
FROM Employees AS e
JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE d.DepartmentID IN (3,10)
ORDER BY e.HireDate

SELECT TOP 5
	e.EmployeeID, e.FirstName,
	p.Name AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects ep ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS p ON p.ProjectID = ep.ProjectID
WHERE p.StartDate > '08/13/2002'
ORDER BY e.EmployeeID

SELECT e.EmployeeID, 
		e.FirstName,
IIF(p.StartDate > '2005-01-01', NULL, p.Name) AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects ep ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS p ON p.ProjectID = ep.ProjectID
WHERE e.EmployeeID = 24
ORDER BY e.EmployeeID

SELECT e.EmployeeID,e.FirstName,e.ManagerID, ep.FirstName 
FROM Employees AS e
JOIN Employees AS ep ON ep.EmployeeID = e.ManagerID
WHERE e.ManagerID IN (3,7)
ORDER BY e.EmployeeID

SELECT TOP 50
	e.EmployeeID,
	e.FirstName + ' ' + e.LastName AS EmployeeName,
	m.FirstName + ' ' + m.LastName AS ManagerName, 
	d.Name AS DepartmentName 
FROM Employees AS e
JOIN Employees AS m ON m.EmployeeID = e.ManagerID
JOIN Departments as d ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID

SELECT TOP 1
	AVG(Salary) AS MinAverageSalary
FROM Employees
GROUP BY DepartmentID
ORDER BY AVG(Salary)

USE Geography

SELECT mc.CountryCode, m.MountainRange,p.PeakName, p.Elevation
FROM MountainsCountries AS mc
JOIN Mountains AS m ON m.Id = mc.MountainId
JOIN Peaks AS p ON p.MountainId = mc.MountainId
WHERE mc.CountryCode = 'BG' 
AND   p.Elevation > 2835
ORDER BY p.Elevation DESC

SELECT mc.CountryCode,
		COUNT(m.MountainRange) AS MountainRanges
FROM MountainsCountries AS mc
JOIN Mountains AS m ON m.Id = mc.MountainId
GROUP BY CountryCode
HAVING mc.CountryCode IN ('US','RU','BG')

SELECT TOP 5
		c.CountryName,
		r.RiverName
FROM Countries AS c
LEFT JOIN CountriesRivers ON CountriesRivers.CountryCode = c.CountryCode
LEFT JOIN Rivers AS r ON r.Id = CountriesRivers.RiverId
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName

SELECT COUNT(c.CountryCode) AS CountryCode
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
WHERE mc.MountainId IS NULL

USE Geography

SELECT TOP 5
		c.CountryName, 
		MAX(p.Elevation) AS HighestPeakElevation,
		MAX(r.Length) AS LongestRiverLength
FROM Countries AS c
JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
JOIN Peaks AS p ON p.MountainId = mc.MountainId
JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY HighestPeakElevation DESC, LongestRiverLength DESC, c.CountryName

SELECT TOP 5
		c.CountryName AS Country, 
		ISNULL(p.PeakName,'(no highest peak)') AS [Highest Peak Name],
		ISNULL(MAX(p.Elevation),0) AS [Highest Peak Elevation],
		ISNULL(m.MountainRange,'(no mountain)') AS Mountain
FROM Countries AS c
JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
JOIN Peaks AS p ON p.MountainId = mc.MountainId
JOIN Mountains AS m ON m.Id = mc.MountainId
GROUP BY c.CountryName
ORDER BY Country, [Highest Peak Name]