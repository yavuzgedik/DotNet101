CREATE TABLE Calisanlar
(
	ID int not null PRIMARY KEY IDENTITY(1,1),
	Ad nvarchar(50),
	SoyAd nvarchar(50),
	Email nvarchar(50),
	IseBaslamaTarihi Date,
	Maas Money,
	DepartmanID int not null
)

CREATE TABLE Departmanlar
(
	ID int not null PRIMARY KEY IDENTITY(1,1),
	Ad nvarchar(50)
)

INSERT INTO Departmanlar VALUES ('Satın Alma')
INSERT INTO Departmanlar VALUES ('Pazarlama')
INSERT INTO Departmanlar VALUES ('Muhasebe')

SELECT * FROM Departmanlar

INSERT INTO Calisanlar VALUES
(
	'Yavuz',
	'Gedik',
	'mail@yavuzgedik.com',
	'2017-01-02',
	5000,
	1
)

SELECT * FROM Calisanlar
