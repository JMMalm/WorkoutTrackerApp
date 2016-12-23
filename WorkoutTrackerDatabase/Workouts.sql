CREATE TABLE [dbo].[Workouts]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Date] DATE NOT NULL, 
    [WorkoutEmphasis] NVARCHAR(50) NULL, 
    [StartTime] SMALLDATETIME NOT NULL, 
    [EndTime] SMALLDATETIME NOT NULL, 
    [Location] NVARCHAR(50) NOT NULL, 
    [WorkoutRoutineId] INT NULL, 
    [Rating] SMALLINT NULL, 
    [BodyWeight] INT NULL, 
    [BodyMassIndex] SMALLINT NULL, 
    [SysCreated] SMALLDATETIME NOT NULL, 
    [SysModified] SMALLDATETIME NOT NULL, 
    [Notes] NVARCHAR(100) NULL
)
