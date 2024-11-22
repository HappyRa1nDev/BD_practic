using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YourLook
{
    public partial class CustomRequestF : Form
    {
        public HashSet<Field> work_fields= new HashSet<Field>();

        public HashSet<string> conn_table= new HashSet<string>();
		public HashSet<string> conn_table_ready = new HashSet<string>();
        public HashSet<string> join = new HashSet<string>();

		public class Field
        {
            public string field { get;set; }
            public string table { get;set; }
            public string type { get;set; }
            public string transf { get;set; }

            public Field(string field_,string table_, string type_, string transf_)
            {
                field = field_;
                table = table_;
                type = type_;
                transf= transf_;
            }
        }
        void check()
        {
            button2.Enabled = listBox2.Items.Count > 0;

		}
		public CustomRequestF()
        {
            InitializeComponent();
            listBox2.DisplayMember = "transf";
            loadfield();
            check();
            comboBox2.Items.AddRange(new string[] {
            "=",">","<",">=","<=","!=" });
            comboBox4.Items.AddRange(new string[] { " ","AND ", "OR " });
            listView1.Columns.Add("Имя поля"); listView1.Columns.Add("Критерий"); listView1.Columns.Add("Значение"); listView1.Columns.Add("Связка");
        }
        void UpdateCombo()//обновить комбики условий
        {
			comboBox3.Items.Clear();
			comboBox1.Text = "";
			comboBox3.Text = "";
            listView1.Items.Clear();
			createREL();
            loadfieldtocombobox();
		}
        public void loadfield()//выполняется 1 раз в конструкторе
        {
            listBox1.DisplayMember = "transf";
            using (var cn = GlobalDefines.GetConnection())
            {
                cn.Open();
                var sql = "SELECT * FROM fields";
                var cmd = new NpgsqlCommand(sql, cn);
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    var fn = (string)reader["field_name"];
                    var tn = (string)reader["table_name"];
                    var ft = (string)reader["field_type"];
                    var tf = (string)reader["trans_fn"];
                    var item = new Field(fn, tn, ft, tf);
                    listBox1.Items.Add(item);
                }
            }
        }
        public void loadfieldtocombobox()
        {
            List<Field> list = new List<Field>();
            foreach (var item in listBox1.Items)
            {
                Field field = item as Field;
                if(conn_table_ready.Contains(field.table))
                    list.Add(field);
            }
            comboBox1.Items.Clear();
            comboBox1.DisplayMember = "transf";
            foreach (var selectfield in list.Distinct().ToList())
                comboBox1.Items.Add(selectfield);
        }
       
        Stack<string> tmpTable = new Stack<string>();

        NpgsqlConnection tmp_cn;
        void MergeT(string t1,string t2)//функция слияния таблиц
        {
			NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM reltable WHERE table_1 = @t1 AND table_2 = @t2", tmp_cn);
			cmd.Parameters.AddWithValue("@t1", t1);
			cmd.Parameters.AddWithValue("@t2", t2);
			NpgsqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            string rel=Convert.ToString(reader[2]);
            string via= Convert.ToString(reader[3]);
			reader.Close();
			if (rel!="" && (!conn_table_ready.Contains(t1) || !conn_table_ready.Contains(t2)))
            {
                join.Add(rel);
                conn_table_ready.Add(t1);
                conn_table_ready.Add(t2);
                return;
            }
            else
            {
                if (via != "")
                {
                    MergeT(t1, via);
                    MergeT(via, t2);
                }
            }
        }
        void createREL()//функция создания связей между таблицами
        {
            tmpTable.Clear();
            join.Clear();
            conn_table_ready.Clear();
            foreach(var v in conn_table)
            {
                tmpTable.Push(v);
			}
            if (tmpTable.Count <= 1)
            {
                conn_table_ready = new HashSet<string>( conn_table);
                return;
			}
            tmp_cn = GlobalDefines.GetConnection();
            tmp_cn.Open();
			string tb = tmpTable.Pop();
            while (tmpTable.Count() > 0)
            {
                string t2 = tmpTable.Pop();
                if (conn_table_ready.Contains(t2))
                    continue;
				MergeT(tb, t2);
            }
            tmp_cn.Close();

		}
		string getStringFields(string razd)
		{

			string s = "";
			if (work_fields.Count == 0)
			{
				return "";
			}
			foreach (Field f in work_fields)
			{
				s += f.field + razd;
			}
			s = s.Substring(0, s.Length - razd.Length);
			return s;
		}
        string getStringTables(string razd)
        {
			string s = "";
			if (conn_table_ready.Count == 0)
			{
				return "";
			}
			foreach (string f in conn_table_ready)
			{
				s += f + razd;
			}
			s = s.Substring(0, s.Length - razd.Length);
			return s;
		}

		string getStringJoin(string razd)
		{
			string s = "";
			if (join.Count == 0)
			{
				return "";
			}
			foreach (string f in join)
			{
				s += f + razd;
			}
			s = s.Substring(0, s.Length - razd.Length);
			return s;
		}
		string getStringCond()
		{
			string s = "";
            if (listView1.Items.Count == 0)
            {
                return "";
            }
            List<string> mas = GetConditions();

			foreach (string v in mas)
            {
                s += v+" ";
            }
			return s;
		}
		string  CreateSQL()//генерируем запрос
        {
            string fields_sql=getStringFields(", ");
            createREL();
            string tables_sql=getStringTables(", ");
            string join_sql=getStringJoin(" AND ");
            string cond_sql = getStringCond();


            string final_sql = "SELECT " + fields_sql + " FROM " + tables_sql;// + " WHERE " + join_sql;
             if(cond_sql!="" && join_sql != "")
            {
                final_sql += " WHERE " + join_sql+" AND "+cond_sql;
            }
            else if(cond_sql != "")
			{
				final_sql += " WHERE " + cond_sql;
			}
            else if(join_sql !="")
            {
                final_sql += " WHERE " + join_sql;
			}
			return final_sql;
			
		}


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void select_Click(object sender, EventArgs e)
        {
            if (!work_fields.Contains((Field)listBox1.SelectedItem))
            {
                work_fields.Add((Field)listBox1.SelectedItem);
                conn_table.Add(((Field)listBox1.SelectedItem).table);
				listBox2.Items.Add(listBox1.SelectedItem);
                UpdateCombo();

			}
			check();

		}

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
				work_fields.Remove((Field)listBox2.SelectedItem);
                conn_table.Remove(((Field)listBox2.SelectedItem).table);
				listBox2.Items.Remove(listBox2.SelectedItem);
                UpdateCombo();
			}
			check();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            string fields = CreateSQL();
			MessageBox.Show(fields);
		}


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            using (var cn = GlobalDefines.GetConnection())
            {
                cn.Open();
                Field selitem = comboBox1.SelectedItem as Field;
                var sql = $"SELECT {selitem.field} FROM {selitem.table}";
                var cmd = new NpgsqlCommand(sql, cn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    comboBox3.Items.Add(reader[$"{selitem.field}"]).ToString();
            }
        }

        public List<string> GetConditions()
        {
            return listView1.Items.Cast<ListViewItem>().Select(item => String.Join(" ",item.SubItems.Cast<ListViewSubItem>().Select(subitem=>subitem.Text))).ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var selecteditem = comboBox1.SelectedItem as Field;
            string someitem = comboBox3.Text;
            if (selecteditem.type == "d" || selecteditem.type=="c" || selecteditem.type == "t")
            {
                someitem = "'" + someitem + "'";
            }

            object[] row = { (selecteditem.table+"."+selecteditem.field), comboBox2.SelectedItem, someitem, comboBox4.SelectedItem };
            var listViewItem = new ListViewItem(row.Select(item => item?.ToString()).ToArray()) { Tag = row };
            listView1.Items.Add(listViewItem);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var indexrow = listView1.SelectedIndices;
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var cn = GlobalDefines.GetConnection())
            {
                cn.Open();
                var sql = CreateSQL();
                var cmd = new NpgsqlCommand(sql, cn);
                var reader = cmd.ExecuteReader();
                listView2.Clear();
				List<string> selectedFields2 = work_fields.Cast<Field>().Select(fieldInfo => fieldInfo.field).ToList();
				foreach (var selF in selectedFields2)
				{
					listView2.Columns.Add(selF.ToString());
				}

				while (reader.Read())
                {
                    string[] columnValues = listView2.Columns
                        .Cast<ColumnHeader>()
                        .Select(columnHeader => reader[columnHeader.Text]?.ToString())
                        .ToArray();

                    listView2.Items.Add(new ListViewItem(columnValues));
                }
            }
        }

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			check();
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}
	}
}
