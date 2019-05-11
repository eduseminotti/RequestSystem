using System;
using System.Windows.Forms;

namespace Request_System
{
    public partial class LoginValidate : Form
    {
        public static LoginValidate loginValidate;

        ValidateUsers validate = new ValidateUsers();
        LOG log = new LOG();

        String loginUserName;
        String loginPass;

        User user;


        public LoginValidate()
        {
            InitializeComponent();
            this.AcceptButton = BTN_Entrar;

            this.MaximizeBox = false;

            log._logador("Iniciando Sistema;");
        }

        private void LoginValidate_FormClosing(object sender, FormClosingEventArgs e)
        {
            log._logador("Fechando Sistema;");
            System.Diagnostics.Process.GetCurrentProcess().Close();
            Environment.Exit(0);
            Application.Exit();
            this.Close();
        }

        private void BTN_Entrar_Click(object sender, EventArgs e)
        {
            loginUserName = TXT_UserName_login.Text != "" ? TXT_UserName_login.Text : null;
            loginPass = TXT_Pass_login.Text != "" ? TXT_Pass_login.Text : null;

            if (loginUserName == null || loginPass == null)
            {
                log._logador("Usuario ou senha nao informado!");
                MessageBox.Show("Usuario ou senha estao vazios!");

                return;
            }

            user = validate.ValidaUsuario(loginUserName, loginPass);

            if (user != null && user.IsValid(loginPass))
            {
                if (user.IsActive == UserIsactive.Inativo)
                    return;
                if (user.Idioma == UserIdioma.Portugues)
                    Idioma.AjustaCultura(this, "pt-BR");

                if (user.Idioma == UserIdioma.Ingles)
                    Idioma.AjustaCultura(this, "en-US");

                if (user.Idioma == UserIdioma.Espanhol)
                    Idioma.AjustaCultura(this, "es-ES");

                Menus_Main admMain = new Menus_Main(user.UserID, user.Name, user.Type, user.Idioma);
                this.Hide();
                admMain.Show();
                log._logador("Login Realizado com sucesso com o usuario: " + user.Name + " Com o Idioma: " + user.Idioma);
            }
            else
            {
                log._logador("Usuario ou senha incorretos!");
                MessageBox.Show("Usuario ou senha incorretos!");
            }
        }
    }
}

