using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Request_System
{
    public partial class Usuarios_view : Form
    {
        List<Return_Usuarios> usuarios;
        ManipulaUsuarios ObterUsers = new ManipulaUsuarios();
        String selectedUserName;
        PageUserEditandAdd PageUserAdd;

        public Usuarios_view()
        {
            InitializeComponent();
            CBX_Filter_Status.DataSource = Enum.GetValues(typeof(UserIsactive));
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            usuarios = ObterUsers.GetUsuarios(null, null, null, 0);
            GRID_USERS_VIEW.DataSource = usuarios;
        }

        private void TXT_Filter_Name_TextChanged(object sender, EventArgs e)
        {
            BTN_Filtrar1.PerformClick();
        }

        private void TXT_Filter_User_Name_TextChanged(object sender, EventArgs e)
        {
            BTN_Filtrar1.PerformClick();
        }

        private void TXT_filter_Setor_TextChanged(object sender, EventArgs e)
        {
            BTN_Filtrar1.PerformClick();
        }

        private void BTN_FilterClean_Click(object sender, EventArgs e)
        {
            usuarios = ObterUsers.GetUsuarios(null, null, null, 0);
            GRID_USERS_VIEW.DataSource = usuarios;
            TXT_Filter_User_Name.Text = "";
            TXT_Filter_Name.Text = "";
            TXT_filter_Setor.Text = "";

            CBX_Filter_Status.DataSource = Enum.GetValues(typeof(UserIsactive));
            usuarios = ObterUsers.GetUsuarios(null, null, null, 0);
            GRID_USERS_VIEW.DataSource = usuarios;
        }

        private void BTN_Filtrar1_Click(object sender, EventArgs e)
        {
            String name = null, userName = null, setor = null;
            UserIsactive status = 0;

            if (TXT_Filter_Name.Text.ToString() != "")
                name = TXT_Filter_Name.Text.ToString();

            if (TXT_Filter_User_Name.Text.ToString() != "")
                userName = TXT_Filter_User_Name.Text.ToString();

            if (TXT_filter_Setor.Text.ToString() != "")
                setor = TXT_filter_Setor.Text.ToString();

            status = (UserIsactive)Enum.Parse(typeof(UserIsactive), CBX_Filter_Status.Text.ToString());

            usuarios = ObterUsers.GetUsuarios(userName, name, setor, status);
            GRID_USERS_VIEW.DataSource = usuarios;
        }

        private void BTN_NewUser_Click(object sender, EventArgs e)
        {
            PageUserAdd = new PageUserEditandAdd(true, null);

            PageUserAdd.ShowDialog();

            usuarios = ObterUsers.GetUsuarios(null, null, null, 0);
            GRID_USERS_VIEW.DataSource = usuarios;
        }

        private void BTN_Edit1_Click(object sender, EventArgs e)
        {
            selectedUserName = GRID_USERS_VIEW.CurrentRow.Cells[3].Value.ToString();

            PageUserAdd = new PageUserEditandAdd(false, selectedUserName);

            PageUserAdd.ShowDialog();
            usuarios = ObterUsers.GetUsuarios(null, null, null, 0);
            GRID_USERS_VIEW.DataSource = usuarios;
        }
    }
}
