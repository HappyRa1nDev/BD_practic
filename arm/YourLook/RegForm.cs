using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourLook
{
    public partial class RegForm : Form
    {
        private void check()
        {
            
            if (txtLogin.Text.Length < 3)
            {
                pasInfo.Text = "Короткий логин";
                btnOK.Enabled=false;
                return;
            }
            if (pas1.Text != pas2.Text)
            {
                pasInfo.Text = "Пароли не совпадают";
                btnOK.Enabled = false;
                return;
            }
            if (pas1.Text.Length<3 || pas2.Text.Length<3)
            {
                pasInfo.Text = "Короткий пароль";
                btnOK.Enabled = false;
                return;
            }
            {
                var sql = @"SELECT count(*) FROM users where login=@Login";

                var cmd = new NpgsqlCommand(sql, GlobalDefines.cn);
                cmd.Parameters.AddWithValue("@Login", txtLogin.Text);

                var result = Convert.ToInt32(cmd.ExecuteScalar());
                if(result != 0)
                {
                    btnOK.Enabled = result == 0;
                    pasInfo.Text = "Логин уже существует";
                    return;
                }
            }
            pasInfo.Text = "Пароль устравивает";
            btnOK.Enabled = true;
        }
        public RegForm()
        {
            InitializeComponent();
          
            check();
        }

        private void pas1_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void pas2_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var hash = GlobalDefines.GetHash(pas1.Text);
            var sql = @"INSERT INTO users (login,password) VALUES
                    (@Login,@Password)";


            var cmd = new NpgsqlCommand(sql, GlobalDefines.cn);

            cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
            cmd.Parameters.AddWithValue("@Password", hash);

            cmd.ExecuteNonQuery();
           // var result = Convert.ToInt32(cmd.ExecuteScalar());
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegForm_Shown(object sender, EventArgs e)
        {
            GlobalDefines.cn.Open();
        }

        private void RegForm_FormClosing(object sender, FormClosingEventArgs e)
        {
			GlobalDefines.cn.Close();
        }
    }
}
