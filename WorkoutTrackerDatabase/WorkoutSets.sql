CREATE TABLE [dbo].[WorkoutSets]
(
	[Id]			INT NOT NULL PRIMARY KEY IDENTITY(0, 1),
	[WorkoutId]		INT NOT NULL,
	[ExerciseName]	NVARCHAR(50) NOT NULL,
	[SetNumber]		SMALLINT NOT NULL,
	[SubSetNumber]	SMALLINT NULL,
	[Weight]		INT NULL,
	[Reps]			INT NULL,
	[Time]			INT NULL,
	[RestPeriod]	INT NOT NULL DEFAULT 0,
	[EquipmentName] NVARCHAR(50) NULL,
	[Angle]			NVARCHAR(50) NULL,
	[SuperSet]		SMALLINT NULL,
	[SetEnhancer]	NVARCHAR(50) NULL,
	[Notes]			NVARCHAR(200) NULL
)
