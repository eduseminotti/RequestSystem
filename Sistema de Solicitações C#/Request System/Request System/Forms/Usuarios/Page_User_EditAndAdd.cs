﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Request_System
{
    public partial class PageUserEditandAdd : Form
    {
        String name;
        String setor;
        String email;
        String cPF;
        String userName;
        String password, confirmPassword;
        UserType type;
        UserIsactive isActive;
        UserIdioma idioma, userLoginIdioma;
        bool saveUserOk, isNew, passEdit = false;

        ManipulaUsuarios Manipula_Usuarios = new ManipulaUsuarios();
        List<Return_Usuarios> usuarios;
        CriptografaSenhas Cripto = new CriptografaSenhas();

        public PageUserEditandAdd(bool IsNew, String SelectUserName, UserIdioma UserLoginIdioma)
        {
            InitializeComponent();
            isNew = IsNew;

            CBX_Status.DataSource = Enum.GetValues(typeof(UserIsactive));
            CBX_TYPE.DataSource = Enum.GetValues(typeof(UserType));

            userLoginIdioma = UserLoginIdioma;

            if (!isNew)//Editar usuario
            {
                TXT_Usuario.Enabled = false;
                usuarios = Manipula_Usuarios.GetUsuarios(SelectUserName, null, null, 0);
                foreach (var return_Usuarios in usuarios)
                {
                    TXT_Nome.Text = return_Usuarios.Name.ToString();
                    TXT_Email.Text = return_Usuarios.Email.ToString();
                    TXT_CPF.Text = return_Usuarios.CPF.ToString();
                    TXT_Setor.Text = return_Usuarios.Setor.ToString();
                    TXT_Usuario.Text = return_Usuarios.UserName.ToString();
                    CBX_TYPE.Text = return_Usuarios.Type.ToString();
                    CBX_Status.Text = return_Usuarios.IsActive.ToString();
                }
            }
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
        private void TXT_Setor_TextChanged(object sender, EventArgs e)
        {
            TXT_Setor.BackColor = Color.White;

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
            passEdit = true;
        }
        private void TXT_CPF_TextChanged(object sender, EventArgs e)
        {
            TXT_CPF.BackColor = Color.White;
        }

        private void TXT_Nome_TabIndexChanged(object sender, EventArgs e)
        {
            TXT_CPF.BackColor = Color.Yellow;
        }

        private void BTN_UserSalvar_Click(object sender, EventArgs e)
        {
            //captura textos dos campos
            name = TXT_Nome.Text.ToString();
            email = TXT_Email.Text.ToString();
            cPF = TXT_CPF.Text.ToString().Replace(",",".");
            setor = TXT_Setor.Text.ToString();
            userName = TXT_Usuario.Text.ToString();
            password = TXT_Password.Text.ToString();
            confirmPassword = TXT_Confirm_Pass.Text.ToString();
            type = (UserType)Enum.Parse(typeof(UserType), CBX_TYPE.Text.ToString());
            isActive = (UserIsactive)Enum.Parse(typeof(UserIsactive), CBX_Status.Text.ToString());
            String maskCPF = TXT_CPF.Text.ToString().Replace(".", "").Replace("-", "").Replace(" ", "").Replace(",","");

            //valida campos obrigatorio e valida seleção comboboxs
            if (name == "" || maskCPF == "" || setor == "" || userName == "" || email == "" || isActive == 0 || type == 0 ||  maskCPF.Length < 11)
            {
                if (name == "")
                    TXT_Nome.BackColor = Color.OrangeRed;
                if (maskCPF == "" || maskCPF.Length < 11)
                    TXT_CPF.BackColor = Color.OrangeRed;
                if (setor == "")
                    TXT_Setor.BackColor = Color.OrangeRed;
                if (email == "")
                    TXT_Email.BackColor = Color.OrangeRed;
                if (userName == "")
                    TXT_Usuario.BackColor = Color.OrangeRed;
                if (isActive == UserIsactive._)
                    CBX_Status.BackColor = Color.OrangeRed;
                if (type == UserType._)
                    CBX_TYPE.BackColor = Color.OrangeRed;

                if (userLoginIdioma == UserIdioma.Portugues)
                    MessageBox.Show("Informe uma opção valida!");
                if (userLoginIdioma == UserIdioma.Ingles)
                    MessageBox.Show("Please enter a valid option!");
                if (userLoginIdioma == UserIdioma.Espanhol)
                    MessageBox.Show("Introduzca una opción válida!");

                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("As senhas informadas nao sao iguais!");
                TXT_Confirm_Pass.BackColor = Color.OrangeRed;
                TXT_Password.BackColor = Color.OrangeRed;
                return;
            }

            password = Cripto.CriptografaSenha(password);

            //novo usuario
            if (isNew)
            {

                if (confirmPassword == "" || password == "")
                {
                    if (password == "")
                        TXT_Password.BackColor = Color.OrangeRed;

                    if (confirmPassword == "")
                        TXT_Confirm_Pass.BackColor = Color.OrangeRed;
                    return;
                }
                //valida se usario ja existe
                usuarios = Manipula_Usuarios.GetUsuarios(userName, null, null, 0);
                if (usuarios.Any())
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
                    saveUserOk = Manipula_Usuarios.Novo_Usuario(name, setor, email, cPF, userName, password, type, isActive);

                    this.Close();
                    if (saveUserOk)
                    {
                        if (userLoginIdioma == UserIdioma.Portugues)
                            MessageBox.Show("Usuario Adicionado com Sucesso!");
                        if (userLoginIdioma == UserIdioma.Ingles)
                            MessageBox.Show("Successfully Added User!");
                        if (userLoginIdioma == UserIdioma.Espanhol)
                            MessageBox.Show("Usuario agregado con éxito!");
                    }
                }
            }
            //edição de usuario
            if (!isNew)
            {
                if (!passEdit)
                    password = null;

                saveUserOk = Manipula_Usuarios.Edit_User(name, setor, email, cPF, userName, password, type, isActive);

                this.Close();

                if (userLoginIdioma == UserIdioma.Portugues)
                    MessageBox.Show("Usuario Editado com Sucesso!");
                if (userLoginIdioma == UserIdioma.Ingles)
                    MessageBox.Show("User Edited Successfully!");
                if (userLoginIdioma == UserIdioma.Espanhol)
                    MessageBox.Show("Usuario Editado con Éxito!");
            }
        }

        private void TXT_Confirm_Pass_TextChanged(object sender, EventArgs e)
        {
            TXT_Confirm_Pass.BackColor = Color.White;
            passEdit = true;
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

        private void TXT_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
    }
}
