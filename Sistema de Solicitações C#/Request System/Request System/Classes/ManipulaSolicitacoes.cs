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
        Configuration configuration = new Configuration();

        public List<ReturnSolicitacoesStockMan> GetSolicitacoes(int solicitationId, string usuarioSolicitante, SolicitationStatus? solicitationStatus)
        {
            List<ReturnSolicitacoesStockMan> returnSolicitacoes = new List<ReturnSolicitacoesStockMan>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);
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
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

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
    public class returnItensSolicitacoes
    {
        public int ProductId { get; set; }
        public int SolicitationId { get; set; }
        public int SolicitationItemId { get; set; }
        public String ProductName { get; set; }
        public String Descricao { get; set; }
        public int QuantidadeSolicitada { get; set; }
        public int QuantidadeAprovada { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
    public class ManipulaItensSolicitacoes
    {
        Configuration configuration = new Configuration();
        ManipulaSolicitacoesUsuario manipulaSolicitacoes = new ManipulaSolicitacoesUsuario();

        public void InsertItemSolicitacao(int SolicitationId, int ProductId, int QuantidadeSolicitada)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " insert into [dbo].[Solicitation_Itens] ( SolicitationID, ProductID, QuantidadeSolicitada , QuantidadeAprovada ) values ( @SolicitationID , @ProductID, @Quantidade ,  @Quantidade  )  ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@SolicitationID", SolicitationId);
            cmd.Parameters.AddWithValue("@ProductID", ProductId);
            cmd.Parameters.AddWithValue("@Quantidade", QuantidadeSolicitada);

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
        public List<returnItensSolicitacoes> GetItensSolicitacao(int SolicitationId)
        {
            List<returnItensSolicitacoes> GetItensSolicitacao = new List<returnItensSolicitacoes>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);
            try
            {
                string queryString =
                    " SELECT si.id AS sid, si.solicitationid, si.productid, si.quantidadesolicitada, si.quantidadeaprovada, p.nome_produto, sti.Quantidade " +
                    "FROM dbo.solicitation_itens AS si INNER JOIN dbo.products AS p ON p.id = si.productid INNER JOIN [dbo].[Stock_Itens] as sti on si.ProductID = sti.ProductID where si.SolicitationId =  @SolicitationId ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                cmd.Parameters.Add("@SolicitationId", SqlDbType.VarChar).Value = SolicitationId;

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    returnItensSolicitacoes itensSolicitacoes = new returnItensSolicitacoes();

                    itensSolicitacoes.SolicitationItemId = Convert.ToInt32(query["sid"].ToString());
                    itensSolicitacoes.SolicitationId = Convert.ToInt32(query["SolicitationID"].ToString());
                    itensSolicitacoes.ProductId = Convert.ToInt32(query["ProductID"].ToString());
                    itensSolicitacoes.QuantidadeSolicitada = Convert.ToInt32(query["QuantidadeSolicitada"].ToString());
                    itensSolicitacoes.QuantidadeAprovada = Convert.ToInt32(query["QuantidadeAprovada"].ToString());
                    itensSolicitacoes.ProductName = query["Nome_produto"].ToString();
                    itensSolicitacoes.QuantidadeEstoque = Convert.ToInt32(query["Quantidade"].ToString());

                    GetItensSolicitacao.Add(itensSolicitacoes);
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
            return GetItensSolicitacao;
        }
        public void AtualizaQuantidadeAprovada(int SolicitationItemId, int Quantidade)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " update [dbo].[Solicitation_Itens] set QuantidadeAprovada = @QuantidadeAprovada  where id = @Id  ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@QuantidadeAprovada", Quantidade);
            cmd.Parameters.AddWithValue("@Id", SolicitationItemId);

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
        public void DeletaTodosItensSolicitacao(int SolicitationId)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " delete from [dbo].[Solicitation_Itens] where SolicitationID = @SolicitationId ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@SolicitationId", SolicitationId);

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
        public void DeletaItemSolicitacao(int ItemID)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[configuration.connectionString].ConnectionString);

            string queryString = " delete from [dbo].[Solicitation_Itens] where id = @id ";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);

            cmd.Parameters.AddWithValue("@id", ItemID);

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


/*
 
 
SELECT     s.id,  s.user_requester,   ur.NAME AS requestername,  s.user_approver,   ua.NAME AS approvername,   s.datasolicitacao,   s.dataaprovacaorejeicao, 
           s.motivo,   s.status,  s.dataretirada ,   
           Substring ( ( 
                      SELECT     product.nome_produto + ' - ' 
					  + Cast(subselectitens.quantidadesolicitada AS VARCHAR( max) ) + ' - '
					  + Cast(subselectitens.quantidadeaprovada AS VARCHAR( max) ) + '\n' AS [text()] 
                      FROM       solicitation_itens subselectitens 
                      inner JOIN products product 
                      ON         product.id = subselectitens.productid 
                      WHERE      subselectitens.solicitationid = s.id 
                      ORDER BY   subselectitens.id FOR xml path ('')), 1, 1000) AS produtos_quantidades
FROM       solicitation  AS s 
INNER JOIN users ur 
ON         ur.id = s.user_requester 
LEFT JOIN  users ua 
ON         ua.id = s.user_approver 
INNER JOIN solicitation_itens AS itens 
ON         itens.solicitationid = s.id 

*/
