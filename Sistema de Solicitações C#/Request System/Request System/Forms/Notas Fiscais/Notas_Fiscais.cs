using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void TXT_Filter_Numero_TextChanged(object sender, EventArgs e)
        {
            TXT_Filter_Serie_NFe.BackColor = Color.White;

            int valor;
            if (Int32.TryParse(TXT_Filter_Numero_NFe.Text, out valor) || TXT_Filter_Numero_NFe.Text == "")
            {
                BTN_Filter.PerformClick();
            }
            else
            {
                TXT_Filter_Numero_NFe.BackColor = Color.OrangeRed;
                MessageBox.Show("0,1,2,3...");
                TXT_Filter_Numero_NFe.Text = "";
            }  
        }
        private void TXT_Filter_Serie_NFe_TextChanged(object sender, EventArgs e)
        {
            TXT_Filter_Serie_NFe.BackColor = Color.White;
            int valor;
            if (Int32.TryParse(TXT_Filter_Serie_NFe.Text, out valor)|| TXT_Filter_Serie_NFe.Text == "")
            {
                BTN_Filter.PerformClick();
            }
            else
            {
                TXT_Filter_Serie_NFe.BackColor = Color.OrangeRed;
                MessageBox.Show("0,1,2,3...");
                TXT_Filter_Serie_NFe.Text = "";
            }
        }
        private void TXT_Filter_CNPJ_TextChanged(object sender, EventArgs e)
        {
            TXT_Filter_Serie_NFe.BackColor = Color.White;
            int valor;
            if (Int32.TryParse(TXT_Filter_CNPJ.Text, out valor)|| TXT_Filter_CNPJ.Text == "")
            {
                BTN_Filter.PerformClick();
            }
            else
            {
                TXT_Filter_CNPJ.BackColor = Color.OrangeRed;
                MessageBox.Show("0,1,2,3...");
                TXT_Filter_CNPJ.Text = "";
            }
        }

        private void BTN_Gerar_PDF_Click(object sender, EventArgs e)
        {
            geradorDePDF.gerarPDF(GRID_NFes_View, "Notas Fiscais");
        }

        private void BTN_Edit_Click_1(object sender, EventArgs e)
        {
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

        private void BTN_New_NFe_Click_1(object sender, EventArgs e)
        {
            pageNFesAddAndEdit = new Page_NFes_Add_And_Edit(idioma);
            pageNFesAddAndEdit.RecebeNovaNFe();

            pageNFesAddAndEdit.ShowDialog();

            Return_NFes = obter_NFes.GetNFes(0, 0, null);
            GRID_NFes_View.DataSource = Return_NFes;
        }

 

        private void BTN_Filter_Click_1(object sender, EventArgs e)
        {
            serieNFe = 0;
            providerCNPJ = null;
            numeroNFe = 0;

            if (TXT_Filter_CNPJ.Text != "")
                providerCNPJ = TXT_Filter_CNPJ.Text;
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
