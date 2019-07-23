
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Request_System
{
    public partial class ConfigGerais : Form
    {
        String folderPath;
        String conectioString, conectioStringMaster;
        String provider;

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        CriaBanco criaBanco = new CriaBanco();

        public ConfigGerais()
        {
            InitializeComponent();
        }

        private void BTN_ConfigFileLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivo|*.txt";
            saveFileDialog1.Title = "Selecione o local para salvar";
            saveFileDialog1.FileName = "LOG.TXT";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                fs.Close();
            }

            folderPath = Convert.ToString(saveFileDialog1.FileName);

            TXT_folderPath.Text = folderPath;
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            bool returns = false;
            if (TXT_folderPath.Text == "")
            {
                TXT_folderPath.BackColor = Color.OrangeRed;
                returns = true;
            }
            if (TXT_Server.Text == "")
            {
                TXT_Server.BackColor = Color.OrangeRed;
                returns = true;
            }
            if (TXT_NomeBanco.Text == "")
            {
                TXT_NomeBanco.BackColor = Color.OrangeRed;
                returns = true;
            }
            if (TXT_User.Text == "")
            {
                TXT_User.BackColor = Color.OrangeRed;
                returns = true;
            }
            if (TXT_Pass.Text == "")
            {
                TXT_Pass.BackColor = Color.OrangeRed;
                returns = true;
            }
            if (returns)
                return;

            //ajsuta CS app
            AjustaCSConfig();

            ConfigurationManager.RefreshSection("connectionStrings");

            //Configuração Inicial
            AjustaConfigTrue();

            //LOG
            AjustaConfigLog();

            ConfigurationManager.RefreshSection("appSettings");


            //criar Banco de dados
            if(CHB_CriaBanco.Checked)
            {
                criaBanco.CriaBancoDeDados(TXT_NomeBanco.Text);
                CHB_GeraTabelas.Checked = true;
                CHB_GeraTabelas.Enabled = false;
            }

            //criar tabelas
            if (CHB_GeraTabelas.Checked)
            {
                CriaTabelas();
                PageUserEditandAdd pageUser = new PageUserEditandAdd(true, null, UserIdioma.Portugues, true);
                pageUser.ShowDialog();
            }



            this.Close();
        }


        private void CHB_CriaBanco_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_CriaBanco.Checked)
            {
                CHB_GeraTabelas.Checked = true;
                CHB_GeraTabelas.Enabled = false;
            }
            else
            {
                CHB_GeraTabelas.Checked = false;
                CHB_GeraTabelas.Enabled = true;
            }
        }

        public void AjustaConfigLog()
        {
            config.AppSettings.Settings.Remove("LocalLog");
            config.AppSettings.Settings.Add("LocalLog", folderPath);

            config.Save(ConfigurationSaveMode.Modified);
        }
        public void AjustaConfigTrue()
        {
            config.AppSettings.Settings.Remove("ConfigInicial");
            config.AppSettings.Settings.Add("ConfigInicial", "True");

            config.Save(ConfigurationSaveMode.Modified);
        }

        public void AjustaCSConfig()
        {
            //Conection String

            conectioString = "Data Source=" + TXT_Server.Text + ";Initial Catalog=" + TXT_NomeBanco.Text + ";Integrated Security=True;User ID="
                + TXT_User.Text + ";Password=" + TXT_Pass.Text + ";Connect Timeout=120";


            conectioStringMaster = "Data Source=" + TXT_Server.Text + ";Initial Catalog=master;Integrated Security=True;User ID="
                + TXT_User.Text + ";Password=" + TXT_Pass.Text + ";Connect Timeout=120";

            provider = "System.Data.SqlClient";

            config.ConnectionStrings.ConnectionStrings["CS"].ConnectionString = conectioString;
            config.ConnectionStrings.ConnectionStrings["CS"].ProviderName = provider;

            config.ConnectionStrings.ConnectionStrings["CSMaster"].ConnectionString = conectioStringMaster;
            config.ConnectionStrings.ConnectionStrings["CSMaster"].ProviderName = provider;

            config.Save(ConfigurationSaveMode.Modified);

        }

        public void CriaTabelas()
        {
            criaBanco.CriaTabelaUsers();
            criaBanco.CriaTabelaProviders();
            criaBanco.CriaTabelaProducts();
            criaBanco.CriaTabelaStock();
            criaBanco.CriaTabelaNotasFiscais();
            criaBanco.CriaTabelaItensNotasFiscais();
            criaBanco.CriaTabelaSolicitation();
            criaBanco.CriaTabelaItensSolicitation();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_Server_TextChanged(object sender, EventArgs e)
        {
            TXT_Server.BackColor = Color.White;
        }

        private void TXT_User_TextChanged(object sender, EventArgs e)
        {
            TXT_User.BackColor = Color.White;
        }

        private void TXT_NomeBanco_TextChanged(object sender, EventArgs e)
        {
            TXT_NomeBanco.BackColor = Color.White;
        }

        private void TXT_Pass_TextChanged(object sender, EventArgs e)
        {
            TXT_Pass.BackColor = Color.White;
        }

        private void TXT_folderPath_TextChanged(object sender, EventArgs e)
        {
            TXT_folderPath.BackColor = Color.White;
        }


        private void BTN_Gerar_Tabelas_Click(object sender, EventArgs e)
        {
            CriaTabelas();
        }
    }
}
