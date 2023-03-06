using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using LogInApp;

namespace LogInApp
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
 //   public bool validateUser(string username, string password)
 //   { 
 //       var LogInApp.LoginDetail


	//}
}
