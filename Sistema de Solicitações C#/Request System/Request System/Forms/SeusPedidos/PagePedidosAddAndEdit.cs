
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Request_System
{
    public partial class PageSolicitationAddAndEdit : Form
    {
        String productName, motivo;
        int productID;
        int quantidade;
        int userRequesterId;
        int solicitationId;
        int itemId;
        SolicitationStatus status;
        UserIdioma userIdioma;

        ManipulaProdutos manipulaProdutos = new ManipulaProdutos();
        ManipulaSolicitacoesUsuario manipulaSolicitacoes = new ManipulaSolicitacoesUsuario();
        ManipulaItensSolicitacoes manipulaItensSolicitacao = new ManipulaItensSolicitacoes();
        List<ReturnProdutos> listProdutos;
        List<returnItensSolicitacoes> itensSolicitacoes = new List<returnItensSolicitacoes>();

        public PageSolicitationAddAndEdit(int UserId, int SolicitationId, bool IsNew, UserIdioma UserIdioma)
        {
            InitializeComponent();

            userIdioma = UserIdioma;

            solicitationId = SolicitationId;
            userRequesterId = UserId;

            TXT_Find_product.Focus();

            var solicitacoes = manipulaSolicitacoes.GetSolicitacoesUsuario(userRequesterId, solicitationId, null);
            foreach (var solicitacao in solicitacoes)
            {
                status = solicitacao.SolicitationStatus;
                motivo = solicitacao.Motivo;
            }
            if (status != SolicitationStatus.Pendente)
            {
                TXT_Find_product.Enabled = false;
                TXT_qtd_Itens.Enabled = false;
                BTN_Remove_Item.Enabled = false;
                BTN_Add_product.Enabled = false;
                txt_motivo.Enabled = false;
                BTN_Salvar.Enabled = false;
            }

            txt_motivo.Text = motivo;

            itensSolicitacoes = manipulaItensSolicitacao.GetItensSolicitacao(solicitationId);
            Grid_Itens_solicitacoes.DataSource = itensSolicitacoes;

            List_products.MouseDoubleClick += new MouseEventHandler(List_products_DoubleClick);

            ContLinhasGrid();
        }
        private void BTN_Add_product_Click(object sender, EventArgs e)
        {
            if (productName != null && TXT_qtd_Itens.Value != 0)
            {

                foreach (var row in this.Grid_Itens_solicitacoes.Rows)
                {
                    var dataGridViewRow = row as DataGridViewRow;
                    var celula = dataGridViewRow.Cells[0];
                    //var valor = celula.Value;

                    int insertProductId = Convert.ToInt32(Grid_Itens_solicitacoes.CurrentRow.Cells[0].Value.ToString());
                    if (insertProductId == productID)
                    {
                        MessageBox.Show("Este produto Já esta inserido neste pedido!");
                        TXT_Find_product.Text = "";
                        TXT_qtd_Itens.Value = 0;
                        return;
                    }
                }

                quantidade = Convert.ToInt32(TXT_qtd_Itens.Value);
                motivo = txt_motivo.Text.ToString();

                manipulaItensSolicitacao.InsertItemSolicitacao(solicitationId, productID, quantidade);

                itensSolicitacoes = manipulaItensSolicitacao.GetItensSolicitacao(solicitationId);
                Grid_Itens_solicitacoes.DataSource = itensSolicitacoes;

                TXT_Find_product.Text = "";
                TXT_qtd_Itens.Value = 0;

                TXT_Find_product.Focus();
                productName = null;
                productID = 0;
            }
            else
            {
                if (userIdioma == UserIdioma.Portugues)
                    MessageBox.Show("Informe um produto.");
                if (userIdioma == UserIdioma.Ingles)
                    MessageBox.Show("Select a product.");
                if (userIdioma == UserIdioma.Espanhol)
                    MessageBox.Show("Seleccione un producto.");
            }
            ContLinhasGrid();
        }
        private void BTN_busca_produto_Click(object sender, EventArgs e)
        {
            GB_Seleciona_produto.Visible = true;

            if (TXT_Find_product.Text != "")
                productName = TXT_Find_product.Text.ToString();
            else
                productName = null;

            listProdutos = manipulaProdutos.GetProducts(0, productName, ProductIsActive.Ativo);

            if (listProdutos.Count == 0)
            {
                listProdutos = manipulaProdutos.GetProducts(0, null, ProductIsActive.Ativo);
            }

            List_products.DataSource = listProdutos;
        }
        private void BTN_Seleciona_produto_Click(object sender, EventArgs e)
        {
            productName = List_products.Text.ToString();
            productName = productName.Split('-')[0];

            listProdutos = manipulaProdutos.GetProducts(0, productName, ProductIsActive.Ativo);

            foreach (var produtos in listProdutos)
            {
                productID = produtos.Product_Id;
            }

            TXT_Find_product.Text = productName.ToString();

            GB_Seleciona_produto.Visible = false;
            TXT_Find_product.Focus();
            GB_Seleciona_produto.Visible = false;
        }
        private void BTN_Remove_Item_Click(object sender, EventArgs e)
        {
            itemId = Convert.ToInt32(Grid_Itens_solicitacoes.CurrentRow.Cells[5].Value.ToString());
            manipulaItensSolicitacao.DeletaItemSolicitacao(itemId);
            itensSolicitacoes = manipulaItensSolicitacao.GetItensSolicitacao(solicitationId);
            Grid_Itens_solicitacoes.DataSource = itensSolicitacoes;
            TXT_Find_product.Focus();

            ContLinhasGrid();
        }
        private void List_products_DoubleClick(object sender, EventArgs e)
        {
            productName = List_products.Text.ToString();
            productName = productName.Split('-')[0];

            listProdutos = manipulaProdutos.GetProducts(0, productName, ProductIsActive.Ativo);

            foreach (var produtos in listProdutos)
            {
                productID = produtos.Product_Id;
            }
            TXT_Find_product.Text = productName;

            GB_Seleciona_produto.Visible = false;
        }
        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            manipulaSolicitacoes.UpdateMotivo(solicitationId, txt_motivo.Text.ToString());
            this.Close();
        }

        private void BTN_Fechar_Click(object sender, EventArgs e)
        {
            int linhasGrid;
            linhasGrid = ContLinhasGrid();
            if (linhasGrid < 1)
            {
                manipulaSolicitacoes.DeletaSolicitacao(solicitationId);
            }
            this.Close();
        }

        private void Txt_motivo_Enter(object sender, EventArgs e)
        {
            txt_motivo.BackColor = Color.Yellow;
        }

        private void Txt_motivo_Leave(object sender, EventArgs e)
        {
            txt_motivo.BackColor = Color.White;
            manipulaSolicitacoes.UpdateMotivo(solicitationId, txt_motivo.Text.ToString());
        }

        private void TXT_Find_product_Enter(object sender, EventArgs e)
        {
            TXT_Find_product.BackColor = Color.Yellow;
        }

        private void TXT_Find_product_Leave(object sender, EventArgs e)
        {
            TXT_Find_product.BackColor = Color.White;
        }

        private void TXT_qtd_Itens_Enter(object sender, EventArgs e)
        {
            TXT_qtd_Itens.BackColor = Color.Yellow;
        }

        private void TXT_qtd_Itens_Leave(object sender, EventArgs e)
        {
            TXT_qtd_Itens.BackColor = Color.White;
        }

        private void TXT_Find_product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_Seleciona_produto.PerformClick();
                GB_Seleciona_produto.Visible = false;
            }
            if (e.KeyCode == Keys.Tab)
                List_products.Focus();

        }

        private void TXT_Find_product_TextChanged(object sender, EventArgs e)
        {
            if (TXT_Find_product.Text == "")
            {
                productName = null;
                GB_Seleciona_produto.Visible = false;
            }
            else
            {
                productName = TXT_Find_product.Text.ToString();
                GB_Seleciona_produto.Visible = true;
            }


            listProdutos = manipulaProdutos.GetProducts(0, productName, ProductIsActive.Ativo);

            if (listProdutos.Count == 0)
            {
                listProdutos = manipulaProdutos.GetProducts(0, null, ProductIsActive.Ativo);
            }

            List_products.DataSource = listProdutos;
        }

        public int ContLinhasGrid()
        {
            int linhasGrid;
            linhasGrid = Grid_Itens_solicitacoes.Rows.Count;

            if (linhasGrid < 1 || status != SolicitationStatus.Pendente)
            {
                BTN_Remove_Item.Enabled = false;
            }
            else if (linhasGrid > 0)
            {
                BTN_Remove_Item.Enabled = true;
            }
            return linhasGrid;
        }
    }
}
