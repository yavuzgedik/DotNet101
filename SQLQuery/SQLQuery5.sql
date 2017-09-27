SELECT * FROM Calisanlar

DELETE FROM Calisanlar WHERE ID = 9

INSERT INTO Calisanlar 
VALUES ('İbrahim', 'Çetin', 'ibrahim@gmail.com', '2016-05-02', 6000, 3)

UPDATE Calisanlar SET Email = 'ahmet@gmail.com' WHERE ID = 8

SELECT * FROM Departmanlar

SELECT 
	DepartmanID, 
	COUNT(*) as [Çalışan Sayısı]
FROM Calisanlar 
GROUP BY DepartmanID

SELECT 
	DepartmanID, 
	COUNT(*) as [Çalışan Sayısı], 
	SUM(Maas) as [Toplam Maaş] 
FROM Calisanlar 
GROUP BY DepartmanID

SELECT 
	DepartmanID, 
	COUNT(*) as [Çalışan Sayısı], 
	SUM(Maas) as [Toplam Maaş],
	SUM(Maas)/COUNT(*) as [Ortlama Maaş] 
FROM Calisanlar 
GROUP BY DepartmanID

SELECT 
	DepartmanID, 
	COUNT(*) as [Çalışan Sayısı], 
	SUM(Maas) as [Toplam Maaş],
	AVG(Maas) as [Ortlama Maaş] 
FROM Calisanlar 
GROUP BY DepartmanID

UPDATE Calisanlar SET Maas = Maas * 0.3 + Maas WHERE ID = 4

UPDATE Calisanlar SET Maas += Maas * 0.3 WHERE ID = 4

SELECT * FROM Calisanlar WHERE ID = 4


SELECT * FROM Calisanlar

SELECT c.Ad, c.SoyAd, c.DepartmanID FROM Calisanlar as c

SELECT c.Ad, c.SoyAd, c.DepartmanID FROM Calisanlar as c
