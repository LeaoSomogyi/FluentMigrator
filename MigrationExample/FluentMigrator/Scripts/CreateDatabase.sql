USE DBObraPerfeita
GO

IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'TOPAddress')
BEGIN
	CREATE TABLE [dbo].[TOPAddress]
	(
		[Code_Address] [uniqueidentifier] NOT NULL,
		[UF_Address] [nvarchar](20) NOT NULL,
		[District_Address] [nvarchar](100) NOT NULL,
		[City_Address] [nvarchar](100) NOT NULL,
		[Number_Address] [int] NOT NULL,
		[Complement_Address] [nvarchar](200) NOT NULL,
		[Phone_Address] [nvarchar](15) NOT NULL,
		[Code_Provider] [uniqueidentifier] NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[Code_Address] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	ALTER TABLE [dbo].[TOPAddress]  WITH CHECK ADD  CONSTRAINT [FK_ProviderCode_Address] FOREIGN KEY([Code_Provider])
	REFERENCES [dbo].[TOPProvider] ([Code_Provider])

	ALTER TABLE [dbo].[TOPAddress] CHECK CONSTRAINT [FK_ProviderCode_Address]
END