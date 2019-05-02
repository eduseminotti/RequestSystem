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
    public partial class Page_Products_Edit_And_Add : Form
    {
        bool isNew, success;
        String nomeProduto, tipoUnidade;
        long selectProductID;
        ProductIsActive productIsActive;

        List<ReturnProdutos> produtos;
        ManipulaProdutos Dados_Produtos = new ManipulaProdutos();
        ManipulaStock dadosStock = new ManipulaStock();


        private void BTN_Product_Salvar_Click_1(object sender, EventArgs e)
        {
            nomeProduto = TXT_Nome_Produto.Text.ToString();
            tipoUnidade = TXT_Tipo_Unidade.Text.ToString();
            productIsActive = (ProductIsActive)Enum.Parse(typeof(ProductIsActive), CBX_Status_Produto.Text.ToString());

            if (nomeProduto == "" || tipoUnidade == "" || productIsActive == ProductIsActive._)
            {
                if (nomeProduto == "")
                    TXT_Nome_Produto.BackColor = Color.OrangeRed;

                if (tipoUnidade == "")
                    TXT_Tipo_Unidade.BackColor = Color.OrangeRed;

                if (productIsActive == ProductIsActive._)
                    txt_validacombo.Visible = true;

                return;
            }

            if (isNew)
            {
                success = Dados_Produtos.New_Product(nomeProduto, tipoUnidade, productIsActive);
                this.Close();
            }
            if (!isNew)
            {
                success = Dados_Produtos.Edit_Produto(selectProductID, nomeProduto, tipoUnidade, productIsActive);
                if (success)
                    this.Close();
                else if (!success)
                    return;
            }
        }

        private void CBX_Status_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_validacombo.Visible = false;
        }

        private void TXT_Tipo_Unidade_TextChanged(object sender, EventArgs e)
        {
            TXT_Tipo_Unidade.BackColor = Color.White;
        }

        private void TXT_Nome_Produto_TextChanged(object sender, EventArgs e)
        {
            TXT_Nome_Produto.BackColor = Color.White;
        }

        private void BTN_Product_Cancel_Click_1(object sender, EventArgs e)
        {
            TXT_Product_Codigo.Text = "";
            TXT_Nome_Produto.Text = "";
            TXT_Tipo_Unidade.Text = "";
            this.Close();
        }

        public Page_Products_Edit_And_Add(bool IsNew, long SelectProductID)
        {
            InitializeComponent();
            isNew = IsNew;
            selectProductID = SelectProductID;

            CBX_Status_Produto.DataSource = Enum.GetValues(typeof(ProductIsActive));

            txt_validacombo.Visible = false;

            if (!isNew)
            {
                produtos = Dados_Produtos.GetProducts(selectProductID, null, 0);
                foreach (var produtos in produtos)
                {
                    TXT_Product_Codigo.Text = produtos.Product_Id.ToString();
                    TXT_Nome_Produto.Text = produtos.Product_Name.ToString();
                    TXT_Tipo_Unidade.Text = produtos.Product_Unidade.ToString();
                    CBX_Status_Produto.Text = produtos.product_IsActive.ToString();
                }
            }
        }
    }
}
