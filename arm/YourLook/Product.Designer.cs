namespace YourLook
{
    partial class ProductForm
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtDescript = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(323, 38);
			this.txtName.Margin = new System.Windows.Forms.Padding(5);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(352, 47);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.check);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(102, 45);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 41);
			this.label1.TabIndex = 1;
			this.label1.Text = "Название: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(104, 113);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 41);
			this.label2.TabIndex = 1;
			this.label2.Text = "Описание:";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(93, 306);
			this.btnOK.Margin = new System.Windows.Forms.Padding(5);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(229, 85);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "ОК";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(447, 306);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(229, 85);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(102, 201);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 41);
			this.label3.TabIndex = 4;
			this.label3.Text = "Цена";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(323, 195);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(5);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(352, 47);
			this.txtPrice.TabIndex = 3;
			this.txtPrice.TextChanged += new System.EventHandler(this.check);
			this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
			// 
			// txtDescript
			// 
			this.txtDescript.Location = new System.Drawing.Point(323, 113);
			this.txtDescript.Margin = new System.Windows.Forms.Padding(5);
			this.txtDescript.Name = "txtDescript";
			this.txtDescript.Size = new System.Drawing.Size(352, 47);
			this.txtDescript.TabIndex = 5;
			this.txtDescript.TextChanged += new System.EventHandler(this.check);
			// 
			// ProductForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(763, 415);
			this.Controls.Add(this.txtDescript);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProductForm";
			this.Text = "Товар";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
		protected Label label3;
		protected TextBox txtPrice;
		protected TextBox txtDescript;
	}
}