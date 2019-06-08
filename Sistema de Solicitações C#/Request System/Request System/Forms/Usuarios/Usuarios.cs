using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Request_System
{
    public partial class Usuarios_view : Form
    {
        UserIdioma idioma;

        List<Return_Usuarios> usuarios;
        ManipulaUsuarios ObterUsers = new ManipulaUsuarios();
        String selectedUserName;
        PageUserEditandAdd PageUserAdd;

        public Usuarios_view(UserIdioma Idioma)
        {
            InitializeComponent();
            CBX_Filter_Status.DataSource = Enum.GetValues(typeof(UserIsactive));

            idioma = Idioma;
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
            PageUserAdd = new PageUserEditandAdd(true, null, idioma);

            PageUserAdd.ShowDialog();

            usuarios = ObterUsers.GetUsuarios(null, null, null, 0);
            GRID_USERS_VIEW.DataSource = usuarios;
        }

        private void BTN_Edit1_Click(object sender, EventArgs e)
        {
            if (ContLinhasGrid() < 1)
                return;

            selectedUserName = GRID_USERS_VIEW.CurrentRow.Cells[3].Value.ToString();

            PageUserAdd = new PageUserEditandAdd(false, selectedUserName, idioma);

            PageUserAdd.ShowDialog();
            usuarios = ObterUsers.GetUsuarios(null, null, null, 0);
            GRID_USERS_VIEW.DataSource = usuarios;
        }
        public int ContLinhasGrid()
        {
            int linhasGrid;
            linhasGrid = GRID_USERS_VIEW.Rows.Count;

            return linhasGrid;
        }

        private void GRID_USERS_VIEW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_Edit1.PerformClick();
        }

        private void TXT_Filter_Name_Enter(object sender, EventArgs e)
        {
            TXT_Filter_Name.BackColor = Color.Yellow;
        }

        private void TXT_Filter_Name_Leave(object sender, EventArgs e)
        {
            TXT_Filter_Name.BackColor = Color.White;
        }

        private void TXT_Filter_User_Name_Enter(object sender, EventArgs e)
        {
            TXT_Filter_User_Name.BackColor = Color.Yellow;
        }

        private void TXT_Filter_User_Name_Leave(object sender, EventArgs e)
        {
            TXT_Filter_User_Name.BackColor = Color.White;
        }

        private void TXT_filter_Setor_Enter(object sender, EventArgs e)
        {
            TXT_filter_Setor.BackColor = Color.Yellow;
        }

        private void TXT_filter_Setor_Leave(object sender, EventArgs e)
        {
            TXT_filter_Setor.BackColor = Color.White;
        }

        private void CBX_Filter_Status_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BTN_Filtrar1.PerformClick();
        }

        private void CBX_Filter_Status_Enter(object sender, EventArgs e)
        {
            CBX_Filter_Status.BackColor = Color.Yellow;
        }

        private void CBX_Filter_Status_Leave(object sender, EventArgs e)
        {
            CBX_Filter_Status.BackColor = Color.White;
        }

        private void GRID_USERS_VIEW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BTN_Edit1.PerformClick();
        }
    }
}
