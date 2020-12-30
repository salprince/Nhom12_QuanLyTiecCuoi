using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using DTO;
using System.Security.Cryptography;

namespace DAL
{
    public class DAL_YC1
    {

        DBConnect db;
        SQLiteConnection conn;
        public DAL_YC1()
        {
            db = new DBConnect();
        }
        public DataTable getSanh()
        {
            conn = db.getConnection();
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT MASANH as 'Mã sảnh', TENSANH as 'Tên sảnh',SOLUONGBANTOIDA as 'Số bàn tối đa', SANH.MALOAISANH as 'Mã loại sảnh', TENLOAISANH as 'Tên loại sảnh', DONGIABANTOITHIEU as 'Đơn giá bàn tối thiểu' FROM SANH INNER JOIN LOAISANH ON SANH.MALOAISANH = LOAISANH.MALOAISANH", conn);


            DataTable dtSanh = new DataTable();
            da.Fill(dtSanh);
            return dtSanh;
        }
    }
}