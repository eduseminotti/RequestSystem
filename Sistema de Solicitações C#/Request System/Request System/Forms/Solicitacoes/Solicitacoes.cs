using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Request_System
{
    public partial class Solicitacoes : Form
    {
        int userId;
        SolicitationStatus? solicitationStatus;
        String userName = null;

        ManipulaSolicitacoesStockMan manipulaSolicitacoes = new ManipulaSolicitacoesStockMan();
        List<ReturnSolicitacoesStockMan> returnSolicitacoes;
        PageEditSolicitacoes pageEditSolicitacoes;
        UserIdioma userIdioma;
        GeradorDePDFGrid geraPDF = new GeradorDePDFGrid();
        List<ReturnRelatorioSolicitacoes> returnRelatorioSolicitacoes;
        ManipulaRelatorioSolicitacoes RelatorioSolicitacoes = new ManipulaRelatorioSolicitacoes();

        public Solicitacoes(int UserId, UserIdioma UserIdioma)
        {
            InitializeComponent();

            userIdioma = UserIdioma;
            userId = UserId;

            CBX_Filtro_Status.DataSource = Enum.GetValues(typeof(SolicitationStatus));
            solicitationStatus = null;

            returnSolicitacoes = manipulaSolicitacoes.GetSolicitacoes(0, null, null);
            GRID_View_Solicitacoes.DataSource = returnSolicitacoes;

            GRID_Relatorio_Solicitacoes.Visible = false;
        }
        private void BTN_Ver_Solicitacao_Click(object sender, EventArgs e)
        {
            int solicitationId = Convert.ToInt32(GRID_View_Solicitacoes.CurrentRow.Cells[0].Value.ToString());
            int userRequesterId = Convert.ToInt32(GRID_View_Solicitacoes.CurrentRow.Cells[7].Value.ToString());

            pageEditSolicitacoes = new PageEditSolicitacoes(solicitationId, userId, userRequesterId, userIdioma);
            pageEditSolicitacoes.ShowDialog();

            returnSolicitacoes = manipulaSolicitacoes.GetSolicitacoes(0, null, null);
            GRID_View_Solicitacoes.DataSource = returnSolicitacoes;
        }

        private void BTN_LIMPAR_FILTRO_Click(object sender, EventArgs e)
        {
            solicitationStatus = null;
            userName = null;
            TXT_Filtro_Nome.Text = "";
            returnSolicitacoes = manipulaSolicitacoes.GetSolicitacoes(0, userName, solicitationStatus);
            GRID_View_Solicitacoes.DataSource = returnSolicitacoes;
        }

        private void BTN_Filtrar_Click(object sender, EventArgs e)
        {
            userName = TXT_Filtro_Nome.Text.ToString() == "" ? userName = null : userName = TXT_Filtro_Nome.Text.ToString();

            returnSolicitacoes = manipulaSolicitacoes.GetSolicitacoes(0, userName, solicitationStatus);
            GRID_View_Solicitacoes.DataSource = returnSolicitacoes;
        }

        private void CBX_Filtro_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            solicitationStatus = (SolicitationStatus)Enum.Parse(typeof(SolicitationStatus), CBX_Filtro_Status.Text.ToString());

            returnSolicitacoes = manipulaSolicitacoes.GetSolicitacoes(0, userName, solicitationStatus);
            GRID_View_Solicitacoes.DataSource = returnSolicitacoes;
        }

        private void TXT_Filtro_Nome_TextChanged(object sender, EventArgs e)
        {
            BTN_Filtrar.PerformClick();
        }

        private void BTN_Gerar_PDF_Click(object sender, EventArgs e) //chama filtro de data PDF 
        {
            GB_filtros.Enabled = false;
            GB_Gera_PDF.Visible = true;
        }

        private void BTN_Gera_PDF_Click(object sender, EventArgs e) // Gera PDF
        {
            GB_filtros.Enabled = true;
            GB_Gera_PDF.Visible = false;

            DateTime inicial, final;
            inicial = DT_Data_inicial.Value;
            final = DT_Data_Final.Value;

            returnRelatorioSolicitacoes = RelatorioSolicitacoes.GetRelatorioSolicitacoes(userName, solicitationStatus, inicial, final);
            GRID_Relatorio_Solicitacoes.DataSource = returnRelatorioSolicitacoes;

            geraPDF.gerarPDF(GRID_Relatorio_Solicitacoes, "Solicitações");
        }

        private void BTN_Cancel_PDF_Click(object sender, EventArgs e)
        {
            GB_filtros.Enabled = true;
            GB_Gera_PDF.Visible = false;
        }
    }
}
