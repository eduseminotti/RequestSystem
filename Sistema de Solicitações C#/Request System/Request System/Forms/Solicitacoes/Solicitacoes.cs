﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
            if (ContLinhasGrid() < 1)
                return;

            int solicitationId = Convert.ToInt32(GRID_View_Solicitacoes.CurrentRow.Cells[0].Value.ToString());
            int userRequesterId = Convert.ToInt32(GRID_View_Solicitacoes.CurrentRow.Cells[7].Value.ToString());

            pageEditSolicitacoes = new PageEditSolicitacoes(solicitationId, userId, userRequesterId, userIdioma);
            pageEditSolicitacoes.ShowDialog();

            returnSolicitacoes = manipulaSolicitacoes.GetSolicitacoes(0, null, null);
            GRID_View_Solicitacoes.DataSource = returnSolicitacoes;
        }
        public int ContLinhasGrid()
        {
            int linhasGrid;
            linhasGrid = GRID_View_Solicitacoes.Rows.Count;

            return linhasGrid;
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

        private void BTN_Gera_PDF_Click(object sender, EventArgs e) // Gera PDF
        {
            GB_filtros.Enabled = true;

            returnRelatorioSolicitacoes = RelatorioSolicitacoes.GetRelatorioSolicitacoes(userName, solicitationStatus);
            GRID_Relatorio_Solicitacoes.DataSource = returnRelatorioSolicitacoes;

            geraPDF.gerarPDF(GRID_Relatorio_Solicitacoes, "Solicitações");
        }

        private void GRID_View_Solicitacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_Ver_Solicitacao.PerformClick();
        }

        private void TXT_Filtro_Nome_Enter(object sender, EventArgs e)
        {
            TXT_Filtro_Nome.BackColor = Color.Yellow;
        }

        private void TXT_Filtro_Nome_Leave(object sender, EventArgs e)
        {
            TXT_Filtro_Nome.BackColor = Color.White;
        }

        private void CBX_Filtro_Status_Enter(object sender, EventArgs e)
        {
            CBX_Filtro_Status.BackColor = Color.Yellow;
        }

        private void CBX_Filtro_Status_Leave(object sender, EventArgs e)
        {
            CBX_Filtro_Status.BackColor = Color.White;
        }

        private void TXT_Filtro_Nome_TextChanged_1(object sender, EventArgs e)
        {
            if (TXT_Filtro_Nome.Text != "")
                BTN_Filtrar.PerformClick();
            else
                BTN_LIMPAR_FILTRO.PerformClick();
        }

        private void CBX_Filtro_Status_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            solicitationStatus = (SolicitationStatus)Enum.Parse(typeof(SolicitationStatus), CBX_Filtro_Status.Text.ToString());

            returnSolicitacoes = manipulaSolicitacoes.GetSolicitacoes(0, userName, solicitationStatus);
            GRID_View_Solicitacoes.DataSource = returnSolicitacoes;
        }
    }
}
