SELECT [Id], [WorkoutEmphasis], [StartTime], [EndTime], [Location],[WorkoutRoutineId], [Rating], [BodyWeight], [BodyMassIndex], [Notes]
FROM [dbo].[Workouts]
WHERE [Id] = @id