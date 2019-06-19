namespace Request_System
{
    partial class ConfigGerais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigGerais));
            this.BTN_Salvar = new MetroFramework.Controls.MetroButton();
            this.BTN_Cancel = new MetroFramework.Controls.MetroButton();
            this.TXT_folderPath = new System.Windows.Forms.TextBox();
            this.BTN_ConfigFileLog = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CHB_CriaBanco = new System.Windows.Forms.CheckBox();
            this.CHB_GeraTabelas = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_NomeBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Server = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Location = new System.Drawing.Point(137, 325);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(115, 30);
            this.BTN_Salvar.TabIndex = 1;
            this.BTN_Salvar.Text = "Salvar";
            this.BTN_Salvar.UseSelectable = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(16, 325);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(115, 30);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "Cancelar";
            this.BTN_Cancel.UseSelectable = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // TXT_folderPath
            // 
            this.TXT_folderPath.Location = new System.Drawing.Point(6, 19);
            this.TXT_folderPath.MaxLength = 500;
            this.TXT_folderPath.Multiline = true;
            this.TXT_folderPath.Name = "TXT_folderPath";
            this.TXT_folderPath.ReadOnly = true;
            this.TXT_folderPath.Size = new System.Drawing.Size(600, 30);
            this.TXT_folderPath.TabIndex = 2;
            this.TXT_folderPath.TextChanged += new System.EventHandler(this.TXT_folderPath_TextChanged);
            // 
            // BTN_ConfigFileLog
            // 
            this.BTN_ConfigFileLog.Location = new System.Drawing.Point(612, 19);
            this.BTN_ConfigFileLog.Name = "BTN_ConfigFileLog";
            this.BTN_ConfigFileLog.Size = new System.Drawing.Size(115, 30);
            this.BTN_ConfigFileLog.TabIndex = 4;
            this.BTN_ConfigFileLog.Text = "Escolher";
            this.BTN_ConfigFileLog.UseSelectable = true;
            this.BTN_ConfigFileLog.Click += new System.EventHandler(this.BTN_ConfigFileLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_folderPath);
            this.groupBox1.Controls.Add(this.BTN_ConfigFileLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definir Local de salvamento dos arquivos de LOG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CHB_CriaBanco);
            this.groupBox2.Controls.Add(this.CHB_GeraTabelas);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXT_Pass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXT_User);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TXT_NomeBanco);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TXT_Server);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 202);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conection String";
            // 
            // CHB_CriaBanco
            // 
            this.CHB_CriaBanco.AutoSize = true;
            this.CHB_CriaBanco.Location = new System.Drawing.Point(13, 154);
            this.CHB_CriaBanco.Name = "CHB_CriaBanco";
            this.CHB_CriaBanco.Size = new System.Drawing.Size(129, 17);
            this.CHB_CriaBanco.TabIndex = 8;
            this.CHB_CriaBanco.Text = "Criar banco de Dados";
            this.CHB_CriaBanco.UseVisualStyleBackColor = true;
            this.CHB_CriaBanco.CheckedChanged += new System.EventHandler(this.CHB_CriaBanco_CheckedChanged);
            // 
            // CHB_GeraTabelas
            // 
            this.CHB_GeraTabelas.Location = new System.Drawing.Point(254, 145);
            this.CHB_GeraTabelas.Name = "CHB_GeraTabelas";
            this.CHB_GeraTabelas.Size = new System.Drawing.Size(231, 35);
            this.CHB_GeraTabelas.TabIndex = 9;
            this.CHB_GeraTabelas.Text = "Gerar Tabelas (Ira executar os scrips e gerar as tabelas no Banco de Dados)";
            this.CHB_GeraTabelas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha:";
            // 
            // TXT_Pass
            // 
            this.TXT_Pass.Location = new System.Drawing.Point(371, 99);
            this.TXT_Pass.Multiline = true;
            this.TXT_Pass.Name = "TXT_Pass";
            this.TXT_Pass.PasswordChar = '*';
            this.TXT_Pass.Size = new System.Drawing.Size(350, 30);
            this.TXT_Pass.TabIndex = 6;
            this.TXT_Pass.TextChanged += new System.EventHandler(this.TXT_Pass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario:";
            // 
            // TXT_User
            // 
            this.TXT_User.Location = new System.Drawing.Point(371, 35);
            this.TXT_User.Multiline = true;
            this.TXT_User.Name = "TXT_User";
            this.TXT_User.Size = new System.Drawing.Size(350, 30);
            this.TXT_User.TabIndex = 4;
            this.TXT_User.TextChanged += new System.EventHandler(this.TXT_User_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Banco:";
            // 
            // TXT_NomeBanco
            // 
            this.TXT_NomeBanco.Location = new System.Drawing.Point(6, 99);
            this.TXT_NomeBanco.Multiline = true;
            this.TXT_NomeBanco.Name = "TXT_NomeBanco";
            this.TXT_NomeBanco.Size = new System.Drawing.Size(350, 30);
            this.TXT_NomeBanco.TabIndex = 2;
            this.TXT_NomeBanco.TextChanged += new System.EventHandler(this.TXT_NomeBanco_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor \\ Instancia (se houver):";
            // 
            // TXT_Server
            // 
            this.TXT_Server.Location = new System.Drawing.Point(6, 35);
            this.TXT_Server.Multiline = true;
            this.TXT_Server.Name = "TXT_Server";
            this.TXT_Server.Size = new System.Drawing.Size(350, 30);
            this.TXT_Server.TabIndex = 0;
            this.TXT_Server.TextChanged += new System.EventHandler(this.TXT_Server_TextChanged);
            // 
            // ConfigGerais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 370);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Salvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigGerais";
            this.Text = "Configurações Gerais";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton BTN_Salvar;
        private MetroFramework.Controls.MetroButton BTN_Cancel;
        private System.Windows.Forms.TextBox TXT_folderPath;
        private MetroFramework.Controls.MetroButton BTN_ConfigFileLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXT_Server;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_NomeBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CHB_GeraTabelas;
        private System.Windows.Forms.CheckBox CHB_CriaBanco;
    }
}