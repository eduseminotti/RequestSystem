using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;


namespace Request_System
{
    public class ManipulaStock
    {
        LOG log = new LOG();

        public void Cria_Item_Stock(long ProductID) // cadastro do item no stock ao cadastrar produto
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            string queryString = " Insert into [dbo].[Stock_Itens] (ProductID, Quantidade) values (@produtcID ,0) ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@produtcID", ProductID);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                log.logador("Item criado em Stock: " + ProductID);
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao criar item em stock: " + ProductID);
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public void AdicionaItensStock(List<ReturnNFeitens> itensNFes) // apenas inclusao de quantidades em stock na recepção de NFe
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var itensNFe in itensNFes)
            {
                stringBuilder.AppendLine($"update dbo.Stock_Itens  set Quantidade = Quantidade + {itensNFe.Quantidade} where ProductID = {itensNFe.ProductCode} ; ");
                log.logador("Preparando para adicionar itens ao estoque, produto: " + itensNFe.ProductCode + " Quantidade: " + itensNFe.Quantidade);
            }

            SqlCommand cmd = new SqlCommand(stringBuilder.ToString(), sqlConn);
            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                log.logador("Itens adicionados ao estoque com sucesso!");
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao atuaizar a quantidade em stock!");
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public void EditaItensStock(List<returnItensSolicitacoes> itensSolicitacao)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var itemSolicitacao in itensSolicitacao)
            {
                stringBuilder.AppendLine($"update dbo.Stock_Itens  set Quantidade = Quantidade - {itemSolicitacao.QuantidadeAprovada} where productid = {itemSolicitacao.ProductId} ; ");
                log.logador("Preparando para atualizar a quantidade de itens em stock, produto: " + itemSolicitacao.ProductId + " Quantidade: " + itemSolicitacao.QuantidadeAprovada);
            }

            SqlCommand cmd = new SqlCommand(stringBuilder.ToString(), sqlConn);
            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                log.logador("Quantidades em stock alterada!");
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao atuaizar a quantidade em stock!");
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
