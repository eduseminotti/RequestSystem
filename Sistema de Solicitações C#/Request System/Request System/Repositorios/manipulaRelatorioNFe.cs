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

        public List<ReturnRelatorioNFe> ReturnRelatorioNFe()
        {
            List<ReturnRelatorioNFe> returnRelatorioNFes = new List<ReturnRelatorioNFe>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            try
            {
                string queryString = "  SELECT distinct nfe.id, nfe.SeriesNFe, nfe.NumberNFe, nfe.value , prov.CNPJ ,prov.Razao_Social ,nfe.EmissionDate,  " +
                    " SUBSTRING (    ( SELECT   product.Nome_produto + ' - ' + cast(subSelectItens.Quantidade  as varchar(max)  ) + '\n'  AS [text()]   " +
                    "FROM nfe_itens subSelectItens INNER JOIN products product ON product.id = subSelectItens.produtcid " +
                    " WHERE subSelectItens.NFEID = nfe.id ORDER BY subSelectItens.id FOR XML PATH ('') ), 1, 1000) as Produtos_Quantidade " +
                    "FROM   notas_fiscais nfe   INNER JOIN providers prov  ON prov.id = nfe.providerid ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

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
                log.logador("Dados do relatorio carregados com sucesso!");
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao carregar os dados do retatorio!");
                log.logador(ex);
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
