USE [TUPPI]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 02/06/2025 14:17:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autores](
	[idAutor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 02/06/2025 14:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[idLibro] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](50) NULL,
	[autor] [int] NULL,
	[formato] [int] NULL,
	[fechaPublicacion] [date] NULL,
	[precio] [float] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Autores] ON 

INSERT [dbo].[Autores] ([idAutor], [nombre]) VALUES (1, N'Borges')
INSERT [dbo].[Autores] ([idAutor], [nombre]) VALUES (2, N'Hernandez')
INSERT [dbo].[Autores] ([idAutor], [nombre]) VALUES (3, N'Allende')
INSERT [dbo].[Autores] ([idAutor], [nombre]) VALUES (4, N'Sabato')
SET IDENTITY_INSERT [dbo].[Autores] OFF
GO
SET IDENTITY_INSERT [dbo].[Libros] ON 

INSERT [dbo].[Libros] ([idLibro], [titulo], [autor], [formato], [fechaPublicacion], [precio]) VALUES (1, N'La casa de los espíritus', 4, 0, CAST(N'1982-05-12' AS Date), 1500)
INSERT [dbo].[Libros] ([idLibro], [titulo], [autor], [formato], [fechaPublicacion], [precio]) VALUES (2, N'mi libro', 2, 2, CAST(N'2023-06-21' AS Date), 3200)
INSERT [dbo].[Libros] ([idLibro], [titulo], [autor], [formato], [fechaPublicacion], [precio]) VALUES (3, N'Otro libro', 1, 2, CAST(N'2023-06-30' AS Date), 3500)
INSERT [dbo].[Libros] ([idLibro], [titulo], [autor], [formato], [fechaPublicacion], [precio]) VALUES (4, N'Hola?', 4, 2, CAST(N'2023-06-21' AS Date), 32)
INSERT [dbo].[Libros] ([idLibro], [titulo], [autor], [formato], [fechaPublicacion], [precio]) VALUES (5, N'Hola que tal!', 4, 1, CAST(N'2023-06-13' AS Date), 99999)
INSERT [dbo].[Libros] ([idLibro], [titulo], [autor], [formato], [fechaPublicacion], [precio]) VALUES (6, N'Todo bien y vos?', 4, 1, CAST(N'2023-06-13' AS Date), 99999)
INSERT [dbo].[Libros] ([idLibro], [titulo], [autor], [formato], [fechaPublicacion], [precio]) VALUES (7, N'Como tener novia!', 4, 2, CAST(N'2023-06-02' AS Date), 8500)
INSERT [dbo].[Libros] ([idLibro], [titulo], [autor], [formato], [fechaPublicacion], [precio]) VALUES (8, N'dsad', 4, 2, CAST(N'2023-06-19' AS Date), 323)
SET IDENTITY_INSERT [dbo].[Libros] OFF
GO
