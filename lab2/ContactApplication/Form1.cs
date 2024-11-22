using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace ContactApplication
{

	public partial class MainForm : Form
	{
		private static NpgsqlConnection GetConnection()
		{
			var connectString = "Host=localhost;Username=postgres;Password=1;Database=Notebook";
			return new NpgsqlConnection(connectString);
		}
		public MainForm()
		{
			InitializeComponent();
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm frmAbout = new AboutForm();
			frmAbout.ShowDialog();

		}

		private void типыКонтактовToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ContactTypeForm form = new ContactTypeForm();
			form.MdiParent = this;
			form.Show();
		}

		private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PersonListForm form = new PersonListForm();
			form.MdiParent = this;
			form.Show();
		}
	}
}
