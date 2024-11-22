using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourLook
{
    public partial class DoOrder : Form
    {
        int selectStore_id;
		int selectCat_id;
		string store_name;
        public int userid { get; set; }
        public string userlogin { get; set; }
        void check() {
            button2.Enabled = listBox1.Items.Count > 0 && listBox1.SelectedItem!=null;
            button3.Enabled = listBox2.Items.Count > 0 && listBox2.SelectedItem != null;
			button1.Enabled = listBox1.Items.Count > 0 && listBox2.Items.Count > 0;

		}
        public DoOrder()
        {
            InitializeComponent();
            LoadInfoStores();
            check();
			calc_sum();
		}
        public void LoadInfoStores()
        {
            comboBox1.Items.Clear();
            comboBox1.DisplayMember = "name";
            var sql = "SELECT * FROM stores";
            using (var cn = GlobalDefines.GetConnection())
            {
                cn.Open();
                var cmd = new NpgsqlCommand(sql, cn);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
					var store_id = (int)dr["store_id"];
					var store_name = (string)dr["store_name"];
          
                    var item = new StoreId(store_id, store_name);
                    comboBox1.Items.Add(item);
                }

				cn.Close();
            }
        }
		public void LoadInfoCat()
		{
			listBox2.Items.Clear();
			comboBox2.Items.Clear();
            comboBox2.Text = "";
			//comboBox2.SelectedIndex = -1;
			comboBox2.DisplayMember = "name";
			var sql = $"SELECT * FROM categories WHERE fk_store_id={((StoreId)(comboBox1.SelectedItem)).id}";
			using (var cn = GlobalDefines.GetConnection())
			{
				cn.Open();
				var cmd = new NpgsqlCommand(sql, cn);
				var dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					var store_id = (int)dr["category_id"];
					var store_name = (string)dr["name_category"];

					var item = new CatId(store_id, store_name);
					comboBox2.Items.Add(item);
				}

				cn.Close();
			}
		}

		public void refreshdishes()
        {
            listBox1.Items.Clear();
            var store = comboBox1.SelectedItem as StoreId;
			var cat = comboBox2.SelectedItem as CatId;
			//comboBox1.DisplayMember = "name";
			listBox1.DisplayMember = "name";
			selectStore_id = store.id;
			selectCat_id = cat.id;
            store_name = store.name;
            using (var cn = GlobalDefines.GetConnection())
            {
                cn.Open();
                var sql = $"SELECT * FROM stores JOIN categories ON store_id=fk_store_id JOIN products ON categories.category_id = products.fk_category_id WHERE store_id = {selectStore_id} AND  category_id = {selectCat_id}";
                var cmd = new NpgsqlCommand(sql, cn);
                var dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    var product_id = (int)dr["product_id"];
					var product_name = (string)dr["product_name"];
					var price_ = (int)dr["price"];
                    var item = new ProductId(product_id, product_name, price_);
                    listBox1.Items.Add(item);
                }
            }
            check();
			calc_sum();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            string text = $"({store_name}): ";
            foreach (var item in listBox2.Items)
            {
                ProductId pd = item as ProductId;
                if (pd != null)
                    text += pd.name + ", ";
            }
            using (var cn = GlobalDefines.GetConnection())
            {
                cn.Open();
                var sql = $"INSERT INTO Orders (fk_user_id,fk_store_id,products_list,sum) VALUES (@user_id,@store_id,@list,@price);";
                var cmd = new NpgsqlCommand(sql, cn);
                 cmd.Parameters.AddWithValue("@user_id", (int)GlobalDefines.curUserID);
				 cmd.Parameters.AddWithValue("@store_id", (int)selectStore_id);
				 cmd.Parameters.AddWithValue("@list", (string)text);
				 cmd.Parameters.AddWithValue("@price", Convert.ToInt32(label2.Text));
				cmd.ExecuteScalar();
                cn.Close();
            }
            MessageBox.Show("Покупка совершена!");
            this.Close();
        }
        public class StoreId
        {
			public int id { get; set; }
            public string name { get; set; }
            public StoreId(int id_,string name_)
            {
                id = id_;
                name = name_;
            }
        }
        public class CatId
        {
            public int id { get; set; }
            public string name { get; set; }
            public CatId(int id,string name)
            {
                this.id = id;
                this.name = name;
            }
        }
		public class ProductId
		{
			public int id { get; set; }
			public string name { get; set; }

			public int price { get; set; }
			public ProductId(int id, string name, int price_)
			{
				this.id = id;
				this.name = name;
                price = price_;
                
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
			listBox2.Items.Clear();
            if (comboBox1.SelectedIndex >= 0)
            {
                LoadInfoCat();
                if(comboBox2.SelectedIndex!=-1)
                  refreshdishes();
            }
            check();
            calc_sum();
        }
       

        public void calc_sum()
        {
            int sum = 0;
            foreach (var item in listBox2.Items)
            {
                ProductId pr = item as ProductId;
                if (pr != null)
                    sum += pr.price;
            }
            label2.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.DisplayMember = "name";
            listBox2.Items.Add(listBox1.SelectedItem);

			calc_sum();
			check();
		}

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem!=null)
                listBox2.Items.Remove(listBox2.SelectedItem);
			calc_sum();
			check();
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox2.Items.Clear();
			if (comboBox2.SelectedIndex >= 0)
			{
				refreshdishes();
			}
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			check();
			calc_sum();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
            check();
			calc_sum();
		}
	}
}
