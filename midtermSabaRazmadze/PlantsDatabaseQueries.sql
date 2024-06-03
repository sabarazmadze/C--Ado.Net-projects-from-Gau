--CREATE OR ALTER PROCEDURE addPlant
--(
--	@PlantName VARCHAR(100),
--	@GroupID INT,
--	@WateringID INT,
--	@SoilID INT,
--	@SunlightID INT
--)
--AS
--INSERT INTO Plant
--VALUES(@PlantName, @GroupID, @WateringID, @SoilID, @SunlightID)

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE addUser
--(
--	@Username VARCHAR(100),
--	@Email VARCHAR(100),
--	@Password VARCHAR(100)
--)
--AS
--INSERT INTO Users(Username, Email, Password)
--VALUES(@Username, @Email, @Password)

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE addGroup
--(
--	@GroupName VARCHAR(100)
--)
--AS
--INSERT INTO Groups
--VALUES(@GroupName)

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE addPhoto
--(
--	@PlantID INT,
--	@PhotoURL nVARCHAR(255)
--)
--AS
--INSERT INTO Photos
--VALUES(@PlantID, @PhotoURL)

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE removeUser
--(
--	@UserID INT
--)
--AS
--DELETE FROM Users
--WHERE UserID = @UserID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE removePlant
--(
--	@PlantID INT
--)
--AS
--DELETE FROM Plant
--WHERE PlantID = @PlantID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE editUser
--(
--	@UserID INT,
--	@Username VARCHAR(100),
--	@Email VARCHAR(100),
--	@Password VARCHAR(100)
--)
--AS
--UPDATE Users
--SET Username = @Username, Email = @Email, Password = @Password
--WHERE UserID = @UserID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE editPlant
--(
--	@PlantID INT,
--	@PlantName VARCHAR(100),
--	@GroupID INT,
--	@WateringID INT,
--	@SoilID INT,
--	@SunlightID INT
--)
--AS
--UPDATE Plant
--SET PlantName = @PlantName, GroupID = @GroupID, WateringID = @WateringID, SoilID = @SoilID, SunlightID = @SunlightID
--WHERE PlantID = @PlantID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE editPlant
--(
--	@PlantID INT,
--	@PlantName VARCHAR(100),
--	@GroupID INT,
--	@WateringID INT,
--	@SoilID INT,
--	@SunlightID INT
--)
--AS
--UPDATE Plant
--SET PlantName = @PlantName, GroupID = @GroupID, WateringID = @WateringID, SoilID = @SoilID, SunlightID = @SunlightID
--WHERE PlantID = @PlantID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE editWatering
--(
--	@WateringID INT,
--	@WateringDescription VARCHAR(255)
--)
--AS
--UPDATE Watering
--SET WateringDescription = @WateringDescription
--WHERE WateringID = @WateringID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE editSoil
--(
--	@SoilID INT,
--	@SoilType VARCHAR(100)
--)
--AS
--UPDATE Soil
--SET SoilType = @SoilType
--WHERE SoilID = @SoilID
---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE editGroup
--(
--	@GroupID INT,
--	@GroupName VARCHAR(100)
--)
--AS
--UPDATE Groups
--SET GroupName = @GroupName
--WHERE GroupID = @GroupID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE editSunlight
--(
--	@SunlightID INT,
--	@SunlightIntensity VARCHAR(100)
--)
--AS
--UPDATE Sunlight
--SET SunlightIntensity = @SunlightIntensity
--WHERE SunlightID = @SunlightID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE removeWatering
--(
--	@WateringID INT
--)
--AS
--DELETE FROM Watering
--WHERE WateringID = @WateringID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE removeSoil
--(
--	@SoilID INT
--)
--AS
--DELETE FROM Soil
--WHERE SoilID = @SoilID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE removeSunlight
--(
--	@SunlightID INT
--)
--AS
--DELETE FROM Sunlight
--WHERE SunlightID = @SunlightID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE removeGroup
--(
--	@GroupID INT
--)
--AS
--DELETE FROM Groups
--WHERE GroupID = @GroupID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE addWatering
--(
--	@WateringDescription VARCHAR(255)
--)
--AS
--INSERT INTO Watering
--VALUES(@WateringDescription)

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE addSoil
--(
--	@SoilType VARCHAR(100)
--)
--AS
--INSERT INTO Soil
--VALUES(@SoilType)

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE addSunlight
--(
--	@SunlightIntensity VARCHAR(255)
--)
--AS
--INSERT INTO Sunlight
--VALUES(@SunlightIntensity)

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE showAllUserPlants
--AS
--SELECT
--	UserName,
--	Email,
--	COUNT(PlantName) AS 'Total Plants'
--FROM Users
--INNER JOIN Plant ON Plant.PlantID = Users.PlantID
--GROUP BY UserName, Email

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE showAllPlants
--AS
--SELECT
--	PlantName,
--	StockQuantity,
--	SunlightIntensity,
--	SoilType
--FROM Plant
--INNER JOIN Soil ON Soil.SoilID = Plant.SoilID
--INNER JOIN Sunlight ON Sunlight.SunlightID = Plant.SunlightID
--INNER JOIN Stock ON Stock.PlantID = Plant.PlantID
---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE showPlantsBYId
--	@ID int
--AS
--SELECT
--	PlantName,
--	StockQuantity,
--	SunlightIntensity,
--	SoilType
--FROM Plant
--INNER JOIN Soil ON Soil.SoilID = Plant.SoilID
--INNER JOIN Sunlight ON Sunlight.SunlightID = Plant.SunlightID
--INNER JOIN Stock ON Stock.PlantID = Plant.PlantID
--where Plant.[PlantID]=@ID
--go 
--exec showPlantsBYId 1
---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE updateStock
--(
--	@PlantID INT,
--	@StockQuantity INT
--)
--AS
--UPDATE Stock
--SET StockQuantity = StockQuantity - @StockQuantity
--WHERE PlantID = @PlantID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE userLogin
--(
--    @Email VARCHAR(100),
--    @Password VARCHAR(100)
--)
--AS
--SELECT
--    UserID
--FROM Users
--WHERE Email = @Email AND Password = @Password

--exec userLogin 'u', 'u'

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE adminLogin
--(
--    @Email VARCHAR(100),
--    @Password VARCHAR(100)
--)
--AS
--SELECT
--    AdminID
--FROM Admins
--WHERE Email = @Email AND Password = @Password


---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE viewSoil
--AS
--SELECT
--[SoilID],
--[SoilType]
--FROM Soil

--go 


--CREATE OR ALTER PROCEDURE viewSunlight
--AS
--SELECT
--[SunlightID],
--[SunlightIntensity]
--FROM Sunlight

--go 

--CREATE OR ALTER PROCEDURE viewGroups
--AS
--SELECT
--[GroupID],
--[GroupName]
--FROM Groups

--go 

--CREATE OR ALTER PROCEDURE viewWatering
--AS
--SELECT
--[WateringID],
--[WateringDescription]
--FROM Watering


---------------------------------------------------------------------------------------------------


--select SunlightIntensity from Sunlight where [SunlightID]=@ID

--select [GroupName] from [dbo].[Groups] where [GroupID]=@ID

--select [SoilType] from [dbo].[Soil] where [SoilID]=@ID

--select [WateringDescription] from [dbo].[Watering] where [WateringID]=@ID

---------------------------------------------------------------------------------------------------

--select [PlantName],[GroupID],[WateringID],[SoilID],[SunlightID] from [dbo].[Plant] where [PlantID]=@Id

---------------------------------------------------------------------------------------------------

--select count(*) from [dbo].[Watering]

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE viewSoilBYId
--@id int
--AS
--SELECT
--[SoilID],
--[SoilType]
--FROM Soil
--where SoilID=@id

--go 


--CREATE OR ALTER PROCEDURE viewSunlightBYId
--@id int
--AS
--SELECT
--[SunlightID],
--[SunlightIntensity]
--FROM Sunlight
--where SunlightID= @id
--go 

--CREATE OR ALTER PROCEDURE viewGroupsBYId
--@id int
--AS
--SELECT
--[GroupID],
--[GroupName]
--FROM Groups
--where GroupID= @id 
--go 

--CREATE OR ALTER PROCEDURE viewWateringBYId
--@id int
--AS
--SELECT
--[WateringID],
--[WateringDescription]
--FROM Watering
--where WateringID=@id 
