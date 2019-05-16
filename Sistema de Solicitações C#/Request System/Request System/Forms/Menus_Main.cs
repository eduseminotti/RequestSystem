using System;
using System.Windows.Forms;

namespace Request_System
{
    public partial class Menus_Main : Form
    {
        private Form _objForm;
        int userID;
        String userName;
        bool logOut;
        UserIdioma idioma;

        LOG log = new LOG();

        public Menus_Main(int UserID, string UserName, UserType userType, UserIdioma UserIdioma)
        {
            InitializeComponent();
            idioma = UserIdioma;

            this.MaximizeBox = false;

            if (userType == UserType.Usuario)
            {
                BTN_Fornecedores.Visible = false;
                BTN_Notas_Fiscais.Visible = false;
                BTN_Pedidos.Visible = false;
                BTN_Produtos.Visible = false;
                BTN_Usuarios.Visible = false;
            }
            if (userType == UserType.Estoquista)
            {
                BTN_Usuarios.Visible = false;
            }

            LBL_Current_User.Text = UserName;
            userID = UserID;
            userName = UserName;
            logOut = false;

            _objForm = new Request_System.Form_Em_Branco
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            PNL_Content_Main_Adm.Controls.Add(_objForm);
            _objForm.Show();
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Visible = true;
            //this.WindowState = FormWindowState.Normal;
            //this.ShowInTaskbar = true;
            //notifyIcon1.Visible = true;
        }
        private void Menus_Main_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Restaurar sistema!";
        }
        private void Menus_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logOut)
            {
                DialogResult? confirm = null;

                if (idioma == UserIdioma.Portugues)
                {
                    confirm = MessageBox.Show("Sair? SIM = sair do sistema, NÃO = Minimiza para a bandeja.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }
                else if (idioma == UserIdioma.Ingles)
                {
                    confirm = MessageBox.Show("Leave ? YES = exit the system, NO = Minimizes to tray.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }
                else if (idioma == UserIdioma.Espanhol)
                {
                    confirm = MessageBox.Show("Fuera ? SIM = salir del sistema, NO = Minimiza a la bandeja.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }

                if (confirm != null)
                {
                    if (confirm == DialogResult.No)
                    {
                        notifyIcon1.Visible = true;
                        this.Visible = false;
                        this.ShowInTaskbar = false;
                        this.WindowState = FormWindowState.Minimized;
                        e.Cancel = true;
                        log.logador("Minimizando sistema para a bandeja!");
                    }
                    else
                    {
                        log.logador("Saindo do sistema!");
                        System.Diagnostics.Process.GetCurrentProcess().Close();
                        Environment.Exit(0);
                        Application.Exit();
                        this.Close();
                    }
                }
            }
        }
        private void BTN_Seus_Pedidos_Click(object sender, EventArgs e)
        {
            _objForm.Close();
            _objForm = new Request_System.SeusPedidos(userID, idioma)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            PNL_Content_Main_Adm.Controls.Add(_objForm);
            _objForm.Show();
        }
        private void BTN_Pedidos_Click(object sender, EventArgs e)
        {
            _objForm.Close();

            _objForm = new Request_System.Solicitacoes(userID, idioma)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            PNL_Content_Main_Adm.Controls.Add(_objForm);
            _objForm.Show();
        }
        private void BTN_Produtos_Click(object sender, EventArgs e)
        {
            _objForm.Close();

            _objForm = new Request_System.produtos_view(idioma)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            PNL_Content_Main_Adm.Controls.Add(_objForm);
            _objForm.Show();
        }
        private void BTN_Notas_Fiscais_Click(object sender, EventArgs e)
        {
            _objForm.Close();

            _objForm = new Request_System.Notas_Fiscais_View(idioma)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            PNL_Content_Main_Adm.Controls.Add(_objForm);
            _objForm.Show();
        }
        private void BTN_Fornecedores_Click(object sender, EventArgs e)
        {
            _objForm.Close();

            _objForm = new Request_System.Providers_View
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            PNL_Content_Main_Adm.Controls.Add(_objForm);
            _objForm.Show();
        }
        private void BTN_Usuarios_Click(object sender, EventArgs e)
        {
            _objForm.Close();

            _objForm = new Request_System.Usuarios_view(idioma)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            PNL_Content_Main_Adm.Controls.Add(_objForm);
            _objForm.Show();
        }
        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            log.logador("Iniciando logout do sistema para o usuario: " + userName);
            logOut = true;
            LoginValidate login = new LoginValidate();
            this.Close();
            login.Show();
        }

        private void Menus_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                BTN_Seus_Pedidos.PerformClick();
            if (e.KeyCode == Keys.F2)
                BTN_Pedidos.PerformClick();
            if (e.KeyCode == Keys.F3)
                BTN_Produtos.PerformClick();
            if (e.KeyCode == Keys.F4)
                BTN_Notas_Fiscais.PerformClick();
            if (e.KeyCode == Keys.F5)
                BTN_Fornecedores.PerformClick();
            if (e.KeyCode == Keys.F6)
                BTN_Usuarios.PerformClick();
        }

        private void Menu_Restaurar_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = true;
        }

        private void Menu_Encerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por:\nEduardo Seminotti.\nSistemas de Informação - UNIPLAC.\nProfessor: Luciano Coelho.\nVersão: Beta");
        }

        private void Menus_Main_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {

            }
        }
    }
}
