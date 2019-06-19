namespace Request_System
{
    partial class Notas_Fiscais_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas_Fiscais_View));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GB_filters = new System.Windows.Forms.GroupBox();
            this.TXT_Filter_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.TXT_Filter_Serie_NFe = new System.Windows.Forms.MaskedTextBox();
            this.TXT_Filter_Numero_NFe = new System.Windows.Forms.MaskedTextBox();
            this.BTN_Filter_limpar = new MetroFramework.Controls.MetroButton();
            this.BTN_Filter = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fantasyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueNFeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRID_NFes_View = new MetroFramework.Controls.MetroGrid();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissionDateDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueNFeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fantasyNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.returnNFesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnNFesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_New_NFe = new MetroFramework.Controls.MetroButton();
            this.BTN_Edit = new MetroFramework.Controls.MetroButton();
            this.Grid_RelatorioNFe = new System.Windows.Forms.DataGridView();
            this.numberNFeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serierNFeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueNFeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJEmitenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissionDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoQuantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnRelatorioNFeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_Gerar_PDF = new MetroFramework.Controls.MetroButton();
            this.LBL_Usuarios = new System.Windows.Forms.Label();
            this.GB_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_NFes_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnNFesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnNFesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_RelatorioNFe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnRelatorioNFeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_filters
            // 
            this.GB_filters.Controls.Add(this.TXT_Filter_CNPJ);
            this.GB_filters.Controls.Add(this.TXT_Filter_Serie_NFe);
            this.GB_filters.Controls.Add(this.TXT_Filter_Numero_NFe);
            this.GB_filters.Controls.Add(this.BTN_Filter_limpar);
            this.GB_filters.Controls.Add(this.BTN_Filter);
            this.GB_filters.Controls.Add(this.label3);
            this.GB_filters.Controls.Add(this.label2);
            this.GB_filters.Controls.Add(this.label1);
            resources.ApplyResources(this.GB_filters, "GB_filters");
            this.GB_filters.Name = "GB_filters";
            this.GB_filters.TabStop = false;
            // 
            // TXT_Filter_CNPJ
            // 
            resources.ApplyResources(this.TXT_Filter_CNPJ, "TXT_Filter_CNPJ");
            this.TXT_Filter_CNPJ.Name = "TXT_Filter_CNPJ";
            this.TXT_Filter_CNPJ.TextChanged += new System.EventHandler(this.TXT_Filter_CNPJ_TextChanged);
            this.TXT_Filter_CNPJ.Enter += new System.EventHandler(this.TXT_Filter_CNPJ_Enter);
            this.TXT_Filter_CNPJ.Leave += new System.EventHandler(this.TXT_Filter_CNPJ_Leave);
            // 
            // TXT_Filter_Serie_NFe
            // 
            resources.ApplyResources(this.TXT_Filter_Serie_NFe, "TXT_Filter_Serie_NFe");
            this.TXT_Filter_Serie_NFe.Name = "TXT_Filter_Serie_NFe";
            this.TXT_Filter_Serie_NFe.TextChanged += new System.EventHandler(this.TXT_Filter_Serie_NFe_TextChanged);
            this.TXT_Filter_Serie_NFe.Enter += new System.EventHandler(this.TXT_Filter_Serie_NFe_Enter);
            this.TXT_Filter_Serie_NFe.Leave += new System.EventHandler(this.TXT_Filter_Serie_NFe_Leave);
            // 
            // TXT_Filter_Numero_NFe
            // 
            resources.ApplyResources(this.TXT_Filter_Numero_NFe, "TXT_Filter_Numero_NFe");
            this.TXT_Filter_Numero_NFe.Name = "TXT_Filter_Numero_NFe";
            this.TXT_Filter_Numero_NFe.TextChanged += new System.EventHandler(this.TXT_Filter_Numero_NFe_TextChanged);
            this.TXT_Filter_Numero_NFe.Enter += new System.EventHandler(this.TXT_Filter_Numero_NFe_Enter);
            this.TXT_Filter_Numero_NFe.Leave += new System.EventHandler(this.TXT_Filter_Numero_NFe_Leave);
            // 
            // BTN_Filter_limpar
            // 
            resources.ApplyResources(this.BTN_Filter_limpar, "BTN_Filter_limpar");
            this.BTN_Filter_limpar.Name = "BTN_Filter_limpar";
            this.BTN_Filter_limpar.UseSelectable = true;
            this.BTN_Filter_limpar.Click += new System.EventHandler(this.BTN_Filter_limpar_Click_1);
            // 
            // BTN_Filter
            // 
            resources.ApplyResources(this.BTN_Filter, "BTN_Filter");
            this.BTN_Filter.Name = "BTN_Filter";
            this.BTN_Filter.UseSelectable = true;
            this.BTN_Filter.Click += new System.EventHandler(this.BTN_Filter_Click_1);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            resources.ApplyResources(this.numberDataGridViewTextBoxColumn, "numberDataGridViewTextBoxColumn");
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "Series";
            resources.ApplyResources(this.seriesDataGridViewTextBoxColumn, "seriesDataGridViewTextBoxColumn");
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            resources.ApplyResources(this.cNPJDataGridViewTextBoxColumn, "cNPJDataGridViewTextBoxColumn");
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // fantasyNameDataGridViewTextBoxColumn
            // 
            this.fantasyNameDataGridViewTextBoxColumn.DataPropertyName = "Fantasy_Name";
            resources.ApplyResources(this.fantasyNameDataGridViewTextBoxColumn, "fantasyNameDataGridViewTextBoxColumn");
            this.fantasyNameDataGridViewTextBoxColumn.Name = "fantasyNameDataGridViewTextBoxColumn";
            // 
            // emissionDateDataGridViewTextBoxColumn
            // 
            this.emissionDateDataGridViewTextBoxColumn.DataPropertyName = "EmissionDate";
            resources.ApplyResources(this.emissionDateDataGridViewTextBoxColumn, "emissionDateDataGridViewTextBoxColumn");
            this.emissionDateDataGridViewTextBoxColumn.Name = "emissionDateDataGridViewTextBoxColumn";
            // 
            // valueNFeDataGridViewTextBoxColumn
            // 
            this.valueNFeDataGridViewTextBoxColumn.DataPropertyName = "ValueNFe";
            resources.ApplyResources(this.valueNFeDataGridViewTextBoxColumn, "valueNFeDataGridViewTextBoxColumn");
            this.valueNFeDataGridViewTextBoxColumn.Name = "valueNFeDataGridViewTextBoxColumn";
            // 
            // GRID_NFes_View
            // 
            this.GRID_NFes_View.AllowUserToResizeRows = false;
            this.GRID_NFes_View.AutoGenerateColumns = false;
            this.GRID_NFes_View.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRID_NFes_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRID_NFes_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRID_NFes_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_NFes_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GRID_NFes_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_NFes_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn1,
            this.seriesDataGridViewTextBoxColumn1,
            this.emissionDateDataGridViewTextBoxColumn3,
            this.valueNFeDataGridViewTextBoxColumn3,
            this.fantasyNameDataGridViewTextBoxColumn1,
            this.cNPJDataGridViewTextBoxColumn1,
            this.nFeIDDataGridViewTextBoxColumn,
            this.providerIDDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1});
            this.GRID_NFes_View.DataSource = this.returnNFesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_NFes_View.DefaultCellStyle = dataGridViewCellStyle5;
            this.GRID_NFes_View.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.GRID_NFes_View, "GRID_NFes_View");
            this.GRID_NFes_View.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRID_NFes_View.Name = "GRID_NFes_View";
            this.GRID_NFes_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_NFes_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GRID_NFes_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GRID_NFes_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_NFes_View.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_NFes_View_CellDoubleClick);
            this.GRID_NFes_View.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GRID_NFes_View_KeyDown);
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            this.numberDataGridViewTextBoxColumn1.DataPropertyName = "Number";
            resources.ApplyResources(this.numberDataGridViewTextBoxColumn1, "numberDataGridViewTextBoxColumn1");
            this.numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            this.numberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // seriesDataGridViewTextBoxColumn1
            // 
            this.seriesDataGridViewTextBoxColumn1.DataPropertyName = "Series";
            resources.ApplyResources(this.seriesDataGridViewTextBoxColumn1, "seriesDataGridViewTextBoxColumn1");
            this.seriesDataGridViewTextBoxColumn1.Name = "seriesDataGridViewTextBoxColumn1";
            this.seriesDataGridViewTextBoxColumn1.ReadOnly = true;
            this.seriesDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // emissionDateDataGridViewTextBoxColumn3
            // 
            this.emissionDateDataGridViewTextBoxColumn3.DataPropertyName = "EmissionDate";
            resources.ApplyResources(this.emissionDateDataGridViewTextBoxColumn3, "emissionDateDataGridViewTextBoxColumn3");
            this.emissionDateDataGridViewTextBoxColumn3.Name = "emissionDateDataGridViewTextBoxColumn3";
            this.emissionDateDataGridViewTextBoxColumn3.ReadOnly = true;
            this.emissionDateDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // valueNFeDataGridViewTextBoxColumn3
            // 
            this.valueNFeDataGridViewTextBoxColumn3.DataPropertyName = "ValueNFe";
            resources.ApplyResources(this.valueNFeDataGridViewTextBoxColumn3, "valueNFeDataGridViewTextBoxColumn3");
            this.valueNFeDataGridViewTextBoxColumn3.Name = "valueNFeDataGridViewTextBoxColumn3";
            this.valueNFeDataGridViewTextBoxColumn3.ReadOnly = true;
            this.valueNFeDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fantasyNameDataGridViewTextBoxColumn1
            // 
            this.fantasyNameDataGridViewTextBoxColumn1.DataPropertyName = "Fantasy_Name";
            resources.ApplyResources(this.fantasyNameDataGridViewTextBoxColumn1, "fantasyNameDataGridViewTextBoxColumn1");
            this.fantasyNameDataGridViewTextBoxColumn1.Name = "fantasyNameDataGridViewTextBoxColumn1";
            this.fantasyNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fantasyNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cNPJDataGridViewTextBoxColumn1
            // 
            this.cNPJDataGridViewTextBoxColumn1.DataPropertyName = "CNPJ";
            resources.ApplyResources(this.cNPJDataGridViewTextBoxColumn1, "cNPJDataGridViewTextBoxColumn1");
            this.cNPJDataGridViewTextBoxColumn1.Name = "cNPJDataGridViewTextBoxColumn1";
            this.cNPJDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cNPJDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nFeIDDataGridViewTextBoxColumn
            // 
            this.nFeIDDataGridViewTextBoxColumn.DataPropertyName = "NFeID";
            resources.ApplyResources(this.nFeIDDataGridViewTextBoxColumn, "nFeIDDataGridViewTextBoxColumn");
            this.nFeIDDataGridViewTextBoxColumn.Name = "nFeIDDataGridViewTextBoxColumn";
            // 
            // providerIDDataGridViewTextBoxColumn
            // 
            this.providerIDDataGridViewTextBoxColumn.DataPropertyName = "ProviderID";
            resources.ApplyResources(this.providerIDDataGridViewTextBoxColumn, "providerIDDataGridViewTextBoxColumn");
            this.providerIDDataGridViewTextBoxColumn.Name = "providerIDDataGridViewTextBoxColumn";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "InStock";
            resources.ApplyResources(this.dataGridViewCheckBoxColumn1, "dataGridViewCheckBoxColumn1");
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // returnNFesBindingSource
            // 
            this.returnNFesBindingSource.DataSource = typeof(Request_System.ReturnNFes);
            // 
            // BTN_New_NFe
            // 
            resources.ApplyResources(this.BTN_New_NFe, "BTN_New_NFe");
            this.BTN_New_NFe.Name = "BTN_New_NFe";
            this.BTN_New_NFe.UseSelectable = true;
            this.BTN_New_NFe.Click += new System.EventHandler(this.BTN_New_NFe_Click_1);
            // 
            // BTN_Edit
            // 
            resources.ApplyResources(this.BTN_Edit, "BTN_Edit");
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.UseSelectable = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click_1);
            // 
            // Grid_RelatorioNFe
            // 
            this.Grid_RelatorioNFe.AutoGenerateColumns = false;
            this.Grid_RelatorioNFe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_RelatorioNFe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberNFeDataGridViewTextBoxColumn,
            this.serierNFeDataGridViewTextBoxColumn,
            this.valueNFeDataGridViewTextBoxColumn1,
            this.cNPJEmitenteDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.emissionDateDataGridViewTextBoxColumn1,
            this.produtoQuantidadeDataGridViewTextBoxColumn});
            this.Grid_RelatorioNFe.DataSource = this.returnRelatorioNFeBindingSource;
            resources.ApplyResources(this.Grid_RelatorioNFe, "Grid_RelatorioNFe");
            this.Grid_RelatorioNFe.Name = "Grid_RelatorioNFe";
            // 
            // numberNFeDataGridViewTextBoxColumn
            // 
            this.numberNFeDataGridViewTextBoxColumn.DataPropertyName = "NumberNFe";
            resources.ApplyResources(this.numberNFeDataGridViewTextBoxColumn, "numberNFeDataGridViewTextBoxColumn");
            this.numberNFeDataGridViewTextBoxColumn.Name = "numberNFeDataGridViewTextBoxColumn";
            // 
            // serierNFeDataGridViewTextBoxColumn
            // 
            this.serierNFeDataGridViewTextBoxColumn.DataPropertyName = "SerierNFe";
            resources.ApplyResources(this.serierNFeDataGridViewTextBoxColumn, "serierNFeDataGridViewTextBoxColumn");
            this.serierNFeDataGridViewTextBoxColumn.Name = "serierNFeDataGridViewTextBoxColumn";
            // 
            // valueNFeDataGridViewTextBoxColumn1
            // 
            this.valueNFeDataGridViewTextBoxColumn1.DataPropertyName = "ValueNFe";
            resources.ApplyResources(this.valueNFeDataGridViewTextBoxColumn1, "valueNFeDataGridViewTextBoxColumn1");
            this.valueNFeDataGridViewTextBoxColumn1.Name = "valueNFeDataGridViewTextBoxColumn1";
            // 
            // cNPJEmitenteDataGridViewTextBoxColumn
            // 
            this.cNPJEmitenteDataGridViewTextBoxColumn.DataPropertyName = "CNPJEmitente";
            resources.ApplyResources(this.cNPJEmitenteDataGridViewTextBoxColumn, "cNPJEmitenteDataGridViewTextBoxColumn");
            this.cNPJEmitenteDataGridViewTextBoxColumn.Name = "cNPJEmitenteDataGridViewTextBoxColumn";
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            resources.ApplyResources(this.razaoSocialDataGridViewTextBoxColumn, "razaoSocialDataGridViewTextBoxColumn");
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            // 
            // emissionDateDataGridViewTextBoxColumn1
            // 
            this.emissionDateDataGridViewTextBoxColumn1.DataPropertyName = "EmissionDate";
            resources.ApplyResources(this.emissionDateDataGridViewTextBoxColumn1, "emissionDateDataGridViewTextBoxColumn1");
            this.emissionDateDataGridViewTextBoxColumn1.Name = "emissionDateDataGridViewTextBoxColumn1";
            // 
            // produtoQuantidadeDataGridViewTextBoxColumn
            // 
            this.produtoQuantidadeDataGridViewTextBoxColumn.DataPropertyName = "ProdutoQuantidade";
            resources.ApplyResources(this.produtoQuantidadeDataGridViewTextBoxColumn, "produtoQuantidadeDataGridViewTextBoxColumn");
            this.produtoQuantidadeDataGridViewTextBoxColumn.Name = "produtoQuantidadeDataGridViewTextBoxColumn";
            // 
            // returnRelatorioNFeBindingSource
            // 
            this.returnRelatorioNFeBindingSource.DataSource = typeof(Request_System.ReturnRelatorioNFe);
            // 
            // BTN_Gerar_PDF
            // 
            resources.ApplyResources(this.BTN_Gerar_PDF, "BTN_Gerar_PDF");
            this.BTN_Gerar_PDF.Name = "BTN_Gerar_PDF";
            this.BTN_Gerar_PDF.UseSelectable = true;
            this.BTN_Gerar_PDF.Click += new System.EventHandler(this.BTN_Gerar_PDF_Click_1);
            // 
            // LBL_Usuarios
            // 
            resources.ApplyResources(this.LBL_Usuarios, "LBL_Usuarios");
            this.LBL_Usuarios.Name = "LBL_Usuarios";
            // 
            // Notas_Fiscais_View
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_Usuarios);
            this.Controls.Add(this.Grid_RelatorioNFe);
            this.Controls.Add(this.BTN_Gerar_PDF);
            this.Controls.Add(this.BTN_New_NFe);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.GRID_NFes_View);
            this.Controls.Add(this.GB_filters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notas_Fiscais_View";
            this.Load += new System.EventHandler(this.Notas_Fiscais_Load);
            this.GB_filters.ResumeLayout(false);
            this.GB_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_NFes_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnNFesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnNFesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_RelatorioNFe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnRelatorioNFeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_filters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fantasyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueNFeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource returnNFesBindingSource4;
        private MetroFramework.Controls.MetroGrid GRID_NFes_View;
        private MetroFramework.Controls.MetroButton BTN_Filter_limpar;
        private MetroFramework.Controls.MetroButton BTN_Filter;
        private MetroFramework.Controls.MetroButton BTN_New_NFe;
        private MetroFramework.Controls.MetroButton BTN_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissionDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueNFeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fantasyNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inStockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView Grid_RelatorioNFe;
        private System.Windows.Forms.BindingSource returnRelatorioNFeBindingSource;
        private MetroFramework.Controls.MetroButton BTN_Gerar_PDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberNFeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serierNFeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueNFeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJEmitenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissionDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoQuantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LBL_Usuarios;
        private System.Windows.Forms.BindingSource returnNFesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissionDateDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueNFeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fantasyNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.MaskedTextBox TXT_Filter_CNPJ;
        private System.Windows.Forms.MaskedTextBox TXT_Filter_Serie_NFe;
        private System.Windows.Forms.MaskedTextBox TXT_Filter_Numero_NFe;
    }
}