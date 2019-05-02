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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CBX_IDIOMA = new MetroFramework.Controls.MetroComboBox();
            this.CBX_TYPE = new MetroFramework.Controls.MetroComboBox();
            this.CBX_Status = new MetroFramework.Controls.MetroComboBox();
            this.BTN_UserCancel = new MetroFramework.Controls.MetroButton();
            this.BTN_UserSalvar = new MetroFramework.Controls.MetroButton();
            this.TXT_CPF = new System.Windows.Forms.MaskedTextBox();
            this.returnUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.returnUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_Nome
            // 
            this.TXT_Nome.BackColor = System.Drawing.Color.White;
            this.TXT_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_Nome.Location = new System.Drawing.Point(12, 65);
            this.TXT_Nome.Multiline = true;
            this.TXT_Nome.Name = "TXT_Nome";
            this.TXT_Nome.Size = new System.Drawing.Size(235, 29);
            this.TXT_Nome.TabIndex = 0;
            this.TXT_Nome.TextChanged += new System.EventHandler(this.TXT_Nome_TextChanged);
            // 
            // TXT_Email
            // 
            this.TXT_Email.Location = new System.Drawing.Point(12, 118);
            this.TXT_Email.Multiline = true;
            this.TXT_Email.Name = "TXT_Email";
            this.TXT_Email.Size = new System.Drawing.Size(235, 29);
            this.TXT_Email.TabIndex = 2;
            this.TXT_Email.TextChanged += new System.EventHandler(this.TXT_Email_TextChanged);
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(12, 169);
            this.TXT_Usuario.Multiline = true;
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(235, 29);
            this.TXT_Usuario.TabIndex = 4;
            this.TXT_Usuario.TextChanged += new System.EventHandler(this.TXT_Usuario_TextChanged);
            // 
            // TXT_Setor
            // 
            this.TXT_Setor.Location = new System.Drawing.Point(260, 118);
            this.TXT_Setor.Multiline = true;
            this.TXT_Setor.Name = "TXT_Setor";
            this.TXT_Setor.Size = new System.Drawing.Size(235, 29);
            this.TXT_Setor.TabIndex = 3;
            this.TXT_Setor.TextChanged += new System.EventHandler(this.TXT_Setor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastro de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Setor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Senha";
            // 
            // TXT_Password
            // 
            this.TXT_Password.Location = new System.Drawing.Point(260, 169);
            this.TXT_Password.Multiline = true;
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.Size = new System.Drawing.Size(235, 29);
            this.TXT_Password.TabIndex = 5;
            this.TXT_Password.TextChanged += new System.EventHandler(this.TXT_Password_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Idioma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Status";
            // 
            // CBX_IDIOMA
            // 
            this.CBX_IDIOMA.FormattingEnabled = true;
            this.CBX_IDIOMA.ItemHeight = 23;
            this.CBX_IDIOMA.Location = new System.Drawing.Point(12, 216);
            this.CBX_IDIOMA.Name = "CBX_IDIOMA";
            this.CBX_IDIOMA.Size = new System.Drawing.Size(235, 29);
            this.CBX_IDIOMA.TabIndex = 19;
            this.CBX_IDIOMA.UseSelectable = true;
            // 
            // CBX_TYPE
            // 
            this.CBX_TYPE.FormattingEnabled = true;
            this.CBX_TYPE.ItemHeight = 23;
            this.CBX_TYPE.Location = new System.Drawing.Point(260, 216);
            this.CBX_TYPE.Name = "CBX_TYPE";
            this.CBX_TYPE.Size = new System.Drawing.Size(235, 29);
            this.CBX_TYPE.TabIndex = 20;
            this.CBX_TYPE.UseSelectable = true;
            // 
            // CBX_Status
            // 
            this.CBX_Status.FormattingEnabled = true;
            this.CBX_Status.ItemHeight = 23;
            this.CBX_Status.Location = new System.Drawing.Point(12, 268);
            this.CBX_Status.Name = "CBX_Status";
            this.CBX_Status.Size = new System.Drawing.Size(235, 29);
            this.CBX_Status.TabIndex = 21;
            this.CBX_Status.UseSelectable = true;
            // 
            // BTN_UserCancel
            // 
            this.BTN_UserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_UserCancel.Location = new System.Drawing.Point(260, 268);
            this.BTN_UserCancel.Name = "BTN_UserCancel";
            this.BTN_UserCancel.Size = new System.Drawing.Size(115, 29);
            this.BTN_UserCancel.TabIndex = 22;
            this.BTN_UserCancel.Text = "Cancelar";
            this.BTN_UserCancel.UseSelectable = true;
            this.BTN_UserCancel.Click += new System.EventHandler(this.BTN_UserCancel_Click);
            // 
            // BTN_UserSalvar
            // 
            this.BTN_UserSalvar.Location = new System.Drawing.Point(380, 268);
            this.BTN_UserSalvar.Name = "BTN_UserSalvar";
            this.BTN_UserSalvar.Size = new System.Drawing.Size(115, 29);
            this.BTN_UserSalvar.TabIndex = 23;
            this.BTN_UserSalvar.Text = "Salvar";
            this.BTN_UserSalvar.UseSelectable = true;
            this.BTN_UserSalvar.Click += new System.EventHandler(this.BTN_UserSalvar_Click);
            // 
            // TXT_CPF
            // 
            this.TXT_CPF.Location = new System.Drawing.Point(260, 65);
            this.TXT_CPF.Mask = "000,000,000-00";
            this.TXT_CPF.Name = "TXT_CPF";
            this.TXT_CPF.Size = new System.Drawing.Size(235, 20);
            this.TXT_CPF.TabIndex = 24;
            // 
            // returnUsuariosBindingSource
            // 
            this.returnUsuariosBindingSource.DataSource = typeof(Request_System.Return_Usuarios);
            // 
            // PageUserEditandAdd
            // 
            this.AcceptButton = this.BTN_UserSalvar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.BTN_UserCancel;
            this.ClientSize = new System.Drawing.Size(524, 457);
            this.ControlBox = false;
            this.Controls.Add(this.TXT_CPF);
            this.Controls.Add(this.BTN_UserSalvar);
            this.Controls.Add(this.BTN_UserCancel);
            this.Controls.Add(this.CBX_Status);
            this.Controls.Add(this.CBX_TYPE);
            this.Controls.Add(this.CBX_IDIOMA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "PageUserEditandAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edição de Usuario";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource returnUsuariosBindingSource;
        private MetroFramework.Controls.MetroComboBox CBX_IDIOMA;
        private MetroFramework.Controls.MetroComboBox CBX_TYPE;
        private MetroFramework.Controls.MetroComboBox CBX_Status;
        private MetroFramework.Controls.MetroButton BTN_UserCancel;
        private MetroFramework.Controls.MetroButton BTN_UserSalvar;
        private System.Windows.Forms.MaskedTextBox TXT_CPF;
    }
}