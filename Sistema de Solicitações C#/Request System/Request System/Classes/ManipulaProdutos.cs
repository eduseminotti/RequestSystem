using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Request_System
{
    public class ReturnProdutos
    {
        public int Product_Id { get; set; }
        public String Product_Name { get; set; }
        public String Product_Unidade { get; set; }
        public int Quantidade { get; set; }
        public ProductIsActive product_IsActive { get; set; }
        public String  ProdUnit { get; set; }
    }

    public class ManipulaProdutos
    {
        long lastId;
        LOG log = new LOG();
        ManipulaStock dadosStock = new ManipulaStock();
      

        public List<ReturnProdutos> GetProducts(long ProductID, String ProductName, ProductIsActive ProductStatus)
        {
            List<ReturnProdutos> return_produtos = new List<ReturnProdutos>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            try
            {
                // string queryString = "SELECT id, Nome_produto, Descrição_produto, Tipo_unidade,isactive FROM [Seminotti_Teste].[dbo].[Products] where id > 0  ";

                string queryString = " select p.id as pid, p.Nome_produto, p.Tipo_unidade, p.isactive, s.Quantidade , " +
                    "produnit = p.Nome_produto + '- ' + p.Tipo_unidade  " +
                    "FROM [dbo].[Products] as p  " +
                    "inner join " +
                    " [dbo].[Stock_Itens] as s " +
                    "On s.productid = p.ID  where p.id > 0 ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                if (ProductID != 0)
                {
                    cmd.CommandText += " and p.id = @id";
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ProductID;

                }
                if (ProductName != null)
                {
                    cmd.CommandText += " and Nome_produto like @Nome_produto";
                    cmd.Parameters.Add("@Nome_produto", SqlDbType.VarChar).Value = "%" + ProductName + "%";

                }
                if (ProductStatus != ProductIsActive._)
                {
                    cmd.CommandText += " and isactive = @productStatus";
                    cmd.Parameters.Add("@productStatus", SqlDbType.Int).Value = ProductStatus;
                }

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();
                while (query.Read())
                {
                    ReturnProdutos produtos = new ReturnProdutos();
                    produtos.Product_Id = int.Parse(query["pid"].ToString());
                    produtos.Product_Name = query["Nome_produto"].ToString();
                    produtos.Product_Unidade = query["Tipo_unidade"].ToString();
                    produtos.Quantidade = int.Parse(query["Quantidade"].ToString());
                    produtos.product_IsActive = (ProductIsActive)int.Parse(query["isActive"].ToString());
                    produtos.ProdUnit = query["produnit"].ToString();

                    return_produtos.Add(produtos);
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
            return return_produtos;
        }
        public bool New_Product(String Nome_Produto,  String Tipo_Unidade, ProductIsActive productIsActive)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            bool sucess = false;

            string queryString = "insert [dbo].[Products]" +
                "        (Nome_produto, Tipo_unidade , IsActive) " +
                "values  (@Nome_produto, @Descrição_produto, @Tipo_unidade, @IsActive)";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@Nome_produto", Nome_Produto);
            cmd.Parameters.AddWithValue("@Tipo_unidade", Tipo_Unidade);
            cmd.Parameters.AddWithValue("@IsActive", productIsActive);
            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                lastId = LastProduct();
                dadosStock.Cria_Item_Stock(lastId);
                sucess = true;
                log.logador("produto cadastrado com sucesso, "+ Nome_Produto);
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao cadastrar produto, " + Nome_Produto);
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
            return sucess;

        }
        public bool Edit_Produto(long prodcutID, String Nome_Produto,  String Tipo_Unidade, ProductIsActive productIsActive)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            bool sucess = false;
            string queryString = "update  Seminotti_Teste.[dbo].[Products] set Nome_produto = @Nome_produto, Tipo_unidade = @Tipo_unidade , " +
                "IsActive  = @IsActive where id = @productID";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@productID", prodcutID);
            cmd.Parameters.AddWithValue("@Nome_produto", Nome_Produto);
            cmd.Parameters.AddWithValue("@Tipo_unidade", Tipo_Unidade);
            cmd.Parameters.AddWithValue("@IsActive", productIsActive);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao editar produto, " + Nome_Produto);
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

        public long LastProduct()
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            try
            {
                string queryString = " 	select max(id)  as ID  from dbo.Products ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();
                while (query.Read())
                {
                    lastId = long.Parse(query["ID"].ToString());
                }
            }
            catch (SqlException ex)
            {
                lastId = 0;
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
            return lastId;
        }
    }
}
