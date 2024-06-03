CREATE DATABASE UniversityDB

GO

USE UniversityDB

CREATE TABLE Lecturers
(
    LecturerID INT PRIMARY KEY IDENTITY,
    LecturerName NVARCHAR(100),
    Email NVARCHAR(100),
	Password NVARCHAR(20)
)

CREATE TABLE Students
(
    StudentID INT PRIMARY KEY IDENTITY,
    StudentName NVARCHAR(100),
    Email NVARCHAR(100),
	Password NVARCHAR(20)
)

CREATE TABLE Grading
(
    GradeID INT PRIMARY KEY IDENTITY,
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	LecturerID INT FOREIGN KEY REFERENCES Lecturers(LecturerID),
    Grade INT CHECK(Grade >= 0 AND Grade <= 100)
)

CREATE TABLE Manager
(
	ManagerID INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100),
	Password VARCHAR(20)
)

INSERT INTO Lecturers
VALUES 
    ('John Doe', 'john.doe@example.com', 'password1'),
    ('Jane Smith', 'jane.smith@example.com', 'password2'),
    ('David Johnson', 'david.johnson@example.com', 'password3')

INSERT INTO Students(StudentName, Email, Password)
VALUES 
    ('Alice Johnson', 'alice.johnson@example.com', 'password4'),
    ('Bob Smith', 'bob.smith@example.com', 'password5'),
    ('Carol Williams', 'carol.williams@example.com', 'password6'),
    ('David Brown', 'david.brown@example.com', 'password7'),
    ('Eva Garcia', 'eva.garcia@example.com', 'password8'),
    ('Frank Martinez', 'frank.martinez@example.com', 'password9'),
    ('Grace Wilson', 'grace.wilson@example.com', 'password10'),
    ('Henry Anderson', 'henry.anderson@example.com', 'password11'),
    ('Ivy Thomas', 'ivy.thomas@example.com', 'password12'),
    ('Jack Lee', 'jack.lee@example.com', 'password13')

INSERT INTO Grading
VALUES 
    (1, 1, 85, '2024-04-01'),
    (1, 2, 90, '2024-04-10'),
    (1, 3, 88, '2024-04-15'),
    (1, 1, 92, '2024-04-20'),
    (1, 2, 86, '2024-04-25'),
    (2, 2, 75, '2024-04-02'),
    (2, 3, 80, '2024-04-09'),
    (2, 1, 78, '2024-04-14'),
    (2, 2, 82, '2024-04-18'),
    (2, 3, 79, '2024-04-23'),
    (3, 3, 88, '2024-04-03'),
    (3, 1, 92, '2024-04-11'),
    (3, 2, 90, '2024-04-16'),
    (3, 3, 89, '2024-04-21'),
    (3, 1, 91, '2024-04-26'),
    (4, 1, 78, '2024-04-04'),
    (4, 2, 82, '2024-04-12'),
    (4, 3, 80, '2024-04-17'),
    (4, 1, 79, '2024-04-22'),
    (4, 2, 81, '2024-04-27'),
    (5, 3, 92, '2024-04-05'),
    (5, 1, 96, '2024-04-13'),
    (5, 2, 94, '2024-04-19'),
    (5, 3, 95, '2024-04-24'),
    (5, 1, 93, '2024-04-29'),
    (6, 2, 80, '2024-04-06'),
    (6, 3, 75, '2024-04-14'),
    (6, 1, 82, '2024-04-20'),
    (6, 2, 78, '2024-04-25'),
    (6, 3, 79, '2024-04-30'),
    (7, 3, 85, '2024-04-07'),
    (7, 1, 90, '2024-04-15'),
    (7, 2, 88, '2024-04-21'),
    (7, 3, 86, '2024-04-26'),
    (7, 1, 89, '2024-05-01'),
    (8, 1, 70, '2024-04-08'),
    (8, 2, 75, '2024-04-16'),
    (8, 3, 72, '2024-04-22'),
    (8, 1, 74, '2024-04-27'),
    (8, 2, 71, '2024-05-02'),
    (9, 2, 78, '2024-04-09'),
    (9, 3, 82, '2024-04-17'),
    (9, 1, 80, '2024-04-23'),
    (9, 2, 79, '2024-04-28'),
    (9, 3, 81, '2024-05-03'),
    (10, 3, 88, '2024-04-10'),
    (10, 1, 92, '2024-04-18'),
    (10, 2, 90, '2024-04-24'),
    (10, 3, 89, '2024-04-29'),
    (10, 1, 91, '2024-05-04')

INSERT INTO Manager
VALUES('levankob', '123456789')