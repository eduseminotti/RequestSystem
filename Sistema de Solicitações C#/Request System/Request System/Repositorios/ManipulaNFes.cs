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
                log.logador("Dados da NFe carregados com sucesso!");
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao carregar dados da NFe, Serie: " + Series + "Numero: " + Number);
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
            return return_NFes;
        }
        public int Insere_NFe(int Series, long Number, DateTime EmissionDate, decimal ValueNFe, long ProviderID)
        {
            int lastId;
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            bool sucess = false;

            string queryString = " insert into dbo.Notas_Fiscais (SeriesNFe, NumberNFe, EmissionDate,Value, ProviderID )" +
                " values ( @SeriesNFe, @NumberNFe , @EmissionDate, @Value, @ProviderID )  ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@SeriesNFe", Series);
            cmd.Parameters.AddWithValue("@NumberNFe", Number);
            cmd.Parameters.AddWithValue("@EmissionDate", EmissionDate);
            cmd.Parameters.AddWithValue("@Value", ValueNFe);
            cmd.Parameters.AddWithValue("@ProviderID", ProviderID);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                lastId = LastSolicitationId();
                log.logador("NFe inserida com sucesso, Serie: " + Series + "Numero: " + Number);
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao inserir NFe, Serie: " + Series + "Numero: " + Number + " Query: " + queryString);
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
                sucess = true;
            }
            return lastId;
        }
        public int LastSolicitationId()
        {
            int lastId = 0;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            try
            {
                string queryString = " 	select max(id)  as ID  from dbo.Notas_Fiscais ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();
                while (query.Read())
                {
                    lastId = int.Parse(query["ID"].ToString());
                }
            }
            catch (SqlException)
            {
                lastId = 0;
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
            return lastId;
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
            catch (SqlException ex)
            {
                log.logador(ex);
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
                log.logador("Itens da NFe inserido no Stock com sucesso! NFeID: " + nFeId);
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao inserir itens no Stock! NFeID: " + nFeId);
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
