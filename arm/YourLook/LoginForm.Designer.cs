namespace YourLook
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.regBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(274, 346);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(183, 110);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "О&тмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(96, 79);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Пользователь:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(332, 77);
			this.txtLogin.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(342, 47);
			this.txtLogin.TabIndex = 1;
			this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(332, 215);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(342, 47);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(96, 218);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 41);
			this.label2.TabIndex = 2;
			this.label2.Text = "Па&роль:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(60, 346);
			this.btnOK.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(183, 110);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// regBtn
			// 
			this.regBtn.Location = new System.Drawing.Point(504, 346);
			this.regBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.regBtn.Name = "regBtn";
			this.regBtn.Size = new System.Drawing.Size(174, 110);
			this.regBtn.TabIndex = 6;
			this.regBtn.Text = "Регистрация";
			this.regBtn.UseVisualStyleBackColor = true;
			this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(750, 487);
			this.Controls.Add(this.regBtn);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.Text = "login";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button regBtn;
    }
}

