﻿namespace Request_System
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
            this.TXT_Filter_Codigo = new System.Windows.Forms.MaskedTextBox();
            this.TXT_Filter_Nome = new System.Windows.Forms.TextBox();
            this.CBX_Filter_Status = new System.Windows.Forms.ComboBox();
            this.BTN_Filter_limpar = new MetroFramework.Controls.MetroButton();
            this.BTN_Filter = new MetroFramework.Controls.MetroButton();
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
            this.Grid_Produtos_PDF = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIsActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnProdutosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_View_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produtos_PDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProdutosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Usuarios
            // 
            resources.ApplyResources(this.LBL_Usuarios, "LBL_Usuarios");
            this.LBL_Usuarios.Name = "LBL_Usuarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_Filter_Codigo);
            this.groupBox1.Controls.Add(this.TXT_Filter_Nome);
            this.groupBox1.Controls.Add(this.CBX_Filter_Status);
            this.groupBox1.Controls.Add(this.BTN_Filter_limpar);
            this.groupBox1.Controls.Add(this.BTN_Filter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // TXT_Filter_Codigo
            // 
            resources.ApplyResources(this.TXT_Filter_Codigo, "TXT_Filter_Codigo");
            this.TXT_Filter_Codigo.Name = "TXT_Filter_Codigo";
            this.TXT_Filter_Codigo.TextChanged += new System.EventHandler(this.TXT_Filter_Codigo_TextChanged);
            this.TXT_Filter_Codigo.Enter += new System.EventHandler(this.TXT_Filter_Codigo_Enter_1);
            this.TXT_Filter_Codigo.Leave += new System.EventHandler(this.TXT_Filter_Codigo_Leave_1);
            // 
            // TXT_Filter_Nome
            // 
            resources.ApplyResources(this.TXT_Filter_Nome, "TXT_Filter_Nome");
            this.TXT_Filter_Nome.Name = "TXT_Filter_Nome";
            this.TXT_Filter_Nome.TextChanged += new System.EventHandler(this.TXT_Filter_Nome_TextChanged_1);
            this.TXT_Filter_Nome.Enter += new System.EventHandler(this.TXT_Filter_Nome_Enter);
            this.TXT_Filter_Nome.Leave += new System.EventHandler(this.TXT_Filter_Nome_Leave);
            // 
            // CBX_Filter_Status
            // 
            this.CBX_Filter_Status.FormattingEnabled = true;
            resources.ApplyResources(this.CBX_Filter_Status, "CBX_Filter_Status");
            this.CBX_Filter_Status.Name = "CBX_Filter_Status";
            this.CBX_Filter_Status.SelectedIndexChanged += new System.EventHandler(this.CBX_Filter_Status_SelectedIndexChanged);
            this.CBX_Filter_Status.Enter += new System.EventHandler(this.CBX_Filter_Status_Enter);
            this.CBX_Filter_Status.Leave += new System.EventHandler(this.CBX_Filter_Status_Leave);
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
            // Grid_View_produtos
            // 
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
            resources.ApplyResources(this.Grid_View_produtos, "Grid_View_produtos");
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
            this.Grid_View_produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_View_produtos_CellDoubleClick);
            this.Grid_View_produtos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Grid_View_produtos_KeyDown);
            // 
            // productIdDataGridViewTextBoxColumn1
            // 
            this.productIdDataGridViewTextBoxColumn1.DataPropertyName = "Product_Id";
            resources.ApplyResources(this.productIdDataGridViewTextBoxColumn1, "productIdDataGridViewTextBoxColumn1");
            this.productIdDataGridViewTextBoxColumn1.Name = "productIdDataGridViewTextBoxColumn1";
            this.productIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            this.productNameDataGridViewTextBoxColumn1.DataPropertyName = "Product_Name";
            resources.ApplyResources(this.productNameDataGridViewTextBoxColumn1, "productNameDataGridViewTextBoxColumn1");
            this.productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            this.productNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productUnidadeDataGridViewTextBoxColumn1
            // 
            this.productUnidadeDataGridViewTextBoxColumn1.DataPropertyName = "Product_Unidade";
            resources.ApplyResources(this.productUnidadeDataGridViewTextBoxColumn1, "productUnidadeDataGridViewTextBoxColumn1");
            this.productUnidadeDataGridViewTextBoxColumn1.Name = "productUnidadeDataGridViewTextBoxColumn1";
            this.productUnidadeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.productUnidadeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            resources.ApplyResources(this.quantidadeDataGridViewTextBoxColumn, "quantidadeDataGridViewTextBoxColumn");
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productIsActiveDataGridViewTextBoxColumn1
            // 
            this.productIsActiveDataGridViewTextBoxColumn1.DataPropertyName = "product_IsActive";
            resources.ApplyResources(this.productIsActiveDataGridViewTextBoxColumn1, "productIsActiveDataGridViewTextBoxColumn1");
            this.productIsActiveDataGridViewTextBoxColumn1.Name = "productIsActiveDataGridViewTextBoxColumn1";
            this.productIsActiveDataGridViewTextBoxColumn1.ReadOnly = true;
            this.productIsActiveDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // Grid_Produtos_PDF
            // 
            this.Grid_Produtos_PDF.AutoGenerateColumns = false;
            this.Grid_Produtos_PDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Produtos_PDF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.productNameDataGridViewTextBoxColumn,
            this.productUnidadeDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn1,
            this.productIsActiveDataGridViewTextBoxColumn});
            this.Grid_Produtos_PDF.DataSource = this.returnProdutosBindingSource;
            resources.ApplyResources(this.Grid_Produtos_PDF, "Grid_Produtos_PDF");
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
            // returnProdutosBindingSource1
            // 
            this.returnProdutosBindingSource1.DataSource = typeof(Request_System.ReturnProdutos);
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
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produtos_PDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProdutosBindingSource1)).EndInit();
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
        private MetroFramework.Controls.MetroButton BTN_Filter_limpar;
        private MetroFramework.Controls.MetroButton BTN_Filter;
        private MetroFramework.Controls.MetroButton BTN_Edit;
        private MetroFramework.Controls.MetroButton BTN_New_Product;
        private System.Windows.Forms.DataGridView Grid_Produtos_PDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIsActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnidadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIsActiveDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox TXT_Filter_Nome;
        private System.Windows.Forms.ComboBox CBX_Filter_Status;
        private System.Windows.Forms.MaskedTextBox TXT_Filter_Codigo;
    }
}