using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Request_System.Classes
{
    public class returnItensSolicitacoes
    {
        public int ProductId { get; set; }
        public int SolicitationId { get; set; }
        public int SolicitationItemId { get; set; }
        public String ProductName { get; set; }
        public String Descricao { get; set; }
        public int QuantidadeSolicitada { get; set; }
        public int QuantidadeAprovada { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
    public class ManipulaItensSolicitacoes
    {
        Configuration configuration = new Configuration();
        ManipulaSolicitacoesUsuario manipulaSolicitacoes = new ManipulaSolicitacoesUsuario();

        public void InsertItemSolicitacao(int SolicitationId, int ProductId, int QuantidadeSolicitada)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " insert into [dbo].[Solicitation_Itens] ( SolicitationID, ProductID, QuantidadeSolicitada , QuantidadeAprovada ) values ( @SolicitationID , @ProductID, @Quantidade ,  @Quantidade  )  ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@SolicitationID", SolicitationId);
            cmd.Parameters.AddWithValue("@ProductID", ProductId);
            cmd.Parameters.AddWithValue("@Quantidade", QuantidadeSolicitada);

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
        public List<returnItensSolicitacoes> GetItensSolicitacao(int SolicitationId)
        {
            List<returnItensSolicitacoes> GetItensSolicitacao = new List<returnItensSolicitacoes>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);
            try
            {
                string queryString =
                    " SELECT  si.id AS sid, si.solicitationid, si.productid, si.quantidadesolicitada, si.quantidadeaprovada, p.nome_produto, sti.Quantidade " +
                    "FROM dbo.solicitation_itens AS si INNER JOIN dbo.products AS p ON p.id = si.productid INNER JOIN [dbo].[Stock_Itens] as sti on si.ProductID = sti.ProductID where si.SolicitationId =  @SolicitationId ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                cmd.Parameters.Add("@SolicitationId", SqlDbType.VarChar).Value = SolicitationId;

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    returnItensSolicitacoes itensSolicitacoes = new returnItensSolicitacoes();

                    itensSolicitacoes.SolicitationItemId = Convert.ToInt32(query["sid"].ToString());
                    itensSolicitacoes.SolicitationId = Convert.ToInt32(query["SolicitationID"].ToString());
                    itensSolicitacoes.ProductId = Convert.ToInt32(query["ProductID"].ToString());
                    itensSolicitacoes.QuantidadeSolicitada = Convert.ToInt32(query["QuantidadeSolicitada"].ToString());
                    itensSolicitacoes.QuantidadeAprovada = Convert.ToInt32(query["QuantidadeAprovada"].ToString());
                    itensSolicitacoes.ProductName = query["Nome_produto"].ToString();
                    itensSolicitacoes.QuantidadeEstoque = Convert.ToInt32(query["Quantidade"].ToString());

                    GetItensSolicitacao.Add(itensSolicitacoes);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
            return GetItensSolicitacao;
        }
        public void AtualizaQuantidadeAprovada(int SolicitationItemId, int Quantidade)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " update [dbo].[Solicitation_Itens] set QuantidadeAprovada = @QuantidadeAprovada  where id = @Id  ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@QuantidadeAprovada", Quantidade);
            cmd.Parameters.AddWithValue("@Id", SolicitationItemId);

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
        public void DeletaTodosItensSolicitacao(int SolicitationId)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " delete from [dbo].[Solicitation_Itens] where SolicitationID = @SolicitationId ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@SolicitationId", SolicitationId);

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
        public void DeletaItemSolicitacao(int ItemID)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " delete from [dbo].[Solicitation_Itens] where id = @id ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@id", ItemID);

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
