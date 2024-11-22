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

	public partial class ContactTypeForm : Form
	{
		public DataSet m_DataSet = new DataSet();
		//public DataTable DBTable = new DataTable();
		public const string DBTable = "contacttype";
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
			string sQuery = "SELECT * FROM "+ DBTable;
			m_DataAdapter = new NpgsqlDataAdapter(sQuery, m_Connection);
			m_DataAdapter.Fill(m_DataSet, DBTable);
			dataGridView1.DataSource = m_DataSet;
			dataGridView1.DataMember = DBTable;


			NpgsqlCommandBuilder cb = new NpgsqlCommandBuilder(m_DataAdapter as NpgsqlDataAdapter);
			m_DataAdapter.InsertCommand = cb.GetInsertCommand();
			m_DataAdapter.DeleteCommand = cb.GetDeleteCommand();
			m_DataAdapter.UpdateCommand = cb.GetUpdateCommand();

			m_Connection.Close();
		}

		public ContactTypeForm()
		{	
			InitializeComponent();

			SetupDataConnection();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			m_Connection.Open();
			DataTable table = m_DataSet.Tables[DBTable];
            int response = m_DataAdapter.Update(table);
			m_DataSet.Clear();
			m_DataAdapter.Fill(m_DataSet, DBTable);
			//dataGridView1.Refresh();
			//dataGridView1.Update();
			m_Connection.Close();
			//SetupDataConnection();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
