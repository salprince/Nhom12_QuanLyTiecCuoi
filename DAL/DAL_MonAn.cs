using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using DTO;

namespace DAL
{
    public class DAL_MonAn : DBConnect
    {
        public DataTable searchMA(string key)
        {
            string sql = "SELECT * FROM Phieudatban WHERE TENMONAN LIKE '%" + key + "%' OR MOTA LIKE '%" + key + "%' OR GHICHU LIKE '%" + key + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsMAn = new DataTable();
            da.Fill(dsMAn);
            return dsMAn;
        }
        
        public DataTable getMonAn()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM MonAn", getConnection());
            DataTable dsMonAn = new DataTable();
            da.Fill(dsMonAn);
            return dsMonAn;
        }
        public bool insertMonAn(DTO_MonAn man)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("INSERT INTO MONAN(MAMONAN, TENMONAN, MOTA, DONGIA, GHICHU) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", man.MaMonAn, man.TenMonAn, man.MoTa, man.DonGia, man.GhiChu);

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

        public bool deleteMonAn(string id)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần ID là đủ
                string SQL = string.Format("DELETE FROM MONAN WHERE MAMONAN = '{0}';", id);

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

        public DataTable searchMonAn(string key)
        {
            string sql = "SELECT * FROM MONAN WHERE TENMONAN LIKE '%" + key + "%' OR MOTA LIKE '%" + key + "%' OR GHICHU LIKE '%" + key + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsMAn = new DataTable();
            da.Fill(dsMAn);
            return dsMAn;
        }

        public bool editMonAn(DTO_MonAn man)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("UPDATE MONAN SET TENMONAN = '{0}', MOTA = '{1}', DONGIA = '{2}', GHICHU = '{3}' WHERE MAMONAN = '{4}';", man.TenMonAn, man.MoTa, man.DonGia, man.GhiChu, man.MaMonAn);

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
