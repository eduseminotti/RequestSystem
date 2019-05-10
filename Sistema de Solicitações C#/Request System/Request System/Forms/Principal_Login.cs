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

            log._WriteEntry("Início da minha aplicação");

        }
               
        private void LoginValidate_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Close();
            Environment.Exit(0);
            Application.Exit();
            this.Close();
        }

        private void BTN_Entrar_Click(object sender, EventArgs e)
        {
            loginUserName = TXT_UserName_login.Text;
            loginPass = TXT_Pass_login.Text;

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

            }
            else
                MessageBox.Show("Usuario ou senha incorretos!");
        }
    }
}

