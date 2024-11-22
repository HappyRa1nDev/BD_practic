namespace YourLook
{
	partial class StoreAndCat
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(408, 116);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(229, 85);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(54, 116);
			this.btnOK.Margin = new System.Windows.Forms.Padding(5);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(229, 85);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "ОК";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.TextChanged += new System.EventHandler(this.check);
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 51);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 41);
			this.label1.TabIndex = 6;
			this.label1.Text = "Название: ";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(290, 44);
			this.txtName.Margin = new System.Windows.Forms.Padding(5);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(352, 47);
			this.txtName.TabIndex = 5;
			this.txtName.TextChanged += new System.EventHandler(this.check);
			// 
			// StoreAndCat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 228);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Name = "StoreAndCat";
			this.Text = "StoreAndCat";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnCancel;
		private Button btnOK;
		private Label label1;
		private TextBox txtName;
	}
}