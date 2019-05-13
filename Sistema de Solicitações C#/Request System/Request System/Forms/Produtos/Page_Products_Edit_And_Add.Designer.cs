namespace Request_System
{
    partial class Page_Products_Edit_And_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Products_Edit_And_Add));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Product_Salvar = new MetroFramework.Controls.MetroButton();
            this.BTN_Product_Cancel = new MetroFramework.Controls.MetroButton();
            this.CBX_Status_Produto = new MetroFramework.Controls.MetroComboBox();
            this.TXT_Product_Codigo = new System.Windows.Forms.TextBox();
            this.TXT_Nome_Produto = new System.Windows.Forms.TextBox();
            this.TXT_Tipo_Unidade = new System.Windows.Forms.TextBox();
            this.txt_validacombo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // BTN_Product_Salvar
            // 
            resources.ApplyResources(this.BTN_Product_Salvar, "BTN_Product_Salvar");
            this.BTN_Product_Salvar.Name = "BTN_Product_Salvar";
            this.BTN_Product_Salvar.UseSelectable = true;
            this.BTN_Product_Salvar.Click += new System.EventHandler(this.BTN_Product_Salvar_Click_1);
            // 
            // BTN_Product_Cancel
            // 
            this.BTN_Product_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BTN_Product_Cancel, "BTN_Product_Cancel");
            this.BTN_Product_Cancel.Name = "BTN_Product_Cancel";
            this.BTN_Product_Cancel.UseSelectable = true;
            this.BTN_Product_Cancel.Click += new System.EventHandler(this.BTN_Product_Cancel_Click_1);
            // 
            // CBX_Status_Produto
            // 
            this.CBX_Status_Produto.FormattingEnabled = true;
            resources.ApplyResources(this.CBX_Status_Produto, "CBX_Status_Produto");
            this.CBX_Status_Produto.Name = "CBX_Status_Produto";
            this.CBX_Status_Produto.UseSelectable = true;
            this.CBX_Status_Produto.SelectedIndexChanged += new System.EventHandler(this.CBX_Status_Produto_SelectedIndexChanged);
            // 
            // TXT_Product_Codigo
            // 
            resources.ApplyResources(this.TXT_Product_Codigo, "TXT_Product_Codigo");
            this.TXT_Product_Codigo.Name = "TXT_Product_Codigo";
            this.TXT_Product_Codigo.ReadOnly = true;
            // 
            // TXT_Nome_Produto
            // 
            resources.ApplyResources(this.TXT_Nome_Produto, "TXT_Nome_Produto");
            this.TXT_Nome_Produto.Name = "TXT_Nome_Produto";
            this.TXT_Nome_Produto.TextChanged += new System.EventHandler(this.TXT_Nome_Produto_TextChanged);
            // 
            // TXT_Tipo_Unidade
            // 
            resources.ApplyResources(this.TXT_Tipo_Unidade, "TXT_Tipo_Unidade");
            this.TXT_Tipo_Unidade.Name = "TXT_Tipo_Unidade";
            this.TXT_Tipo_Unidade.TextChanged += new System.EventHandler(this.TXT_Tipo_Unidade_TextChanged);
            // 
            // txt_validacombo
            // 
            this.txt_validacombo.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.txt_validacombo, "txt_validacombo");
            this.txt_validacombo.Name = "txt_validacombo";
            this.txt_validacombo.ReadOnly = true;
            // 
            // Page_Products_Edit_And_Add
            // 
            this.AcceptButton = this.BTN_Product_Salvar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Product_Cancel;
            this.ControlBox = false;
            this.Controls.Add(this.CBX_Status_Produto);
            this.Controls.Add(this.txt_validacombo);
            this.Controls.Add(this.TXT_Tipo_Unidade);
            this.Controls.Add(this.TXT_Nome_Produto);
            this.Controls.Add(this.TXT_Product_Codigo);
            this.Controls.Add(this.BTN_Product_Cancel);
            this.Controls.Add(this.BTN_Product_Salvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Page_Products_Edit_And_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton BTN_Product_Salvar;
        private MetroFramework.Controls.MetroButton BTN_Product_Cancel;
        private MetroFramework.Controls.MetroComboBox CBX_Status_Produto;
        private System.Windows.Forms.TextBox TXT_Product_Codigo;
        private System.Windows.Forms.TextBox TXT_Nome_Produto;
        private System.Windows.Forms.TextBox TXT_Tipo_Unidade;
        private System.Windows.Forms.TextBox txt_validacombo;
    }
}