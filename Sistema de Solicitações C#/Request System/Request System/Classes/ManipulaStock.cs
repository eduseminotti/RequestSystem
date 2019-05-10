using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;


namespace Request_System
{
    public class ManipulaStock
    {
        Configuration configuration = new Configuration();

        public void Cria_Item_Stock(long ProductID)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " Insert into [dbo].[Stock_Itens] (ProductID, Quantidade) values (@produtcID ,0) ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@produtcID", ProductID);

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
        public void AdicionaItensStock(List<ReturnNFeitens> itensNFes) // apenas inclusao de itens na recepção de NFe
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            StringBuilder stringBuilder = new StringBuilder();
            
            foreach (var itensNFe in itensNFes)
            {
                stringBuilder.AppendLine($"update dbo.Stock_Itens  set Quantidade = Quantidade + {itensNFe.Quantidade} where ProductID = {itensNFe.ProductCode} ; ");
            }

            SqlCommand cmd = new SqlCommand(stringBuilder.ToString(), sqlConn);
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

        public void EditaItensStock(List<returnItensSolicitacoes> itensSolicitacao)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var itemSolicitacao in itensSolicitacao)
            {
                stringBuilder.AppendLine($"update dbo.Stock_Itens  set Quantidade = Quantidade - {itemSolicitacao.QuantidadeAprovada} where productid = {itemSolicitacao.ProductId} ; ");
            }

            SqlCommand cmd = new SqlCommand(stringBuilder.ToString(), sqlConn);
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
