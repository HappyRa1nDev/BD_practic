using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frm = new LoginForm();
            frm.ShowDialog();

            MessageBox.Show(LogIn(frm.Login, frm.Password) ? 
                "Успешно" : "Неуспешно");

            //Application.Run(new LoginForm());
        }

        private static bool LogIn( string login, string password)
        {
            var hash = GetHash(password);

            var cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["Univer"].ConnectionString);

            cn.Open();

            var cmd = new SqlCommand(@"select count(*) from Users 
                    where Login=@Login and Password=@Password and IsActive=1", cn);

            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", hash);

            var result = (int)cmd.ExecuteScalar();

            return result == 1;

        }

        private static string GetHash(string password)
        {
            var sha1 = new SHA1Managed();
            var hash = BitConverter.ToString(sha1.ComputeHash
                (Encoding.UTF8.GetBytes(password))).Replace("-", "");
            return hash;
        }


    }
}
