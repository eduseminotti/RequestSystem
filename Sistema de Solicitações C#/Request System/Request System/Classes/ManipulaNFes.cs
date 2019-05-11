using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Request_System
{
    public class ReturnNFes
    {
        public int Series { get; set; }
        public int Number { get; set; }
        public int NFeID { get; set; }
        public String EmissionDate { get; set; }
        public String ValueNFe { get; set; }
        public String CNPJ { get; set; }
        public String Fantasy_Name { get; set; }
        public int ProviderID { get; set; }
        public bool InStock { get; set; }
    }

    public class ManipulaNFes
    {
        LOG log = new LOG();

        public List<ReturnNFes> GetNFes(int Series, int Number, String CNPJ)
        {
            List<ReturnNFes> return_NFes = new List<ReturnNFes>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            try
            {
                string queryString = "SELECT  nfe.ID, nfe.SeriesNFe, nfe.NumberNFe, nfe.ProviderID, nfe.Value, nfe.EmissionDate,nfe.InStock ,p.CNPJ, p.Nome_Fantasia " +
                    "FROM [dbo].[Notas_Fiscais] as nfe " +
                    "inner join [Seminotti_Teste].[dbo].[Providers] as p " +
                    "on nfe.ProviderID = p.ID " +
                    "WHERE nfe.id > 0  ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                if (Series != 0)
                {
                    cmd.CommandText += " and SeriesNFe like @SeriesNFe ";
                    cmd.Parameters.Add("@SeriesNFe", SqlDbType.VarChar).Value = "%" + Series + "%";
                }
                if (Number != 0)
                {
                    cmd.CommandText += " and NumberNFe like @NumberNFe ";
                    cmd.Parameters.Add("@NumberNFe", SqlDbType.VarChar).Value = "%" + Number + "%";
                }
                if (CNPJ != null)
                {
                    cmd.CommandText += " and CNPJ like @CNPJ ";
                    cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = "%" + CNPJ + "%";
                }

                cmd.CommandText += "  order by nfe.insertdate desc  ";

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    ReturnNFes nFes = new ReturnNFes();

                    nFes.NFeID = Convert.ToInt32(query["ID"].ToString());
                    nFes.Series = Convert.ToInt32(query["SeriesNFe"].ToString());
                    nFes.Number = Convert.ToInt32(query["NumberNFe"].ToString());
                    nFes.ProviderID = Convert.ToInt32(query["ProviderID"].ToString());
                    nFes.ValueNFe = query["Value"].ToString();
                    nFes.EmissionDate = query["EmissionDate"].ToString();
                    nFes.CNPJ = query["CNPJ"].ToString();
                    nFes.Fantasy_Name = query["Nome_Fantasia"].ToString();
                    nFes.InStock = Convert.ToBoolean(query["InStock"].ToString());

                    return_NFes.Add(nFes);
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
            return return_NFes;
        }
        public bool Insere_NFe(int SerieNFe, long NumberNFe, DateTime EmissionDate, decimal ValueNFe, long ProviderID)
        {

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            bool sucess = false;

            string queryString = " insert into dbo.Notas_Fiscais (SeriesNFe, NumberNFe, EmissionDate,Value, ProviderID )" +
                " values ( @SeriesNFe, @NumberNFe , @EmissionDate, @Value, @ProviderID )  ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@SeriesNFe", SerieNFe);
            cmd.Parameters.AddWithValue("@NumberNFe", NumberNFe);
            cmd.Parameters.AddWithValue("@EmissionDate", EmissionDate);
            cmd.Parameters.AddWithValue("@Value", ValueNFe);
            cmd.Parameters.AddWithValue("@ProviderID", ProviderID);

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
                sucess = true;
            }
            return sucess;
        }
        public bool EditaNFe(int SerieNFe, long NumberNFe, DateTime EmissionDate, decimal ValueNFe, long NFeId, long ProviderId)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            bool sucess = false;

            string queryString = " update dbo.Notas_Fiscais set " +
                "SeriesNFe = @SeriesNFe,  NumberNFe = @NumberNFe , EmissionDate = @EmissionDate ,Value = @Value, ProviderID = @ProviderID  where id = @id";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@SeriesNFe", SerieNFe);
            cmd.Parameters.AddWithValue("@id", NFeId);
            cmd.Parameters.AddWithValue("@NumberNFe", NumberNFe);
            cmd.Parameters.AddWithValue("@EmissionDate", EmissionDate);
            cmd.Parameters.AddWithValue("@Value", ValueNFe);
            cmd.Parameters.AddWithValue("@ProviderID", ProviderId);

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
        public void SetIncludedInStock(long nFeId)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            string queryString = " update dbo.Notas_Fiscais set InStock = 1 where id = @nfeID ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@nfeid", nFeId);

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
            catch (SqlException)
            {
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
            catch (SqlException)
            {
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

    public class ReturnRelatorioNFe
    {
        public int NFeId { get; set; }
        public int NumberNFe { get; set; }
        public int SerierNFe { get; set; }
        public decimal ValueNFe { get; set; }
        public String CNPJEmitente { get; set; }
        public String RazaoSocial { get; set; }
        public DateTime EmissionDate { get; set; }
        public String ProdutoQuantidade { get; set; }
    }
    public class RelatorioNFe
    {
        LOG log = new LOG();

        public List<ReturnRelatorioNFe> ReturnRelatorioNFe(DateTime Inicial, DateTime Final)
        {
            List<ReturnRelatorioNFe> returnRelatorioNFes = new List<ReturnRelatorioNFe>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            try
            {
                string queryString = "  SELECT distinct nfe.id, nfe.SeriesNFe, nfe.NumberNFe, nfe.value , prov.CNPJ ,prov.Razao_Social ,nfe.EmissionDate,  " +
                    " SUBSTRING (    ( SELECT   product.Nome_produto + ' - ' + cast(subSelectItens.Quantidade  as varchar(max)  ) + '\n'  AS [text()]   " +
                    "FROM nfe_itens subSelectItens INNER JOIN products product ON product.id = subSelectItens.produtcid " +
                    " WHERE subSelectItens.NFEID = nfe.id ORDER BY subSelectItens.id FOR XML PATH ('') ), 1, 1000) as Produtos_Quantidade " +
                    "FROM   notas_fiscais nfe   INNER JOIN providers prov  ON prov.id = nfe.providerid  " +
                    "	 where  nfe.EmissionDate >= @inicial  and nfe.EmissionDate <= @final";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                cmd.Parameters.Add("@inicial", SqlDbType.VarChar).Value = Inicial;
                cmd.Parameters.Add("@final", SqlDbType.VarChar).Value = Final;
                
                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    ReturnRelatorioNFe returnRelatorio = new ReturnRelatorioNFe();

                    returnRelatorio.NFeId = Convert.ToInt32(query["id"].ToString());
                    returnRelatorio.SerierNFe = Convert.ToInt32(query["SeriesNFe"]);
                    returnRelatorio.NumberNFe = Convert.ToInt32(query["NumberNFe"]);
                    returnRelatorio.ValueNFe = Convert.ToInt64(query["value"]);
                    returnRelatorio.CNPJEmitente = query["CNPJ"].ToString();
                    returnRelatorio.RazaoSocial = query["Razao_Social"].ToString();
                    returnRelatorio.EmissionDate = Convert.ToDateTime(query["EmissionDate"]);
                    returnRelatorio.ProdutoQuantidade = query["Produtos_Quantidade"].ToString();

                    returnRelatorioNFes.Add(returnRelatorio);
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
            return returnRelatorioNFes;
        }
    }
}
