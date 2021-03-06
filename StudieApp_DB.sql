USE [master]
GO
/****** Object:  Database [StudieApp]    Script Date: 03/07/2022 20:56:11 ******/
CREATE DATABASE [StudieApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudieApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.HOBBITPC\MSSQL\DATA\StudieApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudieApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.HOBBITPC\MSSQL\DATA\StudieApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StudieApp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudieApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudieApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudieApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudieApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudieApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudieApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudieApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudieApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudieApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudieApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudieApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudieApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudieApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudieApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudieApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudieApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudieApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudieApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudieApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudieApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudieApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudieApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudieApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudieApp] SET RECOVERY FULL 
GO
ALTER DATABASE [StudieApp] SET  MULTI_USER 
GO
ALTER DATABASE [StudieApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudieApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudieApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudieApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudieApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudieApp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudieApp', N'ON'
GO
ALTER DATABASE [StudieApp] SET QUERY_STORE = OFF
GO
USE [StudieApp]
GO
/****** Object:  Table [dbo].[Board_Table]    Script Date: 03/07/2022 20:56:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Board_Table](
	[BoardId] [int] IDENTITY(1,1) NOT NULL,
	[GameId] [int] NOT NULL,
 CONSTRAINT [PK_Board_Table] PRIMARY KEY CLUSTERED 
(
	[BoardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Card_Table]    Script Date: 03/07/2022 20:56:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Card_Table](
	[CardId] [int] IDENTITY(1,1) NOT NULL,
	[CardText] [varchar](255) NOT NULL,
	[Effect] [varchar](255) NOT NULL,
	[BoardId] [int] NULL,
 CONSTRAINT [PK_Card_Table] PRIMARY KEY CLUSTERED 
(
	[CardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category_Table]    Script Date: 03/07/2022 20:56:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category_Table](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Description] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Category_Table] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Game_Table]    Script Date: 03/07/2022 20:56:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game_Table](
	[GameId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Game_Table] PRIMARY KEY CLUSTERED 
(
	[GameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GamePlayer_Table]    Script Date: 03/07/2022 20:56:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GamePlayer_Table](
	[GameId] [int] NOT NULL,
	[PlayerId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Player_Table]    Script Date: 03/07/2022 20:56:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Player_Table](
	[PlayerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Money] [int] NULL,
	[OccupiedPlot] [int] NULL,
 CONSTRAINT [PK_Player_Table] PRIMARY KEY CLUSTERED 
(
	[PlayerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plot_Table]    Script Date: 03/07/2022 20:56:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plot_Table](
	[PlotId] [int] IDENTITY(1,1) NOT NULL,
	[PlotType] [varchar](255) NOT NULL,
	[BoardId] [int] NULL,
	[Owner] [int] NULL,
 CONSTRAINT [PK_Plot_Table] PRIMARY KEY CLUSTERED 
(
	[PlotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question_Table]    Script Date: 03/07/2022 20:56:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question_Table](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionText] [varchar](255) NOT NULL,
	[Answer] [varchar](255) NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Question_Table] PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Card_Table] ON 

INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (1, N'Je hebt 50 euro verdient', N'+ 50 money', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (2, N'Je hebt 100 euro verdient', N'+ 100 money', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (3, N'Je hebt 50 euro verdient', N'+50 money', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (4, N'Iedereen verdient 200 euro', N'+200 money all', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (5, N'Iedereen verdient 100 euro', N'+100 money all', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (6, N'Iedereen verliest 50 euro', N'- 50 money all', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (7, N'Iedereen verliest 100 euro', N'- 100 money all', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (8, N'Je verliest 100 euro', N'- 100 money', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (9, N'Je verliest 50 euro', N'- 50 money', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (10, N'Je gaat 3 vakjes terug', N'- 3 squares', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (11, N'Ga terug naar start, je krijgt geen geld', N'Start', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (12, N'Ga naar de gevangenis, je krijgt geen geld', N'Jail', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (13, N'Je gaat 3 vakjes vooruit', N'+3 squares', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (14, N'Je gaat 2 vakjes terug', N'- 2 squares', NULL)
INSERT [dbo].[Card_Table] ([CardId], [CardText], [Effect], [BoardId]) VALUES (15, N'Je gaat 2 vakjes vooruit', N'+ 2 squares', NULL)
SET IDENTITY_INSERT [dbo].[Card_Table] OFF
GO
SET IDENTITY_INSERT [dbo].[Category_Table] ON 

INSERT [dbo].[Category_Table] ([CategoryId], [Name], [Description]) VALUES (1, N'Scripting', N'Het leukste python vak ooit')
INSERT [dbo].[Category_Table] ([CategoryId], [Name], [Description]) VALUES (2, N'Professional Skills', N'Iedereen was slecht in hogeschool taal')
INSERT [dbo].[Category_Table] ([CategoryId], [Name], [Description]) VALUES (5, N'Testing', N'')
INSERT [dbo].[Category_Table] ([CategoryId], [Name], [Description]) VALUES (6, N'Requirements Engineering', N'')
INSERT [dbo].[Category_Table] ([CategoryId], [Name], [Description]) VALUES (7, N'Team Skills', N'')
INSERT [dbo].[Category_Table] ([CategoryId], [Name], [Description]) VALUES (8, N'Programming Concepts', N'')
INSERT [dbo].[Category_Table] ([CategoryId], [Name], [Description]) VALUES (9, N'Project management', N'')
INSERT [dbo].[Category_Table] ([CategoryId], [Name], [Description]) VALUES (10, N'Software modelling', N'')
INSERT [dbo].[Category_Table] ([CategoryId], [Name], [Description]) VALUES (11, N'Methodical skills', N'')
SET IDENTITY_INSERT [dbo].[Category_Table] OFF
GO
SET IDENTITY_INSERT [dbo].[Game_Table] ON 

INSERT [dbo].[Game_Table] ([GameId], [Name], [CategoryId]) VALUES (1, N'Miel & Bob Test', 1)
INSERT [dbo].[Game_Table] ([GameId], [Name], [CategoryId]) VALUES (12, N'Groep 4 test', 10)
SET IDENTITY_INSERT [dbo].[Game_Table] OFF
GO
INSERT [dbo].[GamePlayer_Table] ([GameId], [PlayerId]) VALUES (1, 1)
INSERT [dbo].[GamePlayer_Table] ([GameId], [PlayerId]) VALUES (1, 2)
INSERT [dbo].[GamePlayer_Table] ([GameId], [PlayerId]) VALUES (12, 21)
INSERT [dbo].[GamePlayer_Table] ([GameId], [PlayerId]) VALUES (12, 22)
INSERT [dbo].[GamePlayer_Table] ([GameId], [PlayerId]) VALUES (12, 23)
GO
SET IDENTITY_INSERT [dbo].[Player_Table] ON 

INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (1, N'Miel', NULL, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (2, N'Bob', NULL, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (3, N'Lotte', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (4, N'Lotte', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (5, N'Lotte', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (6, N'Hobbit', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (7, N'Lotte', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (8, N'Change', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (9, N'Lotte', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (10, N'Hassan', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (11, N'Joes', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (12, N'Joes', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (13, N'Joes', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (14, N'yep yep', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (15, N'Yep Yep', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (16, N'Blub', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (17, N'yep', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (18, N'Mitchello', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (19, N'Lotte', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (20, N'Lottte', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (21, N'Hassan', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (22, N'Joes', 200, NULL)
INSERT [dbo].[Player_Table] ([PlayerId], [Name], [Money], [OccupiedPlot]) VALUES (23, N'Lotte', 200, NULL)
SET IDENTITY_INSERT [dbo].[Player_Table] OFF
GO
SET IDENTITY_INSERT [dbo].[Plot_Table] ON 

INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (1, N'Start', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (2, N'House1', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (3, N'House1', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (4, N'Card', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (5, N'House1', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (6, N'House1', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (7, N'Card', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (8, N'House1', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (9, N'House1', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (10, N'Vrij Parkeren', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (11, N'House2', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (12, N'House2', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (13, N'Card', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (14, N'House2', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (15, N'House2', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (16, N'Card', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (17, N'House2', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (18, N'House2', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (19, N'Jail', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (20, N'House3', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (21, N'House3', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (22, N'Card', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (23, N'House3', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (24, N'House3', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (26, N'Card', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (27, N'House3', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (28, N'House3', NULL, NULL)
INSERT [dbo].[Plot_Table] ([PlotId], [PlotType], [BoardId], [Owner]) VALUES (29, N'End', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Plot_Table] OFF
GO
SET IDENTITY_INSERT [dbo].[Question_Table] ON 

INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (14, N'Een high-level language is een programeertaal, zoals Python, dat ontworpen is om gemakkelijk door mensen te lezen of schrijven, Waar of onwaar?', N'Waar', 1)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (15, N'Een portable computer programma is een programma dat op meer dan een soort computer uitgevoerd kan worden. Bijvoorbeeld op computers van verschillende operating systemen, waar of onwaar?', N'waar', 1)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (16, N'Recursie is het proces waarbij een lus wordt doorlopen, waar of onwaar?', N'onwaar', 1)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (17, N'Een algoritme is een specefieke oplossing voor voor een specefiek probleemm, waar of onwaar?', N'onwaar', 1)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (18, N'Binnen een dictionary wordt een "key-value pair" ook wel "item" genoemd, waar of onwaar?', N'waar', 1)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (19, N'Een void function is een voorbeeld van een fruitful function, waar of onwaar?', N'onwaar', 1)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (20, N'Een functie is een voorbeeld van een composition, waar of onwaar?', N'waar', 1)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (21, N'Argument is de naam voor de waarde die binnen een functie beschikbaar is vanuit de aanroep, waar of onwaar?', N'onwaar', 1)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (22, N'Een string is een data type dat een opeenvolgind van karakters voorstelt.', N'Waar', 1)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (23, N'Code in een functie na een return statement wordt niet uitgevoerd. Dit heet ook wel  "dead code", waar of onwaar?', N'waar', 1)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (24, N'Als je de lezer iets wilt laten weten over een onderwerp wat is dan het tekstdoel? Informeren, amuseren, motiveren of instrueren?', N'Informeren', 2)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (25, N'Welk tekstdoel heeft de gebruiksaanwijzing van een nieuwe televisie? Informeren, amuseren, overtuigen of instrueren?', N'Instrueren', 2)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (26, N'Als je informatiebronnen zoekt dan kan je met Booleanse operatoren de zoektermijnen verfijnen. Wat zijn booleaanse operatoren? Like, Nearby, Amongst? *,+,-:? [], "", ~? AND, OR, NOT?', N'AND, OR, NOT', 2)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (27, N'Een wetenschappelijk tijdschrift wordt gekenmerkt door een strenge kwaliteitscontrole uitgevoerd door onafhankelijke collega''s, hoe heet dit toetsingssysteem?', N'Peer review', 2)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (28, N'De Kolb-test is een.....? Leerstijlentest, persoonlijkheidstest, test om een opleidingsbeeld te krijgen of een test om een beroepsbeeld te krijgen?', N'Leerstijlentest', 2)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (29, N'Waar staat de letter R in SMART voor?', N'Realistisch', 6)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (30, N'Een requirement is....? Een eis voor een nog te ontwikkelen product? Een doelstelling van een nog te ontwikkelen product? Een behoeft van een stakeholder? Een voorwaarde van een stakeholder?', N'Een eis voor een nog te ontwikkelen product', 6)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (31, N'"Een klant moet binnen 5 seconden het bestelde product in het winkelwagentje zien." Is dit een funtionele eis of een niet-functionele eis (Performance)?', N'Niet-funtionele eis', 6)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (32, N'Moet een requirements analist een probleemoplossend vermogen hebben, waar of onwaar?', N'waar', 6)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (33, N'Observatie is een belangrijke elicitatietechniek waarbij een stakeholder de belangrijkste bron van informatie is, waar of onwaar?', N'onwaar', 6)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (34, N'Als <persona> wil ik <activiteit>, zodat <beoogd resultaat>. Is dit de correcte template voor een user story, waar of onwaar?', N'onwaar', 6)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (35, N'Kwaliteit is een subjectief begrip. Wat jij kwalitatief goed vindt van bijvoorbeeld een smartphone, kan door iemand anders als slecht worden ervaren, waar of onwaar?', N'waar', 5)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (36, N'Je controleert of de ontwikkelaars de juiste functionaliteit hebben geleverd voor het oplossen van het probleem van de opdrachtgever. Dit wordt verificatie genoemd, waar of onwaar?', N'onwaar', 5)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (37, N'Bij de agile methode kunnen de volgende producten binnen één sprint simultaan worden vervaardigd: gebruikerseisen, systeemeisen, basisontwerp, detailontwerp, programmacode, waar of onwaar?', N'waar', 5)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (38, N'Verificatie is een bevestiging door onderzoek en door aanleveren van objectief bewijsmateriaal dat aan de eisen ten aanzien van een specifieke wijze van gebruik of toepassing is voldaan, waar of onwaar?', N'onwaar', 5)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (39, N'Testgevallen gebruik je om te onderzoeken of een systeem onder
bepaalde omstandigheden het gewenste gedrag toont. ', N'waar', 5)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (40, N'Bij equivalentieklassen definieer je maximaal één invoerwaarde
per fysiek testgeval. ', N'waar', 5)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (41, N'Use case test is een zeer formele techniek. Daarom moet je deze
techniek alléén volgens standaard procedures uitvoeren, waar of onwaar?', N'onwaar', 5)
INSERT [dbo].[Question_Table] ([QuestionId], [QuestionText], [Answer], [CategoryId]) VALUES (42, N'De procescyclustest is een black box testtechniek waarmee
testgevallen worden ontworpen om bedrijfsprocedures en
processen af te dekken, waar of onwaar?', N'waar', 5)
SET IDENTITY_INSERT [dbo].[Question_Table] OFF
GO
ALTER TABLE [dbo].[Board_Table]  WITH CHECK ADD  CONSTRAINT [FK_Board_Game] FOREIGN KEY([GameId])
REFERENCES [dbo].[Game_Table] ([GameId])
GO
ALTER TABLE [dbo].[Board_Table] CHECK CONSTRAINT [FK_Board_Game]
GO
ALTER TABLE [dbo].[Card_Table]  WITH CHECK ADD  CONSTRAINT [FK_Card_Board] FOREIGN KEY([BoardId])
REFERENCES [dbo].[Board_Table] ([BoardId])
GO
ALTER TABLE [dbo].[Card_Table] CHECK CONSTRAINT [FK_Card_Board]
GO
ALTER TABLE [dbo].[Game_Table]  WITH CHECK ADD  CONSTRAINT [FK_Game_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category_Table] ([CategoryId])
GO
ALTER TABLE [dbo].[Game_Table] CHECK CONSTRAINT [FK_Game_Category]
GO
ALTER TABLE [dbo].[GamePlayer_Table]  WITH CHECK ADD  CONSTRAINT [FK_GamePlayer_Game] FOREIGN KEY([GameId])
REFERENCES [dbo].[Game_Table] ([GameId])
GO
ALTER TABLE [dbo].[GamePlayer_Table] CHECK CONSTRAINT [FK_GamePlayer_Game]
GO
ALTER TABLE [dbo].[GamePlayer_Table]  WITH CHECK ADD  CONSTRAINT [FK_GamePlayer_Player] FOREIGN KEY([PlayerId])
REFERENCES [dbo].[Player_Table] ([PlayerId])
GO
ALTER TABLE [dbo].[GamePlayer_Table] CHECK CONSTRAINT [FK_GamePlayer_Player]
GO
ALTER TABLE [dbo].[Player_Table]  WITH CHECK ADD  CONSTRAINT [FK_Player_OccupiedPlot] FOREIGN KEY([OccupiedPlot])
REFERENCES [dbo].[Plot_Table] ([PlotId])
GO
ALTER TABLE [dbo].[Player_Table] CHECK CONSTRAINT [FK_Player_OccupiedPlot]
GO
ALTER TABLE [dbo].[Plot_Table]  WITH CHECK ADD  CONSTRAINT [FK_Plot_Board] FOREIGN KEY([BoardId])
REFERENCES [dbo].[Board_Table] ([BoardId])
GO
ALTER TABLE [dbo].[Plot_Table] CHECK CONSTRAINT [FK_Plot_Board]
GO
ALTER TABLE [dbo].[Plot_Table]  WITH CHECK ADD  CONSTRAINT [FK_Plot_Owner] FOREIGN KEY([Owner])
REFERENCES [dbo].[Player_Table] ([PlayerId])
GO
ALTER TABLE [dbo].[Plot_Table] CHECK CONSTRAINT [FK_Plot_Owner]
GO
ALTER TABLE [dbo].[Question_Table]  WITH CHECK ADD  CONSTRAINT [FK_Question_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category_Table] ([CategoryId])
GO
ALTER TABLE [dbo].[Question_Table] CHECK CONSTRAINT [FK_Question_Category]
GO
USE [master]
GO
ALTER DATABASE [StudieApp] SET  READ_WRITE 
GO
