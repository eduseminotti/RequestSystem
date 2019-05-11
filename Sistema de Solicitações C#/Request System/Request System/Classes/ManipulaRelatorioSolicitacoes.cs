using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Request_System
{
    public class ReturnRelatorioSolicitacoes
    {
        public String UserRequester { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public String UserApprover { get; set; }
        public DateTime? DataAprovacao { get; set; }
        public DateTime? DataRetirada { get; set; }
        public String Motivo { get; set; }
        public SolicitationStatus SolicitationStatus { get; set; }
        public String ProdutosQuantidades { get; set; }
    }
    public class ManipulaRelatorioSolicitacoes
    {
        LOG log = new LOG();
        public List<ReturnRelatorioSolicitacoes> GetRelatorioSolicitacoes(string usuarioSolicitante, SolicitationStatus? solicitationStatus, DateTime inicial, DateTime final)
        {
            List<ReturnRelatorioSolicitacoes> GetRelatorioSolicitacoes = new List<ReturnRelatorioSolicitacoes>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            try
            {
                string queryString = "  SELECT DISTINCT ur.NAME AS requestername, s.datasolicitacao,ua.NAME AS approvername, s.dataaprovacaorejeicao, s.motivo, s.status, s.dataretirada ," +
                    " Substring ( (  SELECT     product.nome_produto + ' - '   " +
                    "+ Cast(subselectitens.quantidadesolicitada AS VARCHAR( max) ) " +
                    "+ ' - '  + Cast(subselectitens.quantidadeaprovada AS VARCHAR( max) ) + '\n' AS [text()]  " +
                    "FROM       solicitation_itens subselectitens inner JOIN products product  ON product.id = subselectitens.productid WHERE subselectitens.solicitationid = s.id  " +
                    "ORDER BY   subselectitens.id FOR xml path ('')), 1, 1000) AS produtos_quantidades FROM solicitation  " +
                    "AS s INNER JOIN users ur ON ur.id = s.user_requester LEFT JOIN  users ua ON ua.id = s.user_approver INNER JOIN solicitation_itens AS itens " +
                    "ON itens.solicitationid = s.id  	where s.DataSolicitacao >=  @inicial and s.DataSolicitacao <= @final   ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                cmd.Parameters.Add("@inicial", SqlDbType.VarChar).Value = inicial;
                cmd.Parameters.Add("@final", SqlDbType.VarChar).Value = final;

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

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    ReturnRelatorioSolicitacoes itensRelatorioSolicitacoes = new ReturnRelatorioSolicitacoes();

                    itensRelatorioSolicitacoes.UserRequester = query["requestername"].ToString();
                    itensRelatorioSolicitacoes.DataSolicitacao = Convert.ToDateTime(query["datasolicitacao"].ToString());
                    itensRelatorioSolicitacoes.UserApprover = query["approvername"].ToString();
                    itensRelatorioSolicitacoes.DataAprovacao = String.IsNullOrEmpty(query["DataAprovacaoRejeicao"].ToString()) ? (DateTime?)null : Convert.ToDateTime(query["DataAprovacaoRejeicao"].ToString());
                    itensRelatorioSolicitacoes.DataRetirada = String.IsNullOrEmpty(query["DataRetirada"].ToString()) ? (DateTime?)null : Convert.ToDateTime(query["DataRetirada"].ToString());
                    itensRelatorioSolicitacoes.Motivo = query["motivo"].ToString();
                    itensRelatorioSolicitacoes.SolicitationStatus = (SolicitationStatus)int.Parse(query["status"].ToString());
                    itensRelatorioSolicitacoes.ProdutosQuantidades = query["produtos_quantidades"].ToString();

                    GetRelatorioSolicitacoes.Add(itensRelatorioSolicitacoes);
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
            return GetRelatorioSolicitacoes;
        }
    }
}
