namespace Request_System.Forms
{
    partial class Admin_Main
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
            this.BTN_admin_main_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_admin_main_OK
            // 
            this.BTN_admin_main_OK.Location = new System.Drawing.Point(640, 257);
            this.BTN_admin_main_OK.Name = "BTN_admin_main_OK";
            this.BTN_admin_main_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_admin_main_OK.TabIndex = 0;
            this.BTN_admin_main_OK.Text = "OK";
            this.BTN_admin_main_OK.UseVisualStyleBackColor = true;
            this.BTN_admin_main_OK.Click += new System.EventHandler(this.BTN_admin_main_OK_Click);
            // 
            // Admin_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BTN_admin_main_OK);
            this.Name = "Admin_Main";
            this.Text = "Admin_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_admin_main_OK;
    }
}