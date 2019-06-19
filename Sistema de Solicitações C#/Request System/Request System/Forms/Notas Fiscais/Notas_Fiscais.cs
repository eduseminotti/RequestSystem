using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Request_System
{
    public partial class Notas_Fiscais_View : Form
    {
        String providerCNPJ = null;
        int serieNFe = 0;
        int numeroNFe = 0, nfeID, providerId;
        decimal valueNFe;
        bool inStock;
        DateTime emissionDateNFe;
        UserIdioma idioma;

        ManipulaNFes obter_NFes = new ManipulaNFes();
        Page_NFes_Add_And_Edit pageNFesAddAndEdit;
        List<ReturnNFes> Return_NFes;
        RelatorioNFe RelatorioNFe = new RelatorioNFe();
        List<ReturnRelatorioNFe> returnRelatorioNFe;
        GeradorDePDFGrid geradorDePDF = new GeradorDePDFGrid();

        public Notas_Fiscais_View(UserIdioma Idioma)
        {
            InitializeComponent();
            idioma = Idioma;
        }

        private void Notas_Fiscais_Load(object sender, EventArgs e)
        {
            Return_NFes = obter_NFes.GetNFes(0, 0, null);
            GRID_NFes_View.DataSource = Return_NFes;

        }

        private void BTN_Gerar_PDF_Click(object sender, EventArgs e)
        {

            BTN_Filter.PerformClick();
            GB_filters.Visible = false;
        }

        private void BTN_Edit_Click_1(object sender, EventArgs e)
        {

            if (ContLinhasGrid() < 1)
                return;
            

            numeroNFe = Convert.ToInt32(GRID_NFes_View.CurrentRow.Cells[0].Value.ToString());
            serieNFe = Convert.ToInt32(GRID_NFes_View.CurrentRow.Cells[1].Value.ToString());
            emissionDateNFe = Convert.ToDateTime(GRID_NFes_View.CurrentRow.Cells[2].Value.ToString());
            valueNFe = decimal.Parse(GRID_NFes_View.CurrentRow.Cells[3].Value.ToString());
            providerCNPJ = GRID_NFes_View.CurrentRow.Cells[5].Value.ToString();

            nfeID = Convert.ToInt32(GRID_NFes_View.CurrentRow.Cells[6].Value.ToString());
            providerId = Convert.ToInt32(GRID_NFes_View.CurrentRow.Cells[7].Value.ToString());
            inStock = Convert.ToBoolean(GRID_NFes_View.CurrentRow.Cells[8].Value.ToString());

            pageNFesAddAndEdit = new Page_NFes_Add_And_Edit(idioma);

            pageNFesAddAndEdit.RecebeEdicaoNFe(serieNFe, numeroNFe, valueNFe, providerCNPJ, nfeID, providerId, emissionDateNFe, inStock);

            pageNFesAddAndEdit.ShowDialog();

            Return_NFes = obter_NFes.GetNFes(0, 0, null);
            GRID_NFes_View.DataSource = Return_NFes;
        }

        public int ContLinhasGrid()
        {
            int linhasGrid;
            linhasGrid = GRID_NFes_View.Rows.Count;

            return linhasGrid;
        }
        private void BTN_New_NFe_Click_1(object sender, EventArgs e)
        {
            pageNFesAddAndEdit = new Page_NFes_Add_And_Edit(idioma);
            pageNFesAddAndEdit.RecebeNovaNFe();

            pageNFesAddAndEdit.ShowDialog();

            Return_NFes = obter_NFes.GetNFes(0, 0, null);
            GRID_NFes_View.DataSource = Return_NFes;
        }

        private void BTN_Gerar_PDF_Click_1(object sender, EventArgs e)
        {


            returnRelatorioNFe = RelatorioNFe.ReturnRelatorioNFe();
            Grid_RelatorioNFe.DataSource = returnRelatorioNFe;

            if (Grid_RelatorioNFe.Rows.Count > 0)
            {
                geradorDePDF.gerarPDF(Grid_RelatorioNFe, " NFes");
            }
            else
            {
                if (idioma == UserIdioma.Portugues)
                    MessageBox.Show("Nenhum Resultado encontrado!");
                if (idioma == UserIdioma.Ingles)
                    MessageBox.Show("No results found!");
                if (idioma == UserIdioma.Espanhol)
                    MessageBox.Show("Ningún resultado encontrado!");
            }


            GB_filters.Visible = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            GB_filters.Visible = true;
        }

        private void GRID_NFes_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_Edit.PerformClick();
        }

        private void GRID_NFes_View_KeyDown(object sender, KeyEventArgs e)
        {
            BTN_Edit.PerformClick();
        }

        private void TXT_Filter_Numero_NFe_Enter(object sender, EventArgs e)
        {
            TXT_Filter_Numero_NFe.BackColor = Color.Yellow;
        }

        private void TXT_Filter_Numero_NFe_Leave(object sender, EventArgs e)
        {
            TXT_Filter_Numero_NFe.BackColor = Color.White;
        }

        private void TXT_Filter_Serie_NFe_Enter(object sender, EventArgs e)
        {
            TXT_Filter_Serie_NFe.BackColor = Color.Yellow;
        }

        private void TXT_Filter_Serie_NFe_Leave(object sender, EventArgs e)
        {
            TXT_Filter_Serie_NFe.BackColor = Color.White;
        }

        private void TXT_Filter_CNPJ_Enter(object sender, EventArgs e)
        {
            TXT_Filter_CNPJ.BackColor = Color.Yellow;
        }

        private void TXT_Filter_CNPJ_Leave(object sender, EventArgs e)
        {
            TXT_Filter_CNPJ.BackColor = Color.White;
        }

        private void TXT_Filter_Numero_NFe_TextChanged(object sender, EventArgs e)
        {
            BTN_Filter.PerformClick();
        }

        private void TXT_Filter_Serie_NFe_TextChanged(object sender, EventArgs e)
        {
            BTN_Filter.PerformClick();
        }

        private void TXT_Filter_CNPJ_TextChanged(object sender, EventArgs e)
        {
            BTN_Filter.PerformClick();
        }

        private void BTN_Filter_Click_1(object sender, EventArgs e)
        {
            serieNFe = 0;
            providerCNPJ = null;
            numeroNFe = 0;

            if (TXT_Filter_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "").Replace(",","") != "")
                providerCNPJ = TXT_Filter_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "").Replace(",", "");
            if (TXT_Filter_Serie_NFe.Text != "")
                serieNFe = Convert.ToInt32(TXT_Filter_Serie_NFe.Text);
            if (TXT_Filter_Numero_NFe.Text != "")
                numeroNFe = Convert.ToInt32(TXT_Filter_Numero_NFe.Text);

            Return_NFes = obter_NFes.GetNFes(serieNFe, numeroNFe, providerCNPJ);
            GRID_NFes_View.DataSource = Return_NFes;
        }

        private void BTN_Filter_limpar_Click_1(object sender, EventArgs e)
        {
            TXT_Filter_CNPJ.Text = "";
            TXT_Filter_Serie_NFe.Text = "";
            TXT_Filter_Numero_NFe.Text = "";

            Return_NFes = obter_NFes.GetNFes(0, 0, null);
            GRID_NFes_View.DataSource = Return_NFes;
        }

    }
}
