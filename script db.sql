USE [demo]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 27/6/2020 17:50:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeLastName] [varchar](500) NULL,
	[EmployeeFirstName] [varchar](500) NULL,
	[EmployeePhone] [varchar](50) NULL,
	[EmployeeZip] [varchar](50) NULL,
	[EmployeeHireDate] [date] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [EmployeeHireDate]) VALUES (1, N'Deras ventura.', N'Juan jose', N'(766)6075-588', N'1234', CAST(N'2020-05-31' AS Date))
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [EmployeeHireDate]) VALUES (2, N'Melendez', N'Eugenia Beatriz', N'(786)7988-8', N'124', CAST(N'2020-04-01' AS Date))
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [EmployeeHireDate]) VALUES (3, N'deras', N'aby', N'76660755', N'123', CAST(N'2020-06-01' AS Date))
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [EmployeeHireDate]) VALUES (5, N'desire', N'lucas', N'89876512', N'102', CAST(N'2020-06-01' AS Date))
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [EmployeeHireDate]) VALUES (7, N'ribery', N'frank', N'12345678', N'123', CAST(N'2020-07-05' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
