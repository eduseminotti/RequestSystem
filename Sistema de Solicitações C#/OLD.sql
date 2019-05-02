

USE [Seminotti_Teste]
GO

--	[Providers] 1

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Providers](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Razao_Social] [varchar](255) NOT NULL,
	[Nome_Fantasia] [varchar](255) NULL,
	[CNPJ] [varchar](20) NOT NULL,
	[Phone] [varchar](20) NULL,
	[INSERTDATE] [datetime] NULL,
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CNPJ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Providers] ADD  DEFAULT (getdate()) FOR [INSERTDATE]
GO


--[Notas_Fiscais] 2 

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Notas_Fiscais](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[SeriesNFe] [int] NOT NULL,
	[NumberNFe] [bigint] NOT NULL,
	[ProviderID] [bigint] NOT NULL,
	[EmissionDate] [datetime] NOT NULL,
	[insertdate] [datetime] NOT NULL,
 CONSTRAINT [PK_Notas_Fiscais] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Notas_Fiscais] ADD  CONSTRAINT [DF__Notas_Fis__inser__4222D4EF]  DEFAULT (getdate()) FOR [insertdate]
GO

ALTER TABLE [dbo].[Notas_Fiscais]  WITH CHECK ADD  CONSTRAINT [FK_Notas_Fiscais_Providers] FOREIGN KEY([ProviderID])
REFERENCES [dbo].[Providers] ([ID])
GO

ALTER TABLE [dbo].[Notas_Fiscais] CHECK CONSTRAINT [FK_Notas_Fiscais_Providers]
GO


----[Products] 3 

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Nome_produto] [varchar](255) NOT NULL,
	[Descrição_produto] [varchar](255) NULL,
	[Tipo_unidade] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

----[NFe_Itens] 4

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NFe_Itens](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[numero_item] [int] NOT NULL,
	[Quantidade] [bigint] NOT NULL,
	[produtcID] [bigint] NOT NULL,
	[NFEID] [bigint] NOT NULL,
	[Insertdate] [datetime] NOT NULL,
 CONSTRAINT [PK_NFe_Itens1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[NFe_Itens] ADD  CONSTRAINT [DF_NFe_Itens1_Insertdate]  DEFAULT (getdate()) FOR [Insertdate]
GO

ALTER TABLE [dbo].[NFe_Itens]  WITH CHECK ADD  CONSTRAINT [FK_NFe_Itens_Notas_Fiscais] FOREIGN KEY([NFEID])
REFERENCES [dbo].[Notas_Fiscais] ([ID])
GO

ALTER TABLE [dbo].[NFe_Itens] CHECK CONSTRAINT [FK_NFe_Itens_Notas_Fiscais]
GO

ALTER TABLE [dbo].[NFe_Itens]  WITH CHECK ADD  CONSTRAINT [FK_NFe_Itens_Products] FOREIGN KEY([produtcID])
REFERENCES [dbo].[Products] ([ID])
GO

ALTER TABLE [dbo].[NFe_Itens] CHECK CONSTRAINT [FK_NFe_Itens_Products]
GO

----[Stock_Itens] 5


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Stock_Itens](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[Quantidade] [bigint] NOT NULL,
 CONSTRAINT [PK_Stock_Itens] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




-- user 7 
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Phone] [varchar](20) NULL,
	[eMail] [varchar](255) NULL,
	[UserName] [varchar](20) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Type] [int] NOT NULL,
	[Login_Active] [bit] NOT NULL,
	[isActive] [bit] NOT NULL,
	[Idioma] [int] NOT NULL,
	[Insertdate] [datetime] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Insertdate_1]  DEFAULT (getdate()) FOR [Insertdate]
GO




-- Solicitation 8

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Solicitation](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[User_Requester] [bigint] NOT NULL,
	[User_Approver] [bigint] NULL,
	[Approval_Date] [date] NULL,
	[status] [bit] NOT NULL,
	[InsertDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Solicitation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Solicitation] ADD  CONSTRAINT [DF_Solicitation_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO

ALTER TABLE [dbo].[Solicitation]  WITH CHECK ADD  CONSTRAINT [FK_Solicitation_User] FOREIGN KEY([User_Requester])
REFERENCES [dbo].[Users] ([ID])
GO

ALTER TABLE [dbo].[Solicitation] CHECK CONSTRAINT [FK_Solicitation_User]
GO

ALTER TABLE [dbo].[Solicitation]  WITH CHECK ADD  CONSTRAINT [FK_Solicitation_User1] FOREIGN KEY([User_Approver])
REFERENCES [dbo].[Users] ([ID])
GO

ALTER TABLE [dbo].[Solicitation] CHECK CONSTRAINT [FK_Solicitation_User1]
GO


-- [Solicitation_Itens] 9


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Solicitation_Itens](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[SolicitationID] [bigint] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[Quantidade] [bigint] NOT NULL,
 CONSTRAINT [PK_Solicitation_Itens] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Solicitation_Itens]  WITH CHECK ADD  CONSTRAINT [FK_Solicitation_Itens_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO

ALTER TABLE [dbo].[Solicitation_Itens] CHECK CONSTRAINT [FK_Solicitation_Itens_Products]
GO

ALTER TABLE [dbo].[Solicitation_Itens]  WITH CHECK ADD  CONSTRAINT [FK_Solicitation_Itens_Solicitation] FOREIGN KEY([SolicitationID])
REFERENCES [dbo].[Solicitation] ([ID])
GO

ALTER TABLE [dbo].[Solicitation_Itens] CHECK CONSTRAINT [FK_Solicitation_Itens_Solicitation]
GO











