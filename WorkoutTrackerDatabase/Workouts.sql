﻿CREATE TABLE [dbo].[Workouts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(0, 1), 
    [Date] DATE NOT NULL, 
    [WorkoutEmphasis] NVARCHAR(50) NULL, 
    [StartTime] SMALLDATETIME NOT NULL, 
    [EndTime] SMALLDATETIME NOT NULL, 
    [Location] NVARCHAR(50) NOT NULL, 
    [WorkoutRoutineId] INT NULL, 
    [Rating] SMALLINT NULL, 
    [BodyWeight] INT NULL, 
    [BodyMassIndex] SMALLINT NULL, 
    [SysCreated] DATETIME NOT NULL, 
    [SysModified] DATETIME NOT NULL, 
    [Notes] NVARCHAR(100) NULL
)
