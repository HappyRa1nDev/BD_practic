using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ContactApplication
{
	public partial class PersonEditForm : Form
	{

		public DataSet m_DataSet = new DataSet();
		//public DataTable DBTable = new DataTable();
		public Guid user_id;
		public string name = "имя";
		public string surname = "фамилия";
		public DateTime time;
		public const string DBTable = "contacts";

		DataSet typeContactsDS = new DataSet();

		private NpgsqlDataAdapter m_DataAdapter = new NpgsqlDataAdapter();
		private NpgsqlConnection m_Connection = null;

		private static NpgsqlConnection GetConnection()
		{
			var connectString = "Host=localhost;Username=postgres;Password=1;Database=Notebook";
			return new NpgsqlConnection(connectString);
		}
		private void SetupDataConnection()
		{

			m_Connection = GetConnection();
			m_Connection.Open();
			m_DataSet.Reset();
			string sQuery = "SELECT * FROM " + DBTable + " WHERE personid = " + "'" + user_id.ToString() + "'";
			m_DataAdapter = new NpgsqlDataAdapter(sQuery, m_Connection);


			m_DataAdapter.Fill(m_DataSet, DBTable);
			dataGridView1.DataSource = m_DataSet;
			dataGridView1.DataMember = DBTable;
			dataGridView1.Columns["id"].Visible = false;
			dataGridView1.Columns["personID"].Visible = false;

			sQuery = "SELECT * FROM contacttype";
			NpgsqlDataAdapter tmp_a = new NpgsqlDataAdapter(sQuery, m_Connection);
			tmp_a.Fill(typeContactsDS, "contacttype");
			DataGridViewComboBoxColumn cont = new DataGridViewComboBoxColumn();
			cont.DataSource = typeContactsDS;

			//dataGridView1.Columns["ContactTypeID"].CellType = typeof(DataGridViewComboBoxColumn);
			//dataGridView1.Item
			//dataGridView1.Columns["ContactTypeID"].Visible = false;

			NpgsqlCommandBuilder cb = new NpgsqlCommandBuilder(m_DataAdapter as NpgsqlDataAdapter);
			m_DataAdapter.InsertCommand = cb.GetInsertCommand();
			m_DataAdapter.DeleteCommand = cb.GetDeleteCommand();
			m_DataAdapter.UpdateCommand = cb.GetUpdateCommand();

			m_Connection.Close();
		}
		public new void Show()
		{
			tbName.Text = name;
			tbSurname.Text = surname;
			tbBirthdate.Text = time.ToString("dd/MM/yyyy");
			GetConnection();
			SetupDataConnection();
			base.Show();

		}
		public PersonEditForm()
		{
			InitializeComponent();
		}

		private void tbName_TextChanged(object sender, EventArgs e)
		{

		}

		private void PersonEditForm_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			m_Connection.Open();
			DataTable table = m_DataSet.Tables[DBTable];
			foreach (DataRow rw in table.Rows)
			{
				rw["personid"] = user_id;

            }

                int response = m_DataAdapter.Update(table);
			m_DataSet.Clear();
			m_DataAdapter.Fill(m_DataSet, DBTable);
			m_Connection.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
