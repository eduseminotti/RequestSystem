using Request_System.Repositorios.Contexts;
using Request_System.Repositorios.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Request_System
{
    public partial class PageUserEditandAdd : Form
    {
        String confirmPassword;
        UserIdioma userLoginIdioma;
        bool isNew;

        Entities.User user = new Entities.User();
        ManipulaUsuarios manipulaUsuarios = new ManipulaUsuarios();
        UserRepository userRepository;
        MainContext context = new MainContext();
        public PageUserEditandAdd(bool IsNew, String SelectUserName, UserIdioma UserLoginIdioma, bool Install)
        {
            InitializeComponent();
            isNew = IsNew;
            bool install = Install;

            CBX_Status.DataSource = Enum.GetValues(typeof(UserIsactive));
            CBX_TYPE.DataSource = Enum.GetValues(typeof(UserType));

            userLoginIdioma = UserLoginIdioma;

            if (!isNew)//Editar usuario
            {
                TXT_Usuario.Enabled = false;
                //user = manipulaUsuarios.GetByUsername(SelectUserName);

                using (context)
                {
                    userRepository = new UserRepository(context);

                    user = userRepository.GetByUsername(SelectUserName);
                }

                TXT_Nome.Text = user.Name.ToString();
                TXT_Email.Text = user.Email.ToString();
                TXT_CPF.Text = user.CPF.ToString();
                TXT_Setor.Text = user.Setor.ToString();
                TXT_Usuario.Text = user.UserName.ToString();
                CBX_TYPE.Text = user.Type.ToString();
                CBX_Status.Text = user.IsActive.ToString();
                TXT_Password.Text = user.Password.ToString();
                TXT_Confirm_Pass.Text = user.Password.ToString();
            }
            if (Install)
            {
                UserIsactive userStatus = UserIsactive.Ativo;
                CBX_Status.DataSource = Enum.GetValues(typeof(UserIsactive));
                CBX_Status.Text = userStatus.ToString();
                CBX_Status.Enabled = false;

                UserType userType = UserType.Administrador;
                CBX_TYPE.DataSource = Enum.GetValues(typeof(UserType));
                CBX_TYPE.Text = userType.ToString();
                CBX_TYPE.Enabled = false;
            }
        }

        private void BTN_UserSalvar_Click(object sender, EventArgs e)
        {
            user.Name = TXT_Nome.Text.ToString();
            user.Email = TXT_Email.Text.ToString();
            user.CPF = TXT_CPF.Text.ToString().Replace(",", ".");
            user.Setor = TXT_Setor.Text.ToString();
            user.UserName = TXT_Usuario.Text.ToString();
            user.Password = TXT_Password.Text.ToString();
            user.Type = (UserType)Enum.Parse(typeof(UserType), CBX_TYPE.Text.ToString());
            user.IsActive = (UserIsactive)Enum.Parse(typeof(UserIsactive), CBX_Status.Text.ToString());
            user.InsertDate = DateTime.Now;

            confirmPassword = TXT_Confirm_Pass.Text.ToString();

            String maskCPF = TXT_CPF.Text.ToString().Replace(".", "").Replace("-", "").Replace(" ", "").Replace(",", "");

            //valida campos obrigatorio e valida seleção comboboxs
            if (user.Name == "" || maskCPF == "" || user.Setor == "" || user.UserName == "" || user.Email == "" ||
                user.IsActive == UserIsactive._ || user.Type == UserType._ || maskCPF.Length < 11)
            {
                if (user.Name == "")
                    TXT_Nome.BackColor = Color.OrangeRed;
                if (maskCPF == "" || maskCPF.Length < 11)
                    TXT_CPF.BackColor = Color.OrangeRed;
                if (user.Setor == "")
                    TXT_Setor.BackColor = Color.OrangeRed;
                if (user.Setor == "")
                    TXT_Email.BackColor = Color.OrangeRed;
                if (user.UserName == "")
                    TXT_Usuario.BackColor = Color.OrangeRed;
                if (user.IsActive == UserIsactive._)
                    CBX_Status.BackColor = Color.OrangeRed;
                if (user.Type == UserType._)
                    CBX_TYPE.BackColor = Color.OrangeRed;

                if (userLoginIdioma == UserIdioma.Portugues)
                    MessageBox.Show("Informe uma opção valida!");
                if (userLoginIdioma == UserIdioma.Ingles)
                    MessageBox.Show("Please enter a valid option!");
                if (userLoginIdioma == UserIdioma.Espanhol)
                    MessageBox.Show("Introduzca una opción válida!");

                return;
            }

            if (user.Password != confirmPassword)
            {
                MessageBox.Show("As senhas informadas nao sao iguais!");
                TXT_Confirm_Pass.BackColor = Color.OrangeRed;
                TXT_Password.BackColor = Color.OrangeRed;
                return;
            }

            //user.Password = Cripto.CriptografaSenha(user.Password);

            //novo usuario
            if (isNew)
            {
                if (confirmPassword == "" || user.Password == "")
                {
                    if (user.Password == "")
                        TXT_Password.BackColor = Color.OrangeRed;

                    if (confirmPassword == "")
                        TXT_Confirm_Pass.BackColor = Color.OrangeRed;
                    return;
                }

                Entities.User userExists = manipulaUsuarios.GetByUsername(user.UserName);

                if (userExists != null)
                {
                    TXT_Usuario.BackColor = Color.OrangeRed;
                    TXT_Usuario.Focus();

                    if (userLoginIdioma == UserIdioma.Portugues)
                        MessageBox.Show("Usuario ja Existe, Informe um nome de usuario diferente!");
                    if (userLoginIdioma == UserIdioma.Ingles)
                        MessageBox.Show("User already exists, Please enter a different username!");
                    if (userLoginIdioma == UserIdioma.Espanhol)
                        MessageBox.Show("El usuario ya existe, introduzca un nombre de usuario diferente!");
                }
                else// se nao existe cadastra
                {
                    manipulaUsuarios.AddNewUser(user);

                    this.Close();
                }
            }
            //edição de usuario
            if (!isNew)
            {
                using (context)
                {
                    userRepository = new UserRepository(context);

                    context.SaveChanges();
                }

                manipulaUsuarios.EditUser(user);

                this.Close();
            }
        }
        #region
        private void TXT_Confirm_Pass_TextChanged(object sender, EventArgs e)
        {
            TXT_Confirm_Pass.BackColor = Color.White;
        }

        private void BTN_UserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Usuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void TXT_Nome_Enter(object sender, EventArgs e)
        {
            TXT_Nome.BackColor = Color.Yellow;
        }
        private void TXT_Nome_Leave(object sender, EventArgs e)
        {
            TXT_Nome.BackColor = Color.White;
        }

        private void TXT_CPF_Enter(object sender, EventArgs e)
        {
            TXT_CPF.BackColor = Color.Yellow;
        }

        private void TXT_CPF_Leave(object sender, EventArgs e)
        {
            TXT_CPF.BackColor = Color.White;
        }
        private void TXT_Email_Enter(object sender, EventArgs e)
        {
            TXT_Email.BackColor = Color.Yellow;
        }

        private void TXT_Email_Leave(object sender, EventArgs e)
        {
            TXT_Email.BackColor = Color.White;
        }

        private void TXT_Setor_Enter(object sender, EventArgs e)
        {
            TXT_Setor.BackColor = Color.Yellow;
        }

        private void TXT_Setor_Leave(object sender, EventArgs e)
        {
            TXT_Setor.BackColor = Color.White;
        }

        private void TXT_Usuario_Enter(object sender, EventArgs e)
        {
            TXT_Usuario.BackColor = Color.Yellow;
        }

        private void TXT_Usuario_Leave(object sender, EventArgs e)
        {
            TXT_Usuario.BackColor = Color.White;
        }

        private void CBX_TYPE_Enter(object sender, EventArgs e)
        {
            CBX_TYPE.BackColor = Color.Yellow;
        }

        private void CBX_TYPE_Leave(object sender, EventArgs e)
        {
            CBX_TYPE.BackColor = Color.White;
        }

        private void TXT_Password_Enter(object sender, EventArgs e)
        {
            TXT_Password.BackColor = Color.Yellow;
        }

        private void TXT_Password_Leave(object sender, EventArgs e)
        {
            TXT_Password.BackColor = Color.White;
        }

        private void TXT_Confirm_Pass_Enter(object sender, EventArgs e)
        {
            TXT_Confirm_Pass.BackColor = Color.Yellow;
        }

        private void TXT_Confirm_Pass_Leave(object sender, EventArgs e)
        {
            TXT_Confirm_Pass.BackColor = Color.White;
        }

        private void CBX_Status_Enter(object sender, EventArgs e)
        {
            CBX_Status.BackColor = Color.Yellow;
        }

        private void CBX_Status_Leave(object sender, EventArgs e)
        {
            CBX_Status.BackColor = Color.White;
        }

        private void CBX_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBX_TYPE.BackColor = Color.White;
        }
        private void CBX_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBX_Status.BackColor = Color.White;
        }
        private void TXT_Nome_TextChanged(object sender, EventArgs e)
        {
            TXT_Nome.BackColor = Color.White;
        }

        private void TXT_Email_TextChanged(object sender, EventArgs e)
        {
            TXT_Email.BackColor = Color.White;
        }
        private void TXT_Usuario_TextChanged(object sender, EventArgs e)
        {
            TXT_Usuario.BackColor = Color.White;
        }
        private void TXT_Password_TextChanged(object sender, EventArgs e)
        {
            TXT_Password.BackColor = Color.White;
        }
        private void TXT_CPF_TextChanged(object sender, EventArgs e)
        {
            TXT_CPF.BackColor = Color.White;
        }

        private void TXT_Nome_TabIndexChanged(object sender, EventArgs e)
        {
            TXT_CPF.BackColor = Color.Yellow;
        }
        #endregion
    }
}
