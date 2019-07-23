using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Request_System
{
    public partial class LoginValidate : Form
    {
        public static LoginValidate loginValidate;

        ValidateUsers validate = new ValidateUsers();
        LOG log = new LOG();
        CriptografaSenhas cripto = new CriptografaSenhas();
        ConfigGerais configGerais = new ConfigGerais();
        UserIdioma idioma;
        String loginUserName;
        String loginPass;

        User user;


        public LoginValidate()
        {
            InitializeComponent();

            CBX_Idioma.DataSource = Enum.GetValues(typeof(UserIdioma));

            bool configInicial = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("ConfigInicial"));
            if (!configInicial)
            {
                configGerais.ShowDialog();
            }


            this.AcceptButton = BTN_Entrar;

            this.MaximizeBox = false;

            log.logador("Iniciando Sistema!");
        }

        private void LoginValidate_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.logador("Fechando Sistema!");
            System.Diagnostics.Process.GetCurrentProcess().Close();
            Environment.Exit(0);
            Application.Exit();
            this.Close();
        }

        private void BTN_Entrar_Click(object sender, EventArgs e)
        {
            AjustaCultura();

            loginUserName = TXT_UserName_login.Text != "" ? TXT_UserName_login.Text : null;
            loginPass = TXT_Pass_login.Text != "" ? TXT_Pass_login.Text : null;

            if (loginUserName == null || loginPass == null)
            {
                log.logador("Usuario ou senha nao informado!");
                TXT_UserName_login.Focus();

                if (idioma == UserIdioma.Portugues)
                    MessageBox.Show("Usuário ou senha estao vazios!");

                if (idioma == UserIdioma.Ingles)
                    MessageBox.Show("User or password is empty!");

                if (idioma == UserIdioma.Espanhol)
                    MessageBox.Show("Usuario o contraseña están vacíos!");


                return;
            }

            loginPass = cripto.CriptografaSenha(loginPass);

            //user = validate.ValidaUsuario(loginUserName, loginPass);

            var userEntity = validate.ValidaUsuarioEntity(loginUserName, loginPass);

            if (userEntity != null && userEntity.IsValid(loginPass))
            {
                //Menus_Main admMain = new Menus_Main(user.UserID, user.Name, user.Type, idioma);
                Menus_Main admMain = new Menus_Main((int)userEntity.Id, userEntity.Name, userEntity.Type, idioma);
                this.Hide();
                admMain.Show();
                log.logador("Login Realizado com sucesso com o usuario: " + userEntity.Name);
            }
            else
            {
                log.logador("Usuario ou senha incorretos!");
                if (idioma == UserIdioma.Portugues)
                    MessageBox.Show("Usuário ou senha incorretos!");

                if (idioma == UserIdioma.Ingles)
                    MessageBox.Show("Incorrect username or password!");

                if (idioma == UserIdioma.Espanhol)
                    MessageBox.Show("usuario o contraseña incorrectos!");

                TXT_Pass_login.Text = "";
                TXT_UserName_login.Focus();
            }
        }

        private void CBX_Idioma_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AjustaCultura();
        }
        public void AjustaCultura()
        {
            idioma = (UserIdioma)Enum.Parse(typeof(UserIdioma), CBX_Idioma.Text.ToString());

            if (idioma == UserIdioma.Portugues)
                Idioma.AjustaCultura(this, "pt-BR");

            if (idioma == UserIdioma.Ingles)
                Idioma.AjustaCultura(this, "en-US");

            if (idioma == UserIdioma.Espanhol)
                Idioma.AjustaCultura(this, "es-ES");
        }

        private void CBX_Idioma_Enter(object sender, EventArgs e)
        {
            CBX_Idioma.BackColor = Color.Yellow;
        }

        private void CBX_Idioma_Leave(object sender, EventArgs e)
        {
            CBX_Idioma.BackColor = Color.White;
        }

        private void TXT_UserName_login_Enter(object sender, EventArgs e)
        {
            TXT_UserName_login.BackColor = Color.Yellow;
        }

        private void TXT_UserName_login_Leave(object sender, EventArgs e)
        {
            TXT_UserName_login.BackColor = Color.White;
        }

        private void TXT_Pass_login_Enter(object sender, EventArgs e)
        {
            TXT_Pass_login.BackColor = Color.Yellow;
        }

        private void TXT_Pass_login_Leave(object sender, EventArgs e)
        {
            TXT_Pass_login.BackColor = Color.White;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            log.logador("Saindo do sistema!");
            System.Diagnostics.Process.GetCurrentProcess().Close();
            Environment.Exit(0);
            Application.Exit();
            this.Close();
        }
    }
}

