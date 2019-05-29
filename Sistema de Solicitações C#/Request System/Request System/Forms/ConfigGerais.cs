using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Request_System
{
    public partial class ConfigGerais : Form
    {
        String folderPath;
        private Configuration Configuration;

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

            /*
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
                            */

      

            String conectioString = "Data Source=" + TXT_Server.Text + ";Initial Catalog=" + TXT_NomeBanco.Text +
                ";Integrated Security=True;User ID=" + TXT_User.Text + ";Password=" + TXT_Pass.Text +
                ";Connect Timeout=120\"providerName=\"System.Data.SqlClient";


            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Conection String
            config.ConnectionStrings.ConnectionStrings["CS"].ConnectionString = conectioString;

            //Configuração Inicial
              config.AppSettings.Settings.Remove("ConfigInicial");
              config.AppSettings.Settings.Add("ConfigInicial", "True");

            //LOG
            config.AppSettings.Settings.Remove("LocalLog");
            config.AppSettings.Settings.Add("LocalLog", folderPath);

            config.Save(ConfigurationSaveMode.Modified);
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {

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
