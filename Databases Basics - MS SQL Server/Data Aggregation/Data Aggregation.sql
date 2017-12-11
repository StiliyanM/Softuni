SELECT * FROM WizzardDeposits

SELECT SUBSTRING(FirstName,1,1) AS FirstLetter
FROM WizzardDeposits
GROUP BY SUBSTRING(FirstName,1,1),DepositGroup
HAVING DepositGroup = 'Troll Chest'
ORDER BY FirstLetter

SELECT DepositGroup, IsDepositExpired, 
FROM WizzardDeposits

SELECT ageGroups.AgeGroup, COUNT(*) FROM
(
SELECT 
CASE
WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
WHEN Age >= 61 THEN '[61+]'
END AS AgeGroup
FROM WizzardDeposits
) AS ageGroups
GROUP BY ageGroups.AgeGroup


USE SoftUni

SELECT DepartmentID, SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID

SELECT DepartmentID, MIN(Salary) AS MinimumSalary
FROM Employees
WHERE HireDate > 01/01/2000
GROUP BY DepartmentID
HAVING DepartmentID IN (2,5,7)

SELECT * FROM Employees

SELECT * INTO NewTable FROM Employees
WHERE Salary > 30000

DELETE FROM NewTable
WHERE ManagerId = 42

UPDATE NewTable
SET Salary += 5000
WHERE DepartmentID = 1
SELECT DepartmentID, AVG(Salary) AS AverageSalary FROM NewTable
GROUP BY DepartmentID

SELECT DepartmentID, MAX(Salary) AS MaxSalary
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

SELECT COUNT(Salary) AS Count
FROM Employees
WHERE ManagerID is NULL

USE Gringotts

SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS AverageInterest
FROM WizzardDeposits
WHERE DepositStartDate > '1985/1/1'
GROUP BY DepositGroup,IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired
