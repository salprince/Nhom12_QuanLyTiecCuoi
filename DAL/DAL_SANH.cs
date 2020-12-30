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

    public class DAL_SANH
    {

        DBConnect db;
        SQLiteConnection conn;
        public DAL_SANH()
        {
            db = new DBConnect();
        }
        public DataTable getSanh()
        {
            conn = db.getConnection();
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT MASANH as 'Mã sảnh', TENSANH as 'Tên sảnh',SOLUONGBANTOIDA as 'Số bàn tối đa', SOLUONGBANTOITHIEU as 'Số lượng bàn tối thiểu', DONGIABANTOITHIEU as 'Đơn giá bàn tối thiểu', GHICHU as 'Ghi chú' FROM SANH", conn);


            DataTable dtSanh = new DataTable();
            da.Fill(dtSanh);
            return dtSanh;
        }
        public bool insertSanh(DTO_Sanh sanh)
        {
            // Ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("INSERT INTO SANH (MaSanh,TenSanh, SoLuongBanToiDa,SoLuongBanToiThieu,DonGiaBanToiThieu,GhiChu) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", sanh.MaSanh, sanh.TenSanh, sanh.SoLuongBanToiDa, sanh.SoLuongBanToiThieu, sanh.DonGiaBanToiThieu, sanh.GhiChu);

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
        public bool editSanh(DTO_Sanh sanh)
        {
            // Ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("UPDATE SANH SET TENSANH = '{0}', SOLUONGBANTOIDA = '{1}', SOLUONGBANTOITHIEU = '{2}', DONGIABANTOITHIEU = '{3}', GHICHU = '{4}' WHERE MASANH = '{5}';", sanh.TenSanh, sanh.SoLuongBanToiDa, sanh.SoLuongBanToiThieu, sanh.DonGiaBanToiThieu, sanh.GhiChu, sanh.MaSanh);

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;
                }    
                    
            }
            catch (Exception e) { 
            }
            finally
            {
                // Dong ket noi
                connect.Close();
            }

            return false;
        }
        public DataTable searchSanh(string tensanh)
        {
            string sql = "SELECT * FROM SANH WHERE TENSANH LIKE '%" + tensanh + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, db.getConnection());
            DataTable dsSanh = new DataTable();
            da.Fill(dsSanh);
            return dsSanh;
        }
        public bool deleteSanh(string id)
        {
            // Ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM SANH WHERE MASANH = '{0}';", id);

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