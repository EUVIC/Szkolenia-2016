-- Cultures 
IF NOT EXISTS(SELECT * FROM [dbo].[Cultures] WHERE Name = 'Unknown')
BEGIN
	SET IDENTITY_INSERT [dbo].[Cultures] ON
	INSERT [dbo].[Cultures] (Id, Name)
		SELECT 1, 'Unknown'
		UNION ALL
		SELECT 2, 'Northmen'
		UNION ALL
		SELECT 3, 'Braavosi'
		UNION ALL
		SELECT 4, 'Westermen'
		UNION ALL
		SELECT 4, 'Valyrian'
	SET IDENTITY_INSERT [dbo].[Cultures] OFF
END

-- Characters

IF NOT EXISTS(SELECT * FROM [dbo].[Characters] WHERE Name = 'Jon Snow')
BEGIN
	SET IDENTITY_INSERT [dbo].[Characters] ON
	INSERT [dbo].[Characters] (Id, Name, Gender, Born, Died, Culture_Id)
		SELECT 1, 'Jon Snow', 'Male', 'In 283 AC', '', 2
	SET IDENTITY_INSERT [dbo].[Characters] OFF
END