using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Request_System
{
    public partial class Page_NFes_Add_And_Edit : Form
    {
        String providerCNPJ, productName, productTPUnidade;
        double valueNFe;
        long providerID, numberNFe, nfeId, productId;
        int seriesNFe, qtdItens;
        DateTime emissionDateNFe = DateTime.Now;
        bool insereOK, isNew, textchange;
        ProductIsActive productStatus = ProductIsActive.Ativo;

        Page_Products_Edit_And_Add PageProductAdd;
        Dados_Fornecedores fornecedores = new Dados_Fornecedores();
        Dados_Produtos produtos = new Dados_Produtos();
        Dados_NFes dados_NFes = new Dados_NFes();
        Dados_Itens_NFe dados_Itens_NFe = new Dados_Itens_NFe();
        List<Return_Providers> return_Providers;
        List<Return_NFes> Return_NFes;
        List<Return_NFe_itens> ItensNFe;
        List<Return_Produtos> return_Produtos;

        public Page_NFes_Add_And_Edit()
        {
            InitializeComponent();
            BTN_Seleciona_Forn.Enabled = false;
            if(!isNew)
            {
                GB_Add_Itens_NFe.Enabled = true;
                BTN_Reg_NFe.Text = "Salvar Alterações";
            }
        }
        public void RecebeEdicaoNFe(int SerieNFe, long NumeroNFe, double ValorNFe, String CNPJ, long NFeID, long ProviderId, DateTime DataEmissao)
        {
            isNew = false;
            nfeId = NFeID;
            providerID = ProviderId;
            providerCNPJ = CNPJ;
            valueNFe = ValorNFe;
            providerID = ProviderId;
            numberNFe = NumeroNFe;
            nfeId = NFeID;
            seriesNFe = SerieNFe;
            emissionDateNFe = DataEmissao;

            BTN_Reg_NFe.Enabled = true;

            TXT_Numero_NFe.Text = numberNFe.ToString();
            TXT_Serie_NFe.Text = seriesNFe.ToString();
            TXT_Valor.Text = valueNFe.ToString();
            DT_Data_Emissão.Value = emissionDateNFe;
            TXT_CNPJ_Selected.Text = providerCNPJ.ToString();

            ItensNFe = dados_Itens_NFe.GetNFeItens(nfeId);
            GRID_Itens_NFe.DataSource = ItensNFe;

        }
        public void RecebeNovaNFe()
        {
            isNew = true;
        }
        private void BTN_New_Provider_Click(object sender, EventArgs e)
        {
            Page_Providers_Edit_And_Add providers_Edit_And_Add = new Page_Providers_Edit_And_Add(true, 0);
            providers_Edit_And_Add.ShowDialog();

            return_Providers = fornecedores.GetProviders(0, null, providerCNPJ);
            listCNPJ.DataSource = return_Providers;
        }
        private void BTN_Salvar_Click(object sender, EventArgs e)// registra nova NFe
        {
            numberNFe = Convert.ToInt64(TXT_Numero_NFe.Text.ToString());
            seriesNFe = Convert.ToInt32(TXT_Serie_NFe.Text.ToString());
            valueNFe = double.Parse(TXT_Valor.Text.ToString());
            emissionDateNFe = Convert.ToDateTime(DT_Data_Emissão.Text);
            providerCNPJ = TXT_CNPJ_Selected.Text.ToString();

            if (isNew)
            {
                insereOK = dados_NFes.Insere_NFe(seriesNFe, numberNFe, emissionDateNFe, valueNFe, providerID);

                Return_NFes = dados_NFes.GetNFes(seriesNFe, numberNFe, providerCNPJ);
                foreach (var returnNFe in Return_NFes)
                {
                    nfeId = returnNFe.NFeID;
                }
            }
            else if (!isNew)
            {
                insereOK = dados_NFes.EditaNFe(seriesNFe, numberNFe, emissionDateNFe, valueNFe, nfeId, providerID);
            }
            BTN_Reg_NFe.Enabled = false;
            isNew = false;
            GB_Add_Itens_NFe.Enabled = true;
        }
        private void BTN_Find_product_By_Code_Click(object sender, EventArgs e)
        {
            if (TXT_Codigo_product.Text.ToString() != "")
            {
                GB_Find_Product_ById.Visible = true;
                
                productId = Convert.ToInt64(TXT_Codigo_product.Text.ToString());

                return_Produtos = produtos.GetProducts(productId, null, productStatus);

                LB_List_Products_ID.DataSource = return_Produtos;
            }
        }        
        private void BTN_Find_Product_By_Name_Click(object sender, EventArgs e)
        {
            GB_Find_Product_By_Name.Visible = true;

            if (TXT_Nome_Produto.Text.ToString() != "")
            {
                productName = TXT_Nome_Produto.Text.ToString();

                return_Produtos = produtos.GetProducts(0, productName, productStatus);
                LB_List_Products_Name.DataSource = return_Produtos;
            }
        }
        private void BTN_Add_Itens_Stock_Click(object sender, EventArgs e)
        {

        }
        private void GRID_Itens_NFe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_Selecionar_ById_Click(object sender, EventArgs e)
        {
            productId = Convert.ToInt64(LB_List_Products_ID.Text.ToString());

            return_Produtos = produtos.GetProducts(productId, null, productStatus);
            foreach (var return_Produtos in return_Produtos)
            {
                productId = return_Produtos.Product_Id;
                productName = return_Produtos.Product_Name;
                productTPUnidade = return_Produtos.Product_Unidade;
            }
            
            TXT_Codigo_product.Text = productId.ToString();
            TXT_Nome_Produto.Text = productName.ToString();
            TXT_TP_Unidade.Text = productTPUnidade.ToString();

            GB_Find_Product_ById.Visible = false;
        }
        private void BTN_Selecionar_ByName_Click(object sender, EventArgs e)
        {
            productName = LB_List_Products_Name.Text.ToString();

            return_Produtos = produtos.GetProducts(0, productName, productStatus);
            foreach (var return_Produtos in return_Produtos)
            {
                productId = return_Produtos.Product_Id;
                productName = return_Produtos.Product_Name;
                productTPUnidade = return_Produtos.Product_Unidade;
            }

            TXT_Codigo_product.Text = productId.ToString();
            TXT_Nome_Produto.Text = productName.ToString();
            TXT_TP_Unidade.Text = productTPUnidade.ToString();
            GB_Find_Product_By_Name.Visible = false;
        }
        private void BTN_New_Product_Click_1(object sender, EventArgs e)
        {
            PageProductAdd = new Page_Products_Edit_And_Add(true, 0);
            PageProductAdd.ShowDialog();
        }
        private void BTN_Add_Product_Click(object sender, EventArgs e)
        {
            qtdItens = Convert.ToInt32(TXT_QTD_Produto.Text.ToString());
            productId = Convert.ToInt64(TXT_Codigo_product.Text.ToString());

            dados_Itens_NFe.New_NFe_Item(qtdItens, productId, nfeId);

            ItensNFe = dados_Itens_NFe.GetNFeItens(nfeId);
            GRID_Itens_NFe.DataSource = ItensNFe;
            BTN_Add_Itens_Stock.Enabled = true;
        }
        private void TXT_CNPJ_Selected_TextChanged(object sender, EventArgs e)
        {
            providerCNPJ = TXT_CNPJ_Selected.Text;
            if (isNew)
            {
                GB_Busca_CNPJ_Forn.Visible = true;
                BTN_Reg_NFe.Enabled = false;

                return_Providers = fornecedores.GetProviders(0, null, providerCNPJ);
                listCNPJ.DataSource = return_Providers;

                foreach (var return_Providers in return_Providers)
                {
                    providerID = return_Providers.Id;
                }

                BTN_Seleciona_Forn.Enabled = true;
            }
            else if (!isNew)
            {
                while (textchange)
                {
                    GB_Busca_CNPJ_Forn.Visible = true;
                    BTN_Reg_NFe.Enabled = false;
                    return_Providers = fornecedores.GetProviders(0, null, providerCNPJ);
                    listCNPJ.DataSource = return_Providers;

                    foreach (var return_Providers in return_Providers)
                    {
                        providerID = return_Providers.Id;
                    }
                    BTN_Seleciona_Forn.Enabled = true;
                    textchange = false;
                }
                textchange = true;
            }
        }
        private void BTN_Seleciona_Forn_Click(object sender, EventArgs e)
        {
            providerCNPJ = listCNPJ.Text.ToString();
            TXT_CNPJ_Selected.Text = providerCNPJ;
            GB_Busca_CNPJ_Forn.Visible = false;
            BTN_Seleciona_Forn.Enabled = false;
            BTN_Reg_NFe.Enabled = true;
        }
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            TXT_Numero_NFe.Text = "";
            TXT_Serie_NFe.Text = "";
            TXT_Valor.Text = "";
            DT_Data_Emissão.Text = "";
            TXT_CNPJ_Selected.Text = "";
        }
        private void Sair_Da_Tela_Key_down(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
            if (e.KeyValue.Equals(13))
            {
                if (BTN_Seleciona_Forn.Enabled == true)
                {
                    BTN_Seleciona_Forn.PerformClick();
                }
                else
                {
                    BTN_Reg_NFe.PerformClick();
                }
            }
        }
    }
}
