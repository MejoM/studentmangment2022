USE [SmDb]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 27-07-2022 13:12:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Regno] [int] IDENTITY(1,1) NOT NULL,
	[Student_Full_Name] [varchar](30) NOT NULL,
	[CourseJoin] [varchar](30) NOT NULL,
	[Course_Fee] [numeric](8, 2) NOT NULL,
	[BatchID] [varchar](30) NOT NULL,
	[DOJ] [date] NULL,
	[StudentAddress] [varchar](300) NOT NULL,
	[Mobile_Number] [varchar](10) NOT NULL,
	[EmailId] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Regno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Regno], [Student_Full_Name], [CourseJoin], [Course_Fee], [BatchID], [DOJ], [StudentAddress], [Mobile_Number], [EmailId]) VALUES (1, N'Mejo M', N'.NET', CAST(12000.00 AS Numeric(8, 2)), N'Netpvc', CAST(N'0001-01-01' AS Date), N'Kanniaya kumari', N'8270177193', N'mejo@gmail.com')
INSERT [dbo].[Student] ([Regno], [Student_Full_Name], [CourseJoin], [Course_Fee], [BatchID], [DOJ], [StudentAddress], [Mobile_Number], [EmailId]) VALUES (2, N'Shibin', N'.NET', CAST(10000.00 AS Numeric(8, 2)), N'Netjvc', CAST(N'2022-07-27' AS Date), N'Kollam', N'7867070694', N'sibin@gmail.com')
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Student__7ED91ACEA5E5CFA8]    Script Date: 27-07-2022 13:12:59 ******/
ALTER TABLE [dbo].[Student] ADD UNIQUE NONCLUSTERED 
(
	[EmailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Student__C892EBD62E41050A]    Script Date: 27-07-2022 13:12:59 ******/
ALTER TABLE [dbo].[Student] ADD UNIQUE NONCLUSTERED 
(
	[Mobile_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Student] ADD  DEFAULT (getdate()) FOR [DOJ]
GO
