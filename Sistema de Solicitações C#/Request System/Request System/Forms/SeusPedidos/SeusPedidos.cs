
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Request_System
{
    public partial class SeusPedidos : Form
    {
        ManipulaSolicitacoesUsuario manipulaSolicitacoes = new ManipulaSolicitacoesUsuario();
        ManipulaItensSolicitacoes manipulaItensSolicitacoes = new ManipulaItensSolicitacoes();
        PageSolicitationAddAndEdit PageSolicitation;
        List<ReturnSolicitacoesUsuario> Solicitacoes;
        GeradorDePDFGrid GeraPDF = new GeradorDePDFGrid();
        int userId;
        int solicitationId;
        SolicitationStatus status;
        bool telaCarregada = false;
        UserIdioma idioma;

        public SeusPedidos(int UserId, UserIdioma Idioma)
        {
            InitializeComponent();

            idioma = Idioma;
            userId = UserId;

            Solicitacoes = manipulaSolicitacoes.GetSolicitacoesUsuario(userId, 0, null);
            Grid_Solicitacoes.DataSource = Solicitacoes;
            telaCarregada = true;
            CBX_Status_Pedido.DataSource = Enum.GetValues(typeof(SolicitationStatus));
        }
        private void BTN_Nova_Solicitacao_Click(object sender, EventArgs e)
        {
            solicitationId = manipulaSolicitacoes.InsertSolicitacao(userId);

            PageSolicitation = new PageSolicitationAddAndEdit(userId, solicitationId, true, idioma);
            PageSolicitation.ShowDialog();

            Solicitacoes = manipulaSolicitacoes.GetSolicitacoesUsuario(userId, 0, null);
            Grid_Solicitacoes.DataSource = Solicitacoes;
        }               
        private void BTN_Excluir_Solicitacao_Click(object sender, EventArgs e)
        {
            solicitationId = Convert.ToInt32(Grid_Solicitacoes.CurrentRow.Cells[0].Value.ToString());

            var solicitacoes = manipulaSolicitacoes.GetSolicitacoesUsuario(userId, solicitationId, null);
            foreach (var solicitacao in solicitacoes)
            {
                status = solicitacao.SolicitationStatus;
            }
            if (status != SolicitationStatus.Pendente)
            {
                if(idioma == UserIdioma.Portugues)
                MessageBox.Show("Somente solicitações pendentes podem ser excluidas!");

                if (idioma == UserIdioma.Ingles)
                    MessageBox.Show("Only pending requests can be excluded!");

                if (idioma == UserIdioma.Espanhol)
                    MessageBox.Show("Sólo se pueden excluir solicitudes pendientes!");

                return;
            }
            else
            {
                DialogResult? confirm = null;
                if (idioma == UserIdioma.Portugues)
                    confirm = MessageBox.Show("Tem certeza que excluir a solicitação?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (idioma == UserIdioma.Ingles)
                    confirm = MessageBox.Show("Are you sure you want to delete the request?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (idioma == UserIdioma.Espanhol)
                    confirm = MessageBox.Show("Está seguro de que elimina la solicitud?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    manipulaItensSolicitacoes.DeletaTodosItensSolicitacao(solicitationId);
                    manipulaSolicitacoes.DeletaSolicitacao(solicitationId);

                    Solicitacoes = manipulaSolicitacoes.GetSolicitacoesUsuario(userId, 0, null);
                    Grid_Solicitacoes.DataSource = Solicitacoes;
                }
            }
        }
        private void BTN_Filtrar_Click(object sender, EventArgs e)
        {
            var solisitationStatus = (SolicitationStatus)Enum.Parse(typeof(SolicitationStatus), CBX_Status_Pedido.Text.ToString());

            Solicitacoes = manipulaSolicitacoes.GetSolicitacoesUsuario(userId, 0, solisitationStatus);
            Grid_Solicitacoes.DataSource = Solicitacoes;
        }
        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            Solicitacoes = manipulaSolicitacoes.GetSolicitacoesUsuario(userId, 0, null);
            Grid_Solicitacoes.DataSource = Solicitacoes;
        }
        private void CBX_Status_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!telaCarregada)
            {
                BTN_Filtrar.PerformClick();
            }
            telaCarregada = false;
        }

        private void BTN_Edit_Click_1(object sender, EventArgs e)
        {
            solicitationId = Convert.ToInt32(Grid_Solicitacoes.CurrentRow.Cells[0].Value.ToString());

            PageSolicitation = new PageSolicitationAddAndEdit(userId, solicitationId, false, idioma);
            PageSolicitation.ShowDialog();

            Solicitacoes = manipulaSolicitacoes.GetSolicitacoesUsuario(userId, 0, null);
            Grid_Solicitacoes.DataSource = Solicitacoes;
        }

        private void BTN_Gera_PDF_Click(object sender, EventArgs e)
        {
            GeraPDF.gerarPDF(Grid_Solicitacoes, "Pedidos");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Grid_Solicitacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_Edit.PerformClick();
        }
    }
}
