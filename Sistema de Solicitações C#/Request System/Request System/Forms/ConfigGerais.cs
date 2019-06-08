using Request_System.Repositorios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Request_System
{
    public partial class ConfigGerais : Form
    {
        String folderPath;
        //private Configuration Configuration;
        bool criaBanco, CriaTabelas;


        ValidaBanco validaBanco = new ValidaBanco();

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
            /* fuck damm
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

                        String conectioString = "Data Source=" + TXT_Server.Text + ";Initial Catalog=" + TXT_NomeBanco.Text +
                            ";Integrated Security=True;User ID=" + TXT_User.Text + ";Password=" + TXT_Pass.Text +
                            ";Connect Timeout=120";

                        String provider = "System.Data.SqlClient";
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        //Conection String
                        config.ConnectionStrings.ConnectionStrings["CS"].ConnectionString = conectioString;
                        config.ConnectionStrings.ConnectionStrings["CS"].ProviderName = provider;

                        config.Save(ConfigurationSaveMode.Modified); 
                        */
            bool bancoExiste = validaBanco.ValidaSeBancoExiste(TXT_NomeBanco.Text);
            if (!bancoExiste)
            {
                MessageBox.Show("banco Inexistente!");
                return;
            }

            if (CHB_GeraTabelas.Checked)
            {
                validaBanco.CriaTabelas(TXT_NomeBanco.Text);
            }






            /*
                        //Configuração Inicial
                        config.AppSettings.Settings.Remove("ConfigInicial");
                        config.AppSettings.Settings.Add("ConfigInicial", "True");

                        //LOG
                        config.AppSettings.Settings.Remove("LocalLog");
                        config.AppSettings.Settings.Add("LocalLog", folderPath);

                        config.Save(ConfigurationSaveMode.Modified);

                        this.Close();
                        */
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
    }
}
