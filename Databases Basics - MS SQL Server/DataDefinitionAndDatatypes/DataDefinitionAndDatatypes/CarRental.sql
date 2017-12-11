CREATE DATABASE CarRental

USE CarRental

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) NOT NULL,
	DailyRate INT NOT NULL,
	WeeklyRate INT NOT NULL,
	MonthlyRate INT NOT NULL,
	WeekendRate INT NOT NULL
)

CREATE TABLE Cars(
	Id INT PRIMARY KEY IDENTITY,
	PlateNumber NVARCHAR(20) NOT NULL UNIQUE,
	Manufacturer NVARCHAR(20) NOT NULL,
	Model NVARCHAR(20) NOT NULL,
	CarYear INT NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories,
	Doors INT NOT NULL,
	Picture VARBINARY(max),
	Condition NVARCHAR(50),
	Available BIT NOT NULL DEFAULT 1,
)

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Customers(
	Id INT PRIMARY KEY IDENTITY,
	DriverLicenceNumber INT NOT NULL UNIQUE,
	FullName NVARCHAR(100) NOT NULL,
	Address NVARCHAR(100),
	City NVARCHAR(20) NOT NULL,
	ZipCode INT NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE RentalOrders(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees,
	CustomerId INT FOREIGN KEY REFERENCES Customers,
	CarId INT FOREIGN KEY REFERENCES Cars,
	KilometrageStart INT,
	KilometrageEnd INT,
	TotalKilometrage INT,
	StartDate Date NOT NULL,
	EndDate Date NOT NULL,
	TotalDays INT,
	RateApplied DECIMAL(15,2) NOT NULL,
	TaxRate DECIMAL(15,2) NOT NULL,
	OrderStatus BIT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Categories(CategoryName,DailyRate,WeeklyRate,MonthlyRate,WeekendRate) VALUES

('Sedan','15','100','350','25'),
('Convertible','15','100','350','25'),
('Roadster','15','100','350','25')

INSERT INTO Cars(PlateNumber,Manufacturer,Model,CarYear,CategoryId,Doors,Condition) VALUES

('12431232','BMW','5','2002','2','4','Good'),
('12431552','Mercedes','A Class','2006','3','4','Excellent'),
('13234312','Audi','3','2010','2','4','New')

INSERT INTO Employees(FirstName,LastName,Title) VALUES

('Ivan','Ivanov','Manager'),
('Gosho','Ivanov','Store Clerk'),
('Aleks','Ivanov','Accountant')

INSERT INTO Customers(DriverLicenceNumber,FullName,City,ZipCode) VALUES

('21312321','Ivan Ivanov','Varna','1540'),
('21312332','Gosho Petrov','Sofia','1110'),
('54354345','Evgeni Kuzmanov','Plovdiv','1919')

INSERT INTO RentalOrders(EmployeeId,CustomerId,CarId,StartDate,EndDate,RateApplied,TaxRate,OrderStatus) VALUES

('1','2','1','2015-12-01','2015-12-10','500','20','1'),
('2','2','3','2015-12-01','2015-12-10','690','20','1'),
('2','2','1','2015-12-01','2015-12-10','330','20','1')

