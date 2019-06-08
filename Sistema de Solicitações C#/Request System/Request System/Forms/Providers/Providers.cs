

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Request_System

{
    public partial class Providers_View : Form
    {
        List<ReturnProviders> Providers;
        ManipulaFornecedores obterProviders = new ManipulaFornecedores();
        GeradorDePDFGrid GeradorDePDF = new GeradorDePDFGrid();

        int selectProviderID;
        UserIdioma userIdioma;

        public Providers_View(UserIdioma UserIdioma)
        {
            InitializeComponent();
            userIdioma = UserIdioma;
        }
        private void Providers_Load(object sender, EventArgs e)
        {
            Providers = obterProviders.GetProviders(0, null, null);
            GRID_View_Providers.DataSource = Providers;
        }

        private void TXT_Filter_Nome_fantasia_TextChanged(object sender, EventArgs e)
        {
            BTN_Filter1.PerformClick();
        }

        private void BTN_Filter1_Click(object sender, EventArgs e)
        {
            String nomeFantasia = null;
              int id = 0;
            String cnpj = TXT_Filter_CNPJ.Text.ToString().Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "").Replace(" ", "");

            if (cnpj == "")
                cnpj = null;
            if (TXT_Filter_Codigo.Text.ToString() != "")
                id = Convert.ToInt32(TXT_Filter_Codigo.Text.ToString());
            if (TXT_Filter_Nome_fantasia.Text.ToString() != "")
                nomeFantasia = TXT_Filter_Nome_fantasia.Text.ToString();

            Providers = obterProviders.GetProviders(id, nomeFantasia, cnpj);
            GRID_View_Providers.DataSource = Providers;
        }

        private void BTN_FilterLimpar_Click(object sender, EventArgs e)
        {
            TXT_Filter_CNPJ.Text = "";
            TXT_Filter_CNPJ.BackColor = Color.White;
            TXT_Filter_Codigo.Text = "";
            TXT_Filter_Codigo.BackColor = Color.White;
            TXT_Filter_Nome_fantasia.Text = "";
            TXT_Filter_Nome_fantasia.BackColor = Color.White;

            Providers = obterProviders.GetProviders(0, null, null);
            GRID_View_Providers.DataSource = Providers;
        }

        private void BTN_Edit1_Click(object sender, EventArgs e)
        {
            if (ContLinhasGrid() < 1)
                return;

            selectProviderID = Convert.ToInt32(GRID_View_Providers.CurrentRow.Cells[0].Value.ToString());

            Page_Providers_Edit_And_Add page_Providers_Edit_And_Add = new Page_Providers_Edit_And_Add(false, selectProviderID, userIdioma);
            page_Providers_Edit_And_Add.ShowDialog();

            Providers = obterProviders.GetProviders(0, null, null);
            GRID_View_Providers.DataSource = Providers;
        }
        public int ContLinhasGrid()
        {
            int linhasGrid;
            linhasGrid = GRID_View_Providers.Rows.Count;

            return linhasGrid;
        }
        private void BTN_NewProvider_Click(object sender, EventArgs e)
        {
            Page_Providers_Edit_And_Add page_Providers_Edit_And_Add = new Page_Providers_Edit_And_Add(true, 0, userIdioma);
            page_Providers_Edit_And_Add.ShowDialog();

            Providers = obterProviders.GetProviders(0, null, null);
            GRID_View_Providers.DataSource = Providers;
        }

        private void BTN_Gerar_PDF_Click(object sender, EventArgs e)
        {
            GeradorDePDF.gerarPDF(GRID_View_Providers, "Fornecedores");
        }

        private void GRID_View_Providers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_Edit1.PerformClick();
        }

        private void TXT_Filter_CNPJ_TextChanged_1(object sender, EventArgs e)
        {
            BTN_Filter1.PerformClick();
        }

        private void TXT_Filter_Nome_fantasia_Enter(object sender, EventArgs e)
        {
            TXT_Filter_Nome_fantasia.BackColor = Color.Yellow;
        }

        private void TXT_Filter_Nome_fantasia_Leave(object sender, EventArgs e)
        {
            TXT_Filter_Nome_fantasia.BackColor = Color.White;
        }

        private void TXT_Filter_CNPJ_Enter(object sender, EventArgs e)
        {
            TXT_Filter_CNPJ.BackColor = Color.Yellow;
        }

        private void TXT_Filter_CNPJ_Leave(object sender, EventArgs e)
        {
            TXT_Filter_CNPJ.BackColor = Color.White;
        }

        private void TXT_Filter_Codigo_TextChanged_1(object sender, EventArgs e)
        {
            BTN_Filter1.PerformClick();
        }

        private void TXT_Filter_Codigo_Enter_1(object sender, EventArgs e)
        {
            TXT_Filter_Codigo.BackColor = Color.Yellow;
        }

        private void TXT_Filter_Codigo_Leave_1(object sender, EventArgs e)
        {
            TXT_Filter_Codigo.BackColor = Color.White;
        }

        private void GRID_View_Providers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BTN_Edit1.PerformClick();
        }
    }
}
