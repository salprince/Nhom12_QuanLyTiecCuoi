using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using DTO;
using System.Data;
using System.Globalization;

namespace DAL
{
    public class DAL_TiecCuoi : DBConnect
    {
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteConnection conn = new SQLiteConnection();
        DBConnect db;
        public DAL_TiecCuoi()
        {
            db = new DBConnect();
        }
        public DataTable getTiecCuoi()
        {
            conn = db.getConnection();
            conn.Open();
            SQLiteDataAdapter sql = new SQLiteDataAdapter("Select * from TIECCUOI ORDER BY MaTiecCuoi ASC", conn);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getTiecCuoi(String id)
        {
            conn = db.getConnection();
            conn.Open();
            SQLiteDataAdapter sql = new SQLiteDataAdapter($"Select * from TIECCUOI where matieccuoi='{id}'", conn);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            conn.Close();
            /*for(int i=0; i <dt.Columns.Count; i++)
            {
                Console.WriteLine($"{dt.Rows[0][i]} ");
            }*/
            return dt;
        }
        public bool themTiecCuoi(DTO_TiecCuoi tc)
        {
            //ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();
            try
            {
                string SQL = string.Format("INSERT INTO TIECCUOI(MATIECCUOI, TENCHURE, TENCODAU, DIENTHOAI, MACA, MASANH, TIENDATCOC, GHICHU, NGAYDATTIEC, NGAYDAITIEC, SoLuongKhach, SoLuongBan, TienDo) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')", tc.MaTiecCuoi, tc.TenChuRe, tc.TenCoDau, tc.DienThoai, tc.MaCa, tc.MaSanh, tc.TienDatCoc, tc.GhiChu, tc.NgayDatTiec, tc.NgayDaiTiec, tc.SoLuongKhach, tc.SoLuongBan, tc.TienDo);
                // command mặc định là command type = text
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);
                //query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }
        public bool suaTiecCuoi(DTO_TiecCuoi tc)
        {
            //ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                // query string
                string SQL = string.Format("UPDATE TIECCUOI SET TENCHURE = '{0}', TENCODAU = '{1}', DIENTHOAI = '{2}', NGAYDATTIEC = '{3}', NGAYDAITIEC = '{4}', MACA = '{5}', MASANH = '{6}', TIENDATCOC = '{7}', SoLuongBan='{8}', SoLuongKhach='{9}', TienDo='{10}', GHICHU ='{11}' WHERE MATIECCUOI = '{12}'", tc.TenChuRe, tc.TenCoDau, tc.DienThoai, tc.NgayDatTiec, tc.NgayDaiTiec, tc.MaCa, tc.MaSanh, tc.TienDatCoc, tc.SoLuongBan, tc.SoLuongKhach, tc.TienDo, tc.GhiChu, tc.MaTiecCuoi);

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                //query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }
        /// xoá thành viên
        /// 
        public bool capnhatTienCoc(double TiecCoc, string MaTiecCuoi)
        {
            //ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                // query string
                string SQL = string.Format("UPDATE TIECCUOI SET TIENDATCOC = '{0}' WHERE MATIECCUOI = '{1}'", TiecCoc, MaTiecCuoi);

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                //query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }
        public bool xoaTiecCuoi(string ID)
        {
            // Ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();
            try
            {

                string SQL = string.Format("DELETE FROM TIECCUOI WHERE MATIECCUOI = '{0}'", ID);

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                connect.Close();

            }

            return false;
        }
        public bool huyTiecCuoi(string ID)
        {
            SQLiteConnection connect = db.getConnection();
            connect.Open();
            try
            {
                string sql = $"SELECT NGAYDATTIEC FROM TIECCUOI WHERE MATIECCUOI ='{ID}'";
                SQLiteCommand com = new SQLiteCommand(sql, connect);
                SQLiteDataReader read = com.ExecuteReader();
                String ngayDat = "01/01/0001";
                while (read.Read())
                {
                    ngayDat = read["NgayDatTiec"].ToString();
                }
                Console.WriteLine($"ngay dat1 {ngayDat}");
                DateTime ngayDat1 = DateTime.ParseExact(ngayDat, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine($"ngay dat1 {ngayDat1}");

                if ((DateTime.Now - ngayDat1).Days < 7)
                {
                    Console.WriteLine($"TIME SPAN {(DateTime.Now - ngayDat1).Days.ToString()}");
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            return false;
        }
        public void CapNhatHuy(string ID)
        {
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                // query string
                string SQL = string.Format("UPDATE TIECCUOI SET TienDo='Hủy' WHERE MATIECCUOI = '{0}'", ID);

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                //query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0) { }
                // return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
        }
        public double getTienDatCoc(string MaTiecCuoi)
        {
            SQLiteConnection connect = db.getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("SELECT TienDatCoc FROM TIECCUOI WHERE MaTiecCuoi ='{0}'", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);

                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = double.Parse(row["TienDatCoc"].ToString());
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }
        public bool xoaPhieuDatMonAn(string MaTC)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần ID là đủ
                string SQL = string.Format("DELETE FROM PhieuDatBan WHERE MAtieccuoi = '{0}';", MaTC);

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

        public double getTienDo(string MaTiecCuoi)
        {
            SQLiteConnection connect = db.getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("SELECT TienDo FROM TIECCUOI WHERE MaTiecCuoi ='{0}'", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);

                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = double.Parse(row["TienDo"].ToString());
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }
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

        public bool suaTiecCuoiNew(DTO_TiecCuoi tc)
        {
            //ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                // query string
                string SQL = string.Format("UPDATE TIECCUOI SET TENCHURE = '{0}', TENCODAU = '{1}', DIENTHOAI = '{2}',  TIENDATCOC = '{3}', SoLuongKhach ='{4}' , SoLuongBan ='{5}', TienDo ='{6}', MACA = '{7}', MASANH = '{8}',  WHERE MATIECCUOI = '{9}'", tc.TenChuRe, tc.TenCoDau, tc.DienThoai, tc.TienDatCoc, tc.SoLuongKhach, tc.SoLuongBan, tc.TienDo, tc.MaCa, tc.MaSanh, tc.MaTiecCuoi);

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                //query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }
        public double TongTienBan(string MaTiecCuoi)
        {
            SQLiteConnection connect = db.getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("select sum(SoLuongBan*DonGia) as TongTien from (select TIECCUOI.soluongban, monan.dongia from PhieuDatBan, TIECCUOI, monan WHERE PhieuDatBan.matieccuoi='{0}' and PhieuDatBan.mamonan=monan.mamonan and TIECCUOI.matieccuoi='{0}')", MaTiecCuoi);
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

        public double TongTienDichVu(string MaTiecCuoi)
        {
            SQLiteConnection connect = db.getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("SELECT SUM(SoLuong*DonGia) AS TongTien FROM (select soluong, dongia from PHIEUDATDICHVU, dichvu WHERE MaTiecCuoi ='{0}' and phieudatdichvu.madichvu = dichvu.madichvu)", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);
                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = Double.Parse(row["TongTien"].ToString());
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }

    }
}
