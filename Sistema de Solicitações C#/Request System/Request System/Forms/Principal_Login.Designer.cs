namespace Request_System
{
    partial class LoginValidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginValidate));
            this.LBL_User = new System.Windows.Forms.Label();
            this.LBL_Pass = new System.Windows.Forms.Label();
            this.BTN_Entrar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_UserName_login = new System.Windows.Forms.TextBox();
            this.TXT_Pass_login = new System.Windows.Forms.TextBox();
            this.CBX_Idioma = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_User
            // 
            resources.ApplyResources(this.LBL_User, "LBL_User");
            this.LBL_User.Name = "LBL_User";
            // 
            // LBL_Pass
            // 
            resources.ApplyResources(this.LBL_Pass, "LBL_Pass");
            this.LBL_Pass.Name = "LBL_Pass";
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.CausesValidation = false;
            this.BTN_Entrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BTN_Entrar, "BTN_Entrar");
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.UseSelectable = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.BTN_Entrar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TXT_UserName_login
            // 
            resources.ApplyResources(this.TXT_UserName_login, "TXT_UserName_login");
            this.TXT_UserName_login.Name = "TXT_UserName_login";
            this.TXT_UserName_login.Enter += new System.EventHandler(this.TXT_UserName_login_Enter);
            this.TXT_UserName_login.Leave += new System.EventHandler(this.TXT_UserName_login_Leave);
            // 
            // TXT_Pass_login
            // 
            resources.ApplyResources(this.TXT_Pass_login, "TXT_Pass_login");
            this.TXT_Pass_login.Name = "TXT_Pass_login";
            this.TXT_Pass_login.Enter += new System.EventHandler(this.TXT_Pass_login_Enter);
            this.TXT_Pass_login.Leave += new System.EventHandler(this.TXT_Pass_login_Leave);
            // 
            // CBX_Idioma
            // 
            this.CBX_Idioma.FormattingEnabled = true;
            resources.ApplyResources(this.CBX_Idioma, "CBX_Idioma");
            this.CBX_Idioma.Name = "CBX_Idioma";
            this.CBX_Idioma.SelectedIndexChanged += new System.EventHandler(this.CBX_Idioma_SelectedIndexChanged_1);
            this.CBX_Idioma.Enter += new System.EventHandler(this.CBX_Idioma_Enter);
            this.CBX_Idioma.Leave += new System.EventHandler(this.CBX_Idioma_Leave);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // LoginValidate
            // 
            this.AcceptButton = this.BTN_Entrar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.Controls.Add(this.CBX_Idioma);
            this.Controls.Add(this.TXT_Pass_login);
            this.Controls.Add(this.TXT_UserName_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Entrar);
            this.Controls.Add(this.LBL_Pass);
            this.Controls.Add(this.LBL_User);
            this.Controls.Add(this.btn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginValidate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginValidate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_User;
        private System.Windows.Forms.Label LBL_Pass;
        private MetroFramework.Controls.MetroButton BTN_Entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_UserName_login;
        private System.Windows.Forms.TextBox TXT_Pass_login;
        private System.Windows.Forms.ComboBox CBX_Idioma;
        private System.Windows.Forms.Button btn_cancel;
    }
}

