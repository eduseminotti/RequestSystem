﻿namespace Request_System
{
    partial class SeusPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeusPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBX_Status_Pedido = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Limpar = new MetroFramework.Controls.MetroButton();
            this.BTN_Filtrar = new MetroFramework.Controls.MetroButton();
            this.LBL_Usuarios = new System.Windows.Forms.Label();
            this.BTN_Excluir_Solicitacao = new MetroFramework.Controls.MetroButton();
            this.Grid_Solicitacoes = new MetroFramework.Controls.MetroGrid();
            this.returnSolicitacoesUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_Edit = new MetroFramework.Controls.MetroButton();
            this.BTN_Nova_Solicitacao = new MetroFramework.Controls.MetroButton();
            this.BTN_Gera_PDF = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBX_Status_Pedido1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.solicitatonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSolicitacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAprovacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRetiradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitationStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Solicitacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnSolicitacoesUsuarioBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.CBX_Status_Pedido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BTN_Limpar);
            this.groupBox1.Controls.Add(this.BTN_Filtrar);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // CBX_Status_Pedido
            // 
            this.CBX_Status_Pedido.FormattingEnabled = true;
            resources.ApplyResources(this.CBX_Status_Pedido, "CBX_Status_Pedido");
            this.CBX_Status_Pedido.Name = "CBX_Status_Pedido";
            this.CBX_Status_Pedido.Enter += new System.EventHandler(this.CBX_Status_Pedido1_Enter);
            this.CBX_Status_Pedido.Leave += new System.EventHandler(this.CBX_Status_Pedido1_Leave);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // BTN_Limpar
            // 
            resources.ApplyResources(this.BTN_Limpar, "BTN_Limpar");
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.UseSelectable = true;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // BTN_Filtrar
            // 
            resources.ApplyResources(this.BTN_Filtrar, "BTN_Filtrar");
            this.BTN_Filtrar.Name = "BTN_Filtrar";
            this.BTN_Filtrar.UseSelectable = true;
            this.BTN_Filtrar.Click += new System.EventHandler(this.BTN_Filtrar_Click);
            // 
            // LBL_Usuarios
            // 
            resources.ApplyResources(this.LBL_Usuarios, "LBL_Usuarios");
            this.LBL_Usuarios.Name = "LBL_Usuarios";
            // 
            // BTN_Excluir_Solicitacao
            // 
            resources.ApplyResources(this.BTN_Excluir_Solicitacao, "BTN_Excluir_Solicitacao");
            this.BTN_Excluir_Solicitacao.Name = "BTN_Excluir_Solicitacao";
            this.BTN_Excluir_Solicitacao.UseSelectable = true;
            this.BTN_Excluir_Solicitacao.Click += new System.EventHandler(this.BTN_Excluir_Solicitacao_Click);
            // 
            // Grid_Solicitacoes
            // 
            this.Grid_Solicitacoes.AllowUserToResizeRows = false;
            this.Grid_Solicitacoes.AutoGenerateColumns = false;
            this.Grid_Solicitacoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_Solicitacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Solicitacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Solicitacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Solicitacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Solicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Solicitacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.solicitatonIDDataGridViewTextBoxColumn,
            this.dataSolicitacaoDataGridViewTextBoxColumn,
            this.dataAprovacaoDataGridViewTextBoxColumn,
            this.dataRetiradaDataGridViewTextBoxColumn,
            this.motivoDataGridViewTextBoxColumn,
            this.solicitationStatusDataGridViewTextBoxColumn});
            this.Grid_Solicitacoes.DataSource = this.returnSolicitacoesUsuarioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Solicitacoes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Solicitacoes.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.Grid_Solicitacoes, "Grid_Solicitacoes");
            this.Grid_Solicitacoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_Solicitacoes.Name = "Grid_Solicitacoes";
            this.Grid_Solicitacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Solicitacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_Solicitacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Solicitacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Solicitacoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Solicitacoes_CellDoubleClick);
            // 
            // returnSolicitacoesUsuarioBindingSource
            // 
            this.returnSolicitacoesUsuarioBindingSource.DataSource = typeof(Request_System.ReturnSolicitacoesUsuario);
            // 
            // BTN_Edit
            // 
            resources.ApplyResources(this.BTN_Edit, "BTN_Edit");
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.UseSelectable = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click_1);
            // 
            // BTN_Nova_Solicitacao
            // 
            resources.ApplyResources(this.BTN_Nova_Solicitacao, "BTN_Nova_Solicitacao");
            this.BTN_Nova_Solicitacao.Name = "BTN_Nova_Solicitacao";
            this.BTN_Nova_Solicitacao.UseSelectable = true;
            this.BTN_Nova_Solicitacao.Click += new System.EventHandler(this.BTN_Nova_Solicitacao_Click);
            // 
            // BTN_Gera_PDF
            // 
            resources.ApplyResources(this.BTN_Gera_PDF, "BTN_Gera_PDF");
            this.BTN_Gera_PDF.Name = "BTN_Gera_PDF";
            this.BTN_Gera_PDF.UseSelectable = true;
            this.BTN_Gera_PDF.Click += new System.EventHandler(this.BTN_Gera_PDF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.CBX_Status_Pedido1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.metroButton2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // CBX_Status_Pedido1
            // 
            this.CBX_Status_Pedido1.FormattingEnabled = true;
            resources.ApplyResources(this.CBX_Status_Pedido1, "CBX_Status_Pedido1");
            this.CBX_Status_Pedido1.Name = "CBX_Status_Pedido1";
            this.CBX_Status_Pedido1.SelectedIndexChanged += new System.EventHandler(this.CBX_Status_Pedido1_SelectedIndexChanged_1);
            this.CBX_Status_Pedido1.Enter += new System.EventHandler(this.CBX_Status_Pedido1_Enter);
            this.CBX_Status_Pedido1.Leave += new System.EventHandler(this.CBX_Status_Pedido1_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // metroButton1
            // 
            resources.ApplyResources(this.metroButton1, "metroButton1");
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // metroButton2
            // 
            resources.ApplyResources(this.metroButton2, "metroButton2");
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.BTN_Filtrar_Click);
            // 
            // solicitatonIDDataGridViewTextBoxColumn
            // 
            this.solicitatonIDDataGridViewTextBoxColumn.DataPropertyName = "SolicitatonID";
            resources.ApplyResources(this.solicitatonIDDataGridViewTextBoxColumn, "solicitatonIDDataGridViewTextBoxColumn");
            this.solicitatonIDDataGridViewTextBoxColumn.Name = "solicitatonIDDataGridViewTextBoxColumn";
            this.solicitatonIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.solicitatonIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataSolicitacaoDataGridViewTextBoxColumn
            // 
            this.dataSolicitacaoDataGridViewTextBoxColumn.DataPropertyName = "DataSolicitacao";
            resources.ApplyResources(this.dataSolicitacaoDataGridViewTextBoxColumn, "dataSolicitacaoDataGridViewTextBoxColumn");
            this.dataSolicitacaoDataGridViewTextBoxColumn.Name = "dataSolicitacaoDataGridViewTextBoxColumn";
            this.dataSolicitacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataSolicitacaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataAprovacaoDataGridViewTextBoxColumn
            // 
            this.dataAprovacaoDataGridViewTextBoxColumn.DataPropertyName = "DataAprovacao";
            resources.ApplyResources(this.dataAprovacaoDataGridViewTextBoxColumn, "dataAprovacaoDataGridViewTextBoxColumn");
            this.dataAprovacaoDataGridViewTextBoxColumn.Name = "dataAprovacaoDataGridViewTextBoxColumn";
            this.dataAprovacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataAprovacaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataRetiradaDataGridViewTextBoxColumn
            // 
            this.dataRetiradaDataGridViewTextBoxColumn.DataPropertyName = "DataRetirada";
            resources.ApplyResources(this.dataRetiradaDataGridViewTextBoxColumn, "dataRetiradaDataGridViewTextBoxColumn");
            this.dataRetiradaDataGridViewTextBoxColumn.Name = "dataRetiradaDataGridViewTextBoxColumn";
            this.dataRetiradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataRetiradaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // motivoDataGridViewTextBoxColumn
            // 
            this.motivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo";
            resources.ApplyResources(this.motivoDataGridViewTextBoxColumn, "motivoDataGridViewTextBoxColumn");
            this.motivoDataGridViewTextBoxColumn.Name = "motivoDataGridViewTextBoxColumn";
            this.motivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.motivoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // solicitationStatusDataGridViewTextBoxColumn
            // 
            this.solicitationStatusDataGridViewTextBoxColumn.DataPropertyName = "SolicitationStatus";
            resources.ApplyResources(this.solicitationStatusDataGridViewTextBoxColumn, "solicitationStatusDataGridViewTextBoxColumn");
            this.solicitationStatusDataGridViewTextBoxColumn.Name = "solicitationStatusDataGridViewTextBoxColumn";
            this.solicitationStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.solicitationStatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SeusPedidos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Gera_PDF);
            this.Controls.Add(this.BTN_Nova_Solicitacao);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.Grid_Solicitacoes);
            this.Controls.Add(this.BTN_Excluir_Solicitacao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeusPedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Solicitacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnSolicitacoesUsuarioBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_Usuarios;
        private MetroFramework.Controls.MetroButton BTN_Excluir_Solicitacao;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton BTN_Limpar;
        private MetroFramework.Controls.MetroButton BTN_Filtrar;
        private MetroFramework.Controls.MetroGrid Grid_Solicitacoes;
        private MetroFramework.Controls.MetroButton BTN_Edit;
        private MetroFramework.Controls.MetroButton BTN_Nova_Solicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitatonIDDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroButton BTN_Gera_PDF;
        private System.Windows.Forms.BindingSource returnSolicitacoesUsuarioBindingSource;
        private System.Windows.Forms.ComboBox CBX_Status_Pedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBX_Status_Pedido1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitatonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSolicitacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAprovacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRetiradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitationStatusDataGridViewTextBoxColumn;
    }
}