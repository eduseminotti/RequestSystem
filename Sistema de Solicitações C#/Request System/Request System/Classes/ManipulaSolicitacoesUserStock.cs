using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Request_System
{
    public class ReturnSolicitacoesStockMan
    {
        public int SolicitatonId { get; set; }
        public int UserRequesterId { get; set; }
        public String UserRequesterName { get; set; }
        public int? UserApproverId { get; set; }
        public String UserApproverName { get; set; }
        public String Motivo { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime? DataAprovacao { get; set; }
        public DateTime? DataRetirada { get; set; }
        public SolicitationStatus SolicitationStatus { get; set; }
    }
    public class ManipulaSolicitacoesStockMan
    {
        LOG log = new LOG();

        public List<ReturnSolicitacoesStockMan> GetSolicitacoes(int solicitationId, string usuarioSolicitante, SolicitationStatus? solicitationStatus)
        {
            List<ReturnSolicitacoesStockMan> returnSolicitacoes = new List<ReturnSolicitacoesStockMan>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            try
            {
                string queryString = "	SELECT s.id   ,s.User_Requester ,ur.NAME AS requesterName ,s.User_Approver , ua.NAME AS approverName  , s.datasolicitacao  " +
                    ",s.DataAprovacaoRejeicao , s.motivo  " +
                    ",s.status  ,s.dataretirada  FROM   solicitation AS S "
                                 + " INNER JOIN users ur  ON ur.id = s.user_requester  left JOIN users ua  ON ua.id = s.user_approver " +
                                 " where s.id > 0   ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                if (solicitationId != 0)
                {
                    cmd.CommandText += " and s.id  = @id ";
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = solicitationId;
                }
                if (usuarioSolicitante != null)
                {
                    cmd.CommandText += " and ur.NAME like @userName ";
                    cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = "%" + usuarioSolicitante + "%";
                }
                if (solicitationStatus != null)
                {
                    cmd.CommandText += " and s.status  = @status ";
                    cmd.Parameters.Add("@status", SqlDbType.Int).Value = solicitationStatus;
                }

                cmd.CommandText += "  order by s.status asc, s.DataSolicitacao asc,   s.id desc   ";

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    ReturnSolicitacoesStockMan solicitacoes = new ReturnSolicitacoesStockMan();

                    solicitacoes.SolicitatonId = Convert.ToInt32(query["id"].ToString());
                    solicitacoes.UserRequesterId = Convert.ToInt32(query["User_Requester"]);
                    solicitacoes.UserRequesterName = query["requesterName"].ToString();
                    solicitacoes.Motivo = query["motivo"].ToString();

                    solicitacoes.UserApproverId = query["User_Approver"] is DBNull ? solicitacoes.UserApproverId = null : solicitacoes.UserApproverId = Convert.ToInt32(query["User_Approver"]);

                    solicitacoes.UserApproverName = query["approverName"].ToString();
                    solicitacoes.DataSolicitacao = Convert.ToDateTime(query["DataSolicitacao"].ToString());
                    solicitacoes.DataRetirada = String.IsNullOrEmpty(query["DataRetirada"].ToString()) ? (DateTime?)null : Convert.ToDateTime(query["DataRetirada"].ToString());
                    solicitacoes.DataAprovacao = String.IsNullOrEmpty(query["DataAprovacaoRejeicao"].ToString()) ? (DateTime?)null : Convert.ToDateTime(query["DataAprovacaoRejeicao"].ToString());
                    solicitacoes.SolicitationStatus = (SolicitationStatus)int.Parse(query["status"].ToString());

                    returnSolicitacoes.Add(solicitacoes);
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
            return returnSolicitacoes;
        }
        public void UpdateStatus(int SolicitationId, SolicitationStatus Status, bool DataAprovacaoRejeicao, bool DataRetirada, int User_Approver)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            string queryString = " update [dbo].[Solicitation] set status = @status , User_Approver = @User_Approver  ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@User_Approver", User_Approver);

            if (DataAprovacaoRejeicao)
                cmd.CommandText += "  , DataAprovacaoRejeicao = getdate()  ";

            if (DataRetirada)
                cmd.CommandText += "  , DataRetirada = getdate()  ";

            cmd.CommandText += " where id = @Id ";
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
    }

}

