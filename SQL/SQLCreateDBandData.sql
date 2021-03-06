USE [ContosoUniversity]
GO

/****** Object:  Table [dbo].[Course]    Script Date: 07/21/2014 12:25:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Course](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Credits] [int] NULL,
PRIMARY KEY CLUSTERED (
	[CourseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstMidName] [nvarchar](50) NULL,
	[EnrollmentDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[Enrollment](
	[EnrollmentID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[Grade] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EnrollmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Enrollment_dbo.Course_CourseID] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_dbo.Enrollment_dbo.Course_CourseID]
GO

ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Enrollment_dbo.Student_StudentID] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_dbo.Enrollment_dbo.Student_StudentID]
GO




Insert Into ContosoUniversity.dbo.Student (FirstMidName,LastName,EnrollmentDate)
			Select FirstMidName='Carson',LastName='Alexander',EnrollmentDate=('2005-09-01')
Union all	Select FirstMidName='Meredith',LastName='Alonso',EnrollmentDate=('2002-09-01')
Union all	Select FirstMidName='Arturo',LastName='Anand',EnrollmentDate=('2003-09-01')
Union all	Select FirstMidName='Gytis',LastName='Barzdukas',EnrollmentDate=('2002-09-01') 
Union all	Select FirstMidName='Yan',LastName='Li',EnrollmentDate=('2002-09-01')
Union all	Select FirstMidName='Peggy',LastName='Justice',EnrollmentDate=('2001-09-01')
Union all	Select FirstMidName='Laura',LastName='Norman',EnrollmentDate=('2003-09-01')
Union all	Select FirstMidName='Nino',LastName='Olivetto',EnrollmentDate=('2005-09-01')

SET IDENTITY_INSERT dbo.Course ON
Insert Into ContosoUniversity.dbo.Course (CourseID,Title,Credits)
			Select CourseID=1050,Title='Chemistry',Credits=3
Union all	Select CourseID=4022,Title='Microeconomics',Credits=3
Union all	Select CourseID=4041,Title='Macroeconomics',Credits=3
Union all	Select CourseID=1045,Title='Calculus',Credits=4
Union all	Select CourseID=3141,Title='Trigonometry',Credits=4
Union all	Select CourseID=2021,Title='Composition',Credits=3
Union all	Select CourseID=2042,Title='Literature',Credits=4
SET IDENTITY_INSERT dbo.Course OFF

Insert Into ContosoUniversity.dbo.Enrollment (StudentID,CourseID,Grade)
			Select StudentID=1,CourseID=1050,Grade=0
Union all	Select StudentID=1,CourseID=4022,Grade=2
Union all	Select StudentID=1,CourseID=4041,Grade=1
Union all	Select StudentID=2,CourseID=1045,Grade=1
Union all	Select StudentID=2,CourseID=3141,Grade=4
Union all	Select StudentID=2,CourseID=2021,Grade=4
Union all	Select StudentID=3,CourseID=1050,null
Union all	Select StudentID=4,CourseID=1050,null
Union all	Select StudentID=4,CourseID=4022,Grade=4
Union all	Select StudentID=5,CourseID=4041,Grade=2
Union all	Select StudentID=6,CourseID=1045,null
Union all	Select StudentID=7,CourseID=3141,Grade=0
