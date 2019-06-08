using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Request_System.Repositorios
{
    public class ValidaBanco
    {
        public bool ValidaSeBancoExiste(String NomeBanco)
        {
            bool sucess = false;
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            string queryString = " SELECT * FROM sys.databases WHERE name =  @nomeBanco";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@nomeBanco", NomeBanco);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                sucess = true;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();

            }
            return sucess;
        }

        public void CriaTabelas(String NomeBanco)
        {

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
     
            String queryString = " USE @nomeBanco GO SET ANSI_NULLS ON  GO  SET QUOTED_IDENTIFIER ON   GO  SET ANSI_PADDING ON  GO  CREATE TABLE[dbo].[Users]" +
                "(  [ID][bigint] IDENTITY(1, 1) NOT NULL, [Name] [varchar] (255) NOT NULL,  [cpf] [varchar] (20) NULL,  [eMail] [varchar] (255) NULL, " +
                " [UserName] [varchar] (50) NOT NULL,   [Password] [nvarchar] (max) NOT NULL,   [isActive] [int] NOT NULL,  [setor] [nchar] (50) NULL, " +
                "  [Type] [int] NOT NULL,  [Insertdate] [datetime] NOT NULL CONSTRAINT[DF_Users_Insertdate_1] DEFAULT(getdate()), " +
                "  CONSTRAINT[PK_Users] PRIMARY KEY CLUSTERED   (  [ID] ASC    )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF," +
                " ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]  ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]    GO   SET ANSI_PADDING OFF  GO    ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@nomeBanco", NomeBanco);

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
