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
            this.TXT_UserName_login = new MetroFramework.Controls.MetroTextBox();
            this.TXT_Pass_login = new MetroFramework.Controls.MetroTextBox();
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
            resources.ApplyResources(this.BTN_Entrar, "BTN_Entrar");
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.UseSelectable = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.BTN_Entrar_Click);
            // 
            // TXT_UserName_login
            // 
            // 
            // 
            // 
            this.TXT_UserName_login.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.TXT_UserName_login.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.TXT_UserName_login.CustomButton.Name = "";
            this.TXT_UserName_login.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.TXT_UserName_login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_UserName_login.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.TXT_UserName_login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_UserName_login.CustomButton.UseSelectable = true;
            this.TXT_UserName_login.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.TXT_UserName_login.Lines = new string[0];
            resources.ApplyResources(this.TXT_UserName_login, "TXT_UserName_login");
            this.TXT_UserName_login.MaxLength = 32767;
            this.TXT_UserName_login.Name = "TXT_UserName_login";
            this.TXT_UserName_login.PasswordChar = '\0';
            this.TXT_UserName_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_UserName_login.SelectedText = "";
            this.TXT_UserName_login.SelectionLength = 0;
            this.TXT_UserName_login.SelectionStart = 0;
            this.TXT_UserName_login.ShortcutsEnabled = true;
            this.TXT_UserName_login.UseSelectable = true;
            this.TXT_UserName_login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_UserName_login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TXT_Pass_login
            // 
            // 
            // 
            // 
            this.TXT_Pass_login.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.TXT_Pass_login.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.TXT_Pass_login.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.TXT_Pass_login.CustomButton.Name = "";
            this.TXT_Pass_login.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.TXT_Pass_login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Pass_login.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.TXT_Pass_login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Pass_login.CustomButton.UseSelectable = true;
            this.TXT_Pass_login.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.TXT_Pass_login.Lines = new string[0];
            resources.ApplyResources(this.TXT_Pass_login, "TXT_Pass_login");
            this.TXT_Pass_login.MaxLength = 32767;
            this.TXT_Pass_login.Name = "TXT_Pass_login";
            this.TXT_Pass_login.PasswordChar = '\0';
            this.TXT_Pass_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Pass_login.SelectedText = "";
            this.TXT_Pass_login.SelectionLength = 0;
            this.TXT_Pass_login.SelectionStart = 0;
            this.TXT_Pass_login.ShortcutsEnabled = true;
            this.TXT_Pass_login.UseSelectable = true;
            this.TXT_Pass_login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Pass_login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginValidate
            // 
            this.AcceptButton = this.BTN_Entrar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TXT_Pass_login);
            this.Controls.Add(this.TXT_UserName_login);
            this.Controls.Add(this.BTN_Entrar);
            this.Controls.Add(this.LBL_Pass);
            this.Controls.Add(this.LBL_User);
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
        private MetroFramework.Controls.MetroTextBox TXT_UserName_login;
        private MetroFramework.Controls.MetroTextBox TXT_Pass_login;
    }
}

