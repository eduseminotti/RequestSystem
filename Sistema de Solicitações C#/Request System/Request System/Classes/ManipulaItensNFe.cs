using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request_System
{
    public class ReturnNFeitens
    {
        public long ProductCode { get; set; }
        public long ItemID { get; set; }
        public String NomeProduto { get; set; }
        public String TipoUnidade { get; set; }
        public int Quantidade { get; set; }
    }

    public class ManipulaItensNFe
    {
        LOG log = new LOG();

        public List<ReturnNFeitens> GetNFeItens(long NFeID)
        {
            List<ReturnNFeitens> return_Itens = new List<ReturnNFeitens>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            try
            {
                string queryString = "select p.id as productID ,p.Nome_produto ,p.Tipo_unidade,i.Quantidade,i.id as itenID " +
                    "from dbo.Products as p " +
                    "inner join " +
                    "[dbo].[NFe_Itens] as i " +
                    "on i.produtcID = p.ID " +
                    "where i.NFEID = @ID ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = NFeID;

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    ReturnNFeitens return_NFe_itens = new ReturnNFeitens();

                    return_NFe_itens.ProductCode = Convert.ToInt64(query["productID"].ToString());
                    return_NFe_itens.ItemID = Convert.ToInt64(query["itenID"].ToString());
                    return_NFe_itens.NomeProduto = query["Nome_produto"].ToString();
                    return_NFe_itens.TipoUnidade = query["Tipo_unidade"].ToString();
                    return_NFe_itens.Quantidade = Convert.ToInt32(query["Quantidade"].ToString());

                    return_Itens.Add(return_NFe_itens);
                }
            }
            catch (SqlException ex)
            {
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
            return return_Itens;
        }
        public bool New_NFe_Item(int Quantidade, long produtcID, long NFEID)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            bool sucess = false;

            string queryString = "insert into [dbo].[NFe_Itens] (  Quantidade, produtcID, NFEID) values (@Quantidade, @produtcID , @NFEID )  ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@produtcID", produtcID);
            cmd.Parameters.AddWithValue("@NFEID", NFEID);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
                sucess = true;
            }
            return sucess;
        }
        public void Deleta_NFe_Item(long ItemId)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            string queryString = "delete from dbo.NFe_Itens  where id = @id  ";
            SqlCommand cmd = new SqlCommand(queryString, sqlConn);
            cmd.Parameters.AddWithValue("@id", ItemId);
            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
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
