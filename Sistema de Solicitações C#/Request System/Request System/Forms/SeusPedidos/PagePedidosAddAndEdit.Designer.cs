namespace Request_System
{
    partial class PageSolicitationAddAndEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageSolicitationAddAndEdit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_Add_product = new MetroFramework.Controls.MetroButton();
            this.Grid_Itens_solicitacoes = new MetroFramework.Controls.MetroGrid();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeSolicitadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeAprovadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitationItemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnItensSolicitacoesUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnItensSolicitacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensSolicitacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertSolicitacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TXT_Find_product = new MetroFramework.Controls.MetroTextBox();
            this.BTN_Seleciona_produto = new MetroFramework.Controls.MetroButton();
            this.List_products = new System.Windows.Forms.ListBox();
            this.returnProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_Remove_Item = new MetroFramework.Controls.MetroButton();
            this.BTN_busca_produto = new MetroFramework.Controls.MetroButton();
            this.BTN_Fechar = new MetroFramework.Controls.MetroButton();
            this.TXT_qtd_Itens = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_motivo = new MetroFramework.Controls.MetroTextBox();
            this.BTN_Salvar = new MetroFramework.Controls.MetroButton();
            this.GB_Seleciona_produto = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Itens_solicitacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItensSolicitacoesUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItensSolicitacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensSolicitacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertSolicitacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_qtd_Itens)).BeginInit();
            this.GB_Seleciona_produto.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Add_product
            // 
            resources.ApplyResources(this.BTN_Add_product, "BTN_Add_product");
            this.BTN_Add_product.Name = "BTN_Add_product";
            this.BTN_Add_product.UseSelectable = true;
            this.BTN_Add_product.Click += new System.EventHandler(this.BTN_Add_product_Click);
            // 
            // Grid_Itens_solicitacoes
            // 
            this.Grid_Itens_solicitacoes.AllowUserToResizeRows = false;
            this.Grid_Itens_solicitacoes.AutoGenerateColumns = false;
            this.Grid_Itens_solicitacoes.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Itens_solicitacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Itens_solicitacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Itens_solicitacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Itens_solicitacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Itens_solicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Itens_solicitacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantidadeSolicitadaDataGridViewTextBoxColumn,
            this.quantidadeAprovadaDataGridViewTextBoxColumn,
            this.solicitationIdDataGridViewTextBoxColumn,
            this.solicitationItemIdDataGridViewTextBoxColumn});
            this.Grid_Itens_solicitacoes.DataSource = this.returnItensSolicitacoesUsuarioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Itens_solicitacoes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Itens_solicitacoes.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.Grid_Itens_solicitacoes, "Grid_Itens_solicitacoes");
            this.Grid_Itens_solicitacoes.GridColor = System.Drawing.Color.White;
            this.Grid_Itens_solicitacoes.Name = "Grid_Itens_solicitacoes";
            this.Grid_Itens_solicitacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Itens_solicitacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_Itens_solicitacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Itens_solicitacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            resources.ApplyResources(this.productIdDataGridViewTextBoxColumn, "productIdDataGridViewTextBoxColumn");
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            resources.ApplyResources(this.productNameDataGridViewTextBoxColumn, "productNameDataGridViewTextBoxColumn");
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // solicitationIdDataGridViewTextBoxColumn
            // 
            this.solicitationIdDataGridViewTextBoxColumn.DataPropertyName = "SolicitationId";
            resources.ApplyResources(this.solicitationIdDataGridViewTextBoxColumn, "solicitationIdDataGridViewTextBoxColumn");
            this.solicitationIdDataGridViewTextBoxColumn.Name = "solicitationIdDataGridViewTextBoxColumn";
            // 
            // solicitationItemIdDataGridViewTextBoxColumn
            // 
            this.solicitationItemIdDataGridViewTextBoxColumn.DataPropertyName = "SolicitationItemId";
            resources.ApplyResources(this.solicitationItemIdDataGridViewTextBoxColumn, "solicitationItemIdDataGridViewTextBoxColumn");
            this.solicitationItemIdDataGridViewTextBoxColumn.Name = "solicitationItemIdDataGridViewTextBoxColumn";
            // 
            // returnItensSolicitacoesUsuarioBindingSource
            // 
            this.returnItensSolicitacoesUsuarioBindingSource.DataSource = typeof(Request_System.ManipulaSolicitacoesStockMan);
            // 
            // TXT_Find_product
            // 
            // 
            // 
            // 
            this.TXT_Find_product.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.TXT_Find_product.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.TXT_Find_product.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.TXT_Find_product.CustomButton.Name = "";
            this.TXT_Find_product.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.TXT_Find_product.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Find_product.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.TXT_Find_product.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Find_product.CustomButton.UseSelectable = true;
            this.TXT_Find_product.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.TXT_Find_product.Lines = new string[0];
            resources.ApplyResources(this.TXT_Find_product, "TXT_Find_product");
            this.TXT_Find_product.MaxLength = 32767;
            this.TXT_Find_product.Name = "TXT_Find_product";
            this.TXT_Find_product.PasswordChar = '\0';
            this.TXT_Find_product.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Find_product.SelectedText = "";
            this.TXT_Find_product.SelectionLength = 0;
            this.TXT_Find_product.SelectionStart = 0;
            this.TXT_Find_product.ShortcutsEnabled = true;
            this.TXT_Find_product.UseSelectable = true;
            this.TXT_Find_product.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Find_product.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_Find_product.TextChanged += new System.EventHandler(this.TXT_Find_product_TextChanged);

            // 
            // BTN_Seleciona_produto
            // 
            resources.ApplyResources(this.BTN_Seleciona_produto, "BTN_Seleciona_produto");
            this.BTN_Seleciona_produto.Name = "BTN_Seleciona_produto";
            this.BTN_Seleciona_produto.UseSelectable = true;
            this.BTN_Seleciona_produto.Click += new System.EventHandler(this.BTN_Seleciona_produto_Click);
            // 
            // List_products
            // 
            this.List_products.DataSource = this.returnProdutosBindingSource;
            this.List_products.DisplayMember = "Product_Name";
            this.List_products.FormattingEnabled = true;
            resources.ApplyResources(this.List_products, "List_products");
            this.List_products.Name = "List_products";
            this.List_products.ValueMember = "Product_Name";
            // 
            // returnProdutosBindingSource
            // 
            this.returnProdutosBindingSource.DataSource = typeof(Request_System.ReturnProdutos);
            // 
            // BTN_Remove_Item
            // 
            resources.ApplyResources(this.BTN_Remove_Item, "BTN_Remove_Item");
            this.BTN_Remove_Item.Name = "BTN_Remove_Item";
            this.BTN_Remove_Item.UseSelectable = true;
            this.BTN_Remove_Item.Click += new System.EventHandler(this.BTN_Remove_Item_Click);
            // 
            // BTN_busca_produto
            // 
            resources.ApplyResources(this.BTN_busca_produto, "BTN_busca_produto");
            this.BTN_busca_produto.Name = "BTN_busca_produto";
            this.BTN_busca_produto.UseSelectable = true;
            this.BTN_busca_produto.Click += new System.EventHandler(this.BTN_busca_produto_Click);
            // 
            // BTN_Fechar
            // 
            resources.ApplyResources(this.BTN_Fechar, "BTN_Fechar");
            this.BTN_Fechar.Name = "BTN_Fechar";
            this.BTN_Fechar.UseSelectable = true;
            this.BTN_Fechar.Click += new System.EventHandler(this.BTN_Fechar_Click);
            // 
            // TXT_qtd_Itens
            // 
            resources.ApplyResources(this.TXT_qtd_Itens, "TXT_qtd_Itens");
            this.TXT_qtd_Itens.Name = "TXT_qtd_Itens";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txt_motivo
            // 
            // 
            // 
            // 
            this.txt_motivo.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txt_motivo.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.txt_motivo.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txt_motivo.CustomButton.Name = "";
            this.txt_motivo.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txt_motivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_motivo.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txt_motivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_motivo.CustomButton.UseSelectable = true;
            this.txt_motivo.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.txt_motivo.Lines = new string[0];
            resources.ApplyResources(this.txt_motivo, "txt_motivo");
            this.txt_motivo.MaxLength = 250;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.PasswordChar = '\0';
            this.txt_motivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_motivo.SelectedText = "";
            this.txt_motivo.SelectionLength = 0;
            this.txt_motivo.SelectionStart = 0;
            this.txt_motivo.ShortcutsEnabled = true;
            this.txt_motivo.UseSelectable = true;
            this.txt_motivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_motivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTN_Salvar
            // 
            resources.ApplyResources(this.BTN_Salvar, "BTN_Salvar");
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.UseSelectable = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // GB_Seleciona_produto
            // 
            this.GB_Seleciona_produto.Controls.Add(this.List_products);
            this.GB_Seleciona_produto.Controls.Add(this.BTN_Seleciona_produto);
            resources.ApplyResources(this.GB_Seleciona_produto, "GB_Seleciona_produto");
            this.GB_Seleciona_produto.Name = "GB_Seleciona_produto";
            this.GB_Seleciona_produto.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // PageSolicitationAddAndEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GB_Seleciona_produto);
            this.Controls.Add(this.BTN_Salvar);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.BTN_Fechar);
            this.Controls.Add(this.BTN_busca_produto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_qtd_Itens);
            this.Controls.Add(this.BTN_Remove_Item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid_Itens_solicitacoes);
            this.Controls.Add(this.TXT_Find_product);
            this.Controls.Add(this.BTN_Add_product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PageSolicitationAddAndEdit";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Itens_solicitacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItensSolicitacoesUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItensSolicitacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensSolicitacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertSolicitacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_qtd_Itens)).EndInit();
            this.GB_Seleciona_produto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton BTN_Add_product;
        private MetroFramework.Controls.MetroGrid Grid_Itens_solicitacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource insertSolicitacoesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource itensSolicitacoesBindingSource;
        private MetroFramework.Controls.MetroTextBox TXT_Find_product;
        private System.Windows.Forms.ListBox List_products;
        private System.Windows.Forms.BindingSource returnProdutosBindingSource;
        private System.Windows.Forms.NumericUpDown TXT_qtd_Itens;
        private MetroFramework.Controls.MetroButton BTN_Fechar;
        private MetroFramework.Controls.MetroButton BTN_busca_produto;
        private MetroFramework.Controls.MetroButton BTN_Seleciona_produto;
        private System.Windows.Forms.BindingSource returnItensSolicitacoesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MetroFramework.Controls.MetroButton BTN_Remove_Item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource returnItensSolicitacoesUsuarioBindingSource;
        private MetroFramework.Controls.MetroTextBox txt_motivo;
        private MetroFramework.Controls.MetroButton BTN_Salvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox GB_Seleciona_produto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeSolicitadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeAprovadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitationItemIdDataGridViewTextBoxColumn;
    }
}