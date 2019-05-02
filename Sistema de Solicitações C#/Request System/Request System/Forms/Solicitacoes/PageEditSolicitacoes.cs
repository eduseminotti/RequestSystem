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
    public partial class PageEditSolicitacoes : Form
    {
        int solicitationId, userId, solicitationItemId, userRequesterId, quantidadeSolicitada, quantidadeAprovada, quantidadeEmEstoque;
        SolicitationStatus solicitationStatus;
        String userName, pass;
        UserIdioma userIdioma;

        ManipulaItensSolicitacoes itensSolicitacoes = new ManipulaItensSolicitacoes();
        ManipulaSolicitacoesStockMan solicitacoes = new ManipulaSolicitacoesStockMan();
        ValidateUsers validateUsers = new ValidateUsers();
        ManipulaStock manipulaStock = new ManipulaStock();

        List<returnItensSolicitacoes> returnItensSolicitacoes;
        List<ReturnSolicitacoesStockMan> returnSolicitacoesStockMan;

        public PageEditSolicitacoes(int SolicitationId, int UserId, int UserRequesterId, UserIdioma UserIdioma)
        {
            InitializeComponent();

            userIdioma = UserIdioma;
            userId = UserId;
            solicitationId = SolicitationId;
            userRequesterId = UserRequesterId;
        }
        public void PageEditSolicitacoes_Load(object sender, EventArgs e)
        {
            RecarregaTela();
        }
        private void BTN_Aprovar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            bool retorna = false;
            foreach (DataGridViewRow row in Grid_view_itens_solicitação.Rows)
            {
                var qtdAprovada = Convert.ToInt32(Grid_view_itens_solicitação.Rows[cont].Cells[3].Value.ToString());
                var qtdEmEstoque = Convert.ToInt32(Grid_view_itens_solicitação.Rows[cont].Cells[4].Value.ToString());

                if (qtdAprovada > qtdEmEstoque)
                {
                    Grid_view_itens_solicitação.Rows[cont].DefaultCellStyle.BackColor = Color.OrangeRed;

                    retorna = true;
                }
                cont++;
            }
            if (retorna)
            {
                if (userIdioma == UserIdioma.Portugues)
                    MessageBox.Show("Alguns itens do pedido não possuem estoque suficiente!");
                if (userIdioma == UserIdioma.Ingles)
                    MessageBox.Show("Some order items do not have enough stock!");
                if (userIdioma == UserIdioma.Espanhol)
                    MessageBox.Show("Algunos elementos de la solicitud no tienen suficiente stock!");

                return;
            }
            else
            {

                solicitacoes.UpdateStatus(solicitationId, SolicitationStatus.Aprovado, true, false, userId);
                returnItensSolicitacoes = itensSolicitacoes.GetItensSolicitacao(solicitationId);
                manipulaStock.EditaItensStock(returnItensSolicitacoes);


            }
            RecarregaTela();
        }
        private void BTN_Rejeitar_Click(object sender, EventArgs e)
        {
            solicitacoes.UpdateStatus(solicitationId, SolicitationStatus.Rejeitado, true, false, userId);
            RecarregaTela();
        }
        private void BTN_Cancel_QTD_Click(object sender, EventArgs e)
        {
            GB_Editar_QTD_Itens.Visible = false;
            RecarregaTela();
        }

        private void BTN_Assinar_Entrega_Click(object sender, EventArgs e)
        {
            pass = TXT_Pass.Text.ToString();
            var user = validateUsers.ValidaUsuario(userName, pass);
            if (user == null)
            {
                if (userIdioma == UserIdioma.Portugues)
                    MessageBox.Show("Usúario ou senha Invalido");
                if (userIdioma == UserIdioma.Ingles)
                    MessageBox.Show("Invalid User or Password!");
                if (userIdioma == UserIdioma.Espanhol)
                    MessageBox.Show("Usuario o contraseña Invalida!");
                TXT_Pass.Text = "";
            }
            else
            {
                solicitacoes.UpdateStatus(solicitationId, SolicitationStatus.Entregue, false, true, userId);

                GB_valida_usuario.Visible = false;
                TXT_Pass.Text = "";
                RecarregaTela();
            }
        }

        private void BTN_Cancelar_Login_Click(object sender, EventArgs e)
        {
            GB_valida_usuario.Visible = false;
            TXT_Pass.Text = "";
        }
        private void BTN_Salvar_QTD_Click(object sender, EventArgs e)
        {
            quantidadeAprovada = Convert.ToInt32(TXT_QTD_Aprovada.Value);

            if (quantidadeAprovada > quantidadeSolicitada || quantidadeAprovada > quantidadeEmEstoque)
            {
                TXT_QTD_Aprovada.Value = quantidadeSolicitada;

                if (userIdioma == UserIdioma.Portugues)
                    MessageBox.Show("Quantidade aprovada é maior que a quantidade solicitada ou em estoque!");
                if (userIdioma == UserIdioma.Ingles)
                    MessageBox.Show("Approved quantity is greater than the quantity requested or in stock!");
                if (userIdioma == UserIdioma.Espanhol)
                    MessageBox.Show("La cantidad aprobada es mayor que la cantidad solicitada o en stock!");

                return;
            }
            else
            {
                itensSolicitacoes.AtualizaQuantidadeAprovada(solicitationItemId, quantidadeAprovada);
                GB_Editar_QTD_Itens.Visible = false;
            }
            RecarregaTela();
        }
        private void BTN_Fechar_Qtd_Click(object sender, EventArgs e)
        {
            GB_Editar_QTD_Itens.Visible = false;
            RecarregaTela();
        }
        private void BTN_Entregar_Click(object sender, EventArgs e)
        {
            userName = validateUsers.GetUserName(userRequesterId);
            TXT_user_name.Text = userName.ToString();
            GB_valida_usuario.Visible = true;
        }
        public void RecarregaTela()
        {
            CBX_Status_Solicitacao.DataSource = Enum.GetValues(typeof(SolicitationStatus));

            returnSolicitacoesStockMan = solicitacoes.GetSolicitacoes(solicitationId, null, null);

            foreach (var solicitacao in returnSolicitacoesStockMan)
            {
                DT_Data_solicitacao.Value = Convert.ToDateTime(solicitacao.DataSolicitacao);

                if (solicitacao.DataAprovacao != null)
                {
                    DT_Data_Aprovacao.Visible = true;
                    DT_Data_Aprovacao.Value = Convert.ToDateTime(solicitacao.DataAprovacao);
                }
                if (solicitacao.DataRetirada != null)
                {
                    DT_Data_Entrega.Visible = true;
                    DT_Data_Entrega.Value = Convert.ToDateTime(solicitacao.DataRetirada);
                }
                TXT_UsuarioSolicitante.Text = solicitacao.UserRequesterName.ToString();
                solicitationStatus = solicitacao.SolicitationStatus;
                CBX_Status_Solicitacao.Text = solicitationStatus.ToString();
                TXT_Motivo.Text = solicitacao.Motivo.ToString();
            }
            if (solicitationStatus == SolicitationStatus.Pendente)
            {
                BTN_Entregar.Visible = false;
            }
            if (solicitationStatus == SolicitationStatus.Aprovado)
            {
                BTN_Aprovar.Visible = false;
                BTN_Rejeitar.Visible = false;
                GB_DataAprovacao.Visible = true;
                BTN_Editar.Visible = false;
                BTN_Entregar.Visible = true;
            }
            if (solicitationStatus == SolicitationStatus.Rejeitado)
            {
                BTN_Aprovar.Visible = false;
                BTN_Rejeitar.Visible = false;
                BTN_Editar.Visible = false;
                GB_DataAprovacao.Visible = true;
                BTN_Entregar.Visible = false;
            }
            if (solicitationStatus == SolicitationStatus.Entregue)
            {
                BTN_Aprovar.Visible = false;
                BTN_Rejeitar.Visible = false;
                BTN_Entregar.Visible = false;
                GB_DataAprovacao.Visible = true;
                GB_DataEntrega.Visible = true;
                BTN_Editar.Visible = false;
            }
            returnItensSolicitacoes = itensSolicitacoes.GetItensSolicitacao(solicitationId);
            Grid_view_itens_solicitação.DataSource = returnItensSolicitacoes;
        }
        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            Grid_view_itens_solicitação.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            solicitationItemId = Convert.ToInt32(Grid_view_itens_solicitação.CurrentRow.Cells[6].Value.ToString());
            quantidadeSolicitada = Convert.ToInt32(Grid_view_itens_solicitação.CurrentRow.Cells[2].Value.ToString());
            quantidadeAprovada = Convert.ToInt32(Grid_view_itens_solicitação.CurrentRow.Cells[3].Value.ToString());
            quantidadeEmEstoque = Convert.ToInt32(Grid_view_itens_solicitação.CurrentRow.Cells[4].Value.ToString());

            String productName = Grid_view_itens_solicitação.CurrentRow.Cells[1].Value.ToString();

            TXT_Produto.Text = productName.ToString();
            TXT_qtd_solicitada.Text = quantidadeSolicitada.ToString();
            TXT_QTD_Aprovada.Text = quantidadeAprovada.ToString();

            GB_Editar_QTD_Itens.Visible = true;

            RecarregaTela();

        }
        private void BTN_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
