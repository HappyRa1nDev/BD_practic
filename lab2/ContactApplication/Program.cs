using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Npgsql;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ContactApplication
{
    //static class Program
    //{
    //	/// <summary>
    //	/// The main entry point for the application.
    //	/// </summary>
    //	[STAThread]
    //	static void Main()
    //	{
    //		Application.EnableVisualStyles();
    //		Application.SetCompatibleTextRenderingDefault(false);
    //		Application.Run(new MainForm());
    //	}
    //}

    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static NpgsqlConnection GetConnection()
        {
            var connectString = "Host=localhost;Username=postgres;Password=1;Database=Notebook";
            return new NpgsqlConnection(connectString);
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var frm = new LoginForm();
            //frm.ShowDialog();

            //MessageBox.Show(LogIn(frm.Login, frm.Password) ?
            //    "Успешно" : "Неуспешно");
            LoginForm lgnFrm = new LoginForm();
            Application.Run(lgnFrm);
            if (lgnFrm.isOk)
            {
                if (LogIn(lgnFrm._login, lgnFrm._password))
                {
                    Application.Run(new MainForm());
                }
                else
                {
                    MessageBox.Show("Неуспешно");
                }
            }
        }
        //if(LogIn(frm.Login, frm.Password))
        //{
        //    Application.Run(new MainForm());
        //}
        //else
        //{
        //    MessageBox.Show("Неуспешно");
        //}
        //MessageBox.Show(LogIn(frm.Login, frm.Password) ?
        //"Успешно" : "Неуспешно");

        //Application.Run(new LoginForm());

        public static bool LogIn(string login, string password)
        {
            var hash = GetHash(password);

            var cn = GetConnection();

            cn.Open();

            var cmd = new NpgsqlCommand(@"select count(*) from Users 
                    where Login=@Login and Password=@Password and IsActive=1", cn);

            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", hash);

            var result = Convert.ToInt32(cmd.ExecuteScalar());

            cn.Close();
            return result == 1;

        }

        public static string GetHash(string password)
        {
            var sha1 = new SHA1Managed();
            var hash = BitConverter.ToString(sha1.ComputeHash
                (Encoding.UTF8.GetBytes(password))).Replace("-", "");
            return hash;
        }
    }

}
