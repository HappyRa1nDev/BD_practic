namespace YourLook
{
    partial class RegForm
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
            this.pas1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pas2 = new System.Windows.Forms.TextBox();
            this.pasInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pas1
            // 
            this.pas1.Location = new System.Drawing.Point(158, 87);
            this.pas1.Name = "pas1";
            this.pas1.PasswordChar = '*';
            this.pas1.Size = new System.Drawing.Size(163, 22);
            this.pas1.TabIndex = 10;
            this.pas1.TextChanged += new System.EventHandler(this.pas1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Па&роль:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(160, 33);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(163, 22);
            this.txtLogin.TabIndex = 8;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "&Пользователь:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 43);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "О&тмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(32, 187);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 43);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Повторить пароль:";
            // 
            // pas2
            // 
            this.pas2.Location = new System.Drawing.Point(158, 128);
            this.pas2.Name = "pas2";
            this.pas2.PasswordChar = '*';
            this.pas2.Size = new System.Drawing.Size(163, 22);
            this.pas2.TabIndex = 14;
            this.pas2.TextChanged += new System.EventHandler(this.pas2_TextChanged);
            // 
            // pasInfo
            // 
            this.pasInfo.AutoSize = true;
            this.pasInfo.Location = new System.Drawing.Point(158, 157);
            this.pasInfo.Name = "pasInfo";
            this.pasInfo.Size = new System.Drawing.Size(28, 16);
            this.pasInfo.TabIndex = 15;
            this.pasInfo.Text = "info";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 267);
            this.Controls.Add(this.pasInfo);
            this.Controls.Add(this.pas2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pas1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegForm_FormClosing);
            this.Load += new System.EventHandler(this.RegForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pas1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pas2;
        private System.Windows.Forms.Label pasInfo;
    }
}