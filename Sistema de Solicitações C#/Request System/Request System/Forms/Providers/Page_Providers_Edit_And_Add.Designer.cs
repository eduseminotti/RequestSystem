namespace Request_System
{
    partial class Page_Providers_Edit_And_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Providers_Edit_And_Add));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Razao_social = new System.Windows.Forms.TextBox();
            this.TXT_Nome_Fantasia = new System.Windows.Forms.TextBox();
            this.BTN_Cancelar1 = new MetroFramework.Controls.MetroButton();
            this.BTN_Salvar1 = new MetroFramework.Controls.MetroButton();
            this.TXT_Codigo = new System.Windows.Forms.TextBox();
            this.TXT_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.TXT_Phone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // TXT_Razao_social
            // 
            resources.ApplyResources(this.TXT_Razao_social, "TXT_Razao_social");
            this.TXT_Razao_social.Name = "TXT_Razao_social";
            this.TXT_Razao_social.TextChanged += new System.EventHandler(this.TXT_Razao_social_TextChanged);
            this.TXT_Razao_social.Enter += new System.EventHandler(this.TXT_Razao_social_Enter);
            this.TXT_Razao_social.Leave += new System.EventHandler(this.TXT_Razao_social_Leave);
            // 
            // TXT_Nome_Fantasia
            // 
            resources.ApplyResources(this.TXT_Nome_Fantasia, "TXT_Nome_Fantasia");
            this.TXT_Nome_Fantasia.Name = "TXT_Nome_Fantasia";
            this.TXT_Nome_Fantasia.Enter += new System.EventHandler(this.TXT_Nome_Fantasia_Enter);
            this.TXT_Nome_Fantasia.Leave += new System.EventHandler(this.TXT_Nome_Fantasia_Leave);
            // 
            // BTN_Cancelar1
            // 
            this.BTN_Cancelar1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BTN_Cancelar1, "BTN_Cancelar1");
            this.BTN_Cancelar1.Name = "BTN_Cancelar1";
            this.BTN_Cancelar1.UseSelectable = true;
            this.BTN_Cancelar1.Click += new System.EventHandler(this.BTN_Cancelar1_Click);
            // 
            // BTN_Salvar1
            // 
            resources.ApplyResources(this.BTN_Salvar1, "BTN_Salvar1");
            this.BTN_Salvar1.Name = "BTN_Salvar1";
            this.BTN_Salvar1.UseSelectable = true;
            this.BTN_Salvar1.Click += new System.EventHandler(this.BTN_Salvar1_Click);
            // 
            // TXT_Codigo
            // 
            resources.ApplyResources(this.TXT_Codigo, "TXT_Codigo");
            this.TXT_Codigo.Name = "TXT_Codigo";
            this.TXT_Codigo.ReadOnly = true;
            // 
            // TXT_CNPJ
            // 
            resources.ApplyResources(this.TXT_CNPJ, "TXT_CNPJ");
            this.TXT_CNPJ.Name = "TXT_CNPJ";
            this.TXT_CNPJ.Enter += new System.EventHandler(this.TXT_CNPJ_Enter);
            this.TXT_CNPJ.Leave += new System.EventHandler(this.TXT_CNPJ_Leave);
            // 
            // TXT_Phone
            // 
            resources.ApplyResources(this.TXT_Phone, "TXT_Phone");
            this.TXT_Phone.Name = "TXT_Phone";
            this.TXT_Phone.Enter += new System.EventHandler(this.TXT_Phone_Enter);
            this.TXT_Phone.Leave += new System.EventHandler(this.TXT_Phone_Leave);
            // 
            // Page_Providers_Edit_And_Add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancelar1;
            this.ControlBox = false;
            this.Controls.Add(this.TXT_Phone);
            this.Controls.Add(this.TXT_CNPJ);
            this.Controls.Add(this.BTN_Salvar1);
            this.Controls.Add(this.BTN_Cancelar1);
            this.Controls.Add(this.TXT_Nome_Fantasia);
            this.Controls.Add(this.TXT_Razao_social);
            this.Controls.Add(this.TXT_Codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Page_Providers_Edit_And_Add";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_Providers_Edit_And_Add_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Razao_social;
        private System.Windows.Forms.TextBox TXT_Nome_Fantasia;
        private MetroFramework.Controls.MetroButton BTN_Cancelar1;
        private MetroFramework.Controls.MetroButton BTN_Salvar1;
        private System.Windows.Forms.TextBox TXT_Codigo;
        private System.Windows.Forms.MaskedTextBox TXT_CNPJ;
        private System.Windows.Forms.MaskedTextBox TXT_Phone;
    }
}