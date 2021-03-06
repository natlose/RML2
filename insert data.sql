USE [RMLabor]
GO
SET IDENTITY_INSERT [dbo].[Address] ON 

GO
INSERT [dbo].[Address] ([Id], [FI_Person], [Kind], [Country3166], [Zip], [City], [Line1], [Line2]) VALUES (1, 6, N'RES       ', N'HU', N'1162', N'Budapest', N'Diófa utca 120.', NULL)
GO
INSERT [dbo].[Address] ([Id], [FI_Person], [Kind], [Country3166], [Zip], [City], [Line1], [Line2]) VALUES (2, 7, N'MAIL      ', N'HU', N'1143', N'Budapest', N'Lakat utca 45.', NULL)
GO
INSERT [dbo].[Address] ([Id], [FI_Person], [Kind], [Country3166], [Zip], [City], [Line1], [Line2]) VALUES (3, 14, N'MAIL      ', N'HU', N'1018', N'Budapest', N'Ostrom utca 33.', NULL)
GO
INSERT [dbo].[Address] ([Id], [FI_Person], [Kind], [Country3166], [Zip], [City], [Line1], [Line2]) VALUES (4, 15, N'MAIL      ', N'HU', N'1191', N'Budapest', N'Jósika utca 3.', NULL)
GO
SET IDENTITY_INSERT [dbo].[Address] OFF
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (1, NULL, N'Alfonz', N'Senki', N'+361457896', NULL, NULL)
GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (6, NULL, N'Jakab', N'Buga', N'+361857896', NULL, NULL)
GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (7, NULL, N'András', N'Nagy', NULL, NULL, NULL)
GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (8, N'Dr.', N'Ferenc', N'Kis', N'+361466896', NULL, N'ferenc45@gmail.com')
GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (9, NULL, N'Mária', N'Körmendi', N'+3680568741', NULL, NULL)
GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (10, NULL, N'Ferenc', N'Tihanyi', NULL, N'+36708512478', NULL)
GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (11, NULL, N'Klára', N'Szegedi', N'+361457896', NULL, NULL)
GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (12, N'Ifj.', N'András', N'Szegedi', NULL, NULL, NULL)
GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (13, NULL, N'Viktória', N'Debreceni', N'+4425789636', NULL, N'viki@sehol.hu')
GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (14, NULL, N'Andrea', N'Veszprémi', NULL, NULL, NULL)
GO
INSERT [dbo].[Person] ([Id], [Titles], [FirstName], [LastName], [Phone], [Mobile], [Email]) VALUES (15, NULL, N'Brigitta', N'Zombori', NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
