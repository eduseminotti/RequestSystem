namespace Request_System
{
    partial class PageEditSolicitacoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageEditSolicitacoes));
            this.Grid_view_itens_solicitação = new MetroFramework.Controls.MetroGrid();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeSolicitadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeAprovadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitationIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitationItemIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnItensSolicitacoesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CBX_Status_Solicitacao = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_Data_solicitacao = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.DT_Data_Aprovacao = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.DT_Data_Entrega = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Aprovar = new MetroFramework.Controls.MetroButton();
            this.BTN_Rejeitar = new MetroFramework.Controls.MetroButton();
            this.BTN_Entregar = new MetroFramework.Controls.MetroButton();
            this.BTN_Editar = new MetroFramework.Controls.MetroButton();
            this.GB_DataAprovacao = new System.Windows.Forms.GroupBox();
            this.GB_DataEntrega = new System.Windows.Forms.GroupBox();
            this.TXT_UsuarioSolicitante = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_Motivo = new MetroFramework.Controls.MetroTextBox();
            this.BTN_Fechar_tela = new MetroFramework.Controls.MetroButton();
            this.GB_valida_usuario = new System.Windows.Forms.GroupBox();
            this.TXT_user_name = new System.Windows.Forms.TextBox();
            this.TXT_Pass = new System.Windows.Forms.TextBox();
            this.BTN_Assinar_Entrega = new MetroFramework.Controls.MetroButton();
            this.BTN_Cancelar_Login = new MetroFramework.Controls.MetroButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GB_Editar_QTD_Itens = new System.Windows.Forms.GroupBox();
            this.BTN_Cancel_QTD = new MetroFramework.Controls.MetroButton();
            this.TXT_QTD_Aprovada = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_qtd_solicitada = new MetroFramework.Controls.MetroTextBox();
            this.TXT_Produto = new MetroFramework.Controls.MetroTextBox();
            this.BTN_Salvar_QTD = new MetroFramework.Controls.MetroButton();
            this.solicitationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitationItemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnItensSolicitacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_view_itens_solicitação)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItensSolicitacoesBindingSource1)).BeginInit();
            this.GB_DataAprovacao.SuspendLayout();
            this.GB_DataEntrega.SuspendLayout();
            this.GB_valida_usuario.SuspendLayout();
            this.GB_Editar_QTD_Itens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_QTD_Aprovada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItensSolicitacoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_view_itens_solicitação
            // 
            this.Grid_view_itens_solicitação.AllowUserToResizeRows = false;
            this.Grid_view_itens_solicitação.AutoGenerateColumns = false;
            this.Grid_view_itens_solicitação.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_view_itens_solicitação.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_view_itens_solicitação.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_view_itens_solicitação.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_view_itens_solicitação.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid_view_itens_solicitação.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_view_itens_solicitação.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.productNameDataGridViewTextBoxColumn1,
            this.quantidadeSolicitadaDataGridViewTextBoxColumn,
            this.quantidadeAprovadaDataGridViewTextBoxColumn,
            this.quantidadeEstoqueDataGridViewTextBoxColumn,
            this.solicitationIdDataGridViewTextBoxColumn1,
            this.solicitationItemIdDataGridViewTextBoxColumn1});
            this.Grid_view_itens_solicitação.DataSource = this.returnItensSolicitacoesBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_view_itens_solicitação.DefaultCellStyle = dataGridViewCellStyle5;
            this.Grid_view_itens_solicitação.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.Grid_view_itens_solicitação, "Grid_view_itens_solicitação");
            this.Grid_view_itens_solicitação.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_view_itens_solicitação.Name = "Grid_view_itens_solicitação";
            this.Grid_view_itens_solicitação.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_view_itens_solicitação.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid_view_itens_solicitação.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_view_itens_solicitação.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            resources.ApplyResources(this.ProductId, "ProductId");
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            this.productNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            resources.ApplyResources(this.productNameDataGridViewTextBoxColumn1, "productNameDataGridViewTextBoxColumn1");
            this.productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            this.productNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantidadeSolicitadaDataGridViewTextBoxColumn
            // 
            this.quantidadeSolicitadaDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeSolicitada";
            resources.ApplyResources(this.quantidadeSolicitadaDataGridViewTextBoxColumn, "quantidadeSolicitadaDataGridViewTextBoxColumn");
            this.quantidadeSolicitadaDataGridViewTextBoxColumn.Name = "quantidadeSolicitadaDataGridViewTextBoxColumn";
            this.quantidadeSolicitadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeAprovadaDataGridViewTextBoxColumn
            // 
            this.quantidadeAprovadaDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeAprovada";
            resources.ApplyResources(this.quantidadeAprovadaDataGridViewTextBoxColumn, "quantidadeAprovadaDataGridViewTextBoxColumn");
            this.quantidadeAprovadaDataGridViewTextBoxColumn.Name = "quantidadeAprovadaDataGridViewTextBoxColumn";
            this.quantidadeAprovadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeEstoqueDataGridViewTextBoxColumn
            // 
            this.quantidadeEstoqueDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeEstoque";
            resources.ApplyResources(this.quantidadeEstoqueDataGridViewTextBoxColumn, "quantidadeEstoqueDataGridViewTextBoxColumn");
            this.quantidadeEstoqueDataGridViewTextBoxColumn.Name = "quantidadeEstoqueDataGridViewTextBoxColumn";
            this.quantidadeEstoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solicitationIdDataGridViewTextBoxColumn1
            // 
            this.solicitationIdDataGridViewTextBoxColumn1.DataPropertyName = "SolicitationId";
            resources.ApplyResources(this.solicitationIdDataGridViewTextBoxColumn1, "solicitationIdDataGridViewTextBoxColumn1");
            this.solicitationIdDataGridViewTextBoxColumn1.Name = "solicitationIdDataGridViewTextBoxColumn1";
            this.solicitationIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // solicitationItemIdDataGridViewTextBoxColumn1
            // 
            this.solicitationItemIdDataGridViewTextBoxColumn1.DataPropertyName = "SolicitationItemId";
            resources.ApplyResources(this.solicitationItemIdDataGridViewTextBoxColumn1, "solicitationItemIdDataGridViewTextBoxColumn1");
            this.solicitationItemIdDataGridViewTextBoxColumn1.Name = "solicitationItemIdDataGridViewTextBoxColumn1";
            this.solicitationItemIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // returnItensSolicitacoesBindingSource1
            // 
            this.returnItensSolicitacoesBindingSource1.DataSource = typeof(Request_System.returnItensSolicitacoes);
            // 
            // CBX_Status_Solicitacao
            // 
            resources.ApplyResources(this.CBX_Status_Solicitacao, "CBX_Status_Solicitacao");
            this.CBX_Status_Solicitacao.FormattingEnabled = true;
            this.CBX_Status_Solicitacao.Name = "CBX_Status_Solicitacao";
            this.CBX_Status_Solicitacao.UseSelectable = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DT_Data_solicitacao
            // 
            resources.ApplyResources(this.DT_Data_solicitacao, "DT_Data_solicitacao");
            this.DT_Data_solicitacao.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DT_Data_solicitacao.Name = "DT_Data_solicitacao";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // DT_Data_Aprovacao
            // 
            resources.ApplyResources(this.DT_Data_Aprovacao, "DT_Data_Aprovacao");
            this.DT_Data_Aprovacao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DT_Data_Aprovacao.Name = "DT_Data_Aprovacao";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // DT_Data_Entrega
            // 
            resources.ApplyResources(this.DT_Data_Entrega, "DT_Data_Entrega");
            this.DT_Data_Entrega.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DT_Data_Entrega.Name = "DT_Data_Entrega";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // BTN_Aprovar
            // 
            resources.ApplyResources(this.BTN_Aprovar, "BTN_Aprovar");
            this.BTN_Aprovar.Name = "BTN_Aprovar";
            this.BTN_Aprovar.UseSelectable = true;
            this.BTN_Aprovar.Click += new System.EventHandler(this.BTN_Aprovar_Click);
            // 
            // BTN_Rejeitar
            // 
            resources.ApplyResources(this.BTN_Rejeitar, "BTN_Rejeitar");
            this.BTN_Rejeitar.Name = "BTN_Rejeitar";
            this.BTN_Rejeitar.UseSelectable = true;
            this.BTN_Rejeitar.Click += new System.EventHandler(this.BTN_Rejeitar_Click);
            // 
            // BTN_Entregar
            // 
            resources.ApplyResources(this.BTN_Entregar, "BTN_Entregar");
            this.BTN_Entregar.Name = "BTN_Entregar";
            this.BTN_Entregar.UseSelectable = true;
            this.BTN_Entregar.Click += new System.EventHandler(this.BTN_Entregar_Click);
            // 
            // BTN_Editar
            // 
            resources.ApplyResources(this.BTN_Editar, "BTN_Editar");
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.UseSelectable = true;
            this.BTN_Editar.Click += new System.EventHandler(this.BTN_Editar_Click);
            // 
            // GB_DataAprovacao
            // 
            this.GB_DataAprovacao.Controls.Add(this.DT_Data_Aprovacao);
            this.GB_DataAprovacao.Controls.Add(this.label3);
            resources.ApplyResources(this.GB_DataAprovacao, "GB_DataAprovacao");
            this.GB_DataAprovacao.Name = "GB_DataAprovacao";
            this.GB_DataAprovacao.TabStop = false;
            // 
            // GB_DataEntrega
            // 
            this.GB_DataEntrega.Controls.Add(this.label4);
            this.GB_DataEntrega.Controls.Add(this.DT_Data_Entrega);
            resources.ApplyResources(this.GB_DataEntrega, "GB_DataEntrega");
            this.GB_DataEntrega.Name = "GB_DataEntrega";
            this.GB_DataEntrega.TabStop = false;
            // 
            // TXT_UsuarioSolicitante
            // 
            // 
            // 
            // 
            this.TXT_UsuarioSolicitante.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.TXT_UsuarioSolicitante.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.TXT_UsuarioSolicitante.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.TXT_UsuarioSolicitante.CustomButton.Name = "";
            this.TXT_UsuarioSolicitante.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.TXT_UsuarioSolicitante.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_UsuarioSolicitante.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.TXT_UsuarioSolicitante.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_UsuarioSolicitante.CustomButton.UseSelectable = true;
            this.TXT_UsuarioSolicitante.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            resources.ApplyResources(this.TXT_UsuarioSolicitante, "TXT_UsuarioSolicitante");
            this.TXT_UsuarioSolicitante.Lines = new string[0];
            this.TXT_UsuarioSolicitante.MaxLength = 32767;
            this.TXT_UsuarioSolicitante.Name = "TXT_UsuarioSolicitante";
            this.TXT_UsuarioSolicitante.PasswordChar = '\0';
            this.TXT_UsuarioSolicitante.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_UsuarioSolicitante.SelectedText = "";
            this.TXT_UsuarioSolicitante.SelectionLength = 0;
            this.TXT_UsuarioSolicitante.SelectionStart = 0;
            this.TXT_UsuarioSolicitante.ShortcutsEnabled = true;
            this.TXT_UsuarioSolicitante.UseSelectable = true;
            this.TXT_UsuarioSolicitante.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_UsuarioSolicitante.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // TXT_Motivo
            // 
            // 
            // 
            // 
            this.TXT_Motivo.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.TXT_Motivo.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.TXT_Motivo.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.TXT_Motivo.CustomButton.Name = "";
            this.TXT_Motivo.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.TXT_Motivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Motivo.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.TXT_Motivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Motivo.CustomButton.UseSelectable = true;
            this.TXT_Motivo.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            resources.ApplyResources(this.TXT_Motivo, "TXT_Motivo");
            this.TXT_Motivo.Lines = new string[0];
            this.TXT_Motivo.MaxLength = 32767;
            this.TXT_Motivo.Name = "TXT_Motivo";
            this.TXT_Motivo.PasswordChar = '\0';
            this.TXT_Motivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Motivo.SelectedText = "";
            this.TXT_Motivo.SelectionLength = 0;
            this.TXT_Motivo.SelectionStart = 0;
            this.TXT_Motivo.ShortcutsEnabled = true;
            this.TXT_Motivo.UseSelectable = true;
            this.TXT_Motivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Motivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTN_Fechar_tela
            // 
            this.BTN_Fechar_tela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BTN_Fechar_tela, "BTN_Fechar_tela");
            this.BTN_Fechar_tela.Name = "BTN_Fechar_tela";
            this.BTN_Fechar_tela.UseSelectable = true;
            this.BTN_Fechar_tela.Click += new System.EventHandler(this.BTN_Fechar_Click);
            // 
            // GB_valida_usuario
            // 
            this.GB_valida_usuario.Controls.Add(this.TXT_user_name);
            this.GB_valida_usuario.Controls.Add(this.TXT_Pass);
            this.GB_valida_usuario.Controls.Add(this.BTN_Assinar_Entrega);
            this.GB_valida_usuario.Controls.Add(this.BTN_Cancelar_Login);
            this.GB_valida_usuario.Controls.Add(this.label7);
            this.GB_valida_usuario.Controls.Add(this.label8);
            resources.ApplyResources(this.GB_valida_usuario, "GB_valida_usuario");
            this.GB_valida_usuario.Name = "GB_valida_usuario";
            this.GB_valida_usuario.TabStop = false;
            // 
            // TXT_user_name
            // 
            resources.ApplyResources(this.TXT_user_name, "TXT_user_name");
            this.TXT_user_name.Name = "TXT_user_name";
            this.TXT_user_name.ReadOnly = true;
            // 
            // TXT_Pass
            // 
            resources.ApplyResources(this.TXT_Pass, "TXT_Pass");
            this.TXT_Pass.Name = "TXT_Pass";
            this.TXT_Pass.Enter += new System.EventHandler(this.TXT_Pass_Enter);
            this.TXT_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Pass_KeyDown);
            this.TXT_Pass.Leave += new System.EventHandler(this.TXT_Pass_Leave);
            // 
            // BTN_Assinar_Entrega
            // 
            resources.ApplyResources(this.BTN_Assinar_Entrega, "BTN_Assinar_Entrega");
            this.BTN_Assinar_Entrega.Name = "BTN_Assinar_Entrega";
            this.BTN_Assinar_Entrega.UseSelectable = true;
            this.BTN_Assinar_Entrega.Click += new System.EventHandler(this.BTN_Assinar_Entrega_Click);
            // 
            // BTN_Cancelar_Login
            // 
            resources.ApplyResources(this.BTN_Cancelar_Login, "BTN_Cancelar_Login");
            this.BTN_Cancelar_Login.Name = "BTN_Cancelar_Login";
            this.BTN_Cancelar_Login.UseSelectable = true;
            this.BTN_Cancelar_Login.Click += new System.EventHandler(this.BTN_Cancelar_Login_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // GB_Editar_QTD_Itens
            // 
            this.GB_Editar_QTD_Itens.Controls.Add(this.BTN_Cancel_QTD);
            this.GB_Editar_QTD_Itens.Controls.Add(this.TXT_QTD_Aprovada);
            this.GB_Editar_QTD_Itens.Controls.Add(this.label9);
            this.GB_Editar_QTD_Itens.Controls.Add(this.label10);
            this.GB_Editar_QTD_Itens.Controls.Add(this.label11);
            this.GB_Editar_QTD_Itens.Controls.Add(this.TXT_qtd_solicitada);
            this.GB_Editar_QTD_Itens.Controls.Add(this.TXT_Produto);
            this.GB_Editar_QTD_Itens.Controls.Add(this.BTN_Salvar_QTD);
            resources.ApplyResources(this.GB_Editar_QTD_Itens, "GB_Editar_QTD_Itens");
            this.GB_Editar_QTD_Itens.Name = "GB_Editar_QTD_Itens";
            this.GB_Editar_QTD_Itens.TabStop = false;
            // 
            // BTN_Cancel_QTD
            // 
            resources.ApplyResources(this.BTN_Cancel_QTD, "BTN_Cancel_QTD");
            this.BTN_Cancel_QTD.Name = "BTN_Cancel_QTD";
            this.BTN_Cancel_QTD.UseSelectable = true;
            this.BTN_Cancel_QTD.Click += new System.EventHandler(this.BTN_Cancel_QTD_Click);
            // 
            // TXT_QTD_Aprovada
            // 
            resources.ApplyResources(this.TXT_QTD_Aprovada, "TXT_QTD_Aprovada");
            this.TXT_QTD_Aprovada.Name = "TXT_QTD_Aprovada";
            this.TXT_QTD_Aprovada.Enter += new System.EventHandler(this.TXT_QTD_Aprovada_Enter);
            this.TXT_QTD_Aprovada.Leave += new System.EventHandler(this.TXT_QTD_Aprovada_Leave);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // TXT_qtd_solicitada
            // 
            // 
            // 
            // 
            this.TXT_qtd_solicitada.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.TXT_qtd_solicitada.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.TXT_qtd_solicitada.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.TXT_qtd_solicitada.CustomButton.Name = "";
            this.TXT_qtd_solicitada.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.TXT_qtd_solicitada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_qtd_solicitada.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.TXT_qtd_solicitada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_qtd_solicitada.CustomButton.UseSelectable = true;
            this.TXT_qtd_solicitada.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            resources.ApplyResources(this.TXT_qtd_solicitada, "TXT_qtd_solicitada");
            this.TXT_qtd_solicitada.Lines = new string[0];
            this.TXT_qtd_solicitada.MaxLength = 32767;
            this.TXT_qtd_solicitada.Name = "TXT_qtd_solicitada";
            this.TXT_qtd_solicitada.PasswordChar = '\0';
            this.TXT_qtd_solicitada.ReadOnly = true;
            this.TXT_qtd_solicitada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_qtd_solicitada.SelectedText = "";
            this.TXT_qtd_solicitada.SelectionLength = 0;
            this.TXT_qtd_solicitada.SelectionStart = 0;
            this.TXT_qtd_solicitada.ShortcutsEnabled = true;
            this.TXT_qtd_solicitada.UseSelectable = true;
            this.TXT_qtd_solicitada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_qtd_solicitada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TXT_Produto
            // 
            // 
            // 
            // 
            this.TXT_Produto.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.TXT_Produto.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.TXT_Produto.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.TXT_Produto.CustomButton.Name = "";
            this.TXT_Produto.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.TXT_Produto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Produto.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.TXT_Produto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Produto.CustomButton.UseSelectable = true;
            this.TXT_Produto.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            resources.ApplyResources(this.TXT_Produto, "TXT_Produto");
            this.TXT_Produto.Lines = new string[0];
            this.TXT_Produto.MaxLength = 32767;
            this.TXT_Produto.Name = "TXT_Produto";
            this.TXT_Produto.PasswordChar = '\0';
            this.TXT_Produto.ReadOnly = true;
            this.TXT_Produto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Produto.SelectedText = "";
            this.TXT_Produto.SelectionLength = 0;
            this.TXT_Produto.SelectionStart = 0;
            this.TXT_Produto.ShortcutsEnabled = true;
            this.TXT_Produto.UseSelectable = true;
            this.TXT_Produto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Produto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTN_Salvar_QTD
            // 
            resources.ApplyResources(this.BTN_Salvar_QTD, "BTN_Salvar_QTD");
            this.BTN_Salvar_QTD.Name = "BTN_Salvar_QTD";
            this.BTN_Salvar_QTD.UseSelectable = true;
            this.BTN_Salvar_QTD.Click += new System.EventHandler(this.BTN_Salvar_QTD_Click);
            // 
            // solicitationIdDataGridViewTextBoxColumn
            // 
            this.solicitationIdDataGridViewTextBoxColumn.DataPropertyName = "SolicitationId";
            resources.ApplyResources(this.solicitationIdDataGridViewTextBoxColumn, "solicitationIdDataGridViewTextBoxColumn");
            this.solicitationIdDataGridViewTextBoxColumn.Name = "solicitationIdDataGridViewTextBoxColumn";
            this.solicitationIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solicitationItemIdDataGridViewTextBoxColumn
            // 
            this.solicitationItemIdDataGridViewTextBoxColumn.DataPropertyName = "SolicitationItemId";
            resources.ApplyResources(this.solicitationItemIdDataGridViewTextBoxColumn, "solicitationItemIdDataGridViewTextBoxColumn");
            this.solicitationItemIdDataGridViewTextBoxColumn.Name = "solicitationItemIdDataGridViewTextBoxColumn";
            this.solicitationItemIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            resources.ApplyResources(this.productNameDataGridViewTextBoxColumn, "productNameDataGridViewTextBoxColumn");
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnItensSolicitacoesBindingSource
            // 
            this.returnItensSolicitacoesBindingSource.DataSource = typeof(Request_System.returnItensSolicitacoes);
            // 
            // PageEditSolicitacoes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Fechar_tela;
            this.ControlBox = false;
            this.Controls.Add(this.GB_Editar_QTD_Itens);
            this.Controls.Add(this.GB_valida_usuario);
            this.Controls.Add(this.BTN_Fechar_tela);
            this.Controls.Add(this.GB_DataEntrega);
            this.Controls.Add(this.GB_DataAprovacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXT_Motivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_UsuarioSolicitante);
            this.Controls.Add(this.BTN_Aprovar);
            this.Controls.Add(this.BTN_Rejeitar);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.BTN_Entregar);
            this.Controls.Add(this.DT_Data_solicitacao);
            this.Controls.Add(this.CBX_Status_Solicitacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_view_itens_solicitação);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PageEditSolicitacoes";
            this.Load += new System.EventHandler(this.PageEditSolicitacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_view_itens_solicitação)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItensSolicitacoesBindingSource1)).EndInit();
            this.GB_DataAprovacao.ResumeLayout(false);
            this.GB_DataAprovacao.PerformLayout();
            this.GB_DataEntrega.ResumeLayout(false);
            this.GB_DataEntrega.PerformLayout();
            this.GB_valida_usuario.ResumeLayout(false);
            this.GB_valida_usuario.PerformLayout();
            this.GB_Editar_QTD_Itens.ResumeLayout(false);
            this.GB_Editar_QTD_Itens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_QTD_Aprovada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItensSolicitacoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid Grid_view_itens_solicitação;
        private System.Windows.Forms.BindingSource returnItensSolicitacoesBindingSource;
        private MetroFramework.Controls.MetroComboBox CBX_Status_Solicitacao;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime DT_Data_solicitacao;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime DT_Data_Aprovacao;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroDateTime DT_Data_Entrega;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton BTN_Aprovar;
        private MetroFramework.Controls.MetroButton BTN_Rejeitar;
        private MetroFramework.Controls.MetroButton BTN_Entregar;
        private MetroFramework.Controls.MetroButton BTN_Editar;
        private System.Windows.Forms.GroupBox GB_DataAprovacao;
        private System.Windows.Forms.GroupBox GB_DataEntrega;
        private MetroFramework.Controls.MetroTextBox TXT_UsuarioSolicitante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox TXT_Motivo;
        private MetroFramework.Controls.MetroButton BTN_Fechar_tela;
        private System.Windows.Forms.BindingSource returnItensSolicitacoesBindingSource1;
        private System.Windows.Forms.GroupBox GB_valida_usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GB_Editar_QTD_Itens;
        private System.Windows.Forms.NumericUpDown TXT_QTD_Aprovada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTextBox TXT_qtd_solicitada;
        private MetroFramework.Controls.MetroTextBox TXT_Produto;
        private MetroFramework.Controls.MetroButton BTN_Salvar_QTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitationItemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton BTN_Cancel_QTD;
        private MetroFramework.Controls.MetroButton BTN_Cancelar_Login;
        private MetroFramework.Controls.MetroButton BTN_Assinar_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeSolicitadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeAprovadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitationIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitationItemIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox TXT_user_name;
        private System.Windows.Forms.TextBox TXT_Pass;
    }
}