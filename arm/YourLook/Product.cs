namespace YourLook
{
	public partial class ProductForm : Form
	{
		public ProductForm()
		{
			InitializeComponent();
			this.txtName.Text = "";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
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
		public int Price
		{
			get
			{
				return Convert.ToInt32(txtPrice.Text);
			}
			set
			{
				txtPrice.Text = Convert.ToString(value);
			}
		}
		public string Desc
		{
			get
			{
				return (txtDescript.Text);
			}
			set
			{
				txtDescript.Text = value;
			}
		}
		private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch!=8)
			{
				e.Handled = true;
			}
		}

		private void check(object sender, EventArgs e)
		{
			btnOK.Enabled = (txtDescript.Text.Length > 0 && txtName.Text.Length > 0 && txtPrice.Text.Length > 0);
		}
	}
}
