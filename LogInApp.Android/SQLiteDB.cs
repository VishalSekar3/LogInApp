using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using Xamarin.Forms;
using SQLite;
using LogInApp.Droid;

[assembly: Dependency(typeof(SQLiteDB))]
namespace LogInApp.Droid
{
	public class SQLiteDB : ISQLiteDB
	{
		public SQLiteAsyncConnection GetConnection()
		{
			var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
			var path = Path.Combine(documentsPath, "MySQLite.db3");

			return new SQLiteAsyncConnection(path);
		}
	}
}