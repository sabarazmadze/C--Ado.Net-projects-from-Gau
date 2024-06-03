CREATE DATABASE PlantsDatabase
GO
USE PlantsDatabase

CREATE TABLE Groups
(
	GroupID INT PRIMARY KEY IDENTITY,
	GroupName VARCHAR(100)
)

CREATE TABLE Watering
(
	WateringID INT PRIMARY KEY IDENTITY,
	WateringDescription VARCHAR(255)
)

CREATE TABLE Soil
(
	SoilID INT PRIMARY KEY IDENTITY,
	SoilType VARCHAR(100)
)

CREATE TABLE Sunlight
(
	SunlightID INT PRIMARY KEY IDENTITY,
	SunlightIntensity VARCHAR(100)
)

CREATE TABLE Plant
(
    PlantID INT PRIMARY KEY IDENTITY,
    PlantName VARCHAR(100),
    GroupID INT FOREIGN KEY REFERENCES Groups(GroupID),
    WateringID INT FOREIGN KEY REFERENCES Watering(WateringID),
    SoilID INT FOREIGN KEY REFERENCES Soil(SoilID),
    SunlightID INT FOREIGN KEY REFERENCES Sunlight(SunlightID)  
)

CREATE TABLE Users
(
    UserID INT PRIMARY KEY IDENTITY,
	PlantID INT FOREIGN KEY REFERENCES Plant(PlantID),
    Username VARCHAR(50),
    Email VARCHAR(100),
    Password VARCHAR(100)
)

CREATE TABLE Admins
(
    AdminID INT PRIMARY KEY IDENTITY,
    Username VARCHAR(50),
    Email VARCHAR(100),
    Password VARCHAR(100)  
)

CREATE TABLE Photos
(
    PhotoID INT PRIMARY KEY IDENTITY,
    PlantID INT FOREIGN KEY REFERENCES Plant(PlantID),
    PhotoURL VARCHAR(255)
)

ALTER TABLE Photos
ALTER COLUMN PhotoURL NVARCHAR(255);

CREATE TABLE Stock
(
	StockID INT PRIMARY KEY IDENTITY,
	PlantID INT FOREIGN KEY REFERENCES Plant(PlantID),
	StockQuantity INT,
)

---------------------------------------------------------------------------------------------------

INSERT INTO Groups (GroupName)
VALUES ('Flowers'),
       ('Vegetables'),
       ('Herbs')

INSERT INTO Watering (WateringDescription)
VALUES ('Daily'),
       ('Every 2-3 days'),
       ('Weekly')

INSERT INTO Soil (SoilType)
VALUES ('Loam'),
       ('Clay'),
       ('Sandy'),
       ('Peat'),
       ('Chalky')

INSERT INTO Sunlight (SunlightIntensity)
VALUES ('Full Sun'),
       ('Partial Sun'),
       ('Shade')

INSERT INTO Plant (PlantName, GroupID, WateringID, SoilID, SunlightID)
VALUES ('Rose', 1, 1, 1, 1),
       ('Tomato', 2, 2, 1, 1),
       ('Basil', 3, 1, 1, 2),
	   ('Lily', 1, 1, 1, 1),
       ('Sunflower', 1, 2, 2, 1),
       ('Lettuce', 2, 2, 1, 2),
       ('Mint', 3, 1, 1, 2),
	   ('Tulip', 1, 1, 1, 1),
       ('Cucumber', 2, 2, 1, 1),
       ('Rosemary', 3, 1, 1, 2),
       ('Daisy', 1, 1, 1, 1),
       ('Bell Pepper', 2, 2, 1, 1)

INSERT INTO Users (PlantID, Username, Email, Password)
VALUES (1, 'SabaRazmadze', 'saba.razmadze@gmail.com', '123456789'),
       (2, 'MariamSarishvili', 'mariam.sarishvili@gmail.com', '134679825'),
       (3, 'LiziArevadze', 'lizi.arevadze@gmail.com', '193746825')

INSERT INTO Admins (Username, Email, Password)
VALUES ('levankob', 'levankob@plants.com', '123456789')

INSERT INTO Stock (PlantID, StockQuantity)
VALUES 
(1, 50),
(2, 40),
(3, 60),
(4, 30),
(5, 45),
(6, 55),
(7, 70),
(8, 25),
(9, 35),
(10, 65),
(11, 20),
(12, 40)