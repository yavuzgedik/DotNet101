SELECT * FROM Calisanlar

SELECT * FROM Departmanlar

INSERT INTO Departmanlar VALUES ('Avukat')

INSERT INTO Calisanlar 
VALUES ('Ahmet','Serçinoğlu', 'okan@gmail.com', '2010-01-02', 6500, 1)

SELECT Ad, SoyAd, Email, Maas, DepartmanID FROM Calisanlar

SELECT Ad, SoyAd as [Soy Adı] FROM Calisanlar

SELECT Ad, SoyAd FROM Calisanlar

SELECT CONCAT(Ad,' ', SoyAd) FROM Calisanlar

SELECT CONCAT(Ad,' ', SoyAd) as [Ad SoyAd] FROM Calisanlar

SELECT * FROM Calisanlar WHERE DepartmanID = 1

SELECT 
	CONCAT(Ad,' ', SoyAd) as [Ad SoyAd], 
	Email, 
	Maas 
	FROM Calisanlar 
	WHERE DepartmanID = 1

SELECT 
	CONCAT(Ad,' ', SoyAd) as [Ad SoyAd], 
	Email, 
	Maas 
	FROM Calisanlar 
	WHERE DepartmanID = 1 OR DepartmanID = 2

SELECT
	CONCAT(Ad,' ', SoyAd) as [Ad SoyAd], 
	Maas
	FROM Calisanlar
	WHERE Maas < 3000

SELECT
	CONCAT(Ad,' ', SoyAd) as [Ad SoyAd], 
	Maas
	FROM Calisanlar
	WHERE Maas >= 2500

SELECT
	Ad,
	Soyad,
	Maas,
	Email
	FROM Calisanlar
	WHERE Email = 'burak@gmail.com' OR Email = 'funda@gmail.com'

SELECT
	Ad,
	Soyad,
	Maas,
	Email
	FROM Calisanlar
	WHERE Email IN('burak@gmail.com','funda@gmail.com')

SELECT
	Ad,
	Soyad,
	Maas,
	Email
	FROM Calisanlar
	WHERE Email NOT IN('burak@gmail.com','funda@gmail.com')

SELECT * FROM Calisanlar
	WHERE Ad LIKE '%ü%'
	
SELECT * FROM Calisanlar
	WHERE Ad LIKE '%a'

SELECT * FROM Calisanlar
	WHERE Ad LIKE 'a%'

SELECT * FROM Calisanlar
	WHERE Email LIKE '%gmail%'

SELECT * FROM Calisanlar
	WHERE IseBaslamaTarihi LIKE '%2010%'

SELECT * FROM Calisanlar ORDER BY Maas

SELECT * FROM Calisanlar ORDER BY ID

SELECT * FROM Calisanlar ORDER BY Maas DESC

SELECT * FROM Calisanlar ORDER BY Maas ASC

SELECT 
	CONCAT(Ad,' ', SoyAd) as [Ad SoyAd]
	FROM Calisanlar
	ORDER BY [Ad SoyAd] DESC

SELECT TOP 2 * FROM Calisanlar

SELECT TOP 2 * FROM Calisanlar ORDER BY Maas

SELECT * FROM Calisanlar

SELECT COUNT(*) FROM Calisanlar

SELECT COUNT(ID) FROM Calisanlar

INSERT INTO Calisanlar 
	VALUES (NULL, 'Gedik', 'gedik@gmail.com', '2010-01-02', 7500, 3)

SELECT COUNT(Ad) FROM Calisanlar

SELECT SUM(Maas) FROM Calisanlar

SELECT AVG(Maas) FROM Calisanlar

SELECT MIN(Maas) FROM Calisanlar

-- Sümeyra
SELECT MAX(Maas) as [Max Maaş] FROM Calisanlar
