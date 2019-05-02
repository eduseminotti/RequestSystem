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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BTN_Filtrar = new MetroFramework.Controls.MetroButton();
            this.BTN_LIMPAR_FILTRO = new MetroFramework.Controls.MetroButton();
            this.Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Filtro_Nome = new MetroFramework.Controls.MetroTextBox();
            this.CBX_Filtro_Status = new MetroFramework.Controls.MetroComboBox();
            this.returnSolicitacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_Gerar_PDF = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_View_Solicitacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnSolicitacoesBindingSource1)).BeginInit();
            this.GB_filtros.SuspendLayout();
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
            resources.ApplyResources(this.GRID_View_Solicitacoes, "GRID_View_Solicitacoes");
            this.GRID_View_Solicitacoes.AllowUserToResizeRows = false;
            this.GRID_View_Solicitacoes.AutoGenerateColumns = false;
            this.GRID_View_Solicitacoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRID_View_Solicitacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRID_View_Solicitacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRID_View_Solicitacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_View_Solicitacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_View_Solicitacoes.DefaultCellStyle = dataGridViewCellStyle2;
            this.GRID_View_Solicitacoes.EnableHeadersVisualStyles = false;
            this.GRID_View_Solicitacoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRID_View_Solicitacoes.Name = "GRID_View_Solicitacoes";
            this.GRID_View_Solicitacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_View_Solicitacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GRID_View_Solicitacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GRID_View_Solicitacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            resources.ApplyResources(this.GB_filtros, "GB_filtros");
            this.GB_filtros.Controls.Add(this.BTN_Filtrar);
            this.GB_filtros.Controls.Add(this.BTN_LIMPAR_FILTRO);
            this.GB_filtros.Controls.Add(this.Status);
            this.GB_filtros.Controls.Add(this.label1);
            this.GB_filtros.Controls.Add(this.TXT_Filtro_Nome);
            this.GB_filtros.Controls.Add(this.CBX_Filtro_Status);
            this.GB_filtros.Name = "GB_filtros";
            this.GB_filtros.TabStop = false;
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
            // TXT_Filtro_Nome
            // 
            resources.ApplyResources(this.TXT_Filtro_Nome, "TXT_Filtro_Nome");
            // 
            // 
            // 
            this.TXT_Filtro_Nome.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.TXT_Filtro_Nome.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.TXT_Filtro_Nome.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.TXT_Filtro_Nome.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.TXT_Filtro_Nome.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.TXT_Filtro_Nome.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.TXT_Filtro_Nome.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.TXT_Filtro_Nome.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.TXT_Filtro_Nome.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.TXT_Filtro_Nome.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.TXT_Filtro_Nome.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.TXT_Filtro_Nome.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.TXT_Filtro_Nome.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.TXT_Filtro_Nome.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.TXT_Filtro_Nome.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.TXT_Filtro_Nome.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.TXT_Filtro_Nome.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.TXT_Filtro_Nome.CustomButton.Name = "";
            this.TXT_Filtro_Nome.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.TXT_Filtro_Nome.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.TXT_Filtro_Nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Filtro_Nome.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.TXT_Filtro_Nome.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.TXT_Filtro_Nome.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.TXT_Filtro_Nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Filtro_Nome.CustomButton.UseSelectable = true;
            this.TXT_Filtro_Nome.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.TXT_Filtro_Nome.Lines = new string[0];
            this.TXT_Filtro_Nome.MaxLength = 32767;
            this.TXT_Filtro_Nome.Name = "TXT_Filtro_Nome";
            this.TXT_Filtro_Nome.PasswordChar = '\0';
            this.TXT_Filtro_Nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Filtro_Nome.SelectedText = "";
            this.TXT_Filtro_Nome.SelectionLength = 0;
            this.TXT_Filtro_Nome.SelectionStart = 0;
            this.TXT_Filtro_Nome.ShortcutsEnabled = true;
            this.TXT_Filtro_Nome.UseSelectable = true;
            this.TXT_Filtro_Nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Filtro_Nome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_Filtro_Nome.TextChanged += new System.EventHandler(this.TXT_Filtro_Nome_TextChanged);
            // 
            // CBX_Filtro_Status
            // 
            resources.ApplyResources(this.CBX_Filtro_Status, "CBX_Filtro_Status");
            this.CBX_Filtro_Status.FormattingEnabled = true;
            this.CBX_Filtro_Status.Name = "CBX_Filtro_Status";
            this.CBX_Filtro_Status.UseSelectable = true;
            this.CBX_Filtro_Status.SelectedIndexChanged += new System.EventHandler(this.CBX_Filtro_Status_SelectedIndexChanged);
            // 
            // returnSolicitacoesBindingSource
            // 
            this.returnSolicitacoesBindingSource.DataSource = typeof(Request_System.ReturnSolicitacoesStockMan);
            // 
            // BTN_Gerar_PDF
            // 
            resources.ApplyResources(this.BTN_Gerar_PDF, "BTN_Gerar_PDF");
            this.BTN_Gerar_PDF.Name = "BTN_Gerar_PDF";
            this.BTN_Gerar_PDF.UseSelectable = true;
            this.BTN_Gerar_PDF.Click += new System.EventHandler(this.BTN_Gerar_PDF_Click);
            // 
            // Solicitacoes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Gerar_PDF);
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
        private MetroFramework.Controls.MetroTextBox TXT_Filtro_Nome;
        private MetroFramework.Controls.MetroComboBox CBX_Filtro_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolicitatonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRequesterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSolicitacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserApproverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAprovacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRetiradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitationStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRequesterId;
        private MetroFramework.Controls.MetroButton BTN_Gerar_PDF;
    }
}