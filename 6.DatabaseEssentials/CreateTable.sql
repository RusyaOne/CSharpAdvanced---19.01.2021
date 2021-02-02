use [CSharpAdvanced]
go

create table [dbo].[Characters](
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[Gender] [bit] NOT NULL,
	[Age] [int] NOT NULL
) on [PRIMARY]
go


drop table Characters
go


