--CREATE OR ALTER PROCEDURE lecturerLogin
--(
--	@Email VARCHAR(100),
--	@Password VARCHAR(100)
--)
--AS
--SELECT
--	LecturerID,
--	LecturerName,
--	Email
--FROM Lecturers
--WHERE Email = @Email AND Password = @Password
--GO
-- EXEC lecturerLogin 'john.doe@example.com', 'Password1'

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE managerLogin
--(
--	@Email VARCHAR(100),
--	@Password VARCHAR(100)
--)
--AS
--SELECT Email FROM Manager
--WHERE Email = @Email AND Password = @Password
--GO
--EXEC managerLogin 'levankob', '123456789'

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE studentLogin
--(
--	@Email VARCHAR(100),
--	@Password VARCHAR(100)
--)
--AS
--SELECT
--	StudentName,
--	Email,
--	StudentID
--FROM Students
--WHERE Email = @Email AND Password = @Password
--GO
--EXEC studentLogin 'alice.johnson@example.com', 'Password4'

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE addLecturer
--(
--	@LecturerName VARCHAR(100),
--	@Email VARCHAR(100),
--	@Password VARCHAR(20)
--)
--AS
--INSERT INTO Lecturers
--VALUES(@LecturerName, @Email, @Password)

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE addStudent
--(
--	@StudentName VARCHAR(100),
--	@Email VARCHAR(100),
--	@Password VARCHAR(20)
--)
--AS
--INSERT INTO Students
--VALUES(@StudentName, @Email, @Password)

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE removeLecturer
--(
--	@LecturerID INT
--)
--AS
--DELETE FROM Lecturers
--WHERE LecturerID = @LecturerID

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE removeStudent
--(
--	@StudentID INT
--)
--AS
--DELETE FROM Students
--WHERE StudentID = @StudentID

---------------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE addGrade
(
	@StudentID INT,
	@LecturerID INT,
	@Grade INT
)
AS
INSERT INTO Grading(StudentID, Grade, LecturerID, Date)
VALUES(@StudentID, @Grade, @LecturerID, GETDATE())
GO
EXEC addGrade 1, 1, 100

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE showGradesByDate
--(
--	@StudentID INT
--)
--AS
--SELECT
--	Date,
--	Grade,
--	LecturerName
--FROM Grading
--INNER JOIN Lecturers ON Lecturers.LecturerID = Grading.LecturerID
--WHERE StudentID = @studentID
--ORDER BY Date

--GO
--EXEC showGradesByDate 4
---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE showGradesByGrade
--(
--	@StudentID INT
--)
--AS
--SELECT
--	Date,
--	Grade,
--	LecturerName
--FROM Grading
--INNER JOIN Lecturers ON Lecturers.LecturerID = Grading.LecturerID
--WHERE StudentID = @studentID
--ORDER BY Grade

--GO
--EXEC showGradesByGrade 4
---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE showGradesByLecturerName
--(
--	@StudentID INT
--)
--AS
--SELECT
--	Date,
--	Grade,
--	LecturerName
--FROM Grading
--INNER JOIN Lecturers ON Lecturers.LecturerID = Grading.LecturerID
--WHERE StudentID = @studentID
--ORDER BY LecturerName

--GO
--EXEC showGradesByLecturerName 4

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE studentAverageGrade
--(
--	@StudentID INT
--)
--AS
--SELECT
--	AVG(Grade) AS 'Student Average Grade',
--	StudentID
--FROM Grading
--WHERE StudentID = @studentID
--GROUP BY StudentID
--GO
--EXEC studentAverageGrade 1
---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE studentRating
--AS
--SELECT
--	StudentName,
--	AVG(Grade) AS AverageGrade,
--	DENSE_RANK()OVER(ORDER BY AVG(Grade) DESC) AS Rating
--FROM Grading
--INNER JOIN Students ON Students.StudentID = Grading.StudentID
--GROUP BY StudentName
--ORDER BY AverageGrade DESC
--GO
--EXEC studentRating

---------------------------------------------------------------------------------------------------

--CREATE OR ALTER PROCEDURE viewGradesByLecturerID
--(
--	@LecturerID INT,
--	@StudentID INT
--)
--AS
--SELECT
--	LecturerName,
--	Grade,
--	Date
--FROM Grading
--INNER JOIN Lecturers ON Lecturers.LecturerID = Grading.LecturerID
--WHERE Lecturers.LecturerID = @LecturerID AND StudentID = @StudentID
--GO
--EXEC viewGradesByLecturerID 1, 1

-----------------

--CREATE OR ALTER PROCEDURE viewAllSudents
--AS
--SELECT
--	StudentID,
--	StudentName,
--	Email
--FROM Students
--GO
--EXEC viewAllSudents

-----------------

--CREATE OR ALTER PROCEDURE viewAllLecturers
--AS
--SELECT
--	LecturerID,
--	LecturerName,
--	Email
--FROM Lecturers
--GO
--EXEC viewAllLecturers

-----------------------------

--CREATE OR ALTER PROCEDURE viewAllSudentsByLecturer
--	@LecturerID int
--AS
--SELECT
--	Students.StudentID,
--	StudentName,
--	Students.Email
--FROM Students
--inner join Grading on students.StudentID=Grading.StudentID
--Where Grading.LecturerID = @LecturerID
--group by StudentName, Students.Email, Students.StudentID
--GO
--EXEC viewAllSudentsByLecturer 3

--------------------------------------------------

--CREATE OR ALTER PROCEDURE updateLecturer
--(
--	@LecturerID INT,
--	@LecturerName VARCHAR(100),
--	@Email VARCHAR(100),
--	@Password VARCHAR(20)
--)
--AS
--UPDATE Lecturers
--SET LecturerName = @LecturerName, Email = @Email, Password = @Password
--WHERE LecturerID = @LecturerID
	
--------------------------------------------------

--CREATE OR ALTER PROCEDURE updateStudent
--(
--	@StudentID INT,
--	@StudentName VARCHAR(100),
--	@Email VARCHAR(100),
--	@Password VARCHAR(20)
--)
--AS
--UPDATE Students
--SET StudentName = @StudentName, Email = @Email, Password = @Password
--WHERE StudentID = @StudentID
	
--------------------------------------------------

--SELECT
--	LecturerName,
--	Email,
--	Password
--FROM Lecturers
--WHERE LecturerID = @Id

--------------------------------------------------

--SELECT
--	StudentName,
--	Email,
--	Password
--	FROM students
--WHERE StudentID = @Id
