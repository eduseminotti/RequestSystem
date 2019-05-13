namespace Request_System
{
    partial class Providers_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Providers_View));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Filter1 = new MetroFramework.Controls.MetroButton();
            this.BTN_FilterLimpar = new MetroFramework.Controls.MetroButton();
            this.TXT_Filter_CNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Filter_Codigo = new System.Windows.Forms.TextBox();
            this.TXT_Filter_Nome_fantasia = new System.Windows.Forms.TextBox();
            this.LBL_Usuarios = new System.Windows.Forms.Label();
            this.returnProvidersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GRID_View_Providers = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Edit1 = new MetroFramework.Controls.MetroButton();
            this.BTN_NewProvider = new MetroFramework.Controls.MetroButton();
            this.BTN_Gerar_PDF = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnProvidersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_View_Providers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Filter1);
            this.groupBox1.Controls.Add(this.BTN_FilterLimpar);
            this.groupBox1.Controls.Add(this.TXT_Filter_CNPJ);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXT_Filter_Codigo);
            this.groupBox1.Controls.Add(this.TXT_Filter_Nome_fantasia);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BTN_Filter1
            // 
            resources.ApplyResources(this.BTN_Filter1, "BTN_Filter1");
            this.BTN_Filter1.Name = "BTN_Filter1";
            this.BTN_Filter1.UseSelectable = true;
            this.BTN_Filter1.Click += new System.EventHandler(this.BTN_Filter1_Click);
            // 
            // BTN_FilterLimpar
            // 
            resources.ApplyResources(this.BTN_FilterLimpar, "BTN_FilterLimpar");
            this.BTN_FilterLimpar.Name = "BTN_FilterLimpar";
            this.BTN_FilterLimpar.UseSelectable = true;
            this.BTN_FilterLimpar.Click += new System.EventHandler(this.BTN_FilterLimpar_Click);
            // 
            // TXT_Filter_CNPJ
            // 
            resources.ApplyResources(this.TXT_Filter_CNPJ, "TXT_Filter_CNPJ");
            this.TXT_Filter_CNPJ.Name = "TXT_Filter_CNPJ";
            this.TXT_Filter_CNPJ.TextChanged += new System.EventHandler(this.TXT_Filter_CNPJ_TextChanged);
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
            // TXT_Filter_Codigo
            // 
            resources.ApplyResources(this.TXT_Filter_Codigo, "TXT_Filter_Codigo");
            this.TXT_Filter_Codigo.Name = "TXT_Filter_Codigo";
            this.TXT_Filter_Codigo.TextChanged += new System.EventHandler(this.TXT_Filter_Codigo_TextChanged);
            // 
            // TXT_Filter_Nome_fantasia
            // 
            resources.ApplyResources(this.TXT_Filter_Nome_fantasia, "TXT_Filter_Nome_fantasia");
            this.TXT_Filter_Nome_fantasia.Name = "TXT_Filter_Nome_fantasia";
            this.TXT_Filter_Nome_fantasia.TextChanged += new System.EventHandler(this.TXT_Filter_Nome_fantasia_TextChanged);
            // 
            // LBL_Usuarios
            // 
            resources.ApplyResources(this.LBL_Usuarios, "LBL_Usuarios");
            this.LBL_Usuarios.Name = "LBL_Usuarios";
            // 
            // returnProvidersBindingSource
            // 
            this.returnProvidersBindingSource.DataSource = typeof(Request_System.ReturnProviders);
            // 
            // GRID_View_Providers
            // 
            this.GRID_View_Providers.AllowUserToResizeRows = false;
            this.GRID_View_Providers.AutoGenerateColumns = false;
            this.GRID_View_Providers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRID_View_Providers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRID_View_Providers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRID_View_Providers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_View_Providers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRID_View_Providers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_View_Providers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.razaoSocialDataGridViewTextBoxColumn1,
            this.nomeFantasiaDataGridViewTextBoxColumn1,
            this.cNPJDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.nameCnpjDataGridViewTextBoxColumn});
            this.GRID_View_Providers.DataSource = this.returnProvidersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_View_Providers.DefaultCellStyle = dataGridViewCellStyle2;
            this.GRID_View_Providers.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.GRID_View_Providers, "GRID_View_Providers");
            this.GRID_View_Providers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRID_View_Providers.Name = "GRID_View_Providers";
            this.GRID_View_Providers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_View_Providers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GRID_View_Providers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GRID_View_Providers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn1, "idDataGridViewTextBoxColumn1");
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // razaoSocialDataGridViewTextBoxColumn1
            // 
            this.razaoSocialDataGridViewTextBoxColumn1.DataPropertyName = "Razao_Social";
            resources.ApplyResources(this.razaoSocialDataGridViewTextBoxColumn1, "razaoSocialDataGridViewTextBoxColumn1");
            this.razaoSocialDataGridViewTextBoxColumn1.Name = "razaoSocialDataGridViewTextBoxColumn1";
            this.razaoSocialDataGridViewTextBoxColumn1.ReadOnly = true;
            this.razaoSocialDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nomeFantasiaDataGridViewTextBoxColumn1
            // 
            this.nomeFantasiaDataGridViewTextBoxColumn1.DataPropertyName = "Nome_Fantasia";
            resources.ApplyResources(this.nomeFantasiaDataGridViewTextBoxColumn1, "nomeFantasiaDataGridViewTextBoxColumn1");
            this.nomeFantasiaDataGridViewTextBoxColumn1.Name = "nomeFantasiaDataGridViewTextBoxColumn1";
            this.nomeFantasiaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nomeFantasiaDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cNPJDataGridViewTextBoxColumn1
            // 
            this.cNPJDataGridViewTextBoxColumn1.DataPropertyName = "CNPJ";
            resources.ApplyResources(this.cNPJDataGridViewTextBoxColumn1, "cNPJDataGridViewTextBoxColumn1");
            this.cNPJDataGridViewTextBoxColumn1.Name = "cNPJDataGridViewTextBoxColumn1";
            this.cNPJDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cNPJDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            resources.ApplyResources(this.phoneDataGridViewTextBoxColumn1, "phoneDataGridViewTextBoxColumn1");
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameCnpjDataGridViewTextBoxColumn
            // 
            this.nameCnpjDataGridViewTextBoxColumn.DataPropertyName = "NameCnpj";
            resources.ApplyResources(this.nameCnpjDataGridViewTextBoxColumn, "nameCnpjDataGridViewTextBoxColumn");
            this.nameCnpjDataGridViewTextBoxColumn.Name = "nameCnpjDataGridViewTextBoxColumn";
            // 
            // BTN_Edit1
            // 
            resources.ApplyResources(this.BTN_Edit1, "BTN_Edit1");
            this.BTN_Edit1.Name = "BTN_Edit1";
            this.BTN_Edit1.UseSelectable = true;
            this.BTN_Edit1.Click += new System.EventHandler(this.BTN_Edit1_Click);
            // 
            // BTN_NewProvider
            // 
            resources.ApplyResources(this.BTN_NewProvider, "BTN_NewProvider");
            this.BTN_NewProvider.Name = "BTN_NewProvider";
            this.BTN_NewProvider.UseSelectable = true;
            this.BTN_NewProvider.Click += new System.EventHandler(this.BTN_NewProvider_Click);
            // 
            // BTN_Gerar_PDF
            // 
            resources.ApplyResources(this.BTN_Gerar_PDF, "BTN_Gerar_PDF");
            this.BTN_Gerar_PDF.Name = "BTN_Gerar_PDF";
            this.BTN_Gerar_PDF.UseSelectable = true;
            this.BTN_Gerar_PDF.Click += new System.EventHandler(this.BTN_Gerar_PDF_Click);
            // 
            // Providers_View
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Gerar_PDF);
            this.Controls.Add(this.BTN_NewProvider);
            this.Controls.Add(this.BTN_Edit1);
            this.Controls.Add(this.GRID_View_Providers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Providers_View";
            this.Load += new System.EventHandler(this.Providers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnProvidersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_View_Providers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_Filter_CNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Filter_Codigo;
        private System.Windows.Forms.TextBox TXT_Filter_Nome_fantasia;
        private System.Windows.Forms.Label LBL_Usuarios;
        private System.Windows.Forms.BindingSource returnProvidersBindingSource;
        private MetroFramework.Controls.MetroGrid GRID_View_Providers;
        private MetroFramework.Controls.MetroButton BTN_Filter1;
        private MetroFramework.Controls.MetroButton BTN_FilterLimpar;
        private MetroFramework.Controls.MetroButton BTN_Edit1;
        private MetroFramework.Controls.MetroButton BTN_NewProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCnpjDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton BTN_Gerar_PDF;
    }
}