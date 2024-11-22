using Microsoft.VisualBasic.Logging;
using Npgsql;
using System.Security.Policy;

namespace YourLook
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			GlobalDefines.cn = GlobalDefines.GetConnection();
			LoginForm lgnFrm = new LoginForm();

			Application.Run(lgnFrm);

			if (lgnFrm.isOk)
			{
				if (LogIn(lgnFrm._login, lgnFrm._password))
				{
					initUserID(lgnFrm._login, lgnFrm._password);
					Application.Run(new Form1());
				}
				else
				{
					MessageBox.Show("Неуспешно");
				}
			}
			//GlobalDefines.cn.Close();
		}
		public static void initUserID(string login, string password)
		{
			var hash = GlobalDefines.GetHash(password);

			GlobalDefines.cn.Open();
			var cmd = new NpgsqlCommand(@"select user_id from Users 
                    where Login=@Login and Password=@Password", GlobalDefines.cn);
			cmd.Parameters.AddWithValue("@Login", login);
			cmd.Parameters.AddWithValue("@Password", hash);

			var result = Convert.ToInt32(cmd.ExecuteScalar());

			cmd = new NpgsqlCommand(@"select isadmin from Users 
                    where Login=@Login and Password=@Password", GlobalDefines.cn);
			cmd.Parameters.AddWithValue("@Login", login);
			cmd.Parameters.AddWithValue("@Password", hash);

			bool isA= Convert.ToBoolean(cmd.ExecuteScalar());
			GlobalDefines.curUserID = result;
			GlobalDefines.isAdmin = isA;
			GlobalDefines.cn.Close();
		}
		public static bool LogIn(string login, string password)
		{
			var hash = GlobalDefines.GetHash(password);

			//var cn = GlobalDefines.GetConnection();

			GlobalDefines.cn.Open();

			var cmd = new NpgsqlCommand(@"select count(*) from Users 
                    where Login=@Login and Password=@Password", GlobalDefines.cn);

			cmd.Parameters.AddWithValue("@Login", login);
			cmd.Parameters.AddWithValue("@Password", hash);

			var result = Convert.ToInt32(cmd.ExecuteScalar());

			GlobalDefines.cn.Close();
			return result == 1;

		}
	}
}