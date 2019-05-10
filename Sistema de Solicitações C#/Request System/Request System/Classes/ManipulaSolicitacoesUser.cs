using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request_System.Classes
{
    public class ReturnSolicitacoesUsuario
    {
        public long SolicitatonID { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime? DataAprovacao { get; set; }
        public DateTime? DataRetirada { get; set; }
        public String Motivo { get; set; }
        public SolicitationStatus SolicitationStatus { get; set; }
    }
    public class ManipulaSolicitacoesUsuario
    {
        Configuration configuration = new Configuration();

        public List<ReturnSolicitacoesUsuario> GetSolicitacoesUsuario(int userId, int solicitationId, SolicitationStatus? solicitationStatus)
        {
            List<ReturnSolicitacoesUsuario> returnSolicitacoesUsuario = new List<ReturnSolicitacoesUsuario>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);
            try
            {
                string queryString = "select id, DataSolicitacao, DataRetirada, DataAprovacaoRejeicao, status , motivo from [dbo].[Solicitation] where User_Requester =  @useridID  ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                cmd.Parameters.Add("@useridID", SqlDbType.VarChar).Value = userId;

                if (solicitationId != 0)
                {
                    cmd.CommandText += " and id  = @id";
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = solicitationId;
                }
                if (solicitationStatus != null)
                {
                    cmd.CommandText += " and status  = @status ";
                    cmd.Parameters.Add("@status", SqlDbType.Int).Value = solicitationStatus;
                }

                cmd.CommandText += " order by status asc , DataSolicitacao desc , id desc  ";

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    ReturnSolicitacoesUsuario solicitacoesUsuario = new ReturnSolicitacoesUsuario();

                    solicitacoesUsuario.SolicitatonID = Convert.ToInt64(query["id"].ToString());
                    solicitacoesUsuario.DataSolicitacao = Convert.ToDateTime(query["DataSolicitacao"].ToString());
                    solicitacoesUsuario.DataRetirada = String.IsNullOrEmpty(query["DataRetirada"].ToString()) ? (DateTime?)null : Convert.ToDateTime(query["DataRetirada"].ToString());
                    solicitacoesUsuario.DataAprovacao = String.IsNullOrEmpty(query["DataAprovacaoRejeicao"].ToString()) ? (DateTime?)null : Convert.ToDateTime(query["DataAprovacaoRejeicao"].ToString());
                    solicitacoesUsuario.SolicitationStatus = (SolicitationStatus)int.Parse(query["status"].ToString());
                    solicitacoesUsuario.Motivo = query["motivo"].ToString();

                    returnSolicitacoesUsuario.Add(solicitacoesUsuario);
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
            return returnSolicitacoesUsuario;
        }
        public int InsertSolicitacao(int UserRequester)
        {
            int requestID;
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " insert into [dbo].[Solicitation] (User_Requester) values ( @User_Requester) ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@User_Requester", UserRequester);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                requestID = LastSolicitationId();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
            return requestID;
        }
        public void DeletaSolicitacao(int SolicitationId)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " delete from [dbo].[Solicitation] where id = @Id ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@Id", SolicitationId);

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
        public int LastSolicitationId()
        {
            int lastId = 0;

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);
            try
            {
                string queryString = " 	select max(id)  as ID  from dbo.Solicitation ";

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
        public void UpdateMotivo(int SolicitationId, String motivo)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " update [dbo].[Solicitation] set motivo = @motivo  where id = @Id ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@Id", SolicitationId);
            cmd.Parameters.AddWithValue("@motivo", motivo);

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
