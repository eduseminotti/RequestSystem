namespace Request_System
{
    partial class Usuarios_view
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios_view));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBL_Usuarios = new System.Windows.Forms.Label();
            this.TXT_Filter_Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBX_Filter_Status = new System.Windows.Forms.ComboBox();
            this.BTN_FilterClean = new MetroFramework.Controls.MetroButton();
            this.BTN_Filtrar1 = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_filter_Setor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Filter_User_Name = new System.Windows.Forms.TextBox();
            this.GRID_USERS_VIEW = new MetroFramework.Controls.MetroGrid();
            this.returnUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_NewUser = new MetroFramework.Controls.MetroButton();
            this.BTN_Edit1 = new MetroFramework.Controls.MetroButton();
            this.adminMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_USERS_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Usuarios
            // 
            resources.ApplyResources(this.LBL_Usuarios, "LBL_Usuarios");
            this.LBL_Usuarios.Name = "LBL_Usuarios";
            // 
            // TXT_Filter_Name
            // 
            resources.ApplyResources(this.TXT_Filter_Name, "TXT_Filter_Name");
            this.TXT_Filter_Name.Name = "TXT_Filter_Name";
            this.TXT_Filter_Name.TextChanged += new System.EventHandler(this.TXT_Filter_Name_TextChanged);
            this.TXT_Filter_Name.Enter += new System.EventHandler(this.TXT_Filter_Name_Enter);
            this.TXT_Filter_Name.Leave += new System.EventHandler(this.TXT_Filter_Name_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBX_Filter_Status);
            this.groupBox1.Controls.Add(this.BTN_FilterClean);
            this.groupBox1.Controls.Add(this.BTN_Filtrar1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_filter_Setor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXT_Filter_User_Name);
            this.groupBox1.Controls.Add(this.TXT_Filter_Name);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // CBX_Filter_Status
            // 
            this.CBX_Filter_Status.FormattingEnabled = true;
            resources.ApplyResources(this.CBX_Filter_Status, "CBX_Filter_Status");
            this.CBX_Filter_Status.Name = "CBX_Filter_Status";
            this.CBX_Filter_Status.SelectedIndexChanged += new System.EventHandler(this.CBX_Filter_Status_SelectedIndexChanged_1);
            this.CBX_Filter_Status.Enter += new System.EventHandler(this.CBX_Filter_Status_Enter);
            this.CBX_Filter_Status.Leave += new System.EventHandler(this.CBX_Filter_Status_Leave);
            // 
            // BTN_FilterClean
            // 
            resources.ApplyResources(this.BTN_FilterClean, "BTN_FilterClean");
            this.BTN_FilterClean.Name = "BTN_FilterClean";
            this.BTN_FilterClean.UseSelectable = true;
            this.BTN_FilterClean.Click += new System.EventHandler(this.BTN_FilterClean_Click);
            // 
            // BTN_Filtrar1
            // 
            resources.ApplyResources(this.BTN_Filtrar1, "BTN_Filtrar1");
            this.BTN_Filtrar1.Name = "BTN_Filtrar1";
            this.BTN_Filtrar1.UseSelectable = true;
            this.BTN_Filtrar1.Click += new System.EventHandler(this.BTN_Filtrar1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TXT_filter_Setor
            // 
            resources.ApplyResources(this.TXT_filter_Setor, "TXT_filter_Setor");
            this.TXT_filter_Setor.Name = "TXT_filter_Setor";
            this.TXT_filter_Setor.TextChanged += new System.EventHandler(this.TXT_filter_Setor_TextChanged);
            this.TXT_filter_Setor.Enter += new System.EventHandler(this.TXT_filter_Setor_Enter);
            this.TXT_filter_Setor.Leave += new System.EventHandler(this.TXT_filter_Setor_Leave);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TXT_Filter_User_Name
            // 
            resources.ApplyResources(this.TXT_Filter_User_Name, "TXT_Filter_User_Name");
            this.TXT_Filter_User_Name.Name = "TXT_Filter_User_Name";
            this.TXT_Filter_User_Name.TextChanged += new System.EventHandler(this.TXT_Filter_User_Name_TextChanged);
            this.TXT_Filter_User_Name.Enter += new System.EventHandler(this.TXT_Filter_User_Name_Enter);
            this.TXT_Filter_User_Name.Leave += new System.EventHandler(this.TXT_Filter_User_Name_Leave);
            // 
            // GRID_USERS_VIEW
            // 
            this.GRID_USERS_VIEW.AllowUserToResizeRows = false;
            this.GRID_USERS_VIEW.AutoGenerateColumns = false;
            this.GRID_USERS_VIEW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRID_USERS_VIEW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRID_USERS_VIEW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRID_USERS_VIEW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_USERS_VIEW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRID_USERS_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_USERS_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.cPFDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.userNameDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.setorDataGridViewTextBoxColumn1,
            this.isActiveDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1});
            this.GRID_USERS_VIEW.DataSource = this.returnUsuariosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_USERS_VIEW.DefaultCellStyle = dataGridViewCellStyle2;
            this.GRID_USERS_VIEW.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.GRID_USERS_VIEW, "GRID_USERS_VIEW");
            this.GRID_USERS_VIEW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRID_USERS_VIEW.Name = "GRID_USERS_VIEW";
            this.GRID_USERS_VIEW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_USERS_VIEW.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GRID_USERS_VIEW.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GRID_USERS_VIEW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_USERS_VIEW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_USERS_VIEW_CellDoubleClick);
            this.GRID_USERS_VIEW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GRID_USERS_VIEW_KeyDown);
            // 
            // returnUsuariosBindingSource
            // 
            this.returnUsuariosBindingSource.DataSource = typeof(Request_System.Return_Usuarios);
            // 
            // BTN_NewUser
            // 
            resources.ApplyResources(this.BTN_NewUser, "BTN_NewUser");
            this.BTN_NewUser.Name = "BTN_NewUser";
            this.BTN_NewUser.UseSelectable = true;
            this.BTN_NewUser.Click += new System.EventHandler(this.BTN_NewUser_Click);
            // 
            // BTN_Edit1
            // 
            resources.ApplyResources(this.BTN_Edit1, "BTN_Edit1");
            this.BTN_Edit1.Name = "BTN_Edit1";
            this.BTN_Edit1.UseSelectable = true;
            this.BTN_Edit1.Click += new System.EventHandler(this.BTN_Edit1_Click);
            // 
            // adminMainBindingSource
            // 
            this.adminMainBindingSource.DataSource = typeof(Request_System.Menus_Main);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn1, "nameDataGridViewTextBoxColumn1");
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cPFDataGridViewTextBoxColumn1
            // 
            this.cPFDataGridViewTextBoxColumn1.DataPropertyName = "CPF";
            resources.ApplyResources(this.cPFDataGridViewTextBoxColumn1, "cPFDataGridViewTextBoxColumn1");
            this.cPFDataGridViewTextBoxColumn1.Name = "cPFDataGridViewTextBoxColumn1";
            this.cPFDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cPFDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn1, "emailDataGridViewTextBoxColumn1");
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userNameDataGridViewTextBoxColumn1
            // 
            this.userNameDataGridViewTextBoxColumn1.DataPropertyName = "UserName";
            resources.ApplyResources(this.userNameDataGridViewTextBoxColumn1, "userNameDataGridViewTextBoxColumn1");
            this.userNameDataGridViewTextBoxColumn1.Name = "userNameDataGridViewTextBoxColumn1";
            this.userNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "Password";
            resources.ApplyResources(this.passwordDataGridViewTextBoxColumn1, "passwordDataGridViewTextBoxColumn1");
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            // 
            // setorDataGridViewTextBoxColumn1
            // 
            this.setorDataGridViewTextBoxColumn1.DataPropertyName = "Setor";
            resources.ApplyResources(this.setorDataGridViewTextBoxColumn1, "setorDataGridViewTextBoxColumn1");
            this.setorDataGridViewTextBoxColumn1.Name = "setorDataGridViewTextBoxColumn1";
            this.setorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.setorDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // isActiveDataGridViewTextBoxColumn1
            // 
            this.isActiveDataGridViewTextBoxColumn1.DataPropertyName = "IsActive";
            resources.ApplyResources(this.isActiveDataGridViewTextBoxColumn1, "isActiveDataGridViewTextBoxColumn1");
            this.isActiveDataGridViewTextBoxColumn1.Name = "isActiveDataGridViewTextBoxColumn1";
            this.isActiveDataGridViewTextBoxColumn1.ReadOnly = true;
            this.isActiveDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            resources.ApplyResources(this.typeDataGridViewTextBoxColumn1, "typeDataGridViewTextBoxColumn1");
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Usuarios_view
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_NewUser);
            this.Controls.Add(this.BTN_Edit1);
            this.Controls.Add(this.GRID_USERS_VIEW);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios_view";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_USERS_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminMainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_Usuarios;
        private System.Windows.Forms.BindingSource returnUsuariosBindingSource;
        private System.Windows.Forms.BindingSource adminMainBindingSource;
        private System.Windows.Forms.TextBox TXT_Filter_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_Filter_User_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_filter_Setor;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroGrid GRID_USERS_VIEW;
        private MetroFramework.Controls.MetroButton BTN_FilterClean;
        private MetroFramework.Controls.MetroButton BTN_Filtrar1;
        private MetroFramework.Controls.MetroButton BTN_NewUser;
        private MetroFramework.Controls.MetroButton BTN_Edit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idiomaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox CBX_Filter_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
    }
}