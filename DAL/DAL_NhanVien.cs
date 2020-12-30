using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using DTO;
namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        DBConnect db;
        SQLiteConnection conn;
        string machucvu;
        public DAL_NhanVien()
        {
            db = new DBConnect();
        }
       public bool checkUser(String user, String pass)
        {
            conn = db.getConnection();
            conn.Open();
            SQLiteDataAdapter sql = new SQLiteDataAdapter($"Select TenNhanvien from NhanVien where tenDangnhap='{user}' and matkhau='{pass}'", conn);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            conn.Close();
            Console.WriteLine(dt.Rows.Count);
            if (dt.Rows.Count == 1)
                return true;
            return false;
        }
        public DataTable getNhanVien()
        {
            conn = db.getConnection();
            conn.Open();
            SQLiteDataAdapter sql = new SQLiteDataAdapter("Select TendangNhap as [Tên Đăng Nhập],TenNhanVien as [Tên Nhân Viên], LoaiNhanVien  as [Loại Nhân Viên]from NhanVien ORDER BY TenDangNhap ASC", conn);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool insertNV(DTO_NhanVien nv )
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = $"INSERT INTO NhanVien(tenDangNhap,matkhau,tenNhanvien,loainhanvien) VALUES ('{nv.TenDangNhap}', '{nv.MatKhau}', '{nv.TenNhanVien}', '{nv.LoaiNhanVien}')";

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally
            {
                // Dong ket noi
                connect.Close();
            }

            return false;
        }

    }
}
