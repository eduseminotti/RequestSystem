namespace Request_System
{
    partial class Solicitacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitacoes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBL_Usuarios = new System.Windows.Forms.Label();
            this.BTN_Ver_Solicitacao = new MetroFramework.Controls.MetroButton();
            this.GRID_View_Solicitacoes = new MetroFramework.Controls.MetroGrid();
            this.SolicitatonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRequesterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSolicitacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserApproverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAprovacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRetiradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitationStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRequesterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnSolicitacoesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GB_filtros = new System.Windows.Forms.GroupBox();
            this.CBX_Filtro_Status = new System.Windows.Forms.ComboBox();
            this.TXT_Filtro_Nome = new System.Windows.Forms.TextBox();
            this.BTN_Filtrar = new MetroFramework.Controls.MetroButton();
            this.BTN_LIMPAR_FILTRO = new MetroFramework.Controls.MetroButton();
            this.Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Gera_PDF = new MetroFramework.Controls.MetroButton();
            this.GRID_Relatorio_Solicitacoes = new System.Windows.Forms.DataGridView();
            this.userRequesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSolicitacaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userApproverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAprovacaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRetiradaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitationStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosQuantidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnRelatorioSolicitacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnSolicitacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_View_Solicitacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnSolicitacoesBindingSource1)).BeginInit();
            this.GB_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Relatorio_Solicitacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnRelatorioSolicitacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnSolicitacoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Usuarios
            // 
            resources.ApplyResources(this.LBL_Usuarios, "LBL_Usuarios");
            this.LBL_Usuarios.Name = "LBL_Usuarios";
            // 
            // BTN_Ver_Solicitacao
            // 
            resources.ApplyResources(this.BTN_Ver_Solicitacao, "BTN_Ver_Solicitacao");
            this.BTN_Ver_Solicitacao.Name = "BTN_Ver_Solicitacao";
            this.BTN_Ver_Solicitacao.UseSelectable = true;
            this.BTN_Ver_Solicitacao.Click += new System.EventHandler(this.BTN_Ver_Solicitacao_Click);
            // 
            // GRID_View_Solicitacoes
            // 
            this.GRID_View_Solicitacoes.AllowUserToResizeRows = false;
            this.GRID_View_Solicitacoes.AutoGenerateColumns = false;
            this.GRID_View_Solicitacoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRID_View_Solicitacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRID_View_Solicitacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRID_View_Solicitacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_View_Solicitacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GRID_View_Solicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_View_Solicitacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SolicitatonId,
            this.UserRequesterName,
            this.dataSolicitacaoDataGridViewTextBoxColumn,
            this.UserApproverName,
            this.dataAprovacaoDataGridViewTextBoxColumn,
            this.dataRetiradaDataGridViewTextBoxColumn,
            this.solicitationStatusDataGridViewTextBoxColumn,
            this.UserRequesterId});
            this.GRID_View_Solicitacoes.DataSource = this.returnSolicitacoesBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_View_Solicitacoes.DefaultCellStyle = dataGridViewCellStyle5;
            this.GRID_View_Solicitacoes.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.GRID_View_Solicitacoes, "GRID_View_Solicitacoes");
            this.GRID_View_Solicitacoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRID_View_Solicitacoes.Name = "GRID_View_Solicitacoes";
            this.GRID_View_Solicitacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_View_Solicitacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GRID_View_Solicitacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GRID_View_Solicitacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_View_Solicitacoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_View_Solicitacoes_CellDoubleClick);
            // 
            // SolicitatonId
            // 
            this.SolicitatonId.DataPropertyName = "SolicitatonId";
            resources.ApplyResources(this.SolicitatonId, "SolicitatonId");
            this.SolicitatonId.Name = "SolicitatonId";
            this.SolicitatonId.ReadOnly = true;
            // 
            // UserRequesterName
            // 
            this.UserRequesterName.DataPropertyName = "UserRequesterName";
            resources.ApplyResources(this.UserRequesterName, "UserRequesterName");
            this.UserRequesterName.Name = "UserRequesterName";
            this.UserRequesterName.ReadOnly = true;
            // 
            // dataSolicitacaoDataGridViewTextBoxColumn
            // 
            this.dataSolicitacaoDataGridViewTextBoxColumn.DataPropertyName = "DataSolicitacao";
            resources.ApplyResources(this.dataSolicitacaoDataGridViewTextBoxColumn, "dataSolicitacaoDataGridViewTextBoxColumn");
            this.dataSolicitacaoDataGridViewTextBoxColumn.Name = "dataSolicitacaoDataGridViewTextBoxColumn";
            this.dataSolicitacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UserApproverName
            // 
            this.UserApproverName.DataPropertyName = "UserApproverName";
            resources.ApplyResources(this.UserApproverName, "UserApproverName");
            this.UserApproverName.Name = "UserApproverName";
            this.UserApproverName.ReadOnly = true;
            // 
            // dataAprovacaoDataGridViewTextBoxColumn
            // 
            this.dataAprovacaoDataGridViewTextBoxColumn.DataPropertyName = "DataAprovacao";
            resources.ApplyResources(this.dataAprovacaoDataGridViewTextBoxColumn, "dataAprovacaoDataGridViewTextBoxColumn");
            this.dataAprovacaoDataGridViewTextBoxColumn.Name = "dataAprovacaoDataGridViewTextBoxColumn";
            this.dataAprovacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRetiradaDataGridViewTextBoxColumn
            // 
            this.dataRetiradaDataGridViewTextBoxColumn.DataPropertyName = "DataRetirada";
            resources.ApplyResources(this.dataRetiradaDataGridViewTextBoxColumn, "dataRetiradaDataGridViewTextBoxColumn");
            this.dataRetiradaDataGridViewTextBoxColumn.Name = "dataRetiradaDataGridViewTextBoxColumn";
            this.dataRetiradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solicitationStatusDataGridViewTextBoxColumn
            // 
            this.solicitationStatusDataGridViewTextBoxColumn.DataPropertyName = "SolicitationStatus";
            resources.ApplyResources(this.solicitationStatusDataGridViewTextBoxColumn, "solicitationStatusDataGridViewTextBoxColumn");
            this.solicitationStatusDataGridViewTextBoxColumn.Name = "solicitationStatusDataGridViewTextBoxColumn";
            this.solicitationStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UserRequesterId
            // 
            this.UserRequesterId.DataPropertyName = "UserRequesterId";
            resources.ApplyResources(this.UserRequesterId, "UserRequesterId");
            this.UserRequesterId.Name = "UserRequesterId";
            // 
            // returnSolicitacoesBindingSource1
            // 
            this.returnSolicitacoesBindingSource1.DataSource = typeof(Request_System.ReturnSolicitacoesStockMan);
            // 
            // GB_filtros
            // 
            this.GB_filtros.Controls.Add(this.CBX_Filtro_Status);
            this.GB_filtros.Controls.Add(this.TXT_Filtro_Nome);
            this.GB_filtros.Controls.Add(this.BTN_Filtrar);
            this.GB_filtros.Controls.Add(this.BTN_LIMPAR_FILTRO);
            this.GB_filtros.Controls.Add(this.Status);
            this.GB_filtros.Controls.Add(this.label1);
            resources.ApplyResources(this.GB_filtros, "GB_filtros");
            this.GB_filtros.Name = "GB_filtros";
            this.GB_filtros.TabStop = false;
            // 
            // CBX_Filtro_Status
            // 
            this.CBX_Filtro_Status.FormattingEnabled = true;
            resources.ApplyResources(this.CBX_Filtro_Status, "CBX_Filtro_Status");
            this.CBX_Filtro_Status.Name = "CBX_Filtro_Status";
            this.CBX_Filtro_Status.SelectedIndexChanged += new System.EventHandler(this.CBX_Filtro_Status_SelectedIndexChanged_1);
            this.CBX_Filtro_Status.Enter += new System.EventHandler(this.CBX_Filtro_Status_Enter);
            this.CBX_Filtro_Status.Leave += new System.EventHandler(this.CBX_Filtro_Status_Leave);
            // 
            // TXT_Filtro_Nome
            // 
            resources.ApplyResources(this.TXT_Filtro_Nome, "TXT_Filtro_Nome");
            this.TXT_Filtro_Nome.Name = "TXT_Filtro_Nome";
            this.TXT_Filtro_Nome.TextChanged += new System.EventHandler(this.TXT_Filtro_Nome_TextChanged_1);
            this.TXT_Filtro_Nome.Enter += new System.EventHandler(this.TXT_Filtro_Nome_Enter);
            this.TXT_Filtro_Nome.Leave += new System.EventHandler(this.TXT_Filtro_Nome_Leave);
            // 
            // BTN_Filtrar
            // 
            resources.ApplyResources(this.BTN_Filtrar, "BTN_Filtrar");
            this.BTN_Filtrar.Name = "BTN_Filtrar";
            this.BTN_Filtrar.UseSelectable = true;
            this.BTN_Filtrar.Click += new System.EventHandler(this.BTN_Filtrar_Click);
            // 
            // BTN_LIMPAR_FILTRO
            // 
            resources.ApplyResources(this.BTN_LIMPAR_FILTRO, "BTN_LIMPAR_FILTRO");
            this.BTN_LIMPAR_FILTRO.Name = "BTN_LIMPAR_FILTRO";
            this.BTN_LIMPAR_FILTRO.UseSelectable = true;
            this.BTN_LIMPAR_FILTRO.Click += new System.EventHandler(this.BTN_LIMPAR_FILTRO_Click);
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BTN_Gera_PDF
            // 
            resources.ApplyResources(this.BTN_Gera_PDF, "BTN_Gera_PDF");
            this.BTN_Gera_PDF.Name = "BTN_Gera_PDF";
            this.BTN_Gera_PDF.UseSelectable = true;
            this.BTN_Gera_PDF.Click += new System.EventHandler(this.BTN_Gera_PDF_Click);
            // 
            // GRID_Relatorio_Solicitacoes
            // 
            this.GRID_Relatorio_Solicitacoes.AutoGenerateColumns = false;
            this.GRID_Relatorio_Solicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Relatorio_Solicitacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userRequesterDataGridViewTextBoxColumn,
            this.dataSolicitacaoDataGridViewTextBoxColumn1,
            this.userApproverDataGridViewTextBoxColumn,
            this.dataAprovacaoDataGridViewTextBoxColumn1,
            this.dataRetiradaDataGridViewTextBoxColumn1,
            this.motivoDataGridViewTextBoxColumn,
            this.solicitationStatusDataGridViewTextBoxColumn1,
            this.produtosQuantidadesDataGridViewTextBoxColumn});
            this.GRID_Relatorio_Solicitacoes.DataSource = this.returnRelatorioSolicitacoesBindingSource;
            resources.ApplyResources(this.GRID_Relatorio_Solicitacoes, "GRID_Relatorio_Solicitacoes");
            this.GRID_Relatorio_Solicitacoes.Name = "GRID_Relatorio_Solicitacoes";
            // 
            // userRequesterDataGridViewTextBoxColumn
            // 
            this.userRequesterDataGridViewTextBoxColumn.DataPropertyName = "UserRequester";
            resources.ApplyResources(this.userRequesterDataGridViewTextBoxColumn, "userRequesterDataGridViewTextBoxColumn");
            this.userRequesterDataGridViewTextBoxColumn.Name = "userRequesterDataGridViewTextBoxColumn";
            // 
            // dataSolicitacaoDataGridViewTextBoxColumn1
            // 
            this.dataSolicitacaoDataGridViewTextBoxColumn1.DataPropertyName = "DataSolicitacao";
            resources.ApplyResources(this.dataSolicitacaoDataGridViewTextBoxColumn1, "dataSolicitacaoDataGridViewTextBoxColumn1");
            this.dataSolicitacaoDataGridViewTextBoxColumn1.Name = "dataSolicitacaoDataGridViewTextBoxColumn1";
            // 
            // userApproverDataGridViewTextBoxColumn
            // 
            this.userApproverDataGridViewTextBoxColumn.DataPropertyName = "UserApprover";
            resources.ApplyResources(this.userApproverDataGridViewTextBoxColumn, "userApproverDataGridViewTextBoxColumn");
            this.userApproverDataGridViewTextBoxColumn.Name = "userApproverDataGridViewTextBoxColumn";
            // 
            // dataAprovacaoDataGridViewTextBoxColumn1
            // 
            this.dataAprovacaoDataGridViewTextBoxColumn1.DataPropertyName = "DataAprovacao";
            resources.ApplyResources(this.dataAprovacaoDataGridViewTextBoxColumn1, "dataAprovacaoDataGridViewTextBoxColumn1");
            this.dataAprovacaoDataGridViewTextBoxColumn1.Name = "dataAprovacaoDataGridViewTextBoxColumn1";
            // 
            // dataRetiradaDataGridViewTextBoxColumn1
            // 
            this.dataRetiradaDataGridViewTextBoxColumn1.DataPropertyName = "DataRetirada";
            resources.ApplyResources(this.dataRetiradaDataGridViewTextBoxColumn1, "dataRetiradaDataGridViewTextBoxColumn1");
            this.dataRetiradaDataGridViewTextBoxColumn1.Name = "dataRetiradaDataGridViewTextBoxColumn1";
            // 
            // motivoDataGridViewTextBoxColumn
            // 
            this.motivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo";
            resources.ApplyResources(this.motivoDataGridViewTextBoxColumn, "motivoDataGridViewTextBoxColumn");
            this.motivoDataGridViewTextBoxColumn.Name = "motivoDataGridViewTextBoxColumn";
            // 
            // solicitationStatusDataGridViewTextBoxColumn1
            // 
            this.solicitationStatusDataGridViewTextBoxColumn1.DataPropertyName = "SolicitationStatus";
            resources.ApplyResources(this.solicitationStatusDataGridViewTextBoxColumn1, "solicitationStatusDataGridViewTextBoxColumn1");
            this.solicitationStatusDataGridViewTextBoxColumn1.Name = "solicitationStatusDataGridViewTextBoxColumn1";
            // 
            // produtosQuantidadesDataGridViewTextBoxColumn
            // 
            this.produtosQuantidadesDataGridViewTextBoxColumn.DataPropertyName = "ProdutosQuantidades";
            resources.ApplyResources(this.produtosQuantidadesDataGridViewTextBoxColumn, "produtosQuantidadesDataGridViewTextBoxColumn");
            this.produtosQuantidadesDataGridViewTextBoxColumn.Name = "produtosQuantidadesDataGridViewTextBoxColumn";
            // 
            // returnRelatorioSolicitacoesBindingSource
            // 
            this.returnRelatorioSolicitacoesBindingSource.DataSource = typeof(Request_System.ReturnRelatorioSolicitacoes);
            // 
            // returnSolicitacoesBindingSource
            // 
            this.returnSolicitacoesBindingSource.DataSource = typeof(Request_System.ReturnSolicitacoesStockMan);
            // 
            // Solicitacoes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GRID_Relatorio_Solicitacoes);
            this.Controls.Add(this.BTN_Gera_PDF);
            this.Controls.Add(this.GB_filtros);
            this.Controls.Add(this.GRID_View_Solicitacoes);
            this.Controls.Add(this.BTN_Ver_Solicitacao);
            this.Controls.Add(this.LBL_Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Solicitacoes";
            ((System.ComponentModel.ISupportInitialize)(this.GRID_View_Solicitacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnSolicitacoesBindingSource1)).EndInit();
            this.GB_filtros.ResumeLayout(false);
            this.GB_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Relatorio_Solicitacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnRelatorioSolicitacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnSolicitacoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Usuarios;
        private MetroFramework.Controls.MetroButton BTN_Ver_Solicitacao;
        private MetroFramework.Controls.MetroGrid GRID_View_Solicitacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitatonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource returnSolicitacoesBindingSource;
        private System.Windows.Forms.BindingSource returnSolicitacoesBindingSource1;
        private System.Windows.Forms.GroupBox GB_filtros;
        private MetroFramework.Controls.MetroButton BTN_Filtrar;
        private MetroFramework.Controls.MetroButton BTN_LIMPAR_FILTRO;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolicitatonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRequesterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSolicitacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserApproverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAprovacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRetiradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitationStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRequesterId;
        private MetroFramework.Controls.MetroButton BTN_Gera_PDF;
        private System.Windows.Forms.DataGridView GRID_Relatorio_Solicitacoes;
        private System.Windows.Forms.BindingSource returnRelatorioSolicitacoesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRequesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSolicitacaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userApproverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAprovacaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRetiradaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitationStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosQuantidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TXT_Filtro_Nome;
        private System.Windows.Forms.ComboBox CBX_Filtro_Status;
    }
}