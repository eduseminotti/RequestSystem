

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

        public Providers_View()
        {
            InitializeComponent();
        }
        private void Providers_Load(object sender, EventArgs e)
        {
            Providers = obterProviders.GetProviders(0, null, null);
            GRID_View_Providers.DataSource = Providers;
        }

        private void TXT_Filter_Codigo_TextChanged(object sender, EventArgs e)
        {
            TXT_Filter_Codigo.BackColor = Color.White;
            int valor;


            if (Int32.TryParse(TXT_Filter_Codigo.Text, out valor)|| TXT_Filter_Codigo.Text == "")
            {
                BTN_Filter1.PerformClick();
            }
            else
            {
                TXT_Filter_Codigo.BackColor = Color.OrangeRed;
                MessageBox.Show("0,1,2,3...");
            }

        }

        private void TXT_Filter_Nome_fantasia_TextChanged(object sender, EventArgs e)
        {
            BTN_Filter1.PerformClick();
        }

        private void TXT_Filter_CNPJ_TextChanged(object sender, EventArgs e)
        {
            TXT_Filter_CNPJ.BackColor = Color.White;
            int valor;
            if (TXT_Filter_CNPJ.Text != "")
            {
                if (Int32.TryParse(TXT_Filter_CNPJ.Text, out valor) || TXT_Filter_CNPJ.Text == "")
                {
                    BTN_Filter1.PerformClick();
                }
                else
                {
                    TXT_Filter_CNPJ.BackColor = Color.OrangeRed;
                    MessageBox.Show("0,1,2,3...");
                }
            }
        }

        private void BTN_Filter1_Click(object sender, EventArgs e)
        {
            String nomeFantasia = null, cnpj = null;
            int id = 0;            
            if (TXT_Filter_CNPJ.Text.ToString() != "")
                cnpj = TXT_Filter_CNPJ.Text.ToString();
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
            selectProviderID = Convert.ToInt32(GRID_View_Providers.CurrentRow.Cells[0].Value.ToString());

            Page_Providers_Edit_And_Add page_Providers_Edit_And_Add = new Page_Providers_Edit_And_Add(false, selectProviderID);
            page_Providers_Edit_And_Add.ShowDialog();

            Providers = obterProviders.GetProviders(0, null, null);
            GRID_View_Providers.DataSource = Providers;
        }

        private void BTN_NewProvider_Click(object sender, EventArgs e)
        {
            Page_Providers_Edit_And_Add page_Providers_Edit_And_Add = new Page_Providers_Edit_And_Add(true, 0);
            page_Providers_Edit_And_Add.ShowDialog();

            Providers = obterProviders.GetProviders(0, null, null);
            GRID_View_Providers.DataSource = Providers;
        }

        private void BTN_Gerar_PDF_Click(object sender, EventArgs e)
        {
            GeradorDePDF.gerarPDF(GRID_View_Providers, "Fornecedores");
        }
    }
}
