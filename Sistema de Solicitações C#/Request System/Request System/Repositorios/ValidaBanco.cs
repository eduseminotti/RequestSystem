using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Request_System
{
    public class CriaTabelas
    {


        public void CriaTabelaUsers()
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            String queryString = "   SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON SET ANSI_PADDING ON CREATE TABLE [dbo].[Users]( " +
                "	[ID] [bigint] IDENTITY(1,1) NOT NULL, [Name] [varchar](255) NOT NULL, [cpf] [varchar](20) NULL, [eMail] [varchar](255) NULL,	" +
                "[UserName] [varchar](50) NOT NULL, [Password] [nvarchar](max) NOT NULL, [isActive] [int] NOT NULL, [setor] [nchar](50) NULL, [Type] [int] NOT NULL," +
                " [Insertdate] [datetime] NOT NULL CONSTRAINT [DF_Users_Insertdate_1]  DEFAULT (getdate()), CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED  ( " +
                "	[ID] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) " +
                "ON [PRIMARY] TEXTIMAGE_ON [PRIMARY] SET ANSI_PADDING OFF ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public void CriaTabelaProviders()
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            String queryString = "  SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON SET ANSI_PADDING ON CREATE TABLE [dbo].[Providers]( [ID] [bigint] IDENTITY(1,1) " +
                "NOT NULL, [Razao_Social] [varchar](255) NOT NULL, 	[Nome_Fantasia] [varchar](255) NULL, [CNPJ] [varchar](20) NOT NULL, [Phone] [varchar](20) NULL, " +
                "	[INSERTDATE] [datetime] NULL, CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED  ( 	[ID] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, " +
                "IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], UNIQUE NONCLUSTERED  ( 	[ID] ASC )WITH (PAD_INDEX = OFF," +
                " STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], UNIQUE NONCLUSTERED  ( " +
                "	[CNPJ] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] )" +
                " ON [PRIMARY] SET ANSI_PADDING OFF ALTER TABLE [dbo].[Providers] ADD  DEFAULT (getdate()) FOR [INSERTDATE] ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public void CriaTabelaProducts()
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            String queryString = "  SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON SET ANSI_PADDING ON CREATE TABLE [dbo].[Products]( [ID] [bigint] IDENTITY(1,1) NOT NULL, " +
                "[Nome_produto] [varchar](255) NOT NULL, [Tipo_unidade] [varchar](50) NOT NULL, 	[IsActive] [int] NOT NULL, CONSTRAINT [PK_Products] " +
                "PRIMARY KEY CLUSTERED  ( [ID] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, " +
                "ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] SET ANSI_PADDING OFF ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public void CriaTabelaStock()
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            String queryString = " SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON CREATE TABLE [dbo].[Stock_Itens]( 	" +
                "[ID] [bigint] IDENTITY(1,1) NOT NULL, [ProductID] [bigint] NOT NULL, [Quantidade] [bigint] NOT NULL," +
                " CONSTRAINT [PK_Stock_Itens] PRIMARY KEY CLUSTERED  ( [ID] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF," +
                " IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] ALTER TABLE [dbo].[Stock_Itens] " +
                " WITH CHECK ADD  CONSTRAINT [FK_Stock_Itens_Products] FOREIGN KEY([ProductID]) REFERENCES [dbo].[Products] ([ID])" +
                " ALTER TABLE [dbo].[Stock_Itens]    CHECK CONSTRAINT [FK_Stock_Itens_Products] ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public void CriaTabelaNotasFiscais()
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            String queryString = " SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON CREATE TABLE [dbo].[Notas_Fiscais]( [ID] [bigint] IDENTITY(1,1) NOT NULL, 	" +
                "[SeriesNFe] [int] NOT NULL, 	[NumberNFe] [bigint] NOT NULL, 	[ProviderID] [bigint] NOT NULL, 	[EmissionDate] [datetime] NOT NULL, 	" +
                "[value] [decimal](18, 2) NOT NULL, [insertdate] [datetime] NOT NULL, 	[InStock] [bit] NOT NULL,  CONSTRAINT [PK_Notas_Fiscais] " +
                "PRIMARY KEY CLUSTERED  ( [ID] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, " +
                "ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] ALTER TABLE [dbo].[Notas_Fiscais] ADD  CONSTRAINT [DF__Notas_Fis__inser__4222D4EF]  " +
                "DEFAULT (getdate()) FOR [insertdate] ALTER TABLE [dbo].[Notas_Fiscais] ADD  CONSTRAINT [DF_Notas_Fiscais_InStock]  DEFAULT ((0)) FOR [InStock]" +
                " ALTER TABLE [dbo].[Notas_Fiscais]  WITH CHECK ADD  CONSTRAINT [FK_Notas_Fiscais_Providers] FOREIGN KEY([ProviderID]) REFERENCES [dbo].[Providers]" +
                " ([ID]) ALTER TABLE [dbo].[Notas_Fiscais] CHECK CONSTRAINT [FK_Notas_Fiscais_Providers]  ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public void CriaTabelaItensNotasFiscais()
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            String queryString = " SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON CREATE TABLE [dbo].[NFe_Itens]( [ID] [bigint] IDENTITY(1,1) NOT NULL,  " +
                "[Quantidade] [bigint] NOT NULL, 	[produtcID] [bigint] NOT NULL, 	[NFEID] [bigint] NOT NULL, [Insertdate] [datetime] NOT NULL, CONSTRAINT" +
                " [PK_NFe_Itens1] PRIMARY KEY CLUSTERED  ( [ID] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, " +
                "ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY]  ALTER TABLE [dbo].[NFe_Itens] ADD  CONSTRAINT [DF_NFe_Itens1_Insertdate]  DEFAULT (getdate())" +
                " FOR [Insertdate] ALTER TABLE [dbo].[NFe_Itens]  WITH CHECK ADD  CONSTRAINT [FK_NFe_Itens_Notas_Fiscais] FOREIGN KEY([NFEID])" +
                " REFERENCES [dbo].[Notas_Fiscais] ([ID]) ALTER TABLE [dbo].[NFe_Itens] CHECK CONSTRAINT [FK_NFe_Itens_Notas_Fiscais] ALTER TABLE [dbo].[NFe_Itens]" +
                "  WITH CHECK ADD  CONSTRAINT [FK_NFe_Itens_Products] FOREIGN KEY([produtcID]) REFERENCES [dbo].[Products] ([ID])  ALTER TABLE [dbo].[NFe_Itens]" +
                " CHECK CONSTRAINT [FK_NFe_Itens_Products]   ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public void CriaTabelaSolicitation()
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            String queryString = " SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON SET ANSI_PADDING ON CREATE TABLE [dbo].[Solicitation]( [ID] [bigint] IDENTITY(1,1) " +
                "NOT NULL, 	[User_Requester] [bigint] NOT NULL, [User_Approver] [bigint] NULL, [DataAprovacaoRejeicao] [date] NULL, [status] [int] NOT NULL, [Motivo]" +
                " [varchar](255) NULL, 	[DataSolicitacao] [date] NOT NULL, [DataRetirada] [date] NULL, CONSTRAINT [PK_Solicitation] PRIMARY KEY CLUSTERED " +
                " ( [ID] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) " +
                "ON [PRIMARY] SET ANSI_PADDING OFF ALTER TABLE [dbo].[Solicitation] ADD  CONSTRAINT [DF_Solicitation_status]  DEFAULT ((1)) FOR [status] ALTER TABLE " +
                "[dbo].[Solicitation] ADD  CONSTRAINT [DF_Solicitation_InsertDate]  DEFAULT (getdate()) FOR [DataSolicitacao] ALTER TABLE [dbo].[Solicitation] " +
                " WITH CHECK ADD  CONSTRAINT [FK_Solicitation_Users] FOREIGN KEY([User_Requester]) REFERENCES [dbo].[Users] ([ID]) ALTER TABLE [dbo].[Solicitation] " +
                "CHECK CONSTRAINT [FK_Solicitation_Users] ALTER TABLE [dbo].[Solicitation]  WITH CHECK ADD  CONSTRAINT [FK_Solicitation_Users1] " +
                "FOREIGN KEY([User_Requester]) REFERENCES [dbo].[Users] ([ID]) ALTER TABLE [dbo].[Solicitation] CHECK CONSTRAINT [FK_Solicitation_Users1]   ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public void CriaTabelaItensSolicitation()
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            String queryString = "   SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON  CREATE TABLE [dbo].[Solicitation_Itens](	[ID] [bigint] IDENTITY(1,1) NOT NULL,	" +
                "[SolicitationID] [bigint] NOT NULL,	[ProductID] [bigint] NOT NULL,	[QuantidadeSolicitada] [int] NOT NULL,	[QuantidadeAprovada] [int] NOT NULL, " +
                "CONSTRAINT [PK_Solicitation_Itens] PRIMARY KEY CLUSTERED  ( [ID] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, " +
                "ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] ALTER TABLE [dbo].[Solicitation_Itens] ADD  CONSTRAINT " +
                "[DF_Solicitation_Itens_QuantidadeAprovada]  DEFAULT ((0)) FOR [QuantidadeAprovada] ALTER TABLE [dbo].[Solicitation_Itens]  WITH CHECK ADD " +
                " CONSTRAINT [FK_Solicitation_Itens_Products] FOREIGN KEY([ProductID]) REFERENCES [dbo].[Products] ([ID]) ALTER TABLE [dbo].[Solicitation_Itens] " +
                "CHECK CONSTRAINT [FK_Solicitation_Itens_Products] ALTER TABLE [dbo].[Solicitation_Itens]  WITH CHECK ADD  CONSTRAINT " +
                "[FK_Solicitation_Itens_Solicitation] FOREIGN KEY([SolicitationID]) REFERENCES [dbo].[Solicitation] ([ID]) ALTER TABLE [dbo].[Solicitation_Itens] CHECK CONSTRAINT [FK_Solicitation_Itens_Solicitation]   ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
