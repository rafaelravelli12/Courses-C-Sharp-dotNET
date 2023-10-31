CREATE DATABASE DotNetCourseDatabase
GO

USE DotNetCourseDatabase
GO

CREATE SCHEMA TutorialAppSchema
GO

CREATE TABLE TutorialAppSchema.Computer
(
    ComputerId INT IDENTITY(1,1) PRIMARY KEY
    , Motherboard NVARCHAR(50)
    , CPUCores INT
    , HasWifi BIT
    , HasLTE BIT
    , ReleaseDate DATETIME
    , Price DECIMAL(18, 4)
    , VideoCard NVARCHAR(50)
)
GO

SELECT * FROM TutorialAppSchema.Computer WHERE 1 = 0

SELECT * FROM TutorialAppSchema.Computer

SELECT [ComputerId],
[Motherboard],
[CPUCores],
[HasWifi],
[HasLTE],
[ReleaseDate],
[Price],
[VideoCard] FROM TutorialAppSchema.Computer

-- SET IDENTITY_INSERT TutorialAppSchema.Computer ON
-- SET IDENTITY_INSERT TutorialAppSchema.Computer OFF


INSERT INTO TutorialAppSchema.Computer (
    [Motherboard],
    [CPUCores],
    [HasWifi],
    [HasLTE],
    [ReleaseDate],
    [Price],
    [VideoCard]
) VALUES (
    'Sample-Motherboard',
    4,
    1,
    0,
    '2022-01-01',
    1000,
    'Sample-Videocard'
)

DELETE FROM TutorialAppSchema.Computer WHERE ComputerId = 101

UPDATE TutorialAppSchema.Computer SET CPUCores = 6 WHERE ComputerId = 102

UPDATE TutorialAppSchema.Computer SET CPUCores = 6 WHERE ReleaseDate < '2017-01-01'

SELECT [ComputerId],
[Motherboard],
ISNULL([CPUCores], 4) AS CPUCores,
[HasWifi],
[HasLTE],
[ReleaseDate],
[Price],
[VideoCard] FROM TutorialAppSchema.Computer
    ORDER BY HasWifi DESC, ReleaseDate DESC

-- Class 47

USE DotNetCourseDatabase
GO

SELECT * FROM TutorialAppSchema.Users AS Users

    -- Tests to validate Schema
    SELECT * FROM [TutorialAppSchema].[Users] AS Users

    SELECT * FROM sys.database_permissions
    WHERE major_id = OBJECT_ID('TutorialAppSchema.Users');

SELECT [Users].[UserId],
    [Users].[FirstName],
    [Users].[LastName],
    [Users].[FirstName] + ' ' + [Users].[LastName] AS FullName,
    [Users].[Email],
    [Users].[Gender],
    [Users].[Active]
FROM TutorialAppSchema.Users AS Users
WHERE Users.Active = 1
ORDER BY Users.UserId DESC

SELECT [Users].[UserId],
    [Users].[FirstName],
    [Users].[LastName],
    [Users].[FirstName] + ' ' + [Users].[LastName] AS FullName,
    [Users].[Email],
    [Users].[Gender],
    [Users].[Active],
    [UserJobInfo].[JobTitle],
    [UserJobInfo].[Department]
FROM TutorialAppSchema.Users AS Users
    -- INNER JOIN bring only mutual values
    -- INNER JOIN TutorialAppSchema.UserJobInfo

    -- LEFT JOIN bring all first table values and NULL second table values if they do not exist
    LEFT JOIN TutorialAppSchema.UserJobInfo
        ON UserJobInfo.UserId = Users.UserId
WHERE Users.Active = 1
ORDER BY Users.UserId DESC

CREATE CLUSTERED INDEX cix_UserJobInfo_UserId ON TutorialAppSchema.UserJobInfo(UserId)
CREATE NONCLUSTERED INDEX ix_UserJobInfo_UserId ON TutorialAppSchema.UserJobInfo(UserId) INCLUDE (Department)

SELECT [UserId],
[Salary] FROM TutorialAppSchema.UserSalary
UNION ALL
SELECT [UserId],
[Salary] FROM TutorialAppSchema.UserSalary

SELECT 
    ISNULL([UserJobInfo].[Department], 'No department') AS Department,
    SUM([UserSalary].[Salary]) AS Salary,
    MIN([UserSalary].[Salary]) AS MinSalary,
    COUNT(*) AS PeopleInDepartment,
    STRING_AGG(Users.UserId, ', ') AS UsersId
FROM TutorialAppSchema.Users AS Users
    LEFT JOIN TutorialAppSchema.UserSalary AS UserSalary
        ON UserSalary.UserId = Users.UserId
    LEFT JOIN TutorialAppSchema.UserJobInfo AS UserJobInfo
        ON UserJobInfo.UserId = Users.UserId
GROUP BY [UserJobInfo].[Department]

ALTER TABLE TutorialAppSchema.UserSalary ADD AvgSalary DECIMAL(18,4)
