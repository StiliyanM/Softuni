CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) NOT NULL UNIQUE,
	Password VARCHAR(26) NOT NULL UNIQUE,
	ProfilePicture BINARY(900),
	LastLoginTime DATETIME,
	IsDeleted BIT ,
)

INSERT INTO Users(Username, Password, IsDeleted) VALUES

('ethernal', '123', '1'),
('Stiliyan', '123412dfa', '1'),
('theMask', '12312', '1'),
('PinkFlower', '123457', '1'),
('TheLastOne', '1', '1')
