USE mydb;
GO
CREATE TABLE Teacher (
    TeacherID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Gender NVARCHAR(10),
    Subject NVARCHAR(50)
);
USE mydb;
GO
CREATE TABLE Pupil (
    PupilID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Gender NVARCHAR(10),
    Class NVARCHAR(10)
);
USE mydb;
GO
CREATE TABLE Teacher_Pupil (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TeacherID INT NOT NULL,
    PupilID INT NOT NULL,
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID),
    FOREIGN KEY (PupilID) REFERENCES Pupil(PupilID)
);
USE mydb;
GO
INSERT INTO Teacher (FirstName, LastName, Gender, Subject) 
VALUES 
    (N'????', N'?????????', N'????', N'??????????'),
    (N'??????', N'??????', N'????', N'??????'),
    (N'??????', N'??????', N'????', N'?????');

USE mydb;
GO	
INSERT INTO Pupil (FirstName, LastName, Gender, Class) 
VALUES 
    (N'????', N'??????', N'????', N'10'),
    (N'????', N'???????????', N'????', N'10'),
    (N'????', N'???????', N'????', N'9');


USE mydb;
GO
INSERT INTO Teacher_Pupil (TeacherID, PupilID) 
VALUES 
    (1, 1),  
    (1, 2),  
    (2, 1), 
    (2, 3),  
    (3, 2);


USE mydb;
GO
SELECT 
    t.FirstName + ' ' + t.LastName AS Teacher,
    t.Subject,
    p.FirstName + ' ' + p.LastName AS Pupil,
    p.Class
FROM Teacher_Pupil tp
JOIN Teacher t ON tp.TeacherID = t.TeacherID
JOIN Pupil p ON tp.PupilID = p.PupilID;


USE mydb;
GO
SELECT COUNT(*) AS StudentCount
FROM Teacher_Pupil tp
JOIN Teacher t ON tp.TeacherID = t.TeacherID
WHERE t.FirstName = N'??????';


USE mydb;
GO
SELECT COUNT(*) AS TeacherCount
FROM Teacher_Pupil tp
JOIN Pupil p ON tp.PupilID = p.PupilID
WHERE p.FirstName = N'????';