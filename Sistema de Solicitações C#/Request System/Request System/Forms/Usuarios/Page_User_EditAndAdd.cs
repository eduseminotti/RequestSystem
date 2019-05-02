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
        String password;
        UserType type;
        UserIsactive isActive;
        UserIdioma idioma;
        bool saveUserOk, isNew;

        ManipulaUsuarios Manipula_Usuarios = new ManipulaUsuarios();
        // Usuarios_view Usuarios_view = new Usuarios_view();

        List<Return_Usuarios> usuarios;

        public PageUserEditandAdd(bool IsNew, String SelectUserName)
        {
            InitializeComponent();
            isNew = IsNew;

            CBX_IDIOMA.DataSource = Enum.GetValues(typeof(UserIdioma));
            CBX_Status.DataSource = Enum.GetValues(typeof(UserIsactive));
            CBX_TYPE.DataSource = Enum.GetValues(typeof(UserType));

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
                    TXT_Password.Text = return_Usuarios.Password.ToString();
                    CBX_IDIOMA.Text = return_Usuarios.Idioma.ToString();
                    CBX_TYPE.Text = return_Usuarios.Type.ToString();
                    CBX_Status.Text = return_Usuarios.IsActive.ToString();
                }
            }
        }
        private void BTN_User_Salvar_Click(object sender, EventArgs e)
        {
        
        }
        private void BTN_User_Cancel_Click(object sender, EventArgs e)
        {
 
        }
        private void CBX_IDIOMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBX_IDIOMA.BackColor = Color.White;
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
            TXT_Email.BackColor = Color.OrangeRed;
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

        private void BTN_UserSalvar_Click(object sender, EventArgs e)
        {
            //captura textos dos campos
            name = TXT_Nome.Text.ToString();
            email = TXT_Email.Text.ToString();
            cPF = TXT_CPF.Text.ToString();
            setor = TXT_Setor.Text.ToString();
            userName = TXT_Usuario.Text.ToString();
            password = TXT_Password.Text.ToString();
            idioma = (UserIdioma)Enum.Parse(typeof(UserIdioma), CBX_IDIOMA.Text.ToString());
            type = (UserType)Enum.Parse(typeof(UserType), CBX_TYPE.Text.ToString());
            isActive = (UserIsactive)Enum.Parse(typeof(UserIsactive), CBX_Status.Text.ToString());


            //valida campos obrigatorio e valida seleção comboboxs
            if (name == "" || cPF == "" || setor == "" || userName == "" ||
                password == "" || isActive == 0 || type == 0 || idioma == 0)
            {
                if (name == "")
                    TXT_Nome.BackColor = Color.OrangeRed;
                if (cPF == "")
                    TXT_CPF.BackColor = Color.OrangeRed;
                if (setor == "")
                    TXT_Setor.BackColor = Color.OrangeRed;
                if (userName == "")
                    TXT_Usuario.BackColor = Color.OrangeRed;
                if (password == "")
                    TXT_Password.BackColor = Color.OrangeRed;
                if (isActive == 0)
                    CBX_Status.BackColor = Color.OrangeRed;
                if (idioma == 0)
                    CBX_IDIOMA.BackColor = Color.OrangeRed;
                if (type == 0)
                    CBX_TYPE.BackColor = Color.OrangeRed;

                MessageBox.Show("Informe uma opção valida!");
                return;
            }

            //novo usuario
            if (isNew)
            {
                //valida se usario ja existe
                usuarios = Manipula_Usuarios.GetUsuarios(userName, null, null, 0);
                if (usuarios.Any())
                {
                    TXT_Usuario.BackColor = Color.OrangeRed;
                    TXT_Usuario.Focus();
                    MessageBox.Show("Usuario ja Existe, Informe um nome de usuario diferente!");
                }
                else// se nao existe cadastra
                {
                    saveUserOk = Manipula_Usuarios.Novo_Usuario(name, setor, email, cPF, userName, password, type, isActive, idioma);

                    this.Close();
                    if (saveUserOk)
                        MessageBox.Show("Usuario Adicionado com Sucesso!");
                }
            }
            //edição de usuario
            if (!isNew)
            {
                saveUserOk = Manipula_Usuarios.Edit_User(name, setor, email, cPF, userName, password, type, isActive, idioma);
                this.Close();
                MessageBox.Show("Usuario Editado com Sucesso!");
            }
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
    }
}
