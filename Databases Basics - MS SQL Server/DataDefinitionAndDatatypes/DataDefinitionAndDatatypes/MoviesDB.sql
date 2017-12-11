CREATE DATABASE Movies

USE Movies

CREATE TABLE Directors(
	Id INT PRIMARY KEY IDENTITY,
	DirectorName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)	 
)

CREATE TABLE Genres(
	Id INT PRIMARY KEY IDENTITY,
	GenreName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)	 
)

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)	 
)

CREATE TABLE Movies(
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(50) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors,
	CopyrightYear INT NOT NULL,
	Length INT NOT NULL,
	GenreId INT FOREIGN KEY REFERENCES Genres,
	CategoryId INT FOREIGN KEY REFERENCES Categories,
	Rating DECIMAL(2,1),
	Notes NVARCHAR(MAX)	 
)


INSERT INTO Directors(DirectorName,Notes) VALUES

('Steven Spielberg','One of the best'),
('Christopher Nolan','Genius'),
('David Fincher',NULL),
('Stanley Kubrick',Null),
('Woody Allen','Weird, but good.')

INSERT INTO Genres(GenreName,Notes) VALUES

('Comedy','Very good movie'),
('Horror','Almost pissed my pants'),
('Drama','Cried my eyes out'),
('Action',Null),
('Mystery','Very good movie')

INSERT INTO Categories(CategoryName,Notes) VALUES

('Romantic Comedy','Very good movie'),
('Anime Horror','Almost pissed my pants'),
('Classic Drama','Cried my eyes out'),
('Action Thriller',Null),
('TV Mystery','Very good movie')

INSERT INTO Movies(Title,DirectorId,CopyrightYear,Length,GenreId,CategoryId,Rating) VALUES

('Gone Wild','1','1999','79','2','1','4.5'),
('The future','2','1999','60','2','1','3'),
('The last hope','3','1999','79','4','2','4.5'),
('The Magazine','1','2006','90','2','3','4'),
('What do you think','1','2003','79','2','1','4.5')



