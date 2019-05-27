using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Request_System
{
    public partial class Page_NFes_Add_And_Edit : Form
    {
        String providerCNPJ, productName, productTPUnidade;
        decimal valueNFe;
        int providerID, numberNFe, nfeId, productId, itemId;
        int seriesNFe, qtdItens;
        DateTime emissionDateNFe = DateTime.Now;
        bool insereOK, isNew, textchange;
        UserIdioma userIdioma;


        Page_Products_Edit_And_Add PageProductAdd;
        ManipulaFornecedores fornecedores = new ManipulaFornecedores();
        ManipulaProdutos produtos = new ManipulaProdutos();
        ManipulaNFes dadosNFes = new ManipulaNFes();
        ManipulaItensNFe dados_Itens_NFe = new ManipulaItensNFe();
        List<ReturnProviders> return_Providers;
        List<ReturnNFes> Return_NFes;
        List<ReturnNFeitens> ItensNFe;
        List<ReturnProdutos> return_Produtos;
        ManipulaStock dadosStock = new ManipulaStock();

        public Page_NFes_Add_And_Edit(UserIdioma UserIdioma)
        {
            InitializeComponent();

            TXT_Numero_NFe.Focus();
            BTN_SelecionaForn.Enabled = false;
            listCNPJ.MouseDoubleClick += new MouseEventHandler(listCNPJ_DoubleClick);
            LB_List_Products_Name.MouseDoubleClick += new MouseEventHandler(LB_List_Products_Name_DoubleClick);
            userIdioma = UserIdioma;

            ContLinhasGrid();
        }
        public void RecebeEdicaoNFe(int SerieNFe, int NumeroNFe, decimal ValorNFe, String CNPJ, int NFeID, int ProviderId, DateTime DataEmissao, bool inStock)
        {
            isNew = false;
            nfeId = NFeID;
            providerCNPJ = CNPJ;
            valueNFe = ValorNFe;
            providerID = ProviderId;
            numberNFe = NumeroNFe;
            nfeId = NFeID;
            seriesNFe = SerieNFe;
            emissionDateNFe = DataEmissao;
            BTN_RegNFe.Enabled = true;
            TXT_Numero_NFe.Text = numberNFe.ToString();
            TXT_Serie_NFe.Text = seriesNFe.ToString();
            TXT_Valor.Text = valueNFe.ToString();           
            DT_Data_Emissão.Value = emissionDateNFe;
            TXT_CNPJ_Selected.Text = providerCNPJ.ToString();

            ItensNFe = dados_Itens_NFe.GetNFeItens(nfeId);
            GRID_Itens_NFe.DataSource = ItensNFe;

            GB_Add_Itens_NFe.Enabled = true;
            BTN_AddProduct.Enabled = true;

            if (userIdioma == UserIdioma.Portugues)
                BTN_RegNFe.Text = "Salvar Alterações";
            if (userIdioma == UserIdioma.Ingles)
                BTN_RegNFe.Text = "Save Changes";
            if (userIdioma == UserIdioma.Espanhol)
                BTN_RegNFe.Text = "Guardar Cambios";

            TXT_Numero_NFe.Focus();

            if (inStock)
            {
                BTN_AddItensStock.Enabled = false;
                BTN_AddProduct.Enabled = false;
                BTN_RegNFe.Enabled = false;
                BTN_RemoveItem.Enabled = false;
                GB_Add_Itens_NFe.Enabled = false;

                DesabilitaCamposNFe();
            }

            TXT_Valor.Text = TXT_Valor.Text.ToString().Replace("$", "").Replace(" ", "").Replace("R", "").Replace("€", "");
            TXT_Valor.Text = Convert.ToDouble(TXT_Valor.Text).ToString("C");

            ContLinhasGrid();
        }
        public void RecebeNovaNFe()
        {
            isNew = true;
            BTN_AddItensStock.Enabled = false;

            TXT_Numero_NFe.Focus();
        }

        public void DesabilitaCamposNFe()
        {
            TXT_Numero_NFe.ReadOnly = true;
            TXT_CNPJ_Selected.ReadOnly = true;
            TXT_Serie_NFe.ReadOnly = true;
            TXT_Valor.ReadOnly = true;
            DT_Data_Emissão.Enabled = false;
            BTN_LimparNFe.Enabled = false;
            BTN_RegNFe.Enabled = false;
            BTN_NewProvider.Enabled = false;
            label1.Focus();
            BTN_Fechar_tela.Focus();
        }

        private void BTN_Fechar_tela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_RemoveItem_Click(object sender, EventArgs e)
        {
            itemId = Convert.ToInt32(GRID_Itens_NFe.CurrentRow.Cells[4].Value.ToString());

            dados_Itens_NFe.Deleta_NFe_Item(itemId);
            ItensNFe = dados_Itens_NFe.GetNFeItens(nfeId);
            GRID_Itens_NFe.DataSource = ItensNFe;

            ContLinhasGrid();
        }
        public int ContLinhasGrid()
        {
            int linhasGrid;
            linhasGrid = GRID_Itens_NFe.Rows.Count;

            if (linhasGrid < 1)
                BTN_RemoveItem.Enabled = false;
            else
                BTN_RemoveItem.Enabled = true;

            return linhasGrid;
        }
        private void BTN_SelecionarByName_Click(object sender, EventArgs e)
        {
            productName = LB_List_Products_Name.Text.ToString();

            productName = productName.Split('-')[0];

            return_Produtos = produtos.GetProducts(0, productName, ProductIsActive._);
            foreach (var return_Produtos in return_Produtos)
            {
                productId = return_Produtos.Product_Id;
                productName = return_Produtos.Product_Name;
                productTPUnidade = return_Produtos.Product_Unidade;
            }

            if (return_Produtos.Count == 0)
                return;
            TXT_Nome_Produto.Text = productName.ToString();
            TXT_TP_Unidade.Text = productTPUnidade.ToString();
            GB_Find_Product_By_Name.Visible = false;
            TXT_Nome_Produto.Focus();
        }

        private void TXT_QTD_Produto_TextChanged(object sender, EventArgs e)
        {
            TXT_QTD_Produto.BackColor = Color.White;
            if (!Int32.TryParse(TXT_QTD_Produto.Text, out int valor))
            {
                TXT_QTD_Produto.BackColor = Color.OrangeRed;
                return;
            }
        }
        private void BTN_AddProduct_Click(object sender, EventArgs e)
        {
            if (TXT_Nome_Produto.Text == "")
            {
                TXT_Nome_Produto.BackColor = Color.OrangeRed;
                TXT_Nome_Produto.Focus();
                return;
            }
            if (!Int32.TryParse(TXT_QTD_Produto.Text, out int valor))
            {
                TXT_QTD_Produto.BackColor = Color.OrangeRed;
                TXT_QTD_Produto.Focus();
                return;
            }

            qtdItens = Convert.ToInt32(TXT_QTD_Produto.Text.ToString());
            dados_Itens_NFe.New_NFe_Item(qtdItens, productId, nfeId);

            ItensNFe = dados_Itens_NFe.GetNFeItens(nfeId);
            GRID_Itens_NFe.DataSource = ItensNFe;
            BTN_AddItensStock.Enabled = true;

            TXT_Nome_Produto.Text = "";
            TXT_Nome_Produto.Focus();
            TXT_QTD_Produto.Text = "";
            TXT_QTD_Produto.BackColor = Color.White;
            TXT_TP_Unidade.Text = "";

            GB_Find_Product_By_Name.Visible = false;
            ContLinhasGrid();
        }

        private void BTN_LimparItensNFe_Click(object sender, EventArgs e)
        {
            TXT_Nome_Produto.Text = "";
            TXT_QTD_Produto.Text = "";
            TXT_TP_Unidade.Text = "";
            GB_Find_Product_By_Name.Visible = false;
        }

        private void BTN_SelecionaForn_Click(object sender, EventArgs e)
        {
            GB_Busca_CNPJ_Forn.Visible = false;
            providerCNPJ = listCNPJ.Text.ToString();

            TXT_CNPJ_Selected.Text = providerCNPJ.Split('-')[0];

            GB_Busca_CNPJ_Forn.Visible = false;
            BTN_SelecionaForn.Enabled = false;
            BTN_RegNFe.Enabled = true;
            TXT_CNPJ_Selected.Focus();
        }

        private void TXT_Numero_NFe_TextChanged(object sender, EventArgs e)
        {
            TXT_Numero_NFe.BackColor = Color.White;
            if (!Int32.TryParse(TXT_Numero_NFe.Text, out int valor))
            {
                TXT_Numero_NFe.BackColor = Color.OrangeRed;
                return;
            }
        }

        private void TXT_Serie_NFe_TextChanged(object sender, EventArgs e)
        {
            TXT_Serie_NFe.BackColor = Color.White;
            if (!Int32.TryParse(TXT_Serie_NFe.Text, out int valor))
            {
                TXT_Serie_NFe.BackColor = Color.OrangeRed;
                return;
            }
        }

        private void listCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BTN_SelecionaForn.PerformClick();
        }

        private void LB_List_Products_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BTN_SelecionarByName.PerformClick();
        }

        private void TXT_Nome_Produto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                LB_List_Products_Name.Focus();

            if (e.KeyCode == Keys.Enter)
                BTN_SelecionarByName.PerformClick();
        }

        private void TXT_Numero_NFe_Enter(object sender, EventArgs e)
        {
            TXT_Numero_NFe.BackColor = Color.Yellow;
        }

        private void TXT_Numero_NFe_Leave(object sender, EventArgs e)
        {
            TXT_Numero_NFe.BackColor = Color.White;
        }

        private void TXT_Serie_NFe_Enter(object sender, EventArgs e)
        {
            TXT_Serie_NFe.BackColor = Color.Yellow;
        }

        private void TXT_Serie_NFe_Leave(object sender, EventArgs e)
        {
            TXT_Serie_NFe.BackColor = Color.White;
        }

        private void DT_Data_Emissão_Enter(object sender, EventArgs e)
        {
            DT_Data_Emissão.BackColor = Color.Yellow;
        }

        private void DT_Data_Emissão_Leave(object sender, EventArgs e)
        {
            DT_Data_Emissão.BackColor = Color.White;
        }

        private void TXT_Valor_Enter(object sender, EventArgs e)
        {
            TXT_Valor.Text = TXT_Valor.Text.ToString().Replace("$", "").Replace(" ", "").Replace("R", "").Replace("€", "");
            TXT_Valor.BackColor = Color.Yellow;
        }

        private void TXT_Valor_Leave(object sender, EventArgs e)
        {
            TXT_Valor.BackColor = Color.White;
            TXT_Valor.Text = TXT_Valor.Text.ToString().Replace("$", "").Replace("R", "").Replace("€", "").Replace(" ", "");
            if (TXT_Valor.Text != "")
                TXT_Valor.Text = Convert.ToDouble(TXT_Valor.Text).ToString("C");
        }

        private void TXT_Nome_Produto_Enter(object sender, EventArgs e)
        {
            TXT_Nome_Produto.BackColor = Color.Yellow;
        }

        private void TXT_Nome_Produto_Leave(object sender, EventArgs e)
        {
            TXT_Nome_Produto.BackColor = Color.White;
        }

        private void TXT_QTD_Produto_Enter(object sender, EventArgs e)
        {
            TXT_QTD_Produto.BackColor = Color.Yellow;
        }

        private void TXT_QTD_Produto_Leave(object sender, EventArgs e)
        {
            TXT_QTD_Produto.BackColor = Color.White;
        }

        private void LB_List_Products_Name_Enter(object sender, EventArgs e)
        {
            LB_List_Products_Name.BackColor = Color.Yellow;
        }

        private void LB_List_Products_Name_Leave(object sender, EventArgs e)
        {
            LB_List_Products_Name.BackColor = Color.White;
        }

        private void listCNPJ_Enter(object sender, EventArgs e)
        {
            listCNPJ.BackColor = Color.Yellow;
        }

        private void listCNPJ_Leave(object sender, EventArgs e)
        {
            listCNPJ.BackColor = Color.White;
        }

        private void TXT_CNPJ_Selected_TextChanged_1(object sender, EventArgs e)
        {
            TXT_CNPJ_Selected.BackColor = Color.White;
            providerCNPJ = TXT_CNPJ_Selected.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "").Replace(",","");

            if (isNew)
            {

                GB_Busca_CNPJ_Forn.Visible = true;
                BTN_RegNFe.Enabled = false;
                return_Providers = fornecedores.GetProviders(0, null, providerCNPJ);
                listCNPJ.DataSource = return_Providers;

                foreach (var return_Providers in return_Providers)
                {
                    providerID = return_Providers.Id;
                }

                BTN_SelecionaForn.Enabled = true;
            }
            else if (!isNew)
            {
                if (textchange)
                {
                    GB_Busca_CNPJ_Forn.Visible = true;
                    BTN_RegNFe.Enabled = false;
                    return_Providers = fornecedores.GetProviders(0, null, providerCNPJ);
                    listCNPJ.DataSource = return_Providers;

                    foreach (var return_Providers in return_Providers)
                    {
                        providerID = return_Providers.Id;
                    }
                    BTN_SelecionaForn.Enabled = true;
                    textchange = false;
                }
                textchange = true;
            }
        }

        private void TXT_CNPJ_Selected_Enter_1(object sender, EventArgs e)
        {
            TXT_CNPJ_Selected.BackColor = Color.Yellow;
        }

        private void TXT_CNPJ_Selected_Leave_1(object sender, EventArgs e)
        {
            TXT_CNPJ_Selected.BackColor = Color.White;
        }

        private void TXT_CNPJ_Selected_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                listCNPJ.Focus();

            if (e.KeyCode == Keys.Enter)
                BTN_SelecionaForn.PerformClick();
        }

        private void Page_NFes_Add_And_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void TXT_Valor_TextChanged(object sender, EventArgs e)
        {
            TXT_Valor.BackColor = Color.White;
            if (!decimal.TryParse(TXT_Valor.Text.Replace(",", "").Replace(".", "").Replace("$", "").Replace("R", "").Replace("€", "").Replace(" ", ""), out decimal valor) && TXT_Valor.Text != "")
            {
                TXT_Valor.BackColor = Color.OrangeRed;
                return;
            }
        }

        private void BTN_RegNFe_Click(object sender, EventArgs e)
        {
            bool returns = false;
            if (!Int32.TryParse(TXT_Numero_NFe.Text, out int valor))
            {
                TXT_Numero_NFe.BackColor = Color.OrangeRed;
                TXT_Numero_NFe.Focus();
                returns = true;
            }
            if (!Int32.TryParse(TXT_Serie_NFe.Text, out valor))
            {
                TXT_Serie_NFe.BackColor = Color.OrangeRed;
                TXT_Serie_NFe.Focus();
                returns = true;
            }
            if (!decimal.TryParse(TXT_Valor.Text.Replace("$", "").Replace("R", "").Replace("€", "").Replace(" ", ""), out decimal v2))
            {
                TXT_Valor.BackColor = Color.OrangeRed;
                TXT_Valor.Focus();
                returns = true;
            }
            if (TXT_CNPJ_Selected.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "") == "")
            {
                TXT_CNPJ_Selected.BackColor = Color.OrangeRed;
                TXT_CNPJ_Selected.Focus();
                returns = true;
            }
            if (returns)
                return;

            numberNFe = Convert.ToInt32(TXT_Numero_NFe.Text.ToString());
            seriesNFe = Convert.ToInt32(TXT_Serie_NFe.Text.ToString());

            valueNFe = decimal.Parse(TXT_Valor.Text.ToString().Replace("$", "").Replace("R", "").Replace("€", "").Replace(" ", ""));
            emissionDateNFe = Convert.ToDateTime(DT_Data_Emissão.Value);

            providerCNPJ = TXT_CNPJ_Selected.Text.ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "");

            if (isNew)
            {
                insereOK = dadosNFes.Insere_NFe(seriesNFe, numberNFe, emissionDateNFe, valueNFe, providerID);

                Return_NFes = dadosNFes.GetNFes(seriesNFe, numberNFe, providerCNPJ);
                foreach (var returnNFe in Return_NFes)
                {
                    nfeId = returnNFe.NFeID;
                }
            }
            else if (!isNew)
            {
                insereOK = dadosNFes.EditaNFe(seriesNFe, numberNFe, emissionDateNFe, valueNFe, nfeId, providerID);
            }
            BTN_RegNFe.Enabled = false;
            isNew = false;

            DesabilitaCamposNFe();
            GB_Add_Itens_NFe.Enabled = true;
        }

        private void TXT_Nome_Produto_TextChanged(object sender, EventArgs e)
        {
            TXT_Nome_Produto.BackColor = Color.White;

            GB_Find_Product_By_Name.Visible = true;

            if (TXT_Nome_Produto.Text.ToString() != "")
            {
                productName = TXT_Nome_Produto.Text.ToString();
            }
            else
                productName = null;

            return_Produtos = produtos.GetProducts(0, productName, ProductIsActive._);
            if (return_Produtos.Count == 0)
            {
                return_Produtos = produtos.GetProducts(0, null, ProductIsActive._);
            }
            LB_List_Products_Name.DataSource = return_Produtos;
        }

        private void BTN_LimparNFe_Click(object sender, EventArgs e)
        {
            TXT_Serie_NFe.Text = "";
            TXT_Numero_NFe.Text = "";
            TXT_Valor.Text = "";
            TXT_CNPJ_Selected.Text = "";
        }

        private void BTN_NewProvider_Click(object sender, EventArgs e)
        {
            Page_Providers_Edit_And_Add providers_Edit_And_Add = new Page_Providers_Edit_And_Add(true, 0, userIdioma);
            providers_Edit_And_Add.ShowDialog();

            return_Providers = fornecedores.GetProviders(0, null, providerCNPJ);
            listCNPJ.DataSource = return_Providers;
        }

        private void BTN_New_Product_Click(object sender, EventArgs e)
        {
            PageProductAdd = new Page_Products_Edit_And_Add(true, 0);
            PageProductAdd.ShowDialog();

            GB_Find_Product_By_Name.Visible = false;
        }

        private void BTN_AddItensStock_Click_1(object sender, EventArgs e)
        {
            DialogResult? confirm = null;
            if (userIdioma == UserIdioma.Portugues)
            {
                confirm = MessageBox.Show("Apos gravar a NFe nao será possivel mais possivel edita-la, e os itens serão adicionados ao estoque," +
                   " Deseja Continuar?", "Registrar Nota", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            if (userIdioma == UserIdioma.Ingles)
            {
                confirm = MessageBox.Show("After recording the NFe it will not be possible to edit it anymore, and the items will be added to the stock, " +
                    "Do you want to Continue?", "Register NFe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            if (userIdioma == UserIdioma.Espanhol)
            {
                confirm = MessageBox.Show("Después de grabar la NFe no será posible editarla más, y los ítems serán agregados al stock, " +
                    "¿Desea Continuar?", "Registrar NFe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }

            if (confirm.ToString().ToUpper() == "YES")
            {
                ItensNFe = dados_Itens_NFe.GetNFeItens(nfeId);
                dadosStock.AdicionaItensStock(ItensNFe);
                dadosNFes.SetIncludedInStock(nfeId);
                BTN_AddItensStock.Enabled = false;
            }
        }

        private void TXT_CNPJ_Selected_TextChanged(object sender, EventArgs e)
        {
            TXT_CNPJ_Selected.BackColor = Color.White;
            providerCNPJ = TXT_CNPJ_Selected.Text;

            if (isNew)
            {

                GB_Busca_CNPJ_Forn.Visible = true;
                BTN_RegNFe.Enabled = false;
                return_Providers = fornecedores.GetProviders(0, null, providerCNPJ);
                listCNPJ.DataSource = return_Providers;

                foreach (var return_Providers in return_Providers)
                {
                    providerID = return_Providers.Id;
                }

                BTN_SelecionaForn.Enabled = true;
            }
            else if (!isNew)
            {
                if (textchange)
                {
                    GB_Busca_CNPJ_Forn.Visible = true;
                    BTN_RegNFe.Enabled = false;
                    return_Providers = fornecedores.GetProviders(0, null, providerCNPJ);
                    listCNPJ.DataSource = return_Providers;

                    foreach (var return_Providers in return_Providers)
                    {
                        providerID = return_Providers.Id;
                    }
                    BTN_SelecionaForn.Enabled = true;
                    textchange = false;
                }
                textchange = true;
            }
        }

        private void listCNPJ_DoubleClick(object sender, EventArgs e)
        {
            BTN_SelecionaForn.PerformClick();
        }
        private void LB_List_Products_Name_DoubleClick(object sender, EventArgs e)
        {
            BTN_SelecionarByName.PerformClick();
        }
    }
}
