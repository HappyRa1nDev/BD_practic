using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Office.Interop.Excel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace YourLook
{

    public partial class Form1 : Form
    {
        TreeNode baseNode;
        void checkA()
        {
            if (GlobalDefines.isAdmin)
            {
                btnAdmin.Show();
                btnAllOrders.Show();
                btnExcel.Show();
            }
            else
            {
                btnAdmin.Hide();
                btnAllOrders.Hide();
                btnExcel.Hide();
            }
        }
        public Form1()
        {
   
            InitializeComponent();
            treeView1.Nodes.Clear();
            baseNode = new TreeNode("Магазины");
            treeView1.Nodes.Add(baseNode);
            checkA();

		}

        private void button1_Click(object sender, EventArgs e)
        {
            LoadStores();
        }

		private void LoadProducts(ref TreeNode parent)//загрузить товары
		{
			using (NpgsqlConnection cn = GlobalDefines.GetConnection())
			{
				cn.Open();
				String s = "SELECT * from products where fk_category_id=@category_id";
				var cmd = new NpgsqlCommand(s, cn);
				cmd.Parameters.AddWithValue("@category_id", (int)parent.Tag);


				var dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					var gr = new TreeNode(dr["product_name"].ToString());
					gr.Tag = (int)dr["product_id"];
					parent.Nodes.Add(gr);
				}
				dr.Close();
				cn.Close();
			}
		}
		private void LoadCategories(ref TreeNode parent)//загрузить категории
		{
			using (NpgsqlConnection cn = GlobalDefines.GetConnection())
			{

				cn.Open();
				String s = "SELECT * from categories where fk_store_id=@store_id";
				var cmd = new NpgsqlCommand(s, cn);
				cmd.Parameters.AddWithValue("@store_id", (int)parent.Tag);


				var dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					var gr = new TreeNode(dr["name_category"].ToString());
					gr.Tag = (int)dr["category_id"];
					parent.Nodes.Add(gr);
					LoadProducts(ref gr);
				}
				dr.Close();
				cn.Close();
			}
		}
		private void LoadStores()//загрузить магазины
		{


			//NpgsqlConnection cn = GetConnection();
			using (NpgsqlConnection cn = GlobalDefines.GetConnection())
			{
				cn.Open();

				var cmd = new NpgsqlCommand(
					@"Select * from stores", cn);

				cmd.ExecuteNonQuery();
				//cmd.Parameters.AddWithValue("@id", id);

				var dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					var fac = new TreeNode(dr["store_name"].ToString());
					fac.Tag = (int)dr["store_id"];
					baseNode.Nodes.Add(fac);
					LoadCategories(ref fac);
				}
				dr.Close();
				cn.Close();
			}
		}


		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (treeView1.SelectedNode == null)
                e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStores();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Level==0)
                return;

            //var cn = GetConnection(); /*new SqlConnection(ConnectionString);*/

            GlobalDefines.cn.Open();

            TreeNode CurrentNode = treeView1.SelectedNode;
            int id = (int)treeView1.SelectedNode.Tag;
            switch (CurrentNode.Level-1)
            {
                case 0:
                    {
                        var cmd = new NpgsqlCommand(@"delete from stores where store_id=@num", GlobalDefines.cn);
                        cmd.Parameters.AddWithValue("@num", id);
                        cmd.ExecuteNonQuery();
                    }
                    break;
                case 1:
                    {
                        var cmd = new NpgsqlCommand(@"delete from categories where category_id=@num", GlobalDefines.cn);
                        cmd.Parameters.AddWithValue("@num", id);
                        cmd.ExecuteNonQuery();
                    }
                    break;
                case 2:
                    {
                        var cmd = new NpgsqlCommand(@"delete from products where product_id=@num", GlobalDefines.cn);
                        cmd.Parameters.AddWithValue("@num", id);
                        cmd.ExecuteNonQuery();
                    }
                    break;
            }
            GlobalDefines.cn.Close();

			treeView1.SelectedNode.Remove();
            GlobalDefines.cn.Close();

        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Level == 0)
                return;
            TreeNode CurrentNode = treeView1.SelectedNode;
            int id = (int)CurrentNode.Tag;
            switch (CurrentNode.Level - 1)
            {
                case 0:
                    {
                        StoreAndCat frm = new StoreAndCat();
                        frm.setTitle("Магазин");
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            var sql = @"UPDATE Stores 
                                    SET store_name=@Name
                                    WHERE store_id=@fid";

                            //var cn = GetConnection(); /*new SqlConnection(ConnectionString);*/

                            GlobalDefines.cn.Open();

                            var cmd = new NpgsqlCommand(sql, GlobalDefines.cn);

                            //Guid groupId = (Guid)treeView1.SelectedNode.Parent.Tag;

                            cmd.Parameters.AddWithValue("@Name", frm.Name);
                            // cmd.Parameters.AddWithValue("@Surname", frm.Фамилия);
                            cmd.Parameters.AddWithValue("@fid", id);

                            cmd.ExecuteNonQuery();
                            CurrentNode.Text = frm.Name;
                            GlobalDefines.cn.Close();

						}

                        break;
                    }
                case 1:
                    {
                        StoreAndCat frm = new StoreAndCat();
                        frm.setTitle("Категория");
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            var sql = @"UPDATE Categories 
                                    SET name_category=@Name
                                    WHERE category_id=@id";


                            GlobalDefines.cn.Open();

                            var cmd = new NpgsqlCommand(sql, GlobalDefines.cn);


                            cmd.Parameters.AddWithValue("@Name", frm.Name);
                            // cmd.Parameters.AddWithValue("@Surname", frm.Фамилия);
                            cmd.Parameters.AddWithValue("@id", id);

                            cmd.ExecuteNonQuery();
                            CurrentNode.Text = frm.Name;
                            GlobalDefines.cn.Close();
						}
                        break;
                    }
                case 2:
                    {
                        ProductForm frm = new ProductForm();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            var sql = @"UPDATE Products 
                                    SET product_name=@Name, price=@Price, description=@Desc
                                    WHERE product_id=@id";

                            //var cn = GetConnection(); /*new SqlConnection(ConnectionString);*/

                            GlobalDefines.cn.Open();

                            var cmd = new NpgsqlCommand(sql, GlobalDefines.cn);

                            //Guid groupId = (Guid)treeView1.SelectedNode.Parent.Tag;

                            cmd.Parameters.AddWithValue("@Name", frm.Name);
                            cmd.Parameters.AddWithValue("@Price", frm.Price);
							cmd.Parameters.AddWithValue("@Desc", frm.Desc);
							cmd.Parameters.AddWithValue("@id", id);

                            cmd.ExecuteNonQuery();
                            CurrentNode.Text = frm.Name;
							GlobalDefines.cn.Close();
						}
                        break;
                    }
            }
        }
            private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Level == 3)
                return;
            TreeNode CurrentNode = treeView1.SelectedNode;

            switch (CurrentNode.Level)
            {
                case 0:
                    {
						StoreAndCat frm = new StoreAndCat();
						frm.setTitle("Магазин");
						if (frm.ShowDialog() == DialogResult.OK)
                        {
                            //Guid guid = Guid.NewGuid();
                            var sql = @"INSERT INTO Stores (store_name) VALUES
                    (@Name)";

                            //var cn = GetConnection(); /*new SqlConnection(ConnectionString);*/

                            GlobalDefines.cn.Open();

                            var cmd = new NpgsqlCommand(sql, GlobalDefines.cn);

                            //Guid groupId = (Guid)treeView1.SelectedNode.Parent.Tag;

                            cmd.Parameters.AddWithValue("@Name", frm.Name);
                            // cmd.Parameters.AddWithValue("@Surname", frm.Фамилия);
                            // cmd.Parameters.AddWithValue("@student_id", frm.Фамилия);
                           // cmd.Parameters.AddWithValue("@FacId", guid);

                            cmd.ExecuteNonQuery();

                            var n = new TreeNode(frm.Name);
                            n.Tag = GlobalDefines.GetMaxValue("stores", "store_id");
							//n.Tag = (int)dr["id"];
							baseNode.Nodes.Add(n);
							GlobalDefines.cn.Close();
						}

                        break;
                    }
                case 1:
                    {
                        StoreAndCat frm = new StoreAndCat();
                        frm.setTitle("Категория");
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            var sql = @"INSERT INTO Categories (fk_store_id, name_category) VALUES
                    (@Store_id,@Name_cat)";

                            //var cn = GetConnection(); /*new SqlConnection(ConnectionString);*/

                            GlobalDefines.cn.Open();

                            var cmd = new NpgsqlCommand(sql, GlobalDefines.cn);

							int facId = (int)treeView1.SelectedNode.Tag;
							cmd.Parameters.AddWithValue("@Store_id", facId);
							cmd.Parameters.AddWithValue("@Name_cat", frm.Name);

                            cmd.ExecuteNonQuery();

                            var n = new TreeNode(frm.Name);
                            n.Tag = GlobalDefines.GetMaxValue("categories", "category_id");
                            treeView1.SelectedNode.Nodes.Add(n);
							GlobalDefines.cn.Close();
						}
                        break;
                    }
                case 2:
                    {
                        ProductForm frm = new ProductForm();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            var sql = @"INSERT INTO Products (fk_category_id,product_name,price, description) VALUES
                    (@catID,@Name, @Price, @Description )";

                            //var cn = GetConnection(); /*new SqlConnection(ConnectionString);*/

                            GlobalDefines.cn.Open();

                            var cmd = new NpgsqlCommand(sql, GlobalDefines.cn);

                            int catid = (int)treeView1.SelectedNode.Tag;
                            cmd.Parameters.AddWithValue("@Name", frm.Name);
                            cmd.Parameters.AddWithValue("@Price", frm.Price);
							cmd.Parameters.AddWithValue("@Description", frm.Desc);
							cmd.Parameters.AddWithValue("@catID", catid);

                            cmd.ExecuteNonQuery();

                            var n = new TreeNode(frm.Name);
                            int tmp_= GlobalDefines.GetMaxValue("products", "product_id");
                            n.Tag = tmp_;

							treeView1.SelectedNode.Nodes.Add(n);
							GlobalDefines.cn.Close();
						}
                        break;
                    }
            }

        }

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			using (NpgsqlConnection cn = GlobalDefines.GetConnection())
			{
                if (treeView1.SelectedNode == null)
                {
					lbName.Hide();
					lbPrice.Hide();
					lbDesc.Hide();
					return;
                }
				cn.Open();
                int level = treeView1.SelectedNode.Level;

                switch (level)
                {
                    case 0:
                        lbName.Hide();
                        lbPrice.Hide();
                        lbDesc.Hide();
                        break;
                    case 1:
						lbName.Text = "Название: " + treeView1.SelectedNode.Text;
						lbName.Show();
						lbPrice.Hide();
						lbDesc.Hide();
						break;
                    case 2:
						lbName.Text = "Название: " + treeView1.SelectedNode.Text;
						lbName.Show();
						lbPrice.Hide();
						lbDesc.Hide();
						break;
                    case 3:
                        {
                            lbName.Text = "Название: " + treeView1.SelectedNode.Text;
                            String s = "SELECT * from products where product_id=@id";
                            var cmd = new NpgsqlCommand(s, cn);
                            cmd.Parameters.AddWithValue("@id", (int)treeView1.SelectedNode.Tag);

                            var dr = cmd.ExecuteReader();
							while (dr.Read())
								{
                                lbName.Text = "Название: " + treeView1.SelectedNode.Text;
                                lbPrice.Text = "Цена: " + Convert.ToString(dr["price"]);
								lbDesc.Text = "Описание: " + Convert.ToString(dr["description"]);
							}
								lbName.Show();
                            lbPrice.Show();
                            lbDesc.Show();
                        }
						break;
                }
				cn.Close();
			}
		}

		private void btnNewOrder_Click(object sender, EventArgs e)
		{
            DoOrder frm = new DoOrder();
            frm.ShowDialog();
		}

		private void btnAllOrders_Click(object sender, EventArgs e)
		{
            OrdersEditForm frm = new OrdersEditForm(true, "orders");
            frm.ShowDialog();
		}

		private void btnYourOrders_Click(object sender, EventArgs e)
		{
			OrdersEditForm frm = new OrdersEditForm(false,"orders");
			frm.ShowDialog();
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

			app.Visible = true;

			Workbook wb = app.Workbooks.Add();
			Worksheet ws = wb.Worksheets[1];
            using (NpgsqlConnection conn = GlobalDefines.GetConnection())
            {
                conn.Open();

				NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM orders", conn);

				NpgsqlDataReader reader = cmd.ExecuteReader();

                ws.Cells[1, 1].Value = reader.GetName(0);
                ws.Cells[1, 2].Value = reader.GetName(1);
                ws.Cells[1, 3].Value = reader.GetName(2);
				ws.Cells[1, 4].Value = reader.GetName(3);
				ws.Cells[1, 5].Value = reader.GetName(4);
				ws.Cells[1, 6].Value = reader.GetName(5);

				int i = 2;
                while (reader.Read())
                {
                    ws.Cells[i, 1].Value = reader[0];
                    ws.Cells[i, 2].Value = reader[1];
                    ws.Cells[i, 3].Value = reader[2];
					ws.Cells[i, 4].Value = reader[3];
					ws.Cells[i, 5].Value = reader[4];
					ws.Cells[i, 6].Value = reader[5];
					i++;
                }

                reader.Close();
                conn.Close();
            }

		}

		private void btnAdmin_Click(object sender, EventArgs e)
		{
			OrdersEditForm frm = new OrdersEditForm(true,"users");
			frm.ShowDialog();
		}

		private void btnCustomRequest_Click(object sender, EventArgs e)
		{
            CustomRequestF frm = new CustomRequestF();
            frm.ShowDialog();
		}
	}
}
