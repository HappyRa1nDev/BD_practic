
namespace ContactApplication
{
	partial class PersonListForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 102;
			this.dataGridView1.RowTemplate.Height = 40;
			this.dataGridView1.Size = new System.Drawing.Size(955, 495);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 544);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(177, 75);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.Добавить_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(224, 544);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(177, 75);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Изменить";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(426, 544);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(177, 75);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// PersonListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 647);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGridView1);
			this.Name = "PersonListForm";
			this.Text = "PersonListForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
	}
}