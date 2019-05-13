using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Request_System
{
    public partial class Page_Providers_Edit_And_Add : Form
    {
        String razaoSocial, cnpj, nomeFantasia, phone;
        bool sucess, isnew;
        int selectProviderID;

        ManipulaFornecedores Dados_Fornecedores = new ManipulaFornecedores();
        List<ReturnProviders> providers;

        private void Page_Providers_Edit_And_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Tab)
            {
                TXT_Phone.BackColor = Color.White;
                TXT_CNPJ.BackColor = Color.White;
            }
        }

        private void TXT_Razao_social_TextChanged(object sender, EventArgs e)
        {
            TXT_Razao_social.BackColor = Color.White;
        }

        private void TXT_Nome_Fantasia_TextChanged(object sender, EventArgs e)
        {
            TXT_Nome_Fantasia.BackColor = Color.White;
        }

        public Page_Providers_Edit_And_Add(bool IsNew, int SelectProviderID)
        {
            InitializeComponent();
            isnew = IsNew;
            selectProviderID = SelectProviderID;

            if (!IsNew)
            {
                TXT_CNPJ.Enabled = false;
                providers = Dados_Fornecedores.GetProviders(selectProviderID, null, null);
                foreach (var providers in providers)
                {
                    TXT_Codigo.Text = providers.Id.ToString();
                    TXT_Razao_social.Text = providers.Razao_Social.ToString();
                    TXT_Nome_Fantasia.Text = providers.Nome_Fantasia.ToString();
                    TXT_CNPJ.Text = providers.CNPJ.ToString();
                    TXT_Phone.Text = providers.Phone.ToString();
                }
            }
        }

        private void BTN_Cancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Salvar1_Click(object sender, EventArgs e)
        {
            cnpj = TXT_CNPJ.Text.ToString().Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            phone = TXT_Phone.Text.ToString().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            bool returns = false;
            if (TXT_Razao_social.Text == "")
            {
                TXT_Razao_social.BackColor = Color.OrangeRed;
                returns = true;
            }
            if (TXT_Nome_Fantasia.Text == "")
            {
                TXT_Nome_Fantasia.BackColor = Color.OrangeRed;
                returns = true;
            }
            if (cnpj == "")
            {
                TXT_CNPJ.BackColor = Color.OrangeRed;
                returns = true;
            }
            if (phone == "")
            {
                TXT_Phone.BackColor = Color.OrangeRed;
                returns = true;
            }
            if (returns)
                return;

            phone = TXT_Phone.Text.ToString();
            razaoSocial = TXT_Razao_social.Text.ToString();
            nomeFantasia = TXT_Nome_Fantasia.Text.ToString();

            if (isnew)
            {
                sucess = Dados_Fornecedores.New_Provider(razaoSocial, nomeFantasia, cnpj, phone);

                if (sucess)
                    this.Close();
                else
                    return;
            }
            if (!isnew)
            {
                sucess = Dados_Fornecedores.Edit_Provider(selectProviderID, razaoSocial, nomeFantasia, cnpj, phone);
                if (sucess)
                    this.Close();
                else
                    return;
            }
        }
    }
}
