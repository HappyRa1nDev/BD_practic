
namespace YourLook
{
	partial class OrdersEditForm
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(46, 50);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 102;
			this.dataGridView1.RowTemplate.Height = 40;
			this.dataGridView1.Size = new System.Drawing.Size(1178, 614);
			this.dataGridView1.TabIndex = 0;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(715, 713);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(234, 102);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(984, 713);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(240, 102);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// OrdersEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1266, 850);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "OrdersEditForm";
			this.Text = "Покупки";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button btnClose;
	}
}