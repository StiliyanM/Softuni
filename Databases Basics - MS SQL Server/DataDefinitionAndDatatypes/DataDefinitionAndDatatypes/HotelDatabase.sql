CREATE DATABASE Hotel

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
	)

CREATE TABLE Customers(
	AccountNumber INT PRIMARY KEY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	PhoneNumber NVARCHAR(15) NOT NULL,
	EmergencyName NVARCHAR(50),
	EmergencyNumber NVARCHAR(15) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE RoomStatus(
	RoomStatus NVARCHAR(20) PRIMARY KEY,
	Notes NVARCHAR(MAX)
)

CREATE TABLE RoomTypes (
	RoomType  NVARCHAR(20) PRIMARY KEY,
	Notes NVARCHAR(MAX)
)

CREATE TABLE BedTypes (
	BedType NVARCHAR(20) PRIMARY KEY,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Rooms(
	RoomNumber INT PRIMARY KEY,
	RoomType NVARCHAR(20) FOREIGN KEY REFERENCES RoomTypes,
	BedType NVARCHAR(20) FOREIGN KEY REFERENCES BedTypes,
	Rate INT NOT NULL,
	RoomStatus NVARCHAR(20) FOREIGN KEY REFERENCES RoomStatus,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Payments(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees,
	PaymentDate DATE,
	AccountNumber NVARCHAR(20),
	FirstDateOccupied DATE NOT NULL,
	LastDateOccupied DATE,
	TotalDays INT NOT NULL,
	AmmountCharged INT,
	TaxRate INT DEFAULT 20,
	TaxAmmount INT,
	PaymentTotal INT NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Occupancies(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees,
	DateOccupied DATE NOT NULL,
	AccountNumber NVARCHAR(20),
	RoomNumber INT NOT NULL,
	RateApplied INT NOT NULL,
	PhoneCharge INT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees(FirstName,LastName,Title) VALUES

('Ivan','Ivanov','Manager'),
('Gosho','Ivanov','Store Clerk'),
('Aleks','Ivanov','Accountant')

INSERT INTO Customers(AccountNumber,FirstName,LastName,PhoneNumber,EmergencyNumber) VALUES

('123123','Stiliyan','Ivanov','3123125','654643'),
('546478','Ivan','Ivanov','7465654','312357'),
('123575','Petkan','Ivanov','323512','7896754')

INSERT INTO RoomStatus VALUES

('Good',NULL),
('Better','Free'),
('The best',NULL)

INSERT INTO RoomTypes VALUES

('4-bedroom','Clean'),
('2-bedroom', NULL),
('3-bedroom',NULL)

INSERT INTO BedTypes VALUES

('Queen',NULL),
('King',NULL),
('1-person',NULL)

INSERT INTO Rooms(RoomNumber,RoomType,BedType,Rate,RoomStatus) VALUES

('11','1','1','20','1'),
('33','2','3','40','1'),
('12','2','1','20','1')

INSERT INTO Payments(EmployeeId,PaymentDate,AccountNumber,FirstDateOccupied,TotalDays,PaymentTotal) VALUES

('2','2017-05-07','1231235','2017-11-07','10','250'),
('1','2014-05-07','3234567','2017-07-25','5','125'),
('3','2017-05-07','4324124','2015-12-04','1','20')

INSERT INTO Occupancies(EmployeeId,DateOccupied,AccountNumber,RoomNumber,RateApplied,PhoneCharge) VALUES

('1','2017-07-13','3234567','11','20','10'),
('2','2017-07-25','3213213','33','30','0'),
('3','2017-12-08','6564654','22','15','3')
