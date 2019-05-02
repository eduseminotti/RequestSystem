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
    public class ReturnProviders
    {
        public int Id { get; set; }
        public String Razao_Social { get; set; }
        public String Nome_Fantasia { get; set; }
        public String CNPJ { get; set; }
        public String Phone { get; set; }
        public String NameCnpj { get; set; }
    }

    public class ManipulaFornecedores
    {
        Configuration configuration = new Configuration();

        public List<ReturnProviders> GetProviders(int SelectProviderID, String Nomefantasia, String CNPJ)
        {
            List<ReturnProviders> return_Providers = new List<ReturnProviders>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            try
            {
                string queryString = " SELECT [ID], [Razao_Social], [Nome_Fantasia], [CNPJ], [Phone] , namecnpj = CNPJ + '- ' + Nome_Fantasia FROM [dbo].[Providers] where id > 0 ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);
                
                if (SelectProviderID != 0)
                {
                    cmd.CommandText += " and id  = @id";
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = SelectProviderID;
                }
                if(Nomefantasia != null)
                {
                    cmd.CommandText += " and Nome_Fantasia  like  @Nome_Fantasia";
                    cmd.Parameters.Add("@Nome_Fantasia", SqlDbType.VarChar).Value = "%"+Nomefantasia+"%";
                }
                if (CNPJ != null)
                {
                    cmd.CommandText += " and CNPJ  like @CNPJ";
                    cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = "%"+CNPJ+"%";
                }

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();
                while (query.Read())
                {
                    ReturnProviders providers = new ReturnProviders();
                    
                    providers.Id = int.Parse(query["id"].ToString());
                    providers.Razao_Social = query["Razao_Social"].ToString();
                    providers.Nome_Fantasia = query["Nome_Fantasia"].ToString();
                    providers.CNPJ = query["CNPJ"].ToString();
                    providers.Phone = query["Phone"].ToString();
                    providers.NameCnpj = query["namecnpj"].ToString();

                    return_Providers.Add(providers);
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
            return return_Providers;
        }

        public bool New_Provider(String Razao_Social, String Nome_Fantasia, String CNPJ, String Phone)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);
            bool sucess = false;

            string queryString = "insert into Seminotti_Teste.dbo.Providers ( Razao_Social, Nome_Fantasia, cnpj, phone ) values  ( @Razao_Social, @Nome_Fantasia , @cnpj , @phone) ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);     
            
            cmd.Parameters.AddWithValue("@Razao_Social", Razao_Social);
            cmd.Parameters.AddWithValue("@Nome_Fantasia", Nome_Fantasia);
            cmd.Parameters.AddWithValue("@cnpj", CNPJ);
            cmd.Parameters.AddWithValue("@phone", Phone);

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

        public bool Edit_Provider(long Id, String Razao_Social, String Nome_Fantasia, String CNPJ, String Phone)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);
            bool sucess = false;

            string queryString = "update Seminotti_Teste.dbo.Providers SET Razao_Social = " +
                "@Razao_Social, Nome_Fantasia = @Nome_Fantasia, phone = @phone where id = @id";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@Razao_Social", Razao_Social);
            cmd.Parameters.AddWithValue("@Nome_Fantasia", Nome_Fantasia);
            cmd.Parameters.AddWithValue("@phone", Phone);

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
    }
}
