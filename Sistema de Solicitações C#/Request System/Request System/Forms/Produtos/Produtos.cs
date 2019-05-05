using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Request_System
{
    public partial class produtos_view : Form
    {

        List<ReturnProdutos> produtos;
        ManipulaProdutos obterProdutos = new ManipulaProdutos();
        GeradorDePDFGrid GeraPDF = new GeradorDePDFGrid();
        UserIdioma userIdioma;

        long selectProductID;

        ProductIsActive productStatus;

        public produtos_view(UserIdioma UserIdioma)
        {
            InitializeComponent();

            userIdioma = UserIdioma;
            CBX_Filter_Status.DataSource = Enum.GetValues(typeof(ProductIsActive));
        }
        private void Produtos_Load(object sender, EventArgs e)
        {
            produtos = obterProdutos.GetProducts(0, null, 0);
            Grid_View_produtos.DataSource = produtos;
            Grid_Produtos_PDF.DataSource = produtos;
        }
        private void TXT_Filter_Codigo_TextChanged(object sender, EventArgs e)
        {
            int valor;
            if (Int32.TryParse(TXT_Filter_Codigo.Text, out valor) || TXT_Filter_Codigo.Text == "")
            {
                BTN_Filter.PerformClick();
            }
            else
            {
                TXT_Filter_Codigo.BackColor = Color.OrangeRed;
                if (userIdioma == UserIdioma.Portugues)
                    MessageBox.Show("Apenas numeros");
                if (userIdioma == UserIdioma.Ingles)
                    MessageBox.Show("Only numbers");
                if (userIdioma == UserIdioma.Espanhol)
                    MessageBox.Show("Sólo números");
            }
        }
        private void TXT_Filter_Nome_TextChanged(object sender, EventArgs e)
        {
            BTN_Filter.PerformClick();
        }
        private void BTN_Gerar_PDF_Click(object sender, EventArgs e)
        {
            GeraPDF.gerarPDF(Grid_Produtos_PDF, "produtos");
        }
        private void CBX_Filter_Status_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BTN_Filter.PerformClick();
        }
        private void BTN_Filter_Click_1(object sender, EventArgs e)
        {
            String filterName = null;
            int filterID = 0;

            if (TXT_Filter_Nome.Text.ToString() != "")
                filterName = TXT_Filter_Nome.Text.ToString();

            if (TXT_Filter_Codigo.Text != "")
                filterID = Convert.ToInt32(TXT_Filter_Codigo.Text);

            productStatus = (ProductIsActive)Enum.Parse(typeof(ProductIsActive), CBX_Filter_Status.Text.ToString());

            produtos = obterProdutos.GetProducts(filterID, filterName, productStatus);
            Grid_View_produtos.DataSource = produtos;
            Grid_Produtos_PDF.DataSource = produtos;
        }
        private void BTN_New_Product_Click_1(object sender, EventArgs e)
        {
            Page_Products_Edit_And_Add PageProductAdd = new Page_Products_Edit_And_Add(true, 0);
            PageProductAdd.ShowDialog();

            produtos = obterProdutos.GetProducts(0, null, 0);
            Grid_View_produtos.DataSource = produtos;
            Grid_Produtos_PDF.DataSource = produtos;
        }
        private void BTN_Edit_Click_1(object sender, EventArgs e)
        {
            selectProductID = Convert.ToInt64(Grid_View_produtos.CurrentRow.Cells[0].Value.ToString());
            Page_Products_Edit_And_Add PageProductAdd = new Page_Products_Edit_And_Add(false, selectProductID);
            PageProductAdd.ShowDialog();

            produtos = obterProdutos.GetProducts(0, null, 0);
            Grid_View_produtos.DataSource = produtos;
            Grid_Produtos_PDF.DataSource = produtos;
        }
        private void BTN_Filter_limpar_Click_1(object sender, EventArgs e)
        {
            TXT_Filter_Codigo.Text = "";
            TXT_Filter_Nome.Text = "";
            CBX_Filter_Status.DataSource = Enum.GetValues(typeof(ProductIsActive));

            produtos = obterProdutos.GetProducts(0, null, 0);
            Grid_View_produtos.DataSource = produtos;
            Grid_Produtos_PDF.DataSource = produtos;
        }
    }
}
