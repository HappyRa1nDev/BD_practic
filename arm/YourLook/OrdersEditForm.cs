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
using System.Data.Common;
using YourLook;

namespace YourLook
{

	public partial class OrdersEditForm : Form
	{
		private NpgsqlConnection m_Connection = GlobalDefines.GetConnection();
		public DataSet m_DataSet = new DataSet();
		//public DataTable DBTable = new DataTable();
		public string DBTable = "orders";
		private NpgsqlDataAdapter m_DataAdapter = new NpgsqlDataAdapter();
		//private NpgsqlConnection m_Connection = null;
		private bool useAdmin=false;
		public void setUseAdmin(bool flag)
		{
			useAdmin = flag;
			if (useAdmin)
			{
				buttonSave.Show();
				dataGridView1.ReadOnly = false;
			}
			else
			{
				dataGridView1.ReadOnly = true;
				buttonSave.Hide();
			}
		}
		private void SetupDataConnection()
		{
				m_Connection.Open();
				m_DataSet.Reset();
			    string sQuery;
				if (useAdmin)
				{
					sQuery = "SELECT * FROM " + DBTable;
				}
				else
				{
				  sQuery = "SELECT * FROM " + DBTable + " WHERE fk_user_id = "+GlobalDefines.curUserID;
			    }
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

		public OrdersEditForm(bool flag, string table_)
		{	
			InitializeComponent();
			DBTable = table_;
			setUseAdmin(flag);
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
				this.Close();
			//SetupDataConnection();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
