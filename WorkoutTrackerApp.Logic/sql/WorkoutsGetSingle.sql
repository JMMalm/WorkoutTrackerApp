SELECT [Id], [Date], [WorkoutEmphasis], [StartTime], [EndTime], [Location],[WorkoutRoutineId], [Rating], [BodyWeight], [BodyMassIndex], [SysCreated], [SysModified], [Notes]
FROM [dbo].[Workouts]
WHERE [Id] = @id