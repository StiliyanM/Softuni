CREATE VIEW v_UserWithCountries 
AS
SELECT CONCAT(c.FirstName,' ',c.LastName) AS CustomerName,
		c.Age,
		c.Gender,
		cou.Name AS CountryName
FROM Customers c
JOIN Countries cou ON cou.Id = c.CountryId