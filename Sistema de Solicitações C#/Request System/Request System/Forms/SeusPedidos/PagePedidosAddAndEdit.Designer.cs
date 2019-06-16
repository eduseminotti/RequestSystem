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
            this.BTN_Seleciona_produto = new MetroFramework.Controls.MetroButton();
            this.List_products = new System.Windows.Forms.ListBox();
            this.BTN_Remove_Item = new MetroFramework.Controls.MetroButton();
            this.BTN_Fechar = new MetroFramework.Controls.MetroButton();
            this.TXT_qtd_Itens = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Salvar = new MetroFramework.Controls.MetroButton();
            this.GB_Seleciona_produto = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Find_product = new System.Windows.Forms.TextBox();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnItensSolicitacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Itens_solicitacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_qtd_Itens)).BeginInit();
            this.GB_Seleciona_produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnItensSolicitacoesBindingSource)).BeginInit();
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
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.Grid_Itens_solicitacoes.DataSource = this.returnItensSolicitacoesBindingSource;
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
            // BTN_Seleciona_produto
            // 
            resources.ApplyResources(this.BTN_Seleciona_produto, "BTN_Seleciona_produto");
            this.BTN_Seleciona_produto.Name = "BTN_Seleciona_produto";
            this.BTN_Seleciona_produto.UseSelectable = true;
            this.BTN_Seleciona_produto.Click += new System.EventHandler(this.BTN_Seleciona_produto_Click);
            // 
            // List_products
            // 
            this.List_products.DisplayMember = "Product_Name";
            this.List_products.FormattingEnabled = true;
            resources.ApplyResources(this.List_products, "List_products");
            this.List_products.Name = "List_products";
            this.List_products.ValueMember = "Product_Name";
            // 
            // BTN_Remove_Item
            // 
            resources.ApplyResources(this.BTN_Remove_Item, "BTN_Remove_Item");
            this.BTN_Remove_Item.Name = "BTN_Remove_Item";
            this.BTN_Remove_Item.UseSelectable = true;
            this.BTN_Remove_Item.Click += new System.EventHandler(this.BTN_Remove_Item_Click);
            // 
            // BTN_Fechar
            // 
            this.BTN_Fechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BTN_Fechar, "BTN_Fechar");
            this.BTN_Fechar.Name = "BTN_Fechar";
            this.BTN_Fechar.UseSelectable = true;
            this.BTN_Fechar.Click += new System.EventHandler(this.BTN_Fechar_Click);
            // 
            // TXT_qtd_Itens
            // 
            resources.ApplyResources(this.TXT_qtd_Itens, "TXT_qtd_Itens");
            this.TXT_qtd_Itens.Name = "TXT_qtd_Itens";
            this.TXT_qtd_Itens.Enter += new System.EventHandler(this.TXT_qtd_Itens_Enter);
            this.TXT_qtd_Itens.Leave += new System.EventHandler(this.TXT_qtd_Itens_Leave);
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
            // TXT_Find_product
            // 
            resources.ApplyResources(this.TXT_Find_product, "TXT_Find_product");
            this.TXT_Find_product.Name = "TXT_Find_product";
            this.TXT_Find_product.TextChanged += new System.EventHandler(this.TXT_Find_product_TextChanged);
            this.TXT_Find_product.Enter += new System.EventHandler(this.TXT_Find_product_Enter);
            this.TXT_Find_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Find_product_KeyDown);
            this.TXT_Find_product.Leave += new System.EventHandler(this.TXT_Find_product_Leave);
            // 
            // txt_motivo
            // 
            resources.ApplyResources(this.txt_motivo, "txt_motivo");
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Enter += new System.EventHandler(this.Txt_motivo_Enter);
            this.txt_motivo.Leave += new System.EventHandler(this.Txt_motivo_Leave);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ProductName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn11, "dataGridViewTextBoxColumn11");
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "QuantidadeSolicitada";
            resources.ApplyResources(this.dataGridViewTextBoxColumn12, "dataGridViewTextBoxColumn12");
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "QuantidadeAprovada";
            resources.ApplyResources(this.dataGridViewTextBoxColumn13, "dataGridViewTextBoxColumn13");
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SolicitationId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SolicitationItemId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // returnItensSolicitacoesBindingSource
            // 
            this.returnItensSolicitacoesBindingSource.DataSource = typeof(Request_System.returnItensSolicitacoes);
            // 
            // PageSolicitationAddAndEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Fechar;
            this.ControlBox = false;
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.TXT_Find_product);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GB_Seleciona_produto);
            this.Controls.Add(this.BTN_Salvar);
            this.Controls.Add(this.BTN_Fechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_qtd_Itens);
            this.Controls.Add(this.BTN_Remove_Item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid_Itens_solicitacoes);
            this.Controls.Add(this.BTN_Add_product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PageSolicitationAddAndEdit";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Itens_solicitacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_qtd_Itens)).EndInit();
            this.GB_Seleciona_produto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnItensSolicitacoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton BTN_Add_product;
        private MetroFramework.Controls.MetroGrid Grid_Itens_solicitacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ListBox List_products;
        private System.Windows.Forms.NumericUpDown TXT_qtd_Itens;
        private MetroFramework.Controls.MetroButton BTN_Fechar;
        private MetroFramework.Controls.MetroButton BTN_Seleciona_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MetroFramework.Controls.MetroButton BTN_Remove_Item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TextBox TXT_Find_product;
        private System.Windows.Forms.BindingSource returnItensSolicitacoesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox txt_motivo;
    }
}