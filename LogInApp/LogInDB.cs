using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LogInApp
{
	internal class LogInDB
	{
		[PrimaryKey,AutoIncrement]
		public int ID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public User()
		{
			
		}
	}
}
