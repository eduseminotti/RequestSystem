namespace Request_System
{
    partial class produtos_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produtos_view));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBL_Usuarios = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Filter_limpar = new MetroFramework.Controls.MetroButton();
            this.BTN_Filter = new MetroFramework.Controls.MetroButton();
            this.CBX_Filter_Status = new MetroFramework.Controls.MetroComboBox();
            this.TXT_Filter_Nome = new MetroFramework.Controls.MetroTextBox();
            this.TXT_Filter_Codigo = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_View_produtos = new MetroFramework.Controls.MetroGrid();
            this.productIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnidadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIsActiveDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_Gerar_PDF = new MetroFramework.Controls.MetroButton();
            this.BTN_Edit = new MetroFramework.Controls.MetroButton();
            this.BTN_New_Product = new MetroFramework.Controls.MetroButton();
            this.returnProdutosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Grid_Produtos_PDF = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIsActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_View_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProdutosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produtos_PDF)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Usuarios
            // 
            resources.ApplyResources(this.LBL_Usuarios, "LBL_Usuarios");
            this.LBL_Usuarios.Name = "LBL_Usuarios";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.BTN_Filter_limpar);
            this.groupBox1.Controls.Add(this.BTN_Filter);
            this.groupBox1.Controls.Add(this.CBX_Filter_Status);
            this.groupBox1.Controls.Add(this.TXT_Filter_Nome);
            this.groupBox1.Controls.Add(this.TXT_Filter_Codigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            // CBX_Filter_Status
            // 
            resources.ApplyResources(this.CBX_Filter_Status, "CBX_Filter_Status");
            this.CBX_Filter_Status.FormattingEnabled = true;
            this.CBX_Filter_Status.Name = "CBX_Filter_Status";
            this.CBX_Filter_Status.UseSelectable = true;
            this.CBX_Filter_Status.SelectedIndexChanged += new System.EventHandler(this.CBX_Filter_Status_SelectedIndexChanged_1);
            // 
            // TXT_Filter_Nome
            // 
            resources.ApplyResources(this.TXT_Filter_Nome, "TXT_Filter_Nome");
            // 
            // 
            // 
            this.TXT_Filter_Nome.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.TXT_Filter_Nome.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.TXT_Filter_Nome.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.TXT_Filter_Nome.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.TXT_Filter_Nome.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.TXT_Filter_Nome.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.TXT_Filter_Nome.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.TXT_Filter_Nome.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.TXT_Filter_Nome.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.TXT_Filter_Nome.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.TXT_Filter_Nome.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.TXT_Filter_Nome.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.TXT_Filter_Nome.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.TXT_Filter_Nome.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.TXT_Filter_Nome.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.TXT_Filter_Nome.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.TXT_Filter_Nome.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.TXT_Filter_Nome.CustomButton.Name = "";
            this.TXT_Filter_Nome.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.TXT_Filter_Nome.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.TXT_Filter_Nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Filter_Nome.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.TXT_Filter_Nome.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.TXT_Filter_Nome.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.TXT_Filter_Nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Filter_Nome.CustomButton.UseSelectable = true;
            this.TXT_Filter_Nome.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.TXT_Filter_Nome.Lines = new string[0];
            this.TXT_Filter_Nome.MaxLength = 32767;
            this.TXT_Filter_Nome.Name = "TXT_Filter_Nome";
            this.TXT_Filter_Nome.PasswordChar = '\0';
            this.TXT_Filter_Nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Filter_Nome.SelectedText = "";
            this.TXT_Filter_Nome.SelectionLength = 0;
            this.TXT_Filter_Nome.SelectionStart = 0;
            this.TXT_Filter_Nome.ShortcutsEnabled = true;
            this.TXT_Filter_Nome.UseSelectable = true;
            this.TXT_Filter_Nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Filter_Nome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_Filter_Nome.TextChanged += new System.EventHandler(this.TXT_Filter_Nome_TextChanged);
            // 
            // TXT_Filter_Codigo
            // 
            resources.ApplyResources(this.TXT_Filter_Codigo, "TXT_Filter_Codigo");
            // 
            // 
            // 
            this.TXT_Filter_Codigo.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1");
            this.TXT_Filter_Codigo.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1");
            this.TXT_Filter_Codigo.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor1")));
            this.TXT_Filter_Codigo.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize1")));
            this.TXT_Filter_Codigo.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode1")));
            this.TXT_Filter_Codigo.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.TXT_Filter_Codigo.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout1")));
            this.TXT_Filter_Codigo.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock1")));
            this.TXT_Filter_Codigo.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle1")));
            this.TXT_Filter_Codigo.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.TXT_Filter_Codigo.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.TXT_Filter_Codigo.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign1")));
            this.TXT_Filter_Codigo.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex1")));
            this.TXT_Filter_Codigo.CustomButton.ImageKey = resources.GetString("resource.ImageKey1");
            this.TXT_Filter_Codigo.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.TXT_Filter_Codigo.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.TXT_Filter_Codigo.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize1")));
            this.TXT_Filter_Codigo.CustomButton.Name = "";
            this.TXT_Filter_Codigo.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft1")));
            this.TXT_Filter_Codigo.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.TXT_Filter_Codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Filter_Codigo.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.TXT_Filter_Codigo.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign1")));
            this.TXT_Filter_Codigo.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation1")));
            this.TXT_Filter_Codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Filter_Codigo.CustomButton.UseSelectable = true;
            this.TXT_Filter_Codigo.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.TXT_Filter_Codigo.Lines = new string[0];
            this.TXT_Filter_Codigo.MaxLength = 32767;
            this.TXT_Filter_Codigo.Name = "TXT_Filter_Codigo";
            this.TXT_Filter_Codigo.PasswordChar = '\0';
            this.TXT_Filter_Codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Filter_Codigo.SelectedText = "";
            this.TXT_Filter_Codigo.SelectionLength = 0;
            this.TXT_Filter_Codigo.SelectionStart = 0;
            this.TXT_Filter_Codigo.ShortcutsEnabled = true;
            this.TXT_Filter_Codigo.UseSelectable = true;
            this.TXT_Filter_Codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Filter_Codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_Filter_Codigo.TextChanged += new System.EventHandler(this.TXT_Filter_Codigo_TextChanged);
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
            // Grid_View_produtos
            // 
            resources.ApplyResources(this.Grid_View_produtos, "Grid_View_produtos");
            this.Grid_View_produtos.AllowUserToResizeRows = false;
            this.Grid_View_produtos.AutoGenerateColumns = false;
            this.Grid_View_produtos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_View_produtos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_View_produtos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_View_produtos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_View_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_View_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_View_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn1,
            this.productNameDataGridViewTextBoxColumn1,
            this.productUnidadeDataGridViewTextBoxColumn1,
            this.quantidadeDataGridViewTextBoxColumn,
            this.productIsActiveDataGridViewTextBoxColumn1});
            this.Grid_View_produtos.DataSource = this.returnProdutosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_View_produtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_View_produtos.EnableHeadersVisualStyles = false;
            this.Grid_View_produtos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_View_produtos.Name = "Grid_View_produtos";
            this.Grid_View_produtos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_View_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_View_produtos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_View_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // productIdDataGridViewTextBoxColumn1
            // 
            this.productIdDataGridViewTextBoxColumn1.DataPropertyName = "Product_Id";
            resources.ApplyResources(this.productIdDataGridViewTextBoxColumn1, "productIdDataGridViewTextBoxColumn1");
            this.productIdDataGridViewTextBoxColumn1.Name = "productIdDataGridViewTextBoxColumn1";
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            this.productNameDataGridViewTextBoxColumn1.DataPropertyName = "Product_Name";
            resources.ApplyResources(this.productNameDataGridViewTextBoxColumn1, "productNameDataGridViewTextBoxColumn1");
            this.productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            // 
            // productUnidadeDataGridViewTextBoxColumn1
            // 
            this.productUnidadeDataGridViewTextBoxColumn1.DataPropertyName = "Product_Unidade";
            resources.ApplyResources(this.productUnidadeDataGridViewTextBoxColumn1, "productUnidadeDataGridViewTextBoxColumn1");
            this.productUnidadeDataGridViewTextBoxColumn1.Name = "productUnidadeDataGridViewTextBoxColumn1";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            resources.ApplyResources(this.quantidadeDataGridViewTextBoxColumn, "quantidadeDataGridViewTextBoxColumn");
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // productIsActiveDataGridViewTextBoxColumn1
            // 
            this.productIsActiveDataGridViewTextBoxColumn1.DataPropertyName = "product_IsActive";
            resources.ApplyResources(this.productIsActiveDataGridViewTextBoxColumn1, "productIsActiveDataGridViewTextBoxColumn1");
            this.productIsActiveDataGridViewTextBoxColumn1.Name = "productIsActiveDataGridViewTextBoxColumn1";
            // 
            // returnProdutosBindingSource
            // 
            this.returnProdutosBindingSource.DataSource = typeof(Request_System.ReturnProdutos);
            // 
            // BTN_Gerar_PDF
            // 
            resources.ApplyResources(this.BTN_Gerar_PDF, "BTN_Gerar_PDF");
            this.BTN_Gerar_PDF.Name = "BTN_Gerar_PDF";
            this.BTN_Gerar_PDF.UseSelectable = true;
            this.BTN_Gerar_PDF.Click += new System.EventHandler(this.BTN_Gerar_PDF_Click);
            // 
            // BTN_Edit
            // 
            resources.ApplyResources(this.BTN_Edit, "BTN_Edit");
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.UseSelectable = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click_1);
            // 
            // BTN_New_Product
            // 
            resources.ApplyResources(this.BTN_New_Product, "BTN_New_Product");
            this.BTN_New_Product.Name = "BTN_New_Product";
            this.BTN_New_Product.UseSelectable = true;
            this.BTN_New_Product.Click += new System.EventHandler(this.BTN_New_Product_Click_1);
            // 
            // returnProdutosBindingSource1
            // 
            this.returnProdutosBindingSource1.DataSource = typeof(Request_System.ReturnProdutos);
            // 
            // Grid_Produtos_PDF
            // 
            resources.ApplyResources(this.Grid_Produtos_PDF, "Grid_Produtos_PDF");
            this.Grid_Produtos_PDF.AutoGenerateColumns = false;
            this.Grid_Produtos_PDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Produtos_PDF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.productNameDataGridViewTextBoxColumn,
            this.productUnidadeDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn1,
            this.productIsActiveDataGridViewTextBoxColumn});
            this.Grid_Produtos_PDF.DataSource = this.returnProdutosBindingSource;
            this.Grid_Produtos_PDF.Name = "Grid_Produtos_PDF";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Product_Id";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            resources.ApplyResources(this.productNameDataGridViewTextBoxColumn, "productNameDataGridViewTextBoxColumn");
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productUnidadeDataGridViewTextBoxColumn
            // 
            this.productUnidadeDataGridViewTextBoxColumn.DataPropertyName = "Product_Unidade";
            resources.ApplyResources(this.productUnidadeDataGridViewTextBoxColumn, "productUnidadeDataGridViewTextBoxColumn");
            this.productUnidadeDataGridViewTextBoxColumn.Name = "productUnidadeDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn1
            // 
            this.quantidadeDataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            resources.ApplyResources(this.quantidadeDataGridViewTextBoxColumn1, "quantidadeDataGridViewTextBoxColumn1");
            this.quantidadeDataGridViewTextBoxColumn1.Name = "quantidadeDataGridViewTextBoxColumn1";
            // 
            // productIsActiveDataGridViewTextBoxColumn
            // 
            this.productIsActiveDataGridViewTextBoxColumn.DataPropertyName = "product_IsActive";
            resources.ApplyResources(this.productIsActiveDataGridViewTextBoxColumn, "productIsActiveDataGridViewTextBoxColumn");
            this.productIsActiveDataGridViewTextBoxColumn.Name = "productIsActiveDataGridViewTextBoxColumn";
            // 
            // produtos_view
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid_Produtos_PDF);
            this.Controls.Add(this.BTN_New_Product);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.BTN_Gerar_PDF);
            this.Controls.Add(this.Grid_View_produtos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "produtos_view";
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_View_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProdutosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produtos_PDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_Usuarios;
        private System.Windows.Forms.BindingSource returnProdutosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource returnProdutosBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid Grid_View_produtos;
        private MetroFramework.Controls.MetroButton BTN_Gerar_PDF;
        private MetroFramework.Controls.MetroTextBox TXT_Filter_Codigo;
        private MetroFramework.Controls.MetroComboBox CBX_Filter_Status;
        private MetroFramework.Controls.MetroTextBox TXT_Filter_Nome;
        private MetroFramework.Controls.MetroButton BTN_Filter_limpar;
        private MetroFramework.Controls.MetroButton BTN_Filter;
        private MetroFramework.Controls.MetroButton BTN_Edit;
        private MetroFramework.Controls.MetroButton BTN_New_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnidadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIsActiveDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView Grid_Produtos_PDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIsActiveDataGridViewTextBoxColumn;
    }
}