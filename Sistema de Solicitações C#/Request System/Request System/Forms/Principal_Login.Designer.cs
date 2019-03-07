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
            this.TXT_Pass_login = new System.Windows.Forms.TextBox();
            this.TXT_UserName_login = new System.Windows.Forms.TextBox();
            this.LBL_Information = new System.Windows.Forms.Label();
            this.LBL_User = new System.Windows.Forms.Label();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.LBL_Pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_Pass_login
            // 
            resources.ApplyResources(this.TXT_Pass_login, "TXT_Pass_login");
            this.TXT_Pass_login.Name = "TXT_Pass_login";
            // 
            // TXT_UserName_login
            // 
            resources.ApplyResources(this.TXT_UserName_login, "TXT_UserName_login");
            this.TXT_UserName_login.Name = "TXT_UserName_login";
            // 
            // LBL_Information
            // 
            resources.ApplyResources(this.LBL_Information, "LBL_Information");
            this.LBL_Information.Name = "LBL_Information";
            // 
            // LBL_User
            // 
            resources.ApplyResources(this.LBL_User, "LBL_User");
            this.LBL_User.Name = "LBL_User";
            // 
            // BTN_Login
            // 
            resources.ApplyResources(this.BTN_Login, "BTN_Login");
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // LBL_Pass
            // 
            resources.ApplyResources(this.LBL_Pass, "LBL_Pass");
            this.LBL_Pass.Name = "LBL_Pass";
            // 
            // LoginValidate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.LBL_Pass);
            this.Controls.Add(this.LBL_User);
            this.Controls.Add(this.TXT_Pass_login);
            this.Controls.Add(this.TXT_UserName_login);
            this.Controls.Add(this.LBL_Information);
            this.Name = "LoginValidate";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Pass_login;
        private System.Windows.Forms.TextBox TXT_UserName_login;
        private System.Windows.Forms.Label LBL_Information;
        private System.Windows.Forms.Label LBL_User;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Label LBL_Pass;
    }
}

