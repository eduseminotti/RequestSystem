using Request_System.Forms;
using System;
using System.Windows.Forms;

namespace Request_System
{
    public partial class LoginValidate : Form
    {
        public LoginValidate()
        {
            InitializeComponent();
        }
        String loginUserName;
        String loginPass;
        User user;
        ValidateUsers validate = new ValidateUsers();

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            loginUserName = TXT_UserName_login.Text;
            loginPass = TXT_Pass_login.Text;

            user = validate.GetUser(loginUserName, loginPass);

            if (user != null && user.IsValid(loginPass))
            {
                if (user.Idioma == 1)
                    Idioma.AjustaCultura(this, "pt-BR");

                if (user.Idioma == 2)
                    Idioma.AjustaCultura(this, "en-US");

                if (user.Type == 1)
                {
                    
                    Admin_Main admMain = new Admin_Main();
                    this.Hide();
                    admMain.ShowDialog();
                    
                    
                   
                    
                       // MessageBox.Show("Login Efetuado! Usuario admim");
                }
                if (user.Type == 2)
                {
                    MessageBox.Show("Login Efetuado! Usuario stock");
                }
                if (user.Type == 3)
                {
                    MessageBox.Show("Login Efetuado! Usuario Comun");
                }
            }
            else
                MessageBox.Show("Usuario ou senha incorretos!");
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }


    }
}

