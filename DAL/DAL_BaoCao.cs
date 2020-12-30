using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using DTO;
namespace DAL
{
    public class DAL_BaoCao
    {
        DBConnect Db = new DBConnect();
        public DataTable getBaoCao()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM BaoCao", Db.getConnection());
            DataTable dsBaoCao = new DataTable();
            da.Fill(dsBaoCao);
            return dsBaoCao;
        }

        public bool insertBaoCao(DTO_BaoCao bc)
        {
            SQLiteConnection connect = Db.getConnection();
            connect.Open();

            try
            {
                string SQL = string.Format("INSERT INTO BaoCao (MaBaoCao, Quy,  Nam, TongThu, TongSoTiecCuoi, TyLeThanhCong, TyLeHuy) VALUES ('{0}', '{1}', {2}, {3}, {4}, {5}, '{6}')", bc.MaBaoCao, bc.Quy, bc.Nam, bc.TongThu, bc.TongSoTiecCuoi, bc.TyLeThanhCong, bc.TyLeHuy);
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally
            {
                connect.Close();
            }

            return false;
        }
        public double TinhTongThu(int quy, int nam)
        {
            String Thang1 = "";
            String Thang2 = "";
            String Thang3 = "";
            if (quy == 1)
            {
                Thang1 = "%/%" + 01 + "/" + nam;
                Thang2 = "%/%" + 02 + "/" + nam;
                Thang3 = "%/%" + 03 + "/" + nam;
            }
            if (quy == 2)
            {
                Thang1 = "%/%" + 04 + "/" + nam;
                Thang2 = "%/%" + 05 + "/" + nam;
                Thang3 = "%/%" + 06 + "/" + nam;
            }
            if (quy == 3)
            {
                Thang1 = "%/%" + 07 + "/" + nam;
                Thang2 = "%/%" + 08 + "/" + nam;
                Thang3 = "%/%" + 09 + "/" + nam;
            }
            if (quy == 4)
            {
                Thang1 = "%/%" + 10 + "/" + nam; ;
                Thang2 = "%/%" + 11 + "/" + nam;
                Thang3 = "%/%" + 12 + "/" + nam;
            }
            SQLiteConnection connect = Db.getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("select sum(tongtienhoadon) as TongTien from HoaDon where ngaythanhtoan like '{0}' or NgayThanhToan like '{1}' or NgayThanhToan like '{2}'", Thang1, Thang2, Thang3);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);
                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = Double.Parse(row["TongTien"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connect.Close();
            return kq;
        }
        public double DemSoTiecCuoi(int quy, int nam)
        {
            String Thang1 = "";
            String Thang2 = "";
            String Thang3 = "";
            if (quy == 1)
            {
                Thang1 = "%/%" + 01 + "/" + nam;
                Thang2 = "%/%" + 02 + "/" + nam;
                Thang3 = "%/%" + 03 + "/" + nam;
            }
            if (quy == 2)
            {
                Thang1 = "%/%" + 04 + "/" + nam;
                Thang2 = "%/%" + 05 + "/" + nam;
                Thang3 = "%/%" + 06 + "/" + nam;
            }
            if (quy == 3)
            {
                Thang1 = "%/%" + 07 + "/" + nam;
                Thang2 = "%/%" + 08 + "/" + nam;
                Thang3 = "%/%" + 09 + "/" + nam;
            }
            if (quy == 4)
            {
                Thang1 = "%/%" + 10 + "/" + nam; ;
                Thang2 = "%/%" + 11 + "/" + nam;
                Thang3 = "%/%" + 12 + "/" + nam;
            }
            SQLiteConnection connect = Db.getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("select count(MaTiecCuoi) as TongTiec from TiecCuoi where NGAYDAITIEC LIKE '{0}' or NgayDaiTiec like '{1}' or NgayDaiTiec like '{2}'", Thang1, Thang2, Thang3);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);
                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = Double.Parse(row["TongTiec"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connect.Close();
            return kq;
        }
        public double TiecCuoiThanhCong(int quy, int nam)
        {
            String Thang1 = "";
            String Thang2 = "";
            String Thang3 = "";
            if (quy == 1)
            {
                Thang1 = "%/%" + 01 + "/" + nam;
                Thang2 = "%/%" + 02 + "/" + nam;
                Thang3 = "%/%" + 03 + "/" + nam;
            }
            if (quy == 2)
            {
                Thang1 = "%/%" + 04 + "/" + nam;
                Thang2 = "%/%" + 05 + "/" + nam;
                Thang3 = "%/%" + 06 + "/" + nam;
            }
            if (quy == 3)
            {
                Thang1 = "%/%" + 07 + "/" + nam;
                Thang2 = "%/%" + 08 + "/" + nam;
                Thang3 = "%/%" + 09 + "/" + nam;
            }
            if (quy == 4)
            {
                Thang1 = "%/%" + 10 + "/" + nam; ;
                Thang2 = "%/%" + 11 + "/" + nam;
                Thang3 = "%/%" + 12 + "/" + nam;
            }
            SQLiteConnection connect = Db.getConnection();
            connect.Open();
            int kq = 0;
            try
            {
                string sql = string.Format("select count(MaTiecCuoi) as TongTiec from TiecCuoi where TienDo = '100' and (NgayDaiTiec like '{0}' or NgayDaiTiec like '{1}' or NgayDaiTiec like '{2}')", Thang1, Thang2, Thang3);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);
                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = int.Parse(row["TongTiec"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connect.Close();
            return kq;
        }
        public double TiecCuoiHuy(int quy, int nam)
        {
            String Thang1 = "";
            String Thang2 = "";
            String Thang3 = "";
            if (quy == 1)
            {
                Thang1 = "%/%" + 01 + "/" + nam;
                Thang2 = "%/%" + 02 + "/" + nam;
                Thang3 = "%/%" + 03 + "/" + nam;
            }
            if (quy == 2)
            {
                Thang1 = "%/%" + 04 + "/" + nam;
                Thang2 = "%/%" + 05 + "/" + nam;
                Thang3 = "%/%" + 06 + "/" + nam;
            }
            if (quy == 3)
            {
                Thang1 = "%/%" + 07 + "/" + nam;
                Thang2 = "%/%" + 08 + "/" + nam;
                Thang3 = "%/%" + 09 + "/" + nam;
            }
            if (quy == 4)
            {
                Thang1 = "%/%" + 10 + "/" + nam; ;
                Thang2 = "%/%" + 11 + "/" + nam;
                Thang3 = "%/%" + 12 + "/" + nam;
            }
            SQLiteConnection connect = Db.getConnection();
            connect.Open();
            int kq = 0;
            try
            {
                string sql = string.Format("select count(MaTiecCuoi) as TongTiec from TiecCuoi where TienDo like 'H%y' and (NgayDaiTiec like '{0}' or NgayDaiTiec like '{1}' or NgayDaiTiec like '{2}')", Thang1, Thang2, Thang3);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);
                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = int.Parse(row["TongTiec"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connect.Close();
            return kq;
        }
        public bool xoaBaoCao(int Quy, int Nam)
        {
            // Ket noi
            SQLiteConnection connect = Db.getConnection();
            connect.Open();

            try
            {
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM BaoCao WHERE Quy = '{0}' and Nam ='{1}';", Quy, Nam);

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
        public string TimBaoCao(string MaBaoCao)
        {
            SQLiteConnection connect = Db.getConnection();
            connect.Open();
            string kq = null;
            try
            {
                string sql = string.Format("select Quy from BAOCAO where MaBaoCao = '{0}'", MaBaoCao);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);
                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = row["Quy"].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connect.Close();
            return kq;
        }
    }
}
