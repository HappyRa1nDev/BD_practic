using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Npgsql;

namespace YourLook
{
	public static class GlobalDefines
	{
		public static NpgsqlConnection cn;

		public static int curUserID;
		public static bool isAdmin=false;
		public static int GetMaxValue(string table, string col)
		{
			using (NpgsqlConnection cn = GlobalDefines.GetConnection())
			{
				cn.Open();

				var cmd = new NpgsqlCommand(@$"Select max({col}) from {table}", cn);

				int max = Convert.ToInt32(cmd.ExecuteScalar());
				cn.Close();
				return max;
			}
		}
			public static string GetHash(string password)
		{
			var sha1 = new SHA1Managed();
			var hash = BitConverter.ToString(sha1.ComputeHash
				(Encoding.UTF8.GetBytes(password))).Replace("-", "");
			return hash;
		}

		public static NpgsqlConnection GetConnection()
		{
			var connectString = "Host=localhost;Username=postgres;Password=1;Database=your_look";
			return new NpgsqlConnection(connectString);
		}

		public static int lol() { return 1; }
	}
}
