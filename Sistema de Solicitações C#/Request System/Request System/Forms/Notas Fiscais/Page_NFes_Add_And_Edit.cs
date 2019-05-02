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
        UserIdioma idioma;

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

        public Page_NFes_Add_And_Edit(UserIdioma Idioma)
        {
            InitializeComponent();
            BTN_SelecionaForn.Enabled = false;
            listCNPJ.MouseDoubleClick += new MouseEventHandler(listCNPJ_DoubleClick);
            LB_List_Products_Name.MouseDoubleClick += new MouseEventHandler(LB_List_Products_Name_DoubleClick);
            idioma = Idioma;

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

            if (idioma == UserIdioma.Portugues)
                BTN_RegNFe.Text = "Salvar Alterações";
            if (idioma == UserIdioma.Ingles)
                BTN_RegNFe.Text = "Save Changes";
            if (idioma == UserIdioma.Espanhol)
                BTN_RegNFe.Text = "Guardar Cambios";

            if (inStock)
            {
                BTN_AddItensStock.Enabled = false;
                BTN_AddProduct.Enabled = false;
                BTN_RegNFe.Enabled = false;
                BTN_RemoveItem.Enabled = false;
                GB_Add_Itens_NFe.Enabled = false;

                DesabilitaCamposNFe();
            }
            ContLinhasGrid();
        }
        public void RecebeNovaNFe()
        {
            isNew = true;
            BTN_AddItensStock.Enabled = false;
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
        }

        private void BTN_SelecionaForn_Click(object sender, EventArgs e)
        {
            providerCNPJ = listCNPJ.Text.ToString();

            TXT_CNPJ_Selected.Text = providerCNPJ.Split('-')[0];
            GB_Busca_CNPJ_Forn.Visible = false;
            BTN_SelecionaForn.Enabled = false;
            BTN_RegNFe.Enabled = true;
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

        private void TXT_Valor_TextChanged(object sender, EventArgs e)
        {
            TXT_Valor.BackColor = Color.White;
            if (!float.TryParse(TXT_Valor.Text, out float v2))
            {
                TXT_Valor.BackColor = Color.OrangeRed;
                return;
            }
        }
        private void BTN_RegNFe_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(TXT_Numero_NFe.Text, out int valor))
            {
                TXT_Numero_NFe.BackColor = Color.OrangeRed;
                TXT_Numero_NFe.Focus();
                return;
            }
            if (!Int32.TryParse(TXT_Serie_NFe.Text, out valor))
            {
                TXT_Serie_NFe.BackColor = Color.OrangeRed;
                TXT_Serie_NFe.Focus();
                return;
            }
            if (!float.TryParse(TXT_Valor.Text, out float v2))
            {
                TXT_Valor.BackColor = Color.OrangeRed;
                TXT_Valor.Focus();
                return;
            }
            if (TXT_CNPJ_Selected.Text == "")
            {
                TXT_CNPJ_Selected.BackColor = Color.OrangeRed;
                TXT_CNPJ_Selected.Focus();
                return;
            }

            numberNFe = Convert.ToInt32(TXT_Numero_NFe.Text.ToString());
            seriesNFe = Convert.ToInt32(TXT_Serie_NFe.Text.ToString());

            valueNFe = decimal.Parse(TXT_Valor.Text.ToString());
            emissionDateNFe = Convert.ToDateTime(DT_Data_Emissão.Text);
            providerCNPJ = TXT_CNPJ_Selected.Text.ToString();

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
            Page_Providers_Edit_And_Add providers_Edit_And_Add = new Page_Providers_Edit_And_Add(true, 0);
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
            if (idioma == UserIdioma.Portugues)
            {
                confirm = MessageBox.Show("Apos gravar a NFe nao será possivel mais possivel edita-la, e os itens serão adicionados ao estoque," +
                   " Deseja Continuar?", "Registrar Nota", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            if (idioma == UserIdioma.Ingles)
            {
                confirm = MessageBox.Show("After recording the NFe it will not be possible to edit it anymore, and the items will be added to the stock, " +
                    "Do you want to Continue?", "Register NFe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            if (idioma == UserIdioma.Espanhol)
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
                while (textchange)
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

        private void Sair_Da_Tela_Key_down(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                if (GB_Busca_CNPJ_Forn.Visible == true)
                {
                    BTN_SelecionaForn.PerformClick();
                    return;
                }

                if (GB_Find_Product_By_Name.Visible == true)
                {
                    BTN_SelecionarByName.PerformClick();
                    return;
                }
            }
            if (e.KeyValue.Equals(9) && GB_Find_Product_By_Name.Visible == true)
            {
                LB_List_Products_Name.Focus();
                return;
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
