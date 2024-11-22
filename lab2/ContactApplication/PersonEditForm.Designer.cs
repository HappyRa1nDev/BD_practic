
namespace ContactApplication
{
	partial class PersonEditForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbBirthdate = new System.Windows.Forms.TextBox();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(257, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(257, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Surname";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(257, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Birthdate";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(418, 84);
			this.tbName.Name = "tbName";
			this.tbName.ReadOnly = true;
			this.tbName.Size = new System.Drawing.Size(207, 38);
			this.tbName.TabIndex = 3;
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// tbBirthdate
			// 
			this.tbBirthdate.Location = new System.Drawing.Point(418, 185);
			this.tbBirthdate.Name = "tbBirthdate";
			this.tbBirthdate.ReadOnly = true;
			this.tbBirthdate.Size = new System.Drawing.Size(207, 38);
			this.tbBirthdate.TabIndex = 4;
			// 
			// tbSurname
			// 
			this.tbSurname.Location = new System.Drawing.Point(418, 131);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.ReadOnly = true;
			this.tbSurname.Size = new System.Drawing.Size(207, 38);
			this.tbSurname.TabIndex = 5;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(57, 309);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 102;
			this.dataGridView1.RowTemplate.Height = 40;
			this.dataGridView1.Size = new System.Drawing.Size(927, 223);
			this.dataGridView1.TabIndex = 6;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(57, 611);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(227, 108);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(314, 611);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(227, 108);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// PersonEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1125, 768);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.tbBirthdate);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PersonEditForm";
			this.Text = "PersonEditForm";
			this.Load += new System.EventHandler(this.PersonEditForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbBirthdate;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}