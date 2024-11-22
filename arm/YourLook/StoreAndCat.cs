using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourLook
{
	public partial class StoreAndCat : Form
	{
		public StoreAndCat()
		{
			InitializeComponent();
			txtName.Text = "";
		}

		public void setTitle(string title)
		{
			this.Text = title;
		}

		public string Name
		{
			get
			{
				return txtName.Text;
			}
			set
			{
				txtName.Text = value;
			}
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
		private void check(object sender, EventArgs e)
		{
			btnOK.Enabled = (txtName.Text.Length > 0);
		}
	}
}
