USE [master]
GO
IF EXISTS (SELECT *FROM sys.databases WHERE name='Companie')
	BEGIN
	alter database Companie set single_user
	with rollback immediate
	drop database Companie
	END
GO

CREATE DATABASE Companie
GO
USE Companie
GO


CREATE OR ALTER FUNCTION PretTotal(
	@Procentaj AS FLOAT,
	@Pret AS FLOAT
)
RETURNS FLOAT
AS
BEGIN
	RETURN @Pret + @Pret / 100 * @Procentaj
END
GO

CREATE TABLE Agenti(
	Id_Agent INT IDENTITY(1,1) PRIMARY KEY,
	Nume nvarchar(30) NOT NULL,
	Prenume nvarchar(30) NOT NULL,
	Salariu int NOT NULL,
	Varsta int,
	Staj int,
	Procent float NOT NULL,
	)

CREATE TABLE Produse(
	Id_Produs INT PRIMARY KEY,
	Denumire nvarchar(30) NOT NULL,
	Pret float NOT NULL
	)

CREATE TABLE Agenti_Produse(
	Id_Agent_Produs INT IDENTITY(1,1) PRIMARY KEY,
	Id_Agent int FOREIGN KEY REFERENCES Agenti(Id_Agent) NOT NULL ,
	Id_Produs int FOREIGN KEY REFERENCES Produse(Id_Produs) NOT NULL,
	inStoc BIT DEFAULT 0 NOT NULL,
	PretTotal decimal(10, 2) NOT NULL
	)

INSERT INTO Agenti VALUES 
	('Covrig', 'Petru', 5600, 19, 2, 2.2),
	('Crozu', 'Stas', 8400, 23, 1, 1.2),
	('Zgardan', 'Razvan', 5600, 19, 0, 3.4),
	('Balan', 'Elena', 11000, 26, 4, 6.7),
	('Popovici', 'Paul', 6700, 53, 4, 0.5),
	('Caldura', 'Augustina', 9000, 22, 7, 2.2),
	('Urus', 'Adrian', 11000, 20, 2, 4.6)
	

INSERT INTO Produse VALUES
	(1, 'Suruburi', 10.70),
	(2, 'Cuie', 11.20),
	(3, 'Sfori', 23.99),
	(4, 'Gresie', 49.59),
	(5, 'Faianta', 69.99),
	(6, 'Nisip', 30.00),
	(7, 'Ciment', 45.50)
GO

/* Vanzarile primului Agent */
INSERT INTO Agenti_Produse VALUES
	(1, 1, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 1), (SELECT Pret FROM Produse WHERE Id_Produs = 1))),
	(1, 2, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 1), (SELECT Pret FROM Produse WHERE Id_Produs = 2))),
	(1, 3, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 1), (SELECT Pret FROM Produse WHERE Id_Produs = 3))),
	(1, 4, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 1), (SELECT Pret FROM Produse WHERE Id_Produs = 4))),
	(1, 5, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 1), (SELECT Pret FROM Produse WHERE Id_Produs = 5))),
	(1, 6, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 1), (SELECT Pret FROM Produse WHERE Id_Produs = 6))),
	(1, 7, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 1), (SELECT Pret FROM Produse WHERE Id_Produs = 7)))

/* Vanzarile la a doilea Agent */
INSERT INTO Agenti_Produse VALUES
	(2, 1, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 2), (SELECT Pret FROM Produse WHERE Id_Produs = 1))),
	(2, 2, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 2), (SELECT Pret FROM Produse WHERE Id_Produs = 2))),
	(2, 3, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 2), (SELECT Pret FROM Produse WHERE Id_Produs = 3))),
	(2, 4, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 2), (SELECT Pret FROM Produse WHERE Id_Produs = 4))),
	(2, 5, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 2), (SELECT Pret FROM Produse WHERE Id_Produs = 5))),
	(2, 6, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 2), (SELECT Pret FROM Produse WHERE Id_Produs = 6))),
	(2, 7, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 2), (SELECT Pret FROM Produse WHERE Id_Produs = 7)))

/* Vanzarile la a treilea Agent */
INSERT INTO Agenti_Produse VALUES
	(3, 1, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 3), (SELECT Pret FROM Produse WHERE Id_Produs = 1))),
	(3, 2, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 3), (SELECT Pret FROM Produse WHERE Id_Produs = 2))),
	(3, 3, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 3), (SELECT Pret FROM Produse WHERE Id_Produs = 3))),
	(3, 4, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 3), (SELECT Pret FROM Produse WHERE Id_Produs = 4))),
	(3, 5, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 3), (SELECT Pret FROM Produse WHERE Id_Produs = 5))),
	(3, 6, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 3), (SELECT Pret FROM Produse WHERE Id_Produs = 6))),
	(3, 7, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 3), (SELECT Pret FROM Produse WHERE Id_Produs = 7)))

/* Vanzarile la a patrulea Agent */
INSERT INTO Agenti_Produse VALUES
	(4, 1, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 4), (SELECT Pret FROM Produse WHERE Id_Produs = 1))),
	(4, 2, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 4), (SELECT Pret FROM Produse WHERE Id_Produs = 2))),
	(4, 3, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 4), (SELECT Pret FROM Produse WHERE Id_Produs = 3))),
	(4, 4, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 4), (SELECT Pret FROM Produse WHERE Id_Produs = 4))),
	(4, 5, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 4), (SELECT Pret FROM Produse WHERE Id_Produs = 5))),
	(4, 6, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 4), (SELECT Pret FROM Produse WHERE Id_Produs = 6))),
	(4, 7, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 4), (SELECT Pret FROM Produse WHERE Id_Produs = 7)))

/* Vanzarile la a patrulea Agent */
INSERT INTO Agenti_Produse VALUES
	(5, 1, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 5), (SELECT Pret FROM Produse WHERE Id_Produs = 1))),
	(5, 2, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 5), (SELECT Pret FROM Produse WHERE Id_Produs = 2))),
	(5, 3, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 5), (SELECT Pret FROM Produse WHERE Id_Produs = 3))),
	(5, 4, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 5), (SELECT Pret FROM Produse WHERE Id_Produs = 4))),
	(5, 5, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 5), (SELECT Pret FROM Produse WHERE Id_Produs = 5))),
	(5, 6, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 5), (SELECT Pret FROM Produse WHERE Id_Produs = 6))),
	(5, 7, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 5), (SELECT Pret FROM Produse WHERE Id_Produs = 7)))

/* Vanzarile la a patrulea Agent */
INSERT INTO Agenti_Produse VALUES
	(6, 1, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 6), (SELECT Pret FROM Produse WHERE Id_Produs = 1))),
	(6, 2, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 6), (SELECT Pret FROM Produse WHERE Id_Produs = 2))),
	(6, 3, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 6), (SELECT Pret FROM Produse WHERE Id_Produs = 3))),
	(6, 4, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 6), (SELECT Pret FROM Produse WHERE Id_Produs = 4))),
	(6, 5, 0, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 6), (SELECT Pret FROM Produse WHERE Id_Produs = 5))),
	(6, 6, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 6), (SELECT Pret FROM Produse WHERE Id_Produs = 6))),
	(6, 7, 1, dbo.PretTotal((SELECT Procent FROM Agenti WHERE Id_Agent = 6), (SELECT Pret FROM Produse WHERE Id_Produs = 7)))
GO

--SELECT * FROM Agenti_Produse
GO


/* Select informatie produs  */
--SELECT Denumire, Pret FROM Produse


/* Select Toata Informatia utila */
SELECT P.Denumire, P.Pret, A.Nume, A.Prenume, A.Procent, AP.PretTotal AS 'PretTotal',
CASE
    WHEN inStoc = 0 THEN 'DA'
    ELSE 'NU'
END AS inStoc
FROM Agenti_Produse AP
INNER JOIN Produse P ON P.Id_Produs = AP.Id_Produs
INNER JOIN Agenti A ON A.Id_Agent = AP.Id_Agent
ORDER BY P.Denumire, AP.PretTotal DESC
GO





