using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_YC3 : DBConnect
    {
        public DataTable SearchTiecCuoi(string key)
        {
            string sql = "SELECT * FROM TIECCUOI WHERE MATIECCUOI LIKE '%" + key + "%' OR TENCHURE LIKE '%" + key + "%' OR TENCODAU LIKE '%" + key + "%' OR DIENTHOAI LIKE '%" + key + "%' OR MASANH LIKE '%" + key + "%' OR MACA LIKE  '%" + key + "%' OR TIENDATCOC LIKE '%" + key + "%' OR GHICHU LIKE '%" + key + "%' OR NGAYDATTIEC LIKE '%" + key + "%' OR NGAYDAITIEC LIKE '%" + key + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable XemTiecCuoi()
        {
            string sql = "SELECT * FROM TIECCUOI";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



    }

}
