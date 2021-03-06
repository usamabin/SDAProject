USE [HospitalMS]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 6/23/2020 6:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Administrator](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[Username] [varchar](30) NOT NULL,
	[UserPass] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Appointment](
	[AppointmentID] [int] NOT NULL,
	[PatientID] [int] NULL,
	[DoctorID] [int] NULL,
	[ReceptionistID] [int] NULL,
	[ProblemType] [varchar](50) NULL,
	[Descriptions] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AppointmentDetail]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppointmentDetail](
	[AppointmentDetailID] [int] NOT NULL,
	[MedicineID] [int] NULL,
	[AppointmnetID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AppointmentDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AvailableDays]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AvailableDays](
	[DayID] [int] NULL,
	[DocID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctor](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[FatherName] [varchar](50) NULL,
	[Username] [varchar](30) NOT NULL,
	[UserPass] [varchar](20) NOT NULL,
	[Salary] [varchar](20) NULL,
	[Speciality] [varchar](50) NULL,
	[PhoneNum] [varchar](20) NULL,
	[Cnic] [varchar](20) NULL,
	[Address] [varchar](50) NULL,
	[DaoteofBirth] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Handleby]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Handleby](
	[PharmistID] [int] NULL,
	[AppointmnetDetailID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medicine](
	[MedicineID] [int] NOT NULL,
	[Name] [varchar](20) NULL,
	[quantity] [int] NULL,
	[price] [int] NULL,
	[ExpDate] [datetime] NULL,
	[medicinetype] [varchar](20) NULL,
	[problemtype] [varchar](20) NULL,
	[MedicineDescription] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MedicineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OfferedMedicine]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OfferedMedicine](
	[ID] [int] NOT NULL,
	[patientid] [int] NULL,
	[Name] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[FatherName] [varchar](50) NULL,
	[Username] [varchar](30) NOT NULL,
	[UserPass] [varchar](20) NOT NULL,
	[PhoneNum] [varchar](20) NULL,
	[Cnic] [varchar](20) NULL,
	[Address] [varchar](50) NULL,
	[Day] [varchar](20) NULL,
	[DiseaseType] [varchar](20) NULL,
	[ReferedTo] [varchar](20) NULL,
	[DateofBirth] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pharmist]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pharmist](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[FatherName] [varchar](50) NULL,
	[Username] [varchar](30) NOT NULL,
	[UserPass] [varchar](20) NOT NULL,
	[PhoneNum] [varchar](20) NULL,
	[Cnic] [varchar](20) NULL,
	[Address] [varchar](50) NULL,
	[Salary] [varchar](20) NULL,
	[DaoteofBirth] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reception]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reception](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[FatherName] [varchar](50) NULL,
	[Username] [varchar](30) NOT NULL,
	[UserPass] [varchar](20) NOT NULL,
	[PhoneNum] [varchar](20) NULL,
	[Cnic] [varchar](20) NULL,
	[Address] [varchar](50) NULL,
	[Salary] [varchar](20) NULL,
	[DaoteofBirth] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Report]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Report](
	[ID] [int] NOT NULL,
	[patientid] [int] NULL,
	[Name] [varchar](20) NULL,
	[PhoneNumber] [int] NULL,
	[Cnic] [int] NULL,
	[PAddress] [datetime] NULL,
	[diseaseType] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WorkingDays]    Script Date: 6/23/2020 6:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WorkingDays](
	[DayID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[DayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctor] ([ID])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([ReceptionistID])
REFERENCES [dbo].[Reception] ([ID])
GO
ALTER TABLE [dbo].[AppointmentDetail]  WITH CHECK ADD FOREIGN KEY([AppointmnetID])
REFERENCES [dbo].[Appointment] ([AppointmentID])
GO
ALTER TABLE [dbo].[AppointmentDetail]  WITH CHECK ADD FOREIGN KEY([MedicineID])
REFERENCES [dbo].[Medicine] ([MedicineID])
GO
ALTER TABLE [dbo].[AvailableDays]  WITH CHECK ADD FOREIGN KEY([DocID])
REFERENCES [dbo].[WorkingDays] ([DayID])
GO
ALTER TABLE [dbo].[AvailableDays]  WITH CHECK ADD FOREIGN KEY([DayID])
REFERENCES [dbo].[Doctor] ([ID])
GO
ALTER TABLE [dbo].[Handleby]  WITH CHECK ADD FOREIGN KEY([AppointmnetDetailID])
REFERENCES [dbo].[AppointmentDetail] ([AppointmentDetailID])
GO
ALTER TABLE [dbo].[Handleby]  WITH CHECK ADD FOREIGN KEY([PharmistID])
REFERENCES [dbo].[Pharmist] ([ID])
GO
ALTER TABLE [dbo].[OfferedMedicine]  WITH CHECK ADD FOREIGN KEY([patientid])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD FOREIGN KEY([patientid])
REFERENCES [dbo].[Patient] ([ID])
GO
