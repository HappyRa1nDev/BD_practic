
namespace ContactApplication
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.контактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.типыКонтактовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.данныеToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.справкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MdiWindowListItem = this.окноToolStripMenuItem;
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1752, 49);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(112, 48);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(270, 54);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// данныеToolStripMenuItem
			// 
			this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контактыToolStripMenuItem,
            this.типыКонтактовToolStripMenuItem,
            this.отчетToolStripMenuItem});
			this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
			this.данныеToolStripMenuItem.Size = new System.Drawing.Size(149, 48);
			this.данныеToolStripMenuItem.Text = "Данные";
			// 
			// контактыToolStripMenuItem
			// 
			this.контактыToolStripMenuItem.Name = "контактыToolStripMenuItem";
			this.контактыToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
			this.контактыToolStripMenuItem.Text = "Контакты...";
			this.контактыToolStripMenuItem.Click += new System.EventHandler(this.контактыToolStripMenuItem_Click);
			// 
			// типыКонтактовToolStripMenuItem
			// 
			this.типыКонтактовToolStripMenuItem.Name = "типыКонтактовToolStripMenuItem";
			this.типыКонтактовToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
			this.типыКонтактовToolStripMenuItem.Text = "Типы контактов...";
			this.типыКонтактовToolStripMenuItem.Click += new System.EventHandler(this.типыКонтактовToolStripMenuItem_Click);
			// 
			// отчетToolStripMenuItem
			// 
			this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
			this.отчетToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
			this.отчетToolStripMenuItem.Text = "Отчет";
			// 
			// окноToolStripMenuItem
			// 
			this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
			this.окноToolStripMenuItem.Size = new System.Drawing.Size(115, 48);
			this.окноToolStripMenuItem.Text = "Окно";
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(157, 48);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(391, 54);
			this.оПрограммеToolStripMenuItem.Text = "О программе...";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1752, 963);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Записная книга";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem контактыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem типыКонтактовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
	}
}

