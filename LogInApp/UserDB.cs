using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;

namespace LogInApp.Helper
{
	internal class User
	{
		private SQLiteConnection _connection;

		public User()
		{
			_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
			_connection.CreateTables<User>();

		}
		public IEnumerable<User> GetUsers()
		{
			return (from u in _connection.Table<User>() select u).ToList();
		}

		public User GetSpecificUser(int id)
		{
			return _connection.Table<User>().FirstOrDefault(t => t.Id == id);
		}

		public void DeleteUser(int id) { _connection.Dekete<User>(id); }

		public string AddUser(User user)
		{
			var data = _connection.Table<User>();
			var d1 = data.Where(x => x.name == user.name && x.userName == user.userName).FirstOrDefault();
			if (d1 == null)
			{
				_connection.Insert(user);
				return "Sucessfully Added";
			}
			else
				return "Already Mail id Exist";
		}

		public bool updateUserValidation(String userid)
		{
			var data = _connection.Table<User>();
			var d1 = (from values in data
					  where values.name == userid
					  select values).Single();
			if (d1 != null)
			{
				return true;
			}
			else
				return false;
		}


		public bool updateUser(string username, string pwd)
		{
			var data = _connection.Table<User>();
			var d1 = (from values in data
					  where values.name == username
					  select values).Single();
			if (true)
			{
				d1.password = pwd;
				_connection.Update(d1);
				return true;
			}
			else
				return false;
		}
		public bool LoginValidate(string userName1, string pwd1)
		{
			var data = _connection.Table<User>();
			var d1 = data.Where(x => x.name == userName1 && x.password == pwd1).FirstOrDefault();

			if (d1 != null)
			{
				return true;
			}
			else
				return false;

		}
	}
}
