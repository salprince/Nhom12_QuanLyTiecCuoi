using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
namespace DAL
{
    public class DBConnect
    {
        string connectionStr;
        public DBConnect()
        {
            connectionStr = "Data Source=NewQuanLiTiecCuoi.db";
        }
        public SQLiteConnection getConnection()
        {
            return new SQLiteConnection(connectionStr);
        }
    }
}
