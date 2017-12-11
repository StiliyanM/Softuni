CREATE TABLE People(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(200) NOT NULL,
	Picture VARBINARY(max),
	Height DECIMAL(15,2),
	Weight DECIMAL(15,2),
	Gender CHAR(1) NOT NULL,
	BirthDate DATE NOT NULL,
	Biography NVARCHAR(max) 
)

INSERT INTO People(Name, Height, Weight, Gender, BirthDate) VALUES

('Ivan', '175', '80', 'm', '1997-12-03'),
('Georgi', '182', '90', 'm', '1997-12-05'),
('Mila', '162', '49', 'f', '1994-07-03'),
('Ivana', '175', '52', 'f', '1993-02-12'),
('Pesho', '175', '80', 'm', '1991-12-03')