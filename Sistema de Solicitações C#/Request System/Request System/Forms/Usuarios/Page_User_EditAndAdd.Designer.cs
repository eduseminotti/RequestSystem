namespace Request_System
{
    partial class PageUserEditandAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageUserEditandAdd));
            this.TXT_Nome = new System.Windows.Forms.TextBox();
            this.TXT_Email = new System.Windows.Forms.TextBox();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Setor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BTN_UserCancel = new MetroFramework.Controls.MetroButton();
            this.BTN_UserSalvar = new MetroFramework.Controls.MetroButton();
            this.TXT_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_Confirm_Pass = new System.Windows.Forms.TextBox();
            this.CBX_TYPE = new System.Windows.Forms.ComboBox();
            this.CBX_Status = new System.Windows.Forms.ComboBox();
            this.returnUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.returnUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_Nome
            // 
            this.TXT_Nome.BackColor = System.Drawing.Color.White;
            this.TXT_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TXT_Nome, "TXT_Nome");
            this.TXT_Nome.Name = "TXT_Nome";
            this.TXT_Nome.TextChanged += new System.EventHandler(this.TXT_Nome_TextChanged);
            this.TXT_Nome.Enter += new System.EventHandler(this.TXT_Nome_Enter);
            this.TXT_Nome.Leave += new System.EventHandler(this.TXT_Nome_Leave);
            // 
            // TXT_Email
            // 
            resources.ApplyResources(this.TXT_Email, "TXT_Email");
            this.TXT_Email.Name = "TXT_Email";
            this.TXT_Email.TextChanged += new System.EventHandler(this.TXT_Email_TextChanged);
            this.TXT_Email.Enter += new System.EventHandler(this.TXT_Email_Enter);
            this.TXT_Email.Leave += new System.EventHandler(this.TXT_Email_Leave);
            // 
            // TXT_Usuario
            // 
            resources.ApplyResources(this.TXT_Usuario, "TXT_Usuario");
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.TextChanged += new System.EventHandler(this.TXT_Usuario_TextChanged);
            this.TXT_Usuario.Enter += new System.EventHandler(this.TXT_Usuario_Enter);
            this.TXT_Usuario.Leave += new System.EventHandler(this.TXT_Usuario_Leave);
            // 
            // TXT_Setor
            // 
            resources.ApplyResources(this.TXT_Setor, "TXT_Setor");
            this.TXT_Setor.Name = "TXT_Setor";

            this.TXT_Setor.Enter += new System.EventHandler(this.TXT_Setor_Enter);
            this.TXT_Setor.Leave += new System.EventHandler(this.TXT_Setor_Leave);
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
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // TXT_Password
            // 
            resources.ApplyResources(this.TXT_Password, "TXT_Password");
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.TextChanged += new System.EventHandler(this.TXT_Password_TextChanged);
            this.TXT_Password.Enter += new System.EventHandler(this.TXT_Password_Enter);
            this.TXT_Password.Leave += new System.EventHandler(this.TXT_Password_Leave);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // BTN_UserCancel
            // 
            this.BTN_UserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BTN_UserCancel, "BTN_UserCancel");
            this.BTN_UserCancel.Name = "BTN_UserCancel";
            this.BTN_UserCancel.UseSelectable = true;
            this.BTN_UserCancel.Click += new System.EventHandler(this.BTN_UserCancel_Click);
            // 
            // BTN_UserSalvar
            // 
            resources.ApplyResources(this.BTN_UserSalvar, "BTN_UserSalvar");
            this.BTN_UserSalvar.Name = "BTN_UserSalvar";
            this.BTN_UserSalvar.UseSelectable = true;
            this.BTN_UserSalvar.Click += new System.EventHandler(this.BTN_UserSalvar_Click);
            // 
            // TXT_CPF
            // 
            resources.ApplyResources(this.TXT_CPF, "TXT_CPF");
            this.TXT_CPF.Name = "TXT_CPF";
            
            this.TXT_CPF.Enter += new System.EventHandler(this.TXT_CPF_Enter);
            this.TXT_CPF.Leave += new System.EventHandler(this.TXT_CPF_Leave);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // TXT_Confirm_Pass
            // 
            resources.ApplyResources(this.TXT_Confirm_Pass, "TXT_Confirm_Pass");
            this.TXT_Confirm_Pass.Name = "TXT_Confirm_Pass";
            this.TXT_Confirm_Pass.TextChanged += new System.EventHandler(this.TXT_Confirm_Pass_TextChanged);
            this.TXT_Confirm_Pass.Enter += new System.EventHandler(this.TXT_Confirm_Pass_Enter);
            this.TXT_Confirm_Pass.Leave += new System.EventHandler(this.TXT_Confirm_Pass_Leave);
            // 
            // CBX_TYPE
            // 
            this.CBX_TYPE.FormattingEnabled = true;
            resources.ApplyResources(this.CBX_TYPE, "CBX_TYPE");
            this.CBX_TYPE.Name = "CBX_TYPE";
            this.CBX_TYPE.Enter += new System.EventHandler(this.CBX_TYPE_Enter);
            this.CBX_TYPE.Leave += new System.EventHandler(this.CBX_TYPE_Leave);
            // 
            // CBX_Status
            // 
            this.CBX_Status.FormattingEnabled = true;
            resources.ApplyResources(this.CBX_Status, "CBX_Status");
            this.CBX_Status.Name = "CBX_Status";
            this.CBX_Status.Enter += new System.EventHandler(this.CBX_Status_Enter);
            this.CBX_Status.Leave += new System.EventHandler(this.CBX_Status_Leave);
            // 
            // returnUsuariosBindingSource
            // 
            this.returnUsuariosBindingSource.DataSource = typeof(Request_System.Return_Usuarios);
            // 
            // PageUserEditandAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.BTN_UserCancel;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.CBX_Status);
            this.Controls.Add(this.CBX_TYPE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXT_Confirm_Pass);
            this.Controls.Add(this.TXT_CPF);
            this.Controls.Add(this.BTN_UserSalvar);
            this.Controls.Add(this.BTN_UserCancel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXT_Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_Setor);
            this.Controls.Add(this.TXT_Usuario);
            this.Controls.Add(this.TXT_Email);
            this.Controls.Add(this.TXT_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "PageUserEditandAdd";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Usuarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.returnUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Nome;
        private System.Windows.Forms.TextBox TXT_Email;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Setor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_Password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource returnUsuariosBindingSource;
        private MetroFramework.Controls.MetroButton BTN_UserCancel;
        private MetroFramework.Controls.MetroButton BTN_UserSalvar;
        private System.Windows.Forms.MaskedTextBox TXT_CPF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_Confirm_Pass;
        private System.Windows.Forms.ComboBox CBX_TYPE;
        private System.Windows.Forms.ComboBox CBX_Status;
    }
}